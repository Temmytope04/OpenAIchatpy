// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of deployment scripts. </summary>
    internal partial class ArmDeploymentScriptListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentScriptListResult"/>. </summary>
        internal ArmDeploymentScriptListResult()
        {
            Value = new ChangeTrackingList<ArmDeploymentScriptData>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentScriptListResult"/>. </summary>
        /// <param name="value">
        /// An array of deployment scripts.
        /// Please note <see cref="ArmDeploymentScriptData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCliScript"/> and <see cref="AzurePowerShellScript"/>.
        /// </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentScriptListResult(IReadOnlyList<ArmDeploymentScriptData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary>
        /// An array of deployment scripts.
        /// Please note <see cref="ArmDeploymentScriptData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCliScript"/> and <see cref="AzurePowerShellScript"/>.
        /// </summary>
        public IReadOnlyList<ArmDeploymentScriptData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
