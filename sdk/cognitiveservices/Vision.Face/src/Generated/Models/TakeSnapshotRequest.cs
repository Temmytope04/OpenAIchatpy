// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request body for taking snapshot operation.
    /// </summary>
    public partial class TakeSnapshotRequest
    {
        /// <summary>
        /// Initializes a new instance of the TakeSnapshotRequest class.
        /// </summary>
        public TakeSnapshotRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TakeSnapshotRequest class.
        /// </summary>
        /// <param name="type">User specified type for the source object to
        /// take snapshot from. Currently FaceList, PersonGroup, LargeFaceList
        /// and LargePersonGroup are supported. Possible values include:
        /// 'FaceList', 'LargeFaceList', 'LargePersonGroup',
        /// 'PersonGroup'</param>
        /// <param name="objectId">User specified source object id to take
        /// snapshot from.</param>
        /// <param name="applyScope">User specified array of target Face
        /// subscription ids for the snapshot. For each snapshot, only
        /// subscriptions included in the applyScope of Snapshot - Take can
        /// apply it.</param>
        /// <param name="userData">User specified data about the snapshot for
        /// any purpose. Length should not exceed 16KB.</param>
        public TakeSnapshotRequest(SnapshotObjectType type, string objectId, IList<System.Guid?> applyScope, string userData = default(string))
        {
            Type = type;
            ObjectId = objectId;
            ApplyScope = applyScope;
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user specified type for the source object to take
        /// snapshot from. Currently FaceList, PersonGroup, LargeFaceList and
        /// LargePersonGroup are supported. Possible values include:
        /// 'FaceList', 'LargeFaceList', 'LargePersonGroup', 'PersonGroup'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SnapshotObjectType Type { get; set; }

        /// <summary>
        /// Gets or sets user specified source object id to take snapshot from.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets user specified array of target Face subscription ids
        /// for the snapshot. For each snapshot, only subscriptions included in
        /// the applyScope of Snapshot - Take can apply it.
        /// </summary>
        [JsonProperty(PropertyName = "applyScope")]
        public IList<System.Guid?> ApplyScope { get; set; }

        /// <summary>
        /// Gets or sets user specified data about the snapshot for any
        /// purpose. Length should not exceed 16KB.
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectId");
            }
            if (ApplyScope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplyScope");
            }
        }
    }
}
