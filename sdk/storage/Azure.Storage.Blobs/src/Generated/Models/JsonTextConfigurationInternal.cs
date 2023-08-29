// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> json text configuration. </summary>
    internal partial class JsonTextConfigurationInternal
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="JsonTextConfigurationInternal"/>. </summary>
        public JsonTextConfigurationInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JsonTextConfigurationInternal"/>. </summary>
        /// <param name="recordSeparator"> The string used to separate records. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JsonTextConfigurationInternal(string recordSeparator, Dictionary<string, BinaryData> rawData)
        {
            RecordSeparator = recordSeparator;
            _rawData = rawData;
        }

        /// <summary> The string used to separate records. </summary>
        public string RecordSeparator { get; set; }
    }
}
