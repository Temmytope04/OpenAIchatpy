// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The UnknownProbeAction. </summary>
    internal partial class UnknownProbeAction : AppInstanceProbeAction
    {
        /// <summary> Initializes a new instance of UnknownProbeAction. </summary>
        /// <param name="probeActionType"> The type of the action to take to perform the health check. </param>
        internal UnknownProbeAction(ProbeActionType probeActionType) : base(probeActionType)
        {
            ProbeActionType = probeActionType;
        }
    }
}
