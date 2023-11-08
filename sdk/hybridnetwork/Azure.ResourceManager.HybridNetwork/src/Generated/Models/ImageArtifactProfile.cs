// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Image artifact profile. </summary>
    public partial class ImageArtifactProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageArtifactProfile"/>. </summary>
        public ImageArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageArtifactProfile"/>. </summary>
        /// <param name="imageName"> Image name. </param>
        /// <param name="imageVersion"> Image version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageArtifactProfile(string imageName, string imageVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ImageName = imageName;
            ImageVersion = imageVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Image name. </summary>
        public string ImageName { get; set; }
        /// <summary> Image version. </summary>
        public string ImageVersion { get; set; }
    }
}
