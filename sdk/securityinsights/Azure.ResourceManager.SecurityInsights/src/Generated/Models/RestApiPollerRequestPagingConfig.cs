// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The request paging configuration.
    /// Serialized Name: RestApiPollerRequestPagingConfig
    /// </summary>
    public partial class RestApiPollerRequestPagingConfig
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestPagingConfig"/>. </summary>
        /// <param name="pagingType">
        /// Type of paging
        /// Serialized Name: RestApiPollerRequestPagingConfig.pagingType
        /// </param>
        public RestApiPollerRequestPagingConfig(RestApiPollerRequestPagingKind pagingType)
        {
            PagingType = pagingType;
        }

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestPagingConfig"/>. </summary>
        /// <param name="pagingType">
        /// Type of paging
        /// Serialized Name: RestApiPollerRequestPagingConfig.pagingType
        /// </param>
        /// <param name="pageSize">
        /// Page size
        /// Serialized Name: RestApiPollerRequestPagingConfig.pageSize
        /// </param>
        /// <param name="pageSizeParameterName">
        /// Page size parameter name
        /// Serialized Name: RestApiPollerRequestPagingConfig.pageSizeParameterName
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestApiPollerRequestPagingConfig(RestApiPollerRequestPagingKind pagingType, int? pageSize, string pageSizeParameterName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PagingType = pagingType;
            PageSize = pageSize;
            PageSizeParameterName = pageSizeParameterName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestPagingConfig"/> for deserialization. </summary>
        internal RestApiPollerRequestPagingConfig()
        {
        }

        /// <summary>
        /// Type of paging
        /// Serialized Name: RestApiPollerRequestPagingConfig.pagingType
        /// </summary>
        public RestApiPollerRequestPagingKind PagingType { get; set; }
        /// <summary>
        /// Page size
        /// Serialized Name: RestApiPollerRequestPagingConfig.pageSize
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// Page size parameter name
        /// Serialized Name: RestApiPollerRequestPagingConfig.pageSizeParameterName
        /// </summary>
        public string PageSizeParameterName { get; set; }
    }
}
