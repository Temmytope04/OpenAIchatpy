// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic tree. </summary>
    public partial class SwaggerCustomDynamicTree
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicTree"/>. </summary>
        public SwaggerCustomDynamicTree()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicTree"/>. </summary>
        /// <param name="settings"> The tree settings. </param>
        /// <param name="open"> The tree on-open configuration. </param>
        /// <param name="browse"> The tree on-browse configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwaggerCustomDynamicTree(SwaggerCustomDynamicTreeSettings settings, SwaggerCustomDynamicTreeCommand open, SwaggerCustomDynamicTreeCommand browse, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Settings = settings;
            Open = open;
            Browse = browse;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tree settings. </summary>
        public SwaggerCustomDynamicTreeSettings Settings { get; set; }
        /// <summary> The tree on-open configuration. </summary>
        public SwaggerCustomDynamicTreeCommand Open { get; set; }
        /// <summary> The tree on-browse configuration. </summary>
        public SwaggerCustomDynamicTreeCommand Browse { get; set; }
    }
}
