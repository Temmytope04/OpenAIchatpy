// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of the validate probe API. </summary>
    public partial class ValidateProbeContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ValidateProbeContent"/>. </summary>
        /// <param name="probeUri"> The probe URL to validate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="probeUri"/> is null. </exception>
        public ValidateProbeContent(Uri probeUri)
        {
            Argument.AssertNotNull(probeUri, nameof(probeUri));

            ProbeUri = probeUri;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateProbeContent"/>. </summary>
        /// <param name="probeUri"> The probe URL to validate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidateProbeContent(Uri probeUri, Dictionary<string, BinaryData> rawData)
        {
            ProbeUri = probeUri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateProbeContent"/> for deserialization. </summary>
        internal ValidateProbeContent()
        {
        }

        /// <summary> The probe URL to validate. </summary>
        public Uri ProbeUri { get; }
    }
}
