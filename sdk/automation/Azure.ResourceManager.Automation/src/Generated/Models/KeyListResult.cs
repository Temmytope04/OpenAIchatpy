// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The KeyListResult. </summary>
    public partial class KeyListResult
    {
        /// <summary> Initializes a new instance of KeyListResult. </summary>
        internal KeyListResult()
        {
            Keys = new ChangeTrackingList<Key>();
        }

        /// <summary> Initializes a new instance of KeyListResult. </summary>
        /// <param name="keys"> Lists the automation keys. </param>
        internal KeyListResult(IReadOnlyList<Key> keys)
        {
            Keys = keys;
        }

        /// <summary> Lists the automation keys. </summary>
        public IReadOnlyList<Key> Keys { get; }
    }
}
