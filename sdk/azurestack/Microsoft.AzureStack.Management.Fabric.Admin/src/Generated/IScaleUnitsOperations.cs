// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ScaleUnitsOperations operations.
    /// </summary>
    public partial interface IScaleUnitsOperations
    {
        /// <summary>
        /// Scales out a scale unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnit'>
        /// Name of the scale units.
        /// </param>
        /// <param name='nodeList'>
        /// A list of input data that allows for adding a set of scale unit
        /// nodes.
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
        Task<AzureOperationResponse> ScaleOutWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnit, ScaleOutScaleUnitParametersList nodeList, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new scale unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnit'>
        /// Name of the scale units.
        /// </param>
        /// <param name='creationData'>
        /// A list of input data that allows for creating the new scale unit.
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
        Task<AzureOperationResponse> CreateFromJsonWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnit, CreateFromJsonScaleUnitParametersList creationData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the requested scale unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnit'>
        /// Name of the scale units.
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
        Task<AzureOperationResponse<ScaleUnit>> GetWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnit, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all scale units at a location.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<ScaleUnit>>> ListWithHttpMessagesAsync(string resourceGroupName, string location, ODataQuery<ScaleUnit> odataQuery = default(ODataQuery<ScaleUnit>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Scales out a scale unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnit'>
        /// Name of the scale units.
        /// </param>
        /// <param name='nodeList'>
        /// A list of input data that allows for adding a set of scale unit
        /// nodes.
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
        Task<AzureOperationResponse> BeginScaleOutWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnit, ScaleOutScaleUnitParametersList nodeList, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new scale unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnit'>
        /// Name of the scale units.
        /// </param>
        /// <param name='creationData'>
        /// A list of input data that allows for creating the new scale unit.
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
        Task<AzureOperationResponse> BeginCreateFromJsonWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnit, CreateFromJsonScaleUnitParametersList creationData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all scale units at a location.
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
        Task<AzureOperationResponse<IPage<ScaleUnit>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
