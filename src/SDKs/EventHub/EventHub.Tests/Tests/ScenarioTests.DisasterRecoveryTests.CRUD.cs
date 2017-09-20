﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.


namespace EventHub.Tests.ScenarioTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Azure.Management.EventHub.Models;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using TestHelper;
    using Xunit;
    public partial class ScenarioTests
    {
        [Fact]
        public void DisasterRecoveryCreateGetUpdateDelete()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                InitializeClients(context);

                var location = this.ResourceManagementClient.GetLocationFromProvider();

                var resourceGroup = this.ResourceManagementClient.TryGetResourceGroup(location);
                if (string.IsNullOrWhiteSpace(resourceGroup))
                {
                    resourceGroup = TestUtilities.GenerateName(EventHubManagementHelper.ResourceGroupPrefix);
                    this.ResourceManagementClient.TryRegisterResourceGroup(location, resourceGroup);
                }

                var namespaceName = TestUtilities.GenerateName(EventHubManagementHelper.NamespacePrefix);


                // Create namespace 1
                var createNamespaceResponse = this.EventHubManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName,
                    new EHNamespace()
                    {
                        Location = location,
                        Sku = new Sku
                        {
                            Name = SkuName.Standard,
                            Tier = SkuTier.Standard
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

                // Create namespace 2
                var namespaceName2 = TestUtilities.GenerateName(EventHubManagementHelper.NamespacePrefix);
                var createNamespaceResponse2 = this.EventHubManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName2,
                    new EHNamespace()
                    {
                        Location = location,
                        Sku = new Sku
                        {
                            Name = SkuName.Standard,
                            Tier = SkuTier.Standard
                        },
                        Tags = new Dictionary<string, string>()
                        {
                            {"tag1", "value1"},
                            {"tag2", "value2"}
                        }
                    });

                Assert.NotNull(createNamespaceResponse2);
                Assert.Equal(createNamespaceResponse2.Name, namespaceName2);
                TestUtilities.Wait(TimeSpan.FromSeconds(5));

                // Create a Disaster Recovery - Primary
                var disasterRecoveryName = TestUtilities.GenerateName(EventHubManagementHelper.DisasterRecoveryPrefix);

                var DisasterRecoveryResponse = EventHubManagementClient.DisasterRecoveryConfig.CreateOrUpdate(resourceGroup, namespaceName, disasterRecoveryName, new ArmDisasterRecovery()
                {
                    PartnerNamespace = namespaceName2
                });
                Assert.NotNull(DisasterRecoveryResponse);
                
                // Get the created DisasterRecovery config - Primary
                var disasterRecoveryGetResponse = EventHubManagementClient.DisasterRecoveryConfig.Get(resourceGroup, namespaceName, disasterRecoveryName);
                Assert.NotNull(disasterRecoveryGetResponse);
                Assert.Equal(disasterRecoveryGetResponse.Role, RoleDisasterRecovery.Primary);

                // Get the created DisasterRecovery config - Secondary
                var disasterRecoveryGetResponse_Sec = EventHubManagementClient.DisasterRecoveryConfig.Get(resourceGroup, namespaceName2, disasterRecoveryName);
                Assert.NotNull(disasterRecoveryGetResponse_Sec);
                Assert.Equal(disasterRecoveryGetResponse_Sec.Role, RoleDisasterRecovery.Secondary);

                // Break Pairing
                EventHubManagementClient.DisasterRecoveryConfig.BreakPairing(resourceGroup, namespaceName, disasterRecoveryName);

                // Fail over
                EventHubManagementClient.DisasterRecoveryConfig.FailOver(resourceGroup, namespaceName2, disasterRecoveryName);

                // Get all Disaster Recovery for a given NameSpace
                var getListisasterRecoveryResponse = EventHubManagementClient.DisasterRecoveryConfig.ListByNamespace(resourceGroup, namespaceName);
                Assert.NotNull(getListisasterRecoveryResponse);
                Assert.True(getListisasterRecoveryResponse.Count<ArmDisasterRecovery>() >= 1);
                
                // Delete the DisasterRecovery 
                //EventHubManagementClient.DisasterRecoveryConfig.Delete(resourceGroup, namespaceName, disasterRecoveryName);

               // TestUtilities.Wait(TimeSpan.FromSeconds(5));

                // Delete namespace and check for the NotFound exception
                //EventHubManagementClient.Namespaces.Delete(resourceGroup, namespaceName);
            }
        }
    }
}
