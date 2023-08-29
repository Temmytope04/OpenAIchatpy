// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Name value pair. </summary>
    public partial class AppServiceNameValuePair
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceNameValuePair"/>. </summary>
        public AppServiceNameValuePair()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceNameValuePair"/>. </summary>
        /// <param name="name"> Pair name. </param>
        /// <param name="value"> Pair value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceNameValuePair(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Pair name. </summary>
        public string Name { get; set; }
        /// <summary> Pair value. </summary>
        public string Value { get; set; }
    }
}
