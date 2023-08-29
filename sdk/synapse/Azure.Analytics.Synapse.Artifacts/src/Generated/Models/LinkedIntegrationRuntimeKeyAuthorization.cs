// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The key authorization type integration runtime. </summary>
    public partial class LinkedIntegrationRuntimeKeyAuthorization : LinkedIntegrationRuntimeType
    {
        /// <summary> Initializes a new instance of <see cref="LinkedIntegrationRuntimeKeyAuthorization"/>. </summary>
        /// <param name="key"> The key used for authorization. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public LinkedIntegrationRuntimeKeyAuthorization(SecureString key)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            AuthorizationType = "Key";
        }

        /// <summary> Initializes a new instance of <see cref="LinkedIntegrationRuntimeKeyAuthorization"/>. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        /// <param name="key"> The key used for authorization. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkedIntegrationRuntimeKeyAuthorization(string authorizationType, SecureString key, Dictionary<string, BinaryData> rawData) : base(authorizationType, rawData)
        {
            Key = key;
            AuthorizationType = authorizationType ?? "Key";
        }

        /// <summary> Initializes a new instance of <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> for deserialization. </summary>
        internal LinkedIntegrationRuntimeKeyAuthorization()
        {
        }

        /// <summary> The key used for authorization. </summary>
        public SecureString Key { get; set; }
    }
}
