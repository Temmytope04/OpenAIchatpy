// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Model representing a pre-build step. </summary>
    public partial class PreBuildStep
    {
        /// <summary> Initializes a new instance of PreBuildStep. </summary>
        public PreBuildStep()
        {
            Scripts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PreBuildStep. </summary>
        /// <param name="description"> Description of the pre-build step. </param>
        /// <param name="scripts"> List of custom commands to run. </param>
        /// <param name="httpGet"> Http get request to send before the build. </param>
        internal PreBuildStep(string description, IList<string> scripts, HttpGet httpGet)
        {
            Description = description;
            Scripts = scripts;
            HttpGet = httpGet;
        }

        /// <summary> Description of the pre-build step. </summary>
        public string Description { get; set; }
        /// <summary> List of custom commands to run. </summary>
        public IList<string> Scripts { get; }
        /// <summary> Http get request to send before the build. </summary>
        public HttpGet HttpGet { get; set; }
    }
}
