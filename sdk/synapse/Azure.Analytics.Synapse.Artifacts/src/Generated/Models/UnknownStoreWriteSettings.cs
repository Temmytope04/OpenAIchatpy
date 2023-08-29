// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownStoreWriteSettings. </summary>
    internal partial class UnknownStoreWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownStoreWriteSettings"/>. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownStoreWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties) : base(type, maxConcurrentConnections, copyBehavior, additionalProperties)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownStoreWriteSettings"/> for deserialization. </summary>
        internal UnknownStoreWriteSettings()
        {
        }
    }
}
