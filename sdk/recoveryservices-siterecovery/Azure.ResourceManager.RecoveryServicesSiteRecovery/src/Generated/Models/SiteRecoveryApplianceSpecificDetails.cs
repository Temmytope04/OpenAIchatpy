// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Appliance specific details.
    /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownApplianceSpecificDetails))]
    public abstract partial class SiteRecoveryApplianceSpecificDetails
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplianceSpecificDetails"/>. </summary>
        protected SiteRecoveryApplianceSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplianceSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryApplianceSpecificDetails(string instanceType, Dictionary<string, BinaryData> rawData)
        {
            InstanceType = instanceType;
            _rawData = rawData;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
