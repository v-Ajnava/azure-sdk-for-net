// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConsumerGroupsOperations.
    /// </summary>
    public static partial class ConsumerGroupsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates an Event Hubs consumer group as a nested resource within
            /// a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639498.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a consumer group resource.
            /// </param>
            public static ConsumerGroupResource CreateOrUpdate(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroupCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Event Hubs consumer group as a nested resource within
            /// a Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639498.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a consumer group resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConsumerGroupResource> CreateOrUpdateAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroupCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a consumer group from the specified Event Hub and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639491.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            public static void Delete(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a consumer group from the specified Event Hub and resource group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639491.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a description for the specified consumer group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639488.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            public static ConsumerGroupResource Get(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a description for the specified consumer group.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639488.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='consumerGroupName'>
            /// The consumer group name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConsumerGroupResource> GetAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static IPage<ConsumerGroupResource> ListAll(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                return operations.ListAllAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerGroupResource>> ListAllAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConsumerGroupResource> ListAllNext(this IConsumerGroupsOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639503.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerGroupResource>> ListAllNextAsync(this IConsumerGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

