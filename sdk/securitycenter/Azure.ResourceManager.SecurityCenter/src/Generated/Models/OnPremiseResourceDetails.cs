// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Details of the On Premise resource that was assessed
    /// Please note <see cref="OnPremiseResourceDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="OnPremiseSqlResourceDetails"/>.
    /// </summary>
    public partial class OnPremiseResourceDetails : SecurityCenterResourceDetails
    {
        /// <summary> Initializes a new instance of <see cref="OnPremiseResourceDetails"/>. </summary>
        /// <param name="workspaceId"> Azure resource Id of the workspace the machine is attached to. </param>
        /// <param name="vmUuid"> The unique Id of the machine. </param>
        /// <param name="sourceComputerId"> The oms agent Id installed on the machine. </param>
        /// <param name="machineName"> The name of the machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/>, <paramref name="sourceComputerId"/> or <paramref name="machineName"/> is null. </exception>
        public OnPremiseResourceDetails(ResourceIdentifier workspaceId, Guid vmUuid, string sourceComputerId, string machineName)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));
            Argument.AssertNotNull(sourceComputerId, nameof(sourceComputerId));
            Argument.AssertNotNull(machineName, nameof(machineName));

            WorkspaceId = workspaceId;
            VmUuid = vmUuid;
            SourceComputerId = sourceComputerId;
            MachineName = machineName;
            Source = Source.OnPremise;
        }

        /// <summary> Initializes a new instance of <see cref="OnPremiseResourceDetails"/>. </summary>
        /// <param name="source"> The platform where the assessed resource resides. </param>
        /// <param name="workspaceId"> Azure resource Id of the workspace the machine is attached to. </param>
        /// <param name="vmUuid"> The unique Id of the machine. </param>
        /// <param name="sourceComputerId"> The oms agent Id installed on the machine. </param>
        /// <param name="machineName"> The name of the machine. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OnPremiseResourceDetails(Source source, ResourceIdentifier workspaceId, Guid vmUuid, string sourceComputerId, string machineName, Dictionary<string, BinaryData> rawData) : base(source, rawData)
        {
            WorkspaceId = workspaceId;
            VmUuid = vmUuid;
            SourceComputerId = sourceComputerId;
            MachineName = machineName;
            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="OnPremiseResourceDetails"/> for deserialization. </summary>
        internal OnPremiseResourceDetails()
        {
        }

        /// <summary> Azure resource Id of the workspace the machine is attached to. </summary>
        public ResourceIdentifier WorkspaceId { get; set; }
        /// <summary> The unique Id of the machine. </summary>
        public Guid VmUuid { get; set; }
        /// <summary> The oms agent Id installed on the machine. </summary>
        public string SourceComputerId { get; set; }
        /// <summary> The name of the machine. </summary>
        public string MachineName { get; set; }
    }
}
