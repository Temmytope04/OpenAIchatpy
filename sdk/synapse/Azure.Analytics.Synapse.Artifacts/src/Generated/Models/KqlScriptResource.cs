// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptResource. </summary>
    public partial class KqlScriptResource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KqlScriptResource"/>. </summary>
        public KqlScriptResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KqlScriptResource"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="properties"> Properties of sql script. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KqlScriptResource(string id, string name, string type, KqlScript properties, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
        /// <summary> Properties of sql script. </summary>
        public KqlScript Properties { get; set; }
    }
}
