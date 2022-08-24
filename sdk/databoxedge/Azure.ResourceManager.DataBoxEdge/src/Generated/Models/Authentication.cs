// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Authentication mechanism for IoT devices. </summary>
    internal partial class Authentication
    {
        /// <summary> Initializes a new instance of Authentication. </summary>
        public Authentication()
        {
        }

        /// <summary> Initializes a new instance of Authentication. </summary>
        /// <param name="symmetricKey"> Symmetric key for authentication. </param>
        internal Authentication(SymmetricKey symmetricKey)
        {
            SymmetricKey = symmetricKey;
        }

        /// <summary> Symmetric key for authentication. </summary>
        internal SymmetricKey SymmetricKey { get; set; }
        /// <summary> Connection string based on the symmetric key. </summary>
        public AsymmetricEncryptedSecret SymmetricKeyConnectionString
        {
            get => SymmetricKey is null ? default : SymmetricKey.ConnectionString;
            set
            {
                if (SymmetricKey is null)
                    SymmetricKey = new SymmetricKey();
                SymmetricKey.ConnectionString = value;
            }
        }
    }
}
