// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Fabric properties. </summary>
    public partial class SiteRecoveryFabricProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryFabricProperties"/>. </summary>
        internal SiteRecoveryFabricProperties()
        {
            HealthErrorDetails = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryFabricProperties"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the fabric. </param>
        /// <param name="encryptionDetails"> Encryption details for the fabric. </param>
        /// <param name="rolloverEncryptionDetails"> Rollover encryption details for the fabric. </param>
        /// <param name="internalIdentifier"> Dra Registration Id. </param>
        /// <param name="bcdrState"> BCDR state of the fabric. </param>
        /// <param name="customDetails">
        /// Fabric specific settings.
        /// Please note <see cref="FabricSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SiteRecoveryFabricProviderSpecificDetails"/>, <see cref="HyperVSiteDetails"/>, <see cref="InMageRcmFabricSpecificDetails"/>, <see cref="VmmFabricDetails"/>, <see cref="VMwareDetails"/> and <see cref="VMwareV2FabricSpecificDetails"/>.
        /// </param>
        /// <param name="healthErrorDetails"> Fabric health error details. </param>
        /// <param name="health"> Health of fabric. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryFabricProperties(string friendlyName, SiteRecoveryEncryptionDetails encryptionDetails, SiteRecoveryEncryptionDetails rolloverEncryptionDetails, string internalIdentifier, string bcdrState, FabricSpecificDetails customDetails, IReadOnlyList<SiteRecoveryHealthError> healthErrorDetails, string health, Dictionary<string, BinaryData> rawData)
        {
            FriendlyName = friendlyName;
            EncryptionDetails = encryptionDetails;
            RolloverEncryptionDetails = rolloverEncryptionDetails;
            InternalIdentifier = internalIdentifier;
            BcdrState = bcdrState;
            CustomDetails = customDetails;
            HealthErrorDetails = healthErrorDetails;
            Health = health;
            _rawData = rawData;
        }

        /// <summary> Friendly name of the fabric. </summary>
        public string FriendlyName { get; }
        /// <summary> Encryption details for the fabric. </summary>
        public SiteRecoveryEncryptionDetails EncryptionDetails { get; }
        /// <summary> Rollover encryption details for the fabric. </summary>
        public SiteRecoveryEncryptionDetails RolloverEncryptionDetails { get; }
        /// <summary> Dra Registration Id. </summary>
        public string InternalIdentifier { get; }
        /// <summary> BCDR state of the fabric. </summary>
        public string BcdrState { get; }
        /// <summary>
        /// Fabric specific settings.
        /// Please note <see cref="FabricSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SiteRecoveryFabricProviderSpecificDetails"/>, <see cref="HyperVSiteDetails"/>, <see cref="InMageRcmFabricSpecificDetails"/>, <see cref="VmmFabricDetails"/>, <see cref="VMwareDetails"/> and <see cref="VMwareV2FabricSpecificDetails"/>.
        /// </summary>
        public FabricSpecificDetails CustomDetails { get; }
        /// <summary> Fabric health error details. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrorDetails { get; }
        /// <summary> Health of fabric. </summary>
        public string Health { get; }
    }
}
