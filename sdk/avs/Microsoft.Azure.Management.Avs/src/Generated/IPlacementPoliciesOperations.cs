// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PlacementPoliciesOperations operations.
    /// </summary>
    public partial interface IPlacementPoliciesOperations
    {
        /// <summary>
        /// List placement policies in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PlacementPolicy>>> ListWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a placement policy by name in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlacementPolicy>> GetWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='placementPolicy'>
        /// A placement policy in the private cloud cluster
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlacementPolicy>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='placementPolicyUpdate'>
        /// The placement policy properties that may be updated
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlacementPolicy>> UpdateWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='placementPolicy'>
        /// A placement policy in the private cloud cluster
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlacementPolicy>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicy placementPolicy, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='placementPolicyUpdate'>
        /// The placement policy properties that may be updated
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PlacementPolicy>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, PlacementPolicyUpdate placementPolicyUpdate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a placement policy in a private cloud cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='privateCloudName'>
        /// Name of the private cloud
        /// </param>
        /// <param name='clusterName'>
        /// Name of the cluster in the private cloud
        /// </param>
        /// <param name='placementPolicyName'>
        /// Name of the VMware vSphere Distributed Resource Scheduler (DRS)
        /// placement policy
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string privateCloudName, string clusterName, string placementPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List placement policies in a private cloud cluster
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PlacementPolicy>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
