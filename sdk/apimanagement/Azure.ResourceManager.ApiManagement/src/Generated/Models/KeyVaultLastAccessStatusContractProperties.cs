// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Issue contract Update Properties. </summary>
    public partial class KeyVaultLastAccessStatusContractProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultLastAccessStatusContractProperties"/>. </summary>
        public KeyVaultLastAccessStatusContractProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultLastAccessStatusContractProperties"/>. </summary>
        /// <param name="code"> Last status code for sync and refresh of secret from key vault. </param>
        /// <param name="message"> Details of the error else empty. </param>
        /// <param name="timeStampUtc">
        /// Last time secret was accessed. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultLastAccessStatusContractProperties(string code, string message, DateTimeOffset? timeStampUtc, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            TimeStampUtc = timeStampUtc;
            _rawData = rawData;
        }

        /// <summary> Last status code for sync and refresh of secret from key vault. </summary>
        public string Code { get; set; }
        /// <summary> Details of the error else empty. </summary>
        public string Message { get; set; }
        /// <summary>
        /// Last time secret was accessed. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? TimeStampUtc { get; set; }
    }
}
