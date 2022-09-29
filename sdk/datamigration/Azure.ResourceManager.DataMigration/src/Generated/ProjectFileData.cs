// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary> A class representing the ProjectFile data model. </summary>
    public partial class ProjectFileData : ResourceData
    {
        /// <summary> Initializes a new instance of ProjectFileData. </summary>
        public ProjectFileData()
        {
        }

        /// <summary> Initializes a new instance of ProjectFileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> HTTP strong entity tag value. This is ignored if submitted. </param>
        /// <param name="properties"> Custom file properties. </param>
        internal ProjectFileData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, ETag? etag, ProjectFileProperties properties) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Properties = properties;
        }

        /// <summary> HTTP strong entity tag value. This is ignored if submitted. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Custom file properties. </summary>
        public ProjectFileProperties Properties { get; set; }
    }
}
