// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary>
    /// Settings for Extended Groups username and group download.
    /// Serialized Name: CacheUsernameDownloadSettings
    /// </summary>
    public partial class StorageCacheUsernameDownloadSettings
    {
        /// <summary> Initializes a new instance of StorageCacheUsernameDownloadSettings. </summary>
        public StorageCacheUsernameDownloadSettings()
        {
        }

        /// <summary> Initializes a new instance of StorageCacheUsernameDownloadSettings. </summary>
        /// <param name="enableExtendedGroups">
        /// Whether or not Extended Groups is enabled.
        /// Serialized Name: CacheUsernameDownloadSettings.extendedGroups
        /// </param>
        /// <param name="usernameSource">
        /// This setting determines how the cache gets username and group names for clients.
        /// Serialized Name: CacheUsernameDownloadSettings.usernameSource
        /// </param>
        /// <param name="groupFileUri">
        /// The URI of the file containing group information (in /etc/group file format). This field must be populated when &apos;usernameSource&apos; is set to &apos;File&apos;.
        /// Serialized Name: CacheUsernameDownloadSettings.groupFileURI
        /// </param>
        /// <param name="userFileUri">
        /// The URI of the file containing user information (in /etc/passwd file format). This field must be populated when &apos;usernameSource&apos; is set to &apos;File&apos;.
        /// Serialized Name: CacheUsernameDownloadSettings.userFileURI
        /// </param>
        /// <param name="ldapServer">
        /// The fully qualified domain name or IP address of the LDAP server to use.
        /// Serialized Name: CacheUsernameDownloadSettings.ldapServer
        /// </param>
        /// <param name="ldapBaseDN">
        /// The base distinguished name for the LDAP domain.
        /// Serialized Name: CacheUsernameDownloadSettings.ldapBaseDN
        /// </param>
        /// <param name="encryptLdapConnection">
        /// Whether or not the LDAP connection should be encrypted.
        /// Serialized Name: CacheUsernameDownloadSettings.encryptLdapConnection
        /// </param>
        /// <param name="requireValidCertificate">
        /// Determines if the certificates must be validated by a certificate authority. When true, caCertificateURI must be provided.
        /// Serialized Name: CacheUsernameDownloadSettings.requireValidCertificate
        /// </param>
        /// <param name="autoDownloadCertificate">
        /// Determines if the certificate should be automatically downloaded. This applies to &apos;caCertificateURI&apos; only if &apos;requireValidCertificate&apos; is true.
        /// Serialized Name: CacheUsernameDownloadSettings.autoDownloadCertificate
        /// </param>
        /// <param name="caCertificateUri">
        /// The URI of the CA certificate to validate the LDAP secure connection. This field must be populated when &apos;requireValidCertificate&apos; is set to true.
        /// Serialized Name: CacheUsernameDownloadSettings.caCertificateURI
        /// </param>
        /// <param name="usernameDownloaded">
        /// Indicates whether or not the HPC Cache has performed the username download successfully.
        /// Serialized Name: CacheUsernameDownloadSettings.usernameDownloaded
        /// </param>
        /// <param name="credentials">
        /// When present, these are the credentials for the secure LDAP connection.
        /// Serialized Name: CacheUsernameDownloadSettings.credentials
        /// </param>
        internal StorageCacheUsernameDownloadSettings(bool? enableExtendedGroups, StorageCacheUsernameSourceType? usernameSource, Uri groupFileUri, Uri userFileUri, string ldapServer, string ldapBaseDN, bool? encryptLdapConnection, bool? requireValidCertificate, bool? autoDownloadCertificate, Uri caCertificateUri, StorageCacheUsernameDownloadedType? usernameDownloaded, StorageCacheUsernameDownloadCredential credentials)
        {
            EnableExtendedGroups = enableExtendedGroups;
            UsernameSource = usernameSource;
            GroupFileUri = groupFileUri;
            UserFileUri = userFileUri;
            LdapServer = ldapServer;
            LdapBaseDN = ldapBaseDN;
            EncryptLdapConnection = encryptLdapConnection;
            RequireValidCertificate = requireValidCertificate;
            AutoDownloadCertificate = autoDownloadCertificate;
            CaCertificateUri = caCertificateUri;
            UsernameDownloaded = usernameDownloaded;
            Credentials = credentials;
        }

        /// <summary>
        /// Whether or not Extended Groups is enabled.
        /// Serialized Name: CacheUsernameDownloadSettings.extendedGroups
        /// </summary>
        public bool? EnableExtendedGroups { get; set; }
        /// <summary>
        /// This setting determines how the cache gets username and group names for clients.
        /// Serialized Name: CacheUsernameDownloadSettings.usernameSource
        /// </summary>
        public StorageCacheUsernameSourceType? UsernameSource { get; set; }
        /// <summary>
        /// The URI of the file containing group information (in /etc/group file format). This field must be populated when &apos;usernameSource&apos; is set to &apos;File&apos;.
        /// Serialized Name: CacheUsernameDownloadSettings.groupFileURI
        /// </summary>
        public Uri GroupFileUri { get; set; }
        /// <summary>
        /// The URI of the file containing user information (in /etc/passwd file format). This field must be populated when &apos;usernameSource&apos; is set to &apos;File&apos;.
        /// Serialized Name: CacheUsernameDownloadSettings.userFileURI
        /// </summary>
        public Uri UserFileUri { get; set; }
        /// <summary>
        /// The fully qualified domain name or IP address of the LDAP server to use.
        /// Serialized Name: CacheUsernameDownloadSettings.ldapServer
        /// </summary>
        public string LdapServer { get; set; }
        /// <summary>
        /// The base distinguished name for the LDAP domain.
        /// Serialized Name: CacheUsernameDownloadSettings.ldapBaseDN
        /// </summary>
        public string LdapBaseDN { get; set; }
        /// <summary>
        /// Whether or not the LDAP connection should be encrypted.
        /// Serialized Name: CacheUsernameDownloadSettings.encryptLdapConnection
        /// </summary>
        public bool? EncryptLdapConnection { get; set; }
        /// <summary>
        /// Determines if the certificates must be validated by a certificate authority. When true, caCertificateURI must be provided.
        /// Serialized Name: CacheUsernameDownloadSettings.requireValidCertificate
        /// </summary>
        public bool? RequireValidCertificate { get; set; }
        /// <summary>
        /// Determines if the certificate should be automatically downloaded. This applies to &apos;caCertificateURI&apos; only if &apos;requireValidCertificate&apos; is true.
        /// Serialized Name: CacheUsernameDownloadSettings.autoDownloadCertificate
        /// </summary>
        public bool? AutoDownloadCertificate { get; set; }
        /// <summary>
        /// The URI of the CA certificate to validate the LDAP secure connection. This field must be populated when &apos;requireValidCertificate&apos; is set to true.
        /// Serialized Name: CacheUsernameDownloadSettings.caCertificateURI
        /// </summary>
        public Uri CaCertificateUri { get; set; }
        /// <summary>
        /// Indicates whether or not the HPC Cache has performed the username download successfully.
        /// Serialized Name: CacheUsernameDownloadSettings.usernameDownloaded
        /// </summary>
        public StorageCacheUsernameDownloadedType? UsernameDownloaded { get; }
        /// <summary>
        /// When present, these are the credentials for the secure LDAP connection.
        /// Serialized Name: CacheUsernameDownloadSettings.credentials
        /// </summary>
        public StorageCacheUsernameDownloadCredential Credentials { get; set; }
    }
}
