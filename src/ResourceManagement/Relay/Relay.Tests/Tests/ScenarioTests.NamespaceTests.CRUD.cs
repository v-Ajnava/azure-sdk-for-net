﻿//  
//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Relay.Tests.ScenarioTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Azure.Management.Relay.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Relay.Tests.TestHelper;
    using Xunit;
    public partial class ScenarioTests 
    {
        [Fact]
        public void NamespaceCreateGetUpdateDelete()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                InitializeClients(context);

                var location = "West US";// this.ResourceManagementClient.GetLocationFromProvider();

                var resourceGroup = "Default-ServiceBus-WestUS";

                //var resourceGroup = this.ResourceManagementClient.TryGetResourceGroup(location);
                //if (string.IsNullOrWhiteSpace(resourceGroup))
                //{
                //    resourceGroup = TestUtilities.GenerateName(RelayManagementHelper.ResourceGroupPrefix);
                //    this.ResourceManagementClient.TryRegisterResourceGroup(location, resourceGroup);
                //}

                // Create Namespace
                var namespaceName = TestUtilities.GenerateName(RelayManagementHelper.NamespacePrefix);

                var createNamespaceResponse = this.RelayManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName,
                    new NamespaceResource()
                    {
                        Type = NameSpaceResourceType.MicrosoftRealyNamespaces,
                        Location = location,
                        Sku = new Sku
                        {
                            Name = "Standard"
                        }
                    });

                Assert.NotNull(createNamespaceResponse);
                Assert.Equal(createNamespaceResponse.Name, namespaceName);

                TestUtilities.Wait(TimeSpan.FromSeconds(5));

                // Get the created namespace
                var getNamespaceResponse = RelayManagementClient.Namespaces.Get(resourceGroup, namespaceName);
                if (string.Compare(getNamespaceResponse.ProvisioningState, "Succeeded", true) != 0)
                    TestUtilities.Wait(TimeSpan.FromSeconds(5));

                getNamespaceResponse = RelayManagementClient.Namespaces.Get(resourceGroup, namespaceName);
                Assert.NotNull(getNamespaceResponse);
                Assert.Equal("Succeeded", getNamespaceResponse.ProvisioningState, StringComparer.CurrentCultureIgnoreCase);
                //Assert.Equal(NamespaceState.Active, getNamespaceResponse.Status);
                Assert.Equal(location, getNamespaceResponse.Location, StringComparer.CurrentCultureIgnoreCase);

                // Get all namespaces created within a resourceGroup
                var getAllNamespacesResponse = RelayManagementClient.Namespaces.ListByResourceGroupAsync(resourceGroup).Result;
                Assert.NotNull(getAllNamespacesResponse);
                Assert.True(getAllNamespacesResponse.Count() >= 1);
                Assert.True(getAllNamespacesResponse.Any(ns => ns.Name == namespaceName));
                Assert.True(getAllNamespacesResponse.All(ns => ns.Id.Contains(resourceGroup)));

                // Get all namespaces created within the subscription irrespective of the resourceGroup
                getAllNamespacesResponse = RelayManagementClient.Namespaces.ListBySubscription();
                Assert.NotNull(getAllNamespacesResponse);
                Assert.True(getAllNamespacesResponse.Count() >= 1);
                Assert.True(getAllNamespacesResponse.Any(ns => ns.Name == namespaceName));

                // Update namespace tags
                var updateNamespaceParameter = new NamespaceResource()
                {
                    Location = location,
                    Tags = new Dictionary<string, string>()
                        {
                            {"tag1", "value1"},
                            {"tag2", "value2"},
                            {"tag3", "value3"},
                            {"tag4", "value4"}
                        }
                };

                var updateNamespaceResponse = RelayManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName, updateNamespaceParameter);

                TestUtilities.Wait(TimeSpan.FromSeconds(5));

                // Get the updated namespace
                getNamespaceResponse = RelayManagementClient.Namespaces.Get(resourceGroup, namespaceName);
                Assert.NotNull(getNamespaceResponse);
                Assert.Equal(location, getNamespaceResponse.Location, StringComparer.CurrentCultureIgnoreCase);
                Assert.Equal(namespaceName, getNamespaceResponse.Name);
                Assert.Equal(getNamespaceResponse.Tags.Count, 4);
                foreach (var tag in updateNamespaceParameter.Tags)
                {
                    Assert.True(getNamespaceResponse.Tags.Any(t => t.Key.Equals(tag.Key)));
                    Assert.True(getNamespaceResponse.Tags.Any(t => t.Value.Equals(tag.Value)));
                }
                
                try
                {
                    // Delete namespace
                    RelayManagementClient.Namespaces.Delete(resourceGroup, namespaceName);
                }
                catch (Exception ex)
                {
                    Assert.True(ex.Message.Contains("NotFound"));
                }
            }
        }
    }
}
