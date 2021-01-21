// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The server encryption protector. </summary>
    public partial class EncryptionProtector : ProxyResource
    {
        /// <summary> Initializes a new instance of EncryptionProtector. </summary>
        public EncryptionProtector()
        {
        }

        /// <summary> Initializes a new instance of EncryptionProtector. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="kind"> Kind of encryption protector. This is metadata used for the Azure portal experience. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="subregion"> Subregion of the encryption protector. </param>
        /// <param name="serverKeyName"> The name of the server key. </param>
        /// <param name="serverKeyType"> The encryption protector type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </param>
        /// <param name="uri"> The URI of the server key. </param>
        /// <param name="thumbprint"> Thumbprint of the server key. </param>
        internal EncryptionProtector(string id, string name, string type, string kind, string location, string subregion, string serverKeyName, ServerKeyType? serverKeyType, string uri, string thumbprint) : base(id, name, type)
        {
            Kind = kind;
            Location = location;
            Subregion = subregion;
            ServerKeyName = serverKeyName;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
        }

        /// <summary> Kind of encryption protector. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Subregion of the encryption protector. </summary>
        public string Subregion { get; }
        /// <summary> The name of the server key. </summary>
        public string ServerKeyName { get; set; }
        /// <summary> The encryption protector type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </summary>
        public ServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the server key. </summary>
        public string Uri { get; }
        /// <summary> Thumbprint of the server key. </summary>
        public string Thumbprint { get; }
    }
}
