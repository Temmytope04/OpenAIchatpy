// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Rules defining user's geo access within a CDN endpoint. </summary>
    public partial class GeoFilter
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

        /// <summary> Initializes a new instance of <see cref="GeoFilter"/>. </summary>
        /// <param name="relativePath"> Relative path applicable to geo filter. (e.g. '/mypictures', '/mypicture/kitty.jpg', and etc.). </param>
        /// <param name="action"> Action of the geo filter, i.e. allow or block access. </param>
        /// <param name="countryCodes"> Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativePath"/> or <paramref name="countryCodes"/> is null. </exception>
        public GeoFilter(string relativePath, GeoFilterAction action, IEnumerable<string> countryCodes)
        {
            Argument.AssertNotNull(relativePath, nameof(relativePath));
            Argument.AssertNotNull(countryCodes, nameof(countryCodes));

            RelativePath = relativePath;
            Action = action;
            CountryCodes = countryCodes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoFilter"/>. </summary>
        /// <param name="relativePath"> Relative path applicable to geo filter. (e.g. '/mypictures', '/mypicture/kitty.jpg', and etc.). </param>
        /// <param name="action"> Action of the geo filter, i.e. allow or block access. </param>
        /// <param name="countryCodes"> Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoFilter(string relativePath, GeoFilterAction action, IList<string> countryCodes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RelativePath = relativePath;
            Action = action;
            CountryCodes = countryCodes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoFilter"/> for deserialization. </summary>
        internal GeoFilter()
        {
        }

        /// <summary> Relative path applicable to geo filter. (e.g. '/mypictures', '/mypicture/kitty.jpg', and etc.). </summary>
        public string RelativePath { get; set; }
        /// <summary> Action of the geo filter, i.e. allow or block access. </summary>
        public GeoFilterAction Action { get; set; }
        /// <summary> Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US. </summary>
        public IList<string> CountryCodes { get; }
    }
}
