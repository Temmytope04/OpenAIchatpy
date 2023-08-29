// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the SQL server provider properties. </summary>
    public partial class MsSqlServerProviderInstanceProperties : ProviderSpecificProperties
    {
        /// <summary> Initializes a new instance of <see cref="MsSqlServerProviderInstanceProperties"/>. </summary>
        public MsSqlServerProviderInstanceProperties()
        {
            ProviderType = "MsSqlServer";
        }

        /// <summary> Initializes a new instance of <see cref="MsSqlServerProviderInstanceProperties"/>. </summary>
        /// <param name="providerType"> The provider type. For example, the value can be SapHana. </param>
        /// <param name="hostname"> Gets or sets the SQL server host name. </param>
        /// <param name="dbPort"> Gets or sets the database sql port. </param>
        /// <param name="dbUsername"> Gets or sets the database user name. </param>
        /// <param name="dbPassword"> Gets or sets the database password. </param>
        /// <param name="dbPasswordUri"> Gets or sets the key vault URI to secret with the database password. </param>
        /// <param name="sapSid"> Gets or sets the SAP System Identifier. </param>
        /// <param name="sslPreference"> Gets or sets certificate preference if secure communication is enabled. </param>
        /// <param name="sslCertificateUri"> Gets or sets the blob URI to SSL certificate for the SQL Database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MsSqlServerProviderInstanceProperties(string providerType, string hostname, string dbPort, string dbUsername, string dbPassword, Uri dbPasswordUri, string sapSid, SapSslPreference? sslPreference, Uri sslCertificateUri, Dictionary<string, BinaryData> rawData) : base(providerType, rawData)
        {
            Hostname = hostname;
            DBPort = dbPort;
            DBUsername = dbUsername;
            DBPassword = dbPassword;
            DBPasswordUri = dbPasswordUri;
            SapSid = sapSid;
            SslPreference = sslPreference;
            SslCertificateUri = sslCertificateUri;
            ProviderType = providerType ?? "MsSqlServer";
        }

        /// <summary> Gets or sets the SQL server host name. </summary>
        public string Hostname { get; set; }
        /// <summary> Gets or sets the database sql port. </summary>
        public string DBPort { get; set; }
        /// <summary> Gets or sets the database user name. </summary>
        public string DBUsername { get; set; }
        /// <summary> Gets or sets the database password. </summary>
        public string DBPassword { get; set; }
        /// <summary> Gets or sets the key vault URI to secret with the database password. </summary>
        public Uri DBPasswordUri { get; set; }
        /// <summary> Gets or sets the SAP System Identifier. </summary>
        public string SapSid { get; set; }
        /// <summary> Gets or sets certificate preference if secure communication is enabled. </summary>
        public SapSslPreference? SslPreference { get; set; }
        /// <summary> Gets or sets the blob URI to SSL certificate for the SQL Database. </summary>
        public Uri SslCertificateUri { get; set; }
    }
}
