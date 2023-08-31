// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The Batch service does not assign any meaning to this metadata; it is solely for the use of user code. </summary>
    public partial class BatchAccountPoolMetadataItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchAccountPoolMetadataItem"/>. </summary>
        /// <param name="name"> The name of the metadata item. </param>
        /// <param name="value"> The value of the metadata item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public BatchAccountPoolMetadataItem(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountPoolMetadataItem"/>. </summary>
        /// <param name="name"> The name of the metadata item. </param>
        /// <param name="value"> The value of the metadata item. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAccountPoolMetadataItem(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountPoolMetadataItem"/> for deserialization. </summary>
        internal BatchAccountPoolMetadataItem()
        {
        }

        /// <summary> The name of the metadata item. </summary>
        public string Name { get; set; }
        /// <summary> The value of the metadata item. </summary>
        public string Value { get; set; }
    }
}
