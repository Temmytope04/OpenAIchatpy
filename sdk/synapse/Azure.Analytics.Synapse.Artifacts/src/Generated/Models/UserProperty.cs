// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> User property. </summary>
    public partial class UserProperty
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserProperty"/>. </summary>
        /// <param name="name"> User property name. </param>
        /// <param name="value"> User property value. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public UserProperty(string name, object value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="UserProperty"/>. </summary>
        /// <param name="name"> User property name. </param>
        /// <param name="value"> User property value. Type: string (or Expression with resultType string). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserProperty(string name, object value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UserProperty"/> for deserialization. </summary>
        internal UserProperty()
        {
        }

        /// <summary> User property name. </summary>
        public string Name { get; set; }
        /// <summary> User property value. Type: string (or Expression with resultType string). </summary>
        public object Value { get; set; }
    }
}
