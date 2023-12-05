// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Cryptographic key summary values. </summary>
    public partial class FirmwareCryptoKeySummary
    {
        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeySummary"/>. </summary>
        internal FirmwareCryptoKeySummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKeySummary"/>. </summary>
        /// <param name="totalKeys"> Total number of cryptographic keys found. </param>
        /// <param name="publicKeys"> Total number of (non-certificate) public keys found. </param>
        /// <param name="privateKeys"> Total number of private keys found. </param>
        /// <param name="pairedKeys"> Total number of keys found that have a matching paired key or certificate. </param>
        /// <param name="shortKeySize"> Total number of keys found that have an insecure key size for the algorithm. </param>
        internal FirmwareCryptoKeySummary(long? totalKeys, long? publicKeys, long? privateKeys, long? pairedKeys, long? shortKeySize)
        {
            TotalKeys = totalKeys;
            PublicKeys = publicKeys;
            PrivateKeys = privateKeys;
            PairedKeys = pairedKeys;
            ShortKeySize = shortKeySize;
        }

        /// <summary> Total number of cryptographic keys found. </summary>
        public long? TotalKeys { get; }
        /// <summary> Total number of (non-certificate) public keys found. </summary>
        public long? PublicKeys { get; }
        /// <summary> Total number of private keys found. </summary>
        public long? PrivateKeys { get; }
        /// <summary> Total number of keys found that have a matching paired key or certificate. </summary>
        public long? PairedKeys { get; }
        /// <summary> Total number of keys found that have an insecure key size for the algorithm. </summary>
        public long? ShortKeySize { get; }
    }
}
