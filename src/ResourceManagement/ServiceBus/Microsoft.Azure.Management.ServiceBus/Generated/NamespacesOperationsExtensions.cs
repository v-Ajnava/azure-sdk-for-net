// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NamespacesOperations.
    /// </summary>
    public static partial class NamespacesOperationsExtensions
    {
            /// <summary>
            /// Gets all the available namespaces within the subscription, irrespective of
            /// the resource groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NamespaceResource> ListBySubscription(this INamespacesOperations operations)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListBySubscriptionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the available namespaces within the subscription, irrespective of
            /// the resource groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListBySubscriptionAsync(this INamespacesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the available namespaces within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NamespaceResource> ListByResourceGroup(this INamespacesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the available namespaces within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamespaceResource>> ListByResourceGroupAsync(this INamespacesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a namespace resource.
            /// </param>
            public static NamespaceResource CreateOrUpdate(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).CreateOrUpdateAsync(resourceGroupName, namespaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a namespace resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> CreateOrUpdateAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a namespace resource.
            /// </param>
            public static NamespaceResource BeginCreateOrUpdate(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, namespaceName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service namespace. Once created, this namespace's
            /// resource manifest is immutable. This operation is idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a namespace resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> BeginCreateOrUpdateAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, NamespaceCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static void Delete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).DeleteAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static void BeginDelete(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).BeginDeleteAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing namespace. This operation also removes all associated
            /// resources under the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a description for the specified namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static NamespaceResource Get(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).GetAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a description for the specified namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamespaceResource> GetAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this INamespacesOperations operations, string resourceGroupName, string namespaceName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAuthorizationRulesAsync(resourceGroupName, namespaceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an authorization rule for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Namespace authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an authorization rule for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Namespace authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a namespace authorization rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static void DeleteAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                Task.Factory.StartNew(s => ((INamespacesOperations)s).DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a namespace authorization rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an authorization rule for a namespace by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).GetAuthorizationRuleAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a namespace by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static ResourceListKeys ListKeys(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListKeysAsync(resourceGroupName, namespaceName, authorizationRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the primary and secondary connection strings for the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> ListKeysAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings for the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            public static ResourceListKeys RegenerateKeys(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, RegenerateKeysParameters parameters)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).RegenerateKeysAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the primary or secondary connection strings for the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceListKeys> RegenerateKeysAsync(this INamespacesOperations operations, string resourceGroupName, string namespaceName, string authorizationRuleName, RegenerateKeysParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the available namespaces within the subscription, irrespective of
            /// the resource groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListBySubscriptionNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListBySubscriptionNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the available namespaces within the subscription, irrespective of
            /// the resource groups.
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
            public static async Task<IPage<NamespaceResource>> ListBySubscriptionNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the available namespaces within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamespaceResource> ListByResourceGroupNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the available namespaces within a resource group.
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
            public static async Task<IPage<NamespaceResource>> ListByResourceGroupNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this INamespacesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INamespacesOperations)s).ListAuthorizationRulesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a namespace.
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
            public static async Task<IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this INamespacesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
