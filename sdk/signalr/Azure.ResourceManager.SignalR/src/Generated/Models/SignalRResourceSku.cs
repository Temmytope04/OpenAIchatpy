// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> The billing information of the resource. </summary>
    public partial class SignalRResourceSku
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

        /// <summary> Initializes a new instance of <see cref="SignalRResourceSku"/>. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SignalRResourceSku(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceSku"/>. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <param name="tier">
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </param>
        /// <param name="size"> Not used. Retained for future use. </param>
        /// <param name="family"> Not used. Retained for future use. </param>
        /// <param name="capacity">
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRResourceSku(string name, SignalRSkuTier? tier, string size, string family, int? capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceSku"/> for deserialization. </summary>
        internal SignalRResourceSku()
        {
        }

        /// <summary>
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </summary>
        public SignalRSkuTier? Tier { get; set; }
        /// <summary> Not used. Retained for future use. </summary>
        public string Size { get; }
        /// <summary> Not used. Retained for future use. </summary>
        public string Family { get; }
        /// <summary>
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </summary>
        public int? Capacity { get; set; }
    }
}
