// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The DiskExclusionProperties. </summary>
    public partial class DiskExclusionProperties
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

        /// <summary> Initializes a new instance of <see cref="DiskExclusionProperties"/>. </summary>
        public DiskExclusionProperties()
        {
            DiskLunList = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskExclusionProperties"/>. </summary>
        /// <param name="diskLunList"> List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection. </param>
        /// <param name="isInclusionList"> Flag to indicate whether DiskLunList is to be included/ excluded from backup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskExclusionProperties(IList<int> diskLunList, bool? isInclusionList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskLunList = diskLunList;
            IsInclusionList = isInclusionList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Disks' Logical Unit Numbers (LUN) to be used for VM Protection. </summary>
        public IList<int> DiskLunList { get; }
        /// <summary> Flag to indicate whether DiskLunList is to be included/ excluded from backup. </summary>
        public bool? IsInclusionList { get; set; }
    }
}
