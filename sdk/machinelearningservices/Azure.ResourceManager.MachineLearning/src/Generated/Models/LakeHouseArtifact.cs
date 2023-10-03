// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The LakeHouseArtifact. </summary>
    public partial class LakeHouseArtifact : OneLakeArtifact
    {
        /// <summary> Initializes a new instance of LakeHouseArtifact. </summary>
        /// <param name="artifactName"> [Required] OneLake artifact name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public LakeHouseArtifact(string artifactName) : base(artifactName)
        {
            Argument.AssertNotNull(artifactName, nameof(artifactName));

            ArtifactType = OneLakeArtifactType.LakeHouse;
        }

        /// <summary> Initializes a new instance of LakeHouseArtifact. </summary>
        /// <param name="artifactName"> [Required] OneLake artifact name. </param>
        /// <param name="artifactType"> [Required] OneLake artifact type. </param>
        internal LakeHouseArtifact(string artifactName, OneLakeArtifactType artifactType) : base(artifactName, artifactType)
        {
            ArtifactType = artifactType;
        }
    }
}
