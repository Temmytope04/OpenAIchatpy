// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of the Failover Process Server request. </summary>
    public partial class FailoverProcessServerProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FailoverProcessServerProperties"/>. </summary>
        public FailoverProcessServerProperties()
        {
            VmsToMigrate = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FailoverProcessServerProperties"/>. </summary>
        /// <param name="containerName"> The container identifier. </param>
        /// <param name="sourceProcessServerId"> The source process server. </param>
        /// <param name="targetProcessServerId"> The new process server. </param>
        /// <param name="vmsToMigrate"> The VMS to migrate. </param>
        /// <param name="updateType"> A value for failover type. It can be systemlevel/serverlevel. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FailoverProcessServerProperties(string containerName, Guid? sourceProcessServerId, Guid? targetProcessServerId, IList<string> vmsToMigrate, string updateType, Dictionary<string, BinaryData> rawData)
        {
            ContainerName = containerName;
            SourceProcessServerId = sourceProcessServerId;
            TargetProcessServerId = targetProcessServerId;
            VmsToMigrate = vmsToMigrate;
            UpdateType = updateType;
            _rawData = rawData;
        }

        /// <summary> The container identifier. </summary>
        public string ContainerName { get; set; }
        /// <summary> The source process server. </summary>
        public Guid? SourceProcessServerId { get; set; }
        /// <summary> The new process server. </summary>
        public Guid? TargetProcessServerId { get; set; }
        /// <summary> The VMS to migrate. </summary>
        public IList<string> VmsToMigrate { get; }
        /// <summary> A value for failover type. It can be systemlevel/serverlevel. </summary>
        public string UpdateType { get; set; }
    }
}
