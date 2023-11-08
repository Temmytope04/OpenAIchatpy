// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing the MediaTransform data model.
    /// A Transform encapsulates the rules or instructions for generating desired outputs from input media, such as by transcoding or by extracting insights. After the Transform is created, it can be applied to input media by creating Jobs.
    /// </summary>
    public partial class MediaTransformData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaTransformData"/>. </summary>
        public MediaTransformData()
        {
            Outputs = new ChangeTrackingList<MediaTransformOutput>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaTransformData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> The UTC date and time when the Transform was created, in 'YYYY-MM-DDThh:mm:ssZ' format. </param>
        /// <param name="description"> An optional verbose description of the Transform. </param>
        /// <param name="lastModifiedOn"> The UTC date and time when the Transform was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format. </param>
        /// <param name="outputs"> An array of one or more TransformOutputs that the Transform should generate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaTransformData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, string description, DateTimeOffset? lastModifiedOn, IList<MediaTransformOutput> outputs, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            Description = description;
            LastModifiedOn = lastModifiedOn;
            Outputs = outputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The UTC date and time when the Transform was created, in 'YYYY-MM-DDThh:mm:ssZ' format. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> An optional verbose description of the Transform. </summary>
        public string Description { get; set; }
        /// <summary> The UTC date and time when the Transform was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> An array of one or more TransformOutputs that the Transform should generate. </summary>
        public IList<MediaTransformOutput> Outputs { get; }
    }
}
