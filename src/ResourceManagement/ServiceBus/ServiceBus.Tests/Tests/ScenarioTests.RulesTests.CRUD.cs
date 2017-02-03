//  
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


namespace ServiceBus.Tests.ScenarioTests
{
  using System;
  using System.Linq;
  using System.Net;
  using Microsoft.Azure.Management.ServiceBus;
  using Microsoft.Azure.Management.ServiceBus.Models;
  using Microsoft.Rest.Azure;
  using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
  using TestHelper;
  using Xunit;
  public partial class ScenarioTests
  {
    [Fact]
    public void RulesCreateGetUpdateDelete()
    {
      using (MockContext context = MockContext.Start(this.GetType().FullName))
      {
        InitializeClients(context);

                var location = "West Us"; //this.ResourceManagementClient.GetLocationFromProvider();

        // var resourceGroup = this.ResourceManagementClient.TryGetResourceGroup(location);
        var resourceGroup = "Default-ServiceBus-WestUS";
        const string strSqlExp = "myproperty='test'";        
        const string ActionSqlExpression = "set FilterTag = 'true'";

                if (string.IsNullOrWhiteSpace(resourceGroup))
        {
          resourceGroup = TestUtilities.GenerateName(ServiceBusManagementHelper.ResourceGroupPrefix);
          this.ResourceManagementClient.TryRegisterResourceGroup(location, resourceGroup);
        }
                ServiceBusManagementClient.DeserializationSettings.Converters.Add(new RulesResourceConverter());
             var namespaceName = TestUtilities.GenerateName(ServiceBusManagementHelper.NamespacePrefix);

         
        //var createNamespaceResponse = this.ServiceBusManagementClient.Namespaces.CreateOrUpdate(resourceGroup, namespaceName,
        //    new NamespaceCreateOrUpdateParameters()
        //    {
        //      Location = location,
        //      Sku = new Sku
        //      {
        //        Name = "Standard",
        //        Tier = "Standard"
        //      }
        //    });

        //Assert.NotNull(createNamespaceResponse);
        //Assert.Equal(createNamespaceResponse.Name, namespaceName);

        //TestUtilities.Wait(TimeSpan.FromSeconds(5));

        //// Create a Topic
        //var topicName = TestUtilities.GenerateName(ServiceBusManagementHelper.TopicPrefix);

        //var createTopicResponse = this.ServiceBusManagementClient.Topics.CreateOrUpdate(resourceGroup, namespaceName, topicName,
        //new TopicCreateOrUpdateParameters()
        //{
        //  Location = location
        //});
        //Assert.NotNull(createTopicResponse);
        //Assert.Equal(createTopicResponse.Name, topicName);

        //// Get the created topic
        //var getTopicResponse = ServiceBusManagementClient.Topics.Get(resourceGroup, namespaceName, topicName);
        //Assert.NotNull(getTopicResponse);
        //Assert.Equal(EntityStatus.Active, getTopicResponse.Status);
        //Assert.Equal(getTopicResponse.Name, topicName);

        //// Create Subscription.
        //var subscriptionName = TestUtilities.GenerateName(ServiceBusManagementHelper.SubscritpitonPrefix);
        //var createSubscriptionResponse = ServiceBusManagementClient.Subscriptions.CreateOrUpdate(resourceGroup, namespaceName, topicName, subscriptionName, new SubscriptionCreateOrUpdateParameters()
        //{
        //  Location = location
        //});
        //Assert.NotNull(createSubscriptionResponse);
        //Assert.Equal(createSubscriptionResponse.Name, subscriptionName);

        // Create Rule with no filters.
        var ruleName = TestUtilities.GenerateName(ServiceBusManagementHelper.RulesPrefix);
                //var createRulesResponse = ServiceBusManagementClient.Rules.CreateOrUpdate(resourceGroup, namespaceName, topicName, subscriptionName, ruleName, new RuleResource()
                //{
                //  Location = location        
                //});
                
                var createRulesResponse = ServiceBusManagementClient.Rules.CreateOrUpdate(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName, new RuleResource()
                {
                    Location = location
                });

                Assert.NotNull(createRulesResponse);
        Assert.Equal(createRulesResponse.Name, ruleName);

        // Get Created Rules
        var ruleGetResponse = ServiceBusManagementClient.Rules.Get(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName);
        Assert.NotNull(ruleGetResponse);
        Assert.Equal(ruleGetResponse.Name, ruleName);

        // Get all Rules  
        var getRulesListAllResponse = ServiceBusManagementClient.Rules.ListAll(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758");
        Assert.NotNull(getRulesListAllResponse);
        Assert.True(getRulesListAllResponse.Count() >= 1);
        Assert.True(getRulesListAllResponse.All(ns => ns.Id.Contains(resourceGroup)));

        // Update Rule with Filter and Action

        var updateRulesParameter = new RuleResource()
        {
            Location =location,
            Action  = new SqlRuleAction()
            {
                RequiresPreprocessing = true,
                SqlExpression= strSqlExp,
            },
            Filter = new SqlFilter()
            {             
                SqlExpression = strSqlExp
                
            }
        };

        var updateRulesResponse = ServiceBusManagementClient.Rules.CreateOrUpdate(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName, updateRulesParameter);
        Assert.NotNull(updateRulesResponse);
                //Assert.NotEqual(updateRulesResponse.Filter.RequiresPreprocessing, updateRulesResponse.Filter.RequiresPreprocessing);

                RuleResource test = new RuleResource();
               
        // Get the updated rule to check the Updated values. 
        var getRulesResponse = ServiceBusManagementClient.Rules.Get(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName);
        Assert.NotNull(getRulesResponse);
//        Assert.Equal(true, getRulesResponse.Filter.RequiresPreprocessing);
        Assert.Equal(getRulesResponse.Name, ruleName);
        //Assert.True(getRulesResponse.RuleAction.Match);
        Assert.NotEqual(getRulesResponse.CreatedAt, createRulesResponse.CreatedAt);

        // Delete Created rule and check for the NotFound exception 
        ServiceBusManagementClient.Rules.Delete(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName);
        try
        {
          var getRuleResponse1 = ServiceBusManagementClient.Rules.Get(resourceGroup, "sdk-Namespace-1421", "sdk-topics-5247", "sdk-Subscriptions-6758", ruleName);
        }
        catch (CloudException ex)
        {
          Assert.Equal(HttpStatusCode.NotFound, ex.Response.StatusCode);
        }
      }
    }
  }
}
