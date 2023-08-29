// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Key value tuple. </summary>
    public partial class ResourceHealthKeyValueItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthKeyValueItem"/>. </summary>
        internal ResourceHealthKeyValueItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthKeyValueItem"/>. </summary>
        /// <param name="key"> Key of tuple. </param>
        /// <param name="value"> Value of tuple. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthKeyValueItem(string key, string value, Dictionary<string, BinaryData> rawData)
        {
            Key = key;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Key of tuple. </summary>
        public string Key { get; }
        /// <summary> Value of tuple. </summary>
        public string Value { get; }
    }
}
