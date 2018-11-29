﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.


namespace ServiceBus.Tests.ScenarioTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Management.ServiceBus;
    using Microsoft.Azure.Management.ServiceBus.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using TestHelper;
    using Xunit;
    public partial class ScenarioTests
    {
        [Fact]
        public void NamespaceCreateGetUpdateDeleteNetworkRuleSet()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                InitializeClients(context);

                var location = this.ResourceManagementClient.GetLocationFromProvider();

                var resourceGroup = this.ResourceManagementClient.TryGetResourceGroup(location);
                if (string.IsNullOrWhiteSpace(resourceGroup))
                {
                    resourceGroup = TestUtilities.GenerateName(ServiceBusManagementHelper.ResourceGroupPrefix);
                    this.ResourceManagementClient.TryRegisterResourceGroup(location, resourceGroup);
                }

                // Create a namespace
                var namespaceName = TestUtilities.GenerateName(ServiceBusManagementHelper.NamespacePrefix);

                var createNamespaceResponse = ServiceBusManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName,
                    new SBNamespace()
                    {
                        Location = location,
                        Sku = new SBSku
                        {
                            Name = SkuName.Premium,
                            Tier = SkuTier.Premium
                        },
                        Tags = new Dictionary<string, string>()
                        {
                            {"tag1", "value1"},
                            {"tag2", "value2"}
                        }
                    });

                Assert.NotNull(createNamespaceResponse);
                Assert.Equal(createNamespaceResponse.Name, namespaceName);

                TestUtilities.Wait(TimeSpan.FromSeconds(5));

                // Get the created namespace
                var getNamespaceResponse = ServiceBusManagementClient.Namespaces.Get(resourceGroup, namespaceName);
                if (string.Compare(getNamespaceResponse.ProvisioningState, "Succeeded", true) != 0)
                    TestUtilities.Wait(TimeSpan.FromSeconds(5));

                getNamespaceResponse = ServiceBusManagementClient.Namespaces.Get(resourceGroup, namespaceName);
                Assert.NotNull(getNamespaceResponse);
                Assert.Equal("Succeeded", getNamespaceResponse.ProvisioningState, StringComparer.CurrentCultureIgnoreCase);
                Assert.Equal(location, getNamespaceResponse.Location, StringComparer.CurrentCultureIgnoreCase);

                // Create Namepsace IPRules 

                List<NWRuleSetIpRules> IPRules = new List<NWRuleSetIpRules>();

                IPRules.Add(new NWRuleSetIpRules() { IpMask = "1.1.1.1", Action = NetworkRuleIPAction.Allow });
                IPRules.Add(new NWRuleSetIpRules() { IpMask = "1.1.1.2", Action = NetworkRuleIPAction.Allow });
                IPRules.Add(new NWRuleSetIpRules() { IpMask = "1.1.1.3", Action = NetworkRuleIPAction.Allow });
                IPRules.Add(new NWRuleSetIpRules() { IpMask = "1.1.1.4", Action = NetworkRuleIPAction.Allow });
                IPRules.Add(new NWRuleSetIpRules() { IpMask = "1.1.1.5", Action = NetworkRuleIPAction.Allow });
                
                List<NWRuleSetVirtualNetworkRules> VNetRules = new List<NWRuleSetVirtualNetworkRules>();

                VNetRules.Add(new NWRuleSetVirtualNetworkRules() { Subnet = new Subnet() { Id = @"/subscriptions/" + ServiceBusManagementClient.SubscriptionId + "/resourcegroups/alitest/providers/Microsoft.Network/virtualNetworks/myvn/subnets/subnet2" }, IgnoreMissingVnetServiceEndpoint = true });
                VNetRules.Add(new NWRuleSetVirtualNetworkRules() { Subnet = new Subnet() { Id = @"/subscriptions/" + ServiceBusManagementClient.SubscriptionId + "/resourcegroups/alitest/providers/Microsoft.Network/virtualNetworks/myvn/subnets/subnet3" }, IgnoreMissingVnetServiceEndpoint = false });
                VNetRules.Add(new NWRuleSetVirtualNetworkRules() { Subnet = new Subnet() { Id = @"/subscriptions/" + ServiceBusManagementClient.SubscriptionId + "/resourcegroups/alitest/providers/Microsoft.Network/virtualNetworks/myvn/subnets/subnet5" }, IgnoreMissingVnetServiceEndpoint = false });
                               
                var netWorkRuleSet = ServiceBusManagementClient.Namespaces.NetworkRuleSetMethod(resourceGroup, namespaceName, new NetworkRuleSet() { DefaultAction = DefaultAction.Allow, VirtualNetworkRulesList = VNetRules, IpRulesList = IPRules});
                               

                TestUtilities.Wait(TimeSpan.FromSeconds(5));

                //Delete namespace
                ServiceBusManagementClient.Namespaces.Delete(resourceGroup, namespaceName);
            }
        }
    }
}
