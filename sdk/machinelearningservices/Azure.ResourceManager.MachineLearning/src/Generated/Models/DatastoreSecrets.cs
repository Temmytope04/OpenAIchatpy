// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for datastore secrets.
    /// Please note <see cref="DatastoreSecrets"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CertificateDatastoreSecrets"/>, <see cref="KerberosKeytabSecrets"/>, <see cref="KerberosPasswordSecrets"/>, <see cref="SasDatastoreSecrets"/>, <see cref="ServicePrincipalDatastoreSecrets"/> and <see cref="AccountKeyDatastoreSecrets"/>.
    /// </summary>
    public partial class DatastoreSecrets
    {
        /// <summary> Initializes a new instance of DatastoreSecrets. </summary>
        public DatastoreSecrets()
        {
        }

        /// <summary> Initializes a new instance of DatastoreSecrets. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        internal DatastoreSecrets(SecretsType secretsType)
        {
            SecretsType = secretsType;
        }

        /// <summary> [Required] Credential type used to authentication with storage. </summary>
        internal SecretsType SecretsType { get; set; }
    }
}
