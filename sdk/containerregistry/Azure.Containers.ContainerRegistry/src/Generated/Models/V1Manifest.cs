// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested V1 manifest file. </summary>
    internal partial class V1Manifest : Manifest
    {
        /// <summary> Initializes a new instance of V1Manifest. </summary>
        internal V1Manifest()
        {
            FsLayers = new ChangeTrackingList<FsLayer>();
            History = new ChangeTrackingList<History>();
            Signatures = new ChangeTrackingList<ImageSignature>();
        }

        /// <summary> Initializes a new instance of V1Manifest. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="tag"> Image tag. </param>
        /// <param name="fsLayers"> List of layer information. </param>
        /// <param name="history"> Image history. </param>
        /// <param name="signatures"> Image signature. </param>
        internal V1Manifest(int? schemaVersion, string architecture, string name, string tag, IReadOnlyList<FsLayer> fsLayers, IReadOnlyList<History> history, IReadOnlyList<ImageSignature> signatures) : base(schemaVersion)
        {
            Architecture = architecture;
            Name = name;
            Tag = tag;
            FsLayers = fsLayers;
            History = history;
            Signatures = signatures;
        }

        /// <summary> CPU architecture. </summary>
        public string Architecture { get; }
        /// <summary> Image name. </summary>
        public string Name { get; }
        /// <summary> Image tag. </summary>
        public string Tag { get; }
        /// <summary> List of layer information. </summary>
        public IReadOnlyList<FsLayer> FsLayers { get; }
        /// <summary> Image history. </summary>
        public IReadOnlyList<History> History { get; }
        /// <summary> Image signature. </summary>
        public IReadOnlyList<ImageSignature> Signatures { get; }
    }
}
