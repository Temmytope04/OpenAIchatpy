// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The share mount point. </summary>
    public partial class DataBoxEdgeMountPointMap
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeMountPointMap"/>. </summary>
        /// <param name="shareId"> ID of the share mounted to the role VM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareId"/> is null. </exception>
        public DataBoxEdgeMountPointMap(ResourceIdentifier shareId)
        {
            if (shareId == null)
            {
                throw new ArgumentNullException(nameof(shareId));
            }

            ShareId = shareId;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeMountPointMap"/>. </summary>
        /// <param name="shareId"> ID of the share mounted to the role VM. </param>
        /// <param name="roleId"> ID of the role to which share is mounted. </param>
        /// <param name="mountPoint"> Mount point for the share. </param>
        /// <param name="mountType"> Mounting type. </param>
        /// <param name="roleType"> Role type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeMountPointMap(ResourceIdentifier shareId, ResourceIdentifier roleId, string mountPoint, DataBoxEdgeMountType? mountType, DataBoxEdgeRoleType? roleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ShareId = shareId;
            RoleId = roleId;
            MountPoint = mountPoint;
            MountType = mountType;
            RoleType = roleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeMountPointMap"/> for deserialization. </summary>
        internal DataBoxEdgeMountPointMap()
        {
        }

        /// <summary> ID of the share mounted to the role VM. </summary>
        public ResourceIdentifier ShareId { get; set; }
        /// <summary> ID of the role to which share is mounted. </summary>
        public ResourceIdentifier RoleId { get; }
        /// <summary> Mount point for the share. </summary>
        public string MountPoint { get; }
        /// <summary> Mounting type. </summary>
        public DataBoxEdgeMountType? MountType { get; }
        /// <summary> Role type. </summary>
        public DataBoxEdgeRoleType? RoleType { get; }
    }
}
