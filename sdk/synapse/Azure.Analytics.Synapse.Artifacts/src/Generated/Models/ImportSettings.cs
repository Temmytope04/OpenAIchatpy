// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Import command settings.
    /// Please note <see cref="ImportSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureDatabricksDeltaLakeImportCommand"/> and <see cref="SnowflakeImportCopyCommand"/>.
    /// </summary>
    public abstract partial class ImportSettings
    {
        /// <summary> Initializes a new instance of <see cref="ImportSettings"/>. </summary>
        protected ImportSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="ImportSettings"/>. </summary>
        /// <param name="type"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ImportSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The import setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
