// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// BEK is bitlocker key.
    /// KEK is encryption key for BEK
    /// If the VM was encrypted then we will store following details :
    /// 1. Secret(BEK) - Url + Backup Data + vaultId.
    /// 2. Key(KEK) - Url + Backup Data + vaultId.
    /// 3. EncryptionMechanism
    /// BEK and KEK can potentially have different vault ids.
    /// </summary>
    public partial class KeyAndSecretDetails
    {
        /// <summary> Initializes a new instance of KeyAndSecretDetails. </summary>
        public KeyAndSecretDetails()
        {
        }

        /// <summary> Initializes a new instance of KeyAndSecretDetails. </summary>
        /// <param name="kekDetails"> KEK is encryption key for BEK. </param>
        /// <param name="bekDetails"> BEK is bitlocker encryption key. </param>
        /// <param name="encryptionMechanism"> Encryption mechanism: None/ SinglePass/ DoublePass. </param>
        internal KeyAndSecretDetails(KekDetails kekDetails, BekDetails bekDetails, string encryptionMechanism)
        {
            KekDetails = kekDetails;
            BekDetails = bekDetails;
            EncryptionMechanism = encryptionMechanism;
        }

        /// <summary> KEK is encryption key for BEK. </summary>
        public KekDetails KekDetails { get; set; }
        /// <summary> BEK is bitlocker encryption key. </summary>
        public BekDetails BekDetails { get; set; }
        /// <summary> Encryption mechanism: None/ SinglePass/ DoublePass. </summary>
        public string EncryptionMechanism { get; set; }
    }
}
