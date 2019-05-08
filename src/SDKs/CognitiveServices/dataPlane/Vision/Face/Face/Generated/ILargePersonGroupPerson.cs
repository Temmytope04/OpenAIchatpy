// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LargePersonGroupPerson operations.
    /// </summary>
    public partial interface ILargePersonGroupPerson
    {
        /// <summary>
        /// Create a new person in a specified large person group.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='name'>
        /// User defined name, maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// User specified data. Length should not exceed 16KB.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Person>> CreateWithHttpMessagesAsync(string largePersonGroupId, string name = default(string), string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all persons in a large person group, and retrieve person
        /// information (including personId, name, userData and
        /// persistedFaceIds of registered faces of the person).
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='start'>
        /// Starting person id to return (used to list a range of persons).
        /// </param>
        /// <param name='top'>
        /// Number of persons to return starting with the person id indicated
        /// by the 'start' parameter.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<Person>>> ListWithHttpMessagesAsync(string largePersonGroupId, string start = default(string), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing person from a large person group. The
        /// persistedFaceId, userData, person name and face feature in the
        /// person entry will all be deleted.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a person's name and userData, and the persisted faceIds
        /// representing the registered person face feature.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Person>> GetWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update name or userData of a person.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='name'>
        /// User defined name, maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// User specified data. Length should not exceed 16KB.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, string name = default(string), string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a face from a person in a large person group by specified
        /// largePersonGroupId, personId and persistedFaceId.
        /// &lt;br /&gt; Adding/deleting faces to/from a same person will be
        /// processed sequentially. Adding/deleting faces to/from different
        /// persons are processed in parallel.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Id referencing a particular persistedFaceId of an existing face.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteFaceWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, System.Guid persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve information about a persisted face (specified by
        /// persistedFaceId, personId and its belonging largePersonGroupId).
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Id referencing a particular persistedFaceId of an existing face.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFace>> GetFaceWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, System.Guid persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a person persisted face's userData field.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Id referencing a particular persistedFaceId of an existing face.
        /// </param>
        /// <param name='userData'>
        /// User-provided data attached to the face. The size limit is 1KB.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateFaceWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, System.Guid persistedFaceId, string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a face to a person into a large person group for face
        /// identification or verification. To deal with an image contains
        /// multiple faces, input face can be specified as an image with a
        /// targetFace rectangle. It returns a persistedFaceId representing the
        /// added face. No image will be stored. Only the extracted face
        /// feature will be stored on server until [LargePersonGroup PersonFace
        /// -
        /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/599ae2966ac60f11b48b5aa3),
        /// [LargePersonGroup Person -
        /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/599ade5c6ac60f11b48b5aa2)
        /// or [LargePersonGroup -
        /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/599adc216ac60f11b48b5a9f)
        /// is called.
        /// &lt;br /&gt; Note persistedFaceId is different from faceId
        /// generated by [Face -
        /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236).
        /// * Higher face image quality means better recognition precision.
        /// Please consider high-quality faces: frontal, clear, and face size
        /// is 200x200 pixels (100 pixels between eyes) or bigger.
        /// * Each person entry can hold up to 248 faces.
        /// * JPEG, PNG, GIF (the first frame), and BMP format are supported.
        /// The allowed image file size is from 1KB to 6MB.
        /// * "targetFace" rectangle should contain one face. Zero or multiple
        /// faces will be regarded as an error. If the provided "targetFace"
        /// rectangle is not returned from [Face -
        /// Detect](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395236),
        /// there’s no guarantee to detect and add the face successfully.
        /// * Out of detectable face size (36x36 - 4096x4096 pixels), large
        /// head-pose, or large occlusions will cause failures.
        /// * Adding/deleting faces to/from a same person will be processed
        /// sequentially. Adding/deleting faces to/from different persons are
        /// processed in parallel.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='url'>
        /// Publicly reachable URL of an image
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the face for any purpose. The maximum
        /// length is 1KB.
        /// </param>
        /// <param name='targetFace'>
        /// A face rectangle to specify the target face to be added to a person
        /// in the format of "targetFace=left,top,width,height". E.g.
        /// "targetFace=10,10,100,100". If there is more than one face in the
        /// image, targetFace is required to specify which face to add. No
        /// targetFace means there is only one face detected in the entire
        /// image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFace>> AddFaceFromUrlWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, string url, string userData = default(string), IList<int> targetFace = default(IList<int>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a representative face to a person for identification. The input
        /// face is specified as an image with a targetFace rectangle.
        /// </summary>
        /// <param name='largePersonGroupId'>
        /// Id referencing a particular large person group.
        /// </param>
        /// <param name='personId'>
        /// Id referencing a particular person.
        /// </param>
        /// <param name='image'>
        /// An image stream.
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the face for any purpose. The maximum
        /// length is 1KB.
        /// </param>
        /// <param name='targetFace'>
        /// A face rectangle to specify the target face to be added to a person
        /// in the format of "targetFace=left,top,width,height". E.g.
        /// "targetFace=10,10,100,100". If there is more than one face in the
        /// image, targetFace is required to specify which face to add. No
        /// targetFace means there is only one face detected in the entire
        /// image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFace>> AddFaceFromStreamWithHttpMessagesAsync(string largePersonGroupId, System.Guid personId, Stream image, string userData = default(string), IList<int> targetFace = default(IList<int>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
