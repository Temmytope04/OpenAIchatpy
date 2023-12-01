// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.Signing.Models
{
    /// <summary> Parameters for creating or updating a code signing account. </summary>
    public partial class CodeSigningAccountPatch
    {
        /// <summary> Initializes a new instance of CodeSigningAccountPatch. </summary>
        public CodeSigningAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Account Uri of the code signing account. </summary>
        public Uri AccountUri { get; }
    }
}
