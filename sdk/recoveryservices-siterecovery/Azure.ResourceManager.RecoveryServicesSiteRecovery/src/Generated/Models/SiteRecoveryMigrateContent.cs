// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input for migrate. </summary>
    public partial class SiteRecoveryMigrateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryMigrateContent"/>. </summary>
        /// <param name="properties"> Migrate input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryMigrateContent(SiteRecoveryMigrateProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryMigrateContent"/>. </summary>
        /// <param name="properties"> Migrate input properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryMigrateContent(SiteRecoveryMigrateProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryMigrateContent"/> for deserialization. </summary>
        internal SiteRecoveryMigrateContent()
        {
        }

        /// <summary> Migrate input properties. </summary>
        internal SiteRecoveryMigrateProperties Properties { get; }
        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="MigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtMigrateContent"/>.
        /// </summary>
        public MigrateProviderSpecificContent SiteRecoveryMigrateProviderSpecificDetails
        {
            get => Properties?.ProviderSpecificDetails;
        }
    }
}
