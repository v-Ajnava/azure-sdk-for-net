// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
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
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
            /// Parameters supplied to create or update a consumer group resource.
            /// </param>
            public static ConsumerGroup CreateOrUpdate(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Event Hubs consumer group as a nested resource within
            /// a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
            /// Parameters supplied to create or update a consumer group resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConsumerGroup> CreateOrUpdateAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a consumer group from the specified Event Hub and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a description for the specified consumer group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
            public static ConsumerGroup Get(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a description for the specified consumer group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
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
            public static async Task<ConsumerGroup> GetAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, consumerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='skip'>
            /// Skip is only used if a previous operation returned a partial result. If a
            /// previous response contains a nextLink element, the value of the nextLink
            /// element will include a skip parameter that specifies a starting point to
            /// use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            public static IPage<ConsumerGroup> ListByEventHub(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, int? skip = default(int?), int? top = default(int?))
            {
                return operations.ListByEventHubAsync(resourceGroupName, namespaceName, eventHubName, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='skip'>
            /// Skip is only used if a previous operation returned a partial result. If a
            /// previous response contains a nextLink element, the value of the nextLink
            /// element will include a skip parameter that specifies a starting point to
            /// use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerGroup>> ListByEventHubAsync(this IConsumerGroupsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, int? skip = default(int?), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEventHubWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConsumerGroup> ListByEventHubNext(this IConsumerGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByEventHubNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the consumer groups in a Namespace. An empty feed is returned if
            /// no consumer group exists in the Namespace.
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
            public static async Task<IPage<ConsumerGroup>> ListByEventHubNextAsync(this IConsumerGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEventHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
