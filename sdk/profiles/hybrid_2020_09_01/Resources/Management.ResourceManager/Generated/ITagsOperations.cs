// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TagsOperations operations.
    /// </summary>
    public partial interface ITagsOperations
    {
        /// <summary>
        /// Deletes a predefined tag value for a predefined tag name.
        /// </summary>
        /// <remarks>
        /// This operation allows deleting a value from the list of predefined
        /// values for an existing predefined tag name. The value being deleted
        /// must not be in use as a tag value for the given tag name for any
        /// resource.
        /// </remarks>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag to delete.
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
        Task<AzureOperationResponse> DeleteValueWithHttpMessagesAsync(string tagName, string tagValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a predefined value for a predefined tag name.
        /// </summary>
        /// <remarks>
        /// This operation allows adding a value to the list of predefined
        /// values for an existing predefined tag name. A tag value can have a
        /// maximum of 256 characters.
        /// </remarks>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag to create.
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
        Task<AzureOperationResponse<TagValue>> CreateOrUpdateValueWithHttpMessagesAsync(string tagName, string tagValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a predefined tag name.
        /// </summary>
        /// <remarks>
        /// This operation allows adding a name to the list of predefined tag
        /// names for the given subscription. A tag name can have a maximum of
        /// 512 characters and is case-insensitive. Tag names cannot have the
        /// following prefixes which are reserved for Azure use: 'microsoft',
        /// 'azure', 'windows'.
        /// </remarks>
        /// <param name='tagName'>
        /// The name of the tag to create.
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
        Task<AzureOperationResponse<TagDetails>> CreateOrUpdateWithHttpMessagesAsync(string tagName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a predefined tag name.
        /// </summary>
        /// <remarks>
        /// This operation allows deleting a name from the list of predefined
        /// tag names for the given subscription. The name being deleted must
        /// not be in use as a tag name for any resource. All predefined values
        /// for the given name must have already been deleted.
        /// </remarks>
        /// <param name='tagName'>
        /// The name of the tag.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string tagName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a summary of tag usage under the subscription.
        /// </summary>
        /// <remarks>
        /// This operation performs a union of predefined tags, resource tags,
        /// resource group tags and subscription tags, and returns a summary of
        /// usage for each tag name and value under the given subscription. In
        /// case of a large number of tags, this operation may return a
        /// previously cached result.
        /// </remarks>
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
        Task<AzureOperationResponse<IPage<TagDetails>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the entire set of tags on a resource or
        /// subscription.
        /// </summary>
        /// <remarks>
        /// This operation allows adding or replacing the entire set of tags on
        /// the specified resource or subscription. The specified entity can
        /// have a maximum of 50 tags.
        /// </remarks>
        /// <param name='scope'>
        /// The resource scope.
        /// </param>
        /// <param name='parameters'>
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
        Task<AzureOperationResponse<TagsResource>> CreateOrUpdateAtScopeWithHttpMessagesAsync(string scope, TagsResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Selectively updates the set of tags on a resource or subscription.
        /// </summary>
        /// <remarks>
        /// This operation allows replacing, merging or selectively deleting
        /// tags on the specified resource or subscription. The specified
        /// entity can have a maximum of 50 tags at the end of the operation.
        /// The 'replace' option replaces the entire set of existing tags with
        /// a new set. The 'merge' option allows adding tags with new names and
        /// updating the values of tags with existing names. The 'delete'
        /// option allows selectively deleting tags based on given names or
        /// name/value pairs.
        /// </remarks>
        /// <param name='scope'>
        /// The resource scope.
        /// </param>
        /// <param name='parameters'>
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
        Task<AzureOperationResponse<TagsResource>> UpdateAtScopeWithHttpMessagesAsync(string scope, TagsPatchResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the entire set of tags on a resource or subscription.
        /// </summary>
        /// <param name='scope'>
        /// The resource scope.
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
        Task<AzureOperationResponse<TagsResource>> GetAtScopeWithHttpMessagesAsync(string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the entire set of tags on a resource or subscription.
        /// </summary>
        /// <param name='scope'>
        /// The resource scope.
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
        Task<AzureOperationResponse> DeleteAtScopeWithHttpMessagesAsync(string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a summary of tag usage under the subscription.
        /// </summary>
        /// <remarks>
        /// This operation performs a union of predefined tags, resource tags,
        /// resource group tags and subscription tags, and returns a summary of
        /// usage for each tag name and value under the given subscription. In
        /// case of a large number of tags, this operation may return a
        /// previously cached result.
        /// </remarks>
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
        Task<AzureOperationResponse<IPage<TagDetails>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
