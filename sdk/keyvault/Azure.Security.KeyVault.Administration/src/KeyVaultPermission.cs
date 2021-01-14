// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role definition permissions. </summary>
    [CodeGenModel("Permission", Usage = new[] { "input", "output" })]
    public partial class KeyVaultPermission
    {
        /// <summary> Denied actions. </summary>
        [CodeGenMember("NotActions")]
        public IList<string> DeniedActions { get; }

        /// <summary> Denied Data actions. </summary>
        [CodeGenMember("NotDataActions")]
        public IList<DataActions> DeniedDataActions { get; }

        /// <summary> Allowed actions. </summary>
        [CodeGenMember("Actions")]
        public IList<string> AllowedActions { get; }

        /// <summary> Allowed Data actions. </summary>
        [CodeGenMember("DataActions")]
        public IList<DataActions> AllowedDataActions { get; }
    }
}
