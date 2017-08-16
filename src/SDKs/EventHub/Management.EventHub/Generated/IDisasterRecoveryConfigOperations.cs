// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DisasterRecoveryConfigOperations operations.
    /// </summary>
    public partial interface IDisasterRecoveryConfigOperations
    {
        /// <summary>
        /// Gets all the Disaster Recovery in a Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ArmDisasterRecovery>>> ListByNamespaceWithHttpMessagesAsync(string resourceGroupName, string namespaceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a new Disaster Recovery as a nested resource
        /// within a Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='disasterRecoveryName'>
        /// The Disaster Recovery name
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create an Disaster Recovery resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ArmDisasterRecovery>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string disasterRecoveryName, ArmDisasterRecovery parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an Event Hub from the specified Namespace and resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='disasterRecoveryName'>
        /// The Disaster Recovery name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string disasterRecoveryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves Disaster Recovery config description via bith primary or
        /// secondary namespace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='disasterRecoveryName'>
        /// The Disaster Recovery name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ArmDisasterRecovery>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string disasterRecoveryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This operation stops replication from the Primary to the Secondary
        /// namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='disasterRecoveryName'>
        /// The Disaster Recovery name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BreakPairingWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string disasterRecoveryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates Secondary namespace role as primary and removes the role
        /// from the pervious primary namespace
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='disasterRecoveryName'>
        /// The Disaster Recovery name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> FailOverWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string disasterRecoveryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the Disaster Recovery in a Namespace.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ArmDisasterRecovery>>> ListByNamespaceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
