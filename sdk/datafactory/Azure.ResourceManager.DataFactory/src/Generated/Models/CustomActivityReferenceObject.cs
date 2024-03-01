// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Reference objects for custom activity. </summary>
    public partial class CustomActivityReferenceObject
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

        /// <summary> Initializes a new instance of <see cref="CustomActivityReferenceObject"/>. </summary>
        public CustomActivityReferenceObject()
        {
            LinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            Datasets = new ChangeTrackingList<DatasetReference>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomActivityReferenceObject"/>. </summary>
        /// <param name="linkedServices"> Linked service references. </param>
        /// <param name="datasets"> Dataset references. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomActivityReferenceObject(IList<DataFactoryLinkedServiceReference> linkedServices, IList<DatasetReference> datasets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinkedServices = linkedServices;
            Datasets = datasets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Linked service references. </summary>
        public IList<DataFactoryLinkedServiceReference> LinkedServices { get; }
        /// <summary> Dataset references. </summary>
        public IList<DatasetReference> Datasets { get; }
    }
}
