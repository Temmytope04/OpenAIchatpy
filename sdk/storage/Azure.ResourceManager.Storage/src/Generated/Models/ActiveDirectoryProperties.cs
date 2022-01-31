// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Settings properties for Active Directory (AD). </summary>
    public partial class ActiveDirectoryProperties
    {
        /// <summary> Initializes a new instance of ActiveDirectoryProperties. </summary>
        /// <param name="domainName"> Specifies the primary domain that the AD DNS server is authoritative for. </param>
        /// <param name="netBiosDomainName"> Specifies the NetBIOS domain name. </param>
        /// <param name="forestName"> Specifies the Active Directory forest to get. </param>
        /// <param name="domainGuid"> Specifies the domain GUID. </param>
        /// <param name="domainSid"> Specifies the security identifier (SID). </param>
        /// <param name="azureStorageSid"> Specifies the security identifier (SID) for Azure Storage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/>, <paramref name="netBiosDomainName"/>, <paramref name="forestName"/>, <paramref name="domainGuid"/>, <paramref name="domainSid"/>, or <paramref name="azureStorageSid"/> is null. </exception>
        public ActiveDirectoryProperties(string domainName, string netBiosDomainName, string forestName, string domainGuid, string domainSid, string azureStorageSid)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }
            if (netBiosDomainName == null)
            {
                throw new ArgumentNullException(nameof(netBiosDomainName));
            }
            if (forestName == null)
            {
                throw new ArgumentNullException(nameof(forestName));
            }
            if (domainGuid == null)
            {
                throw new ArgumentNullException(nameof(domainGuid));
            }
            if (domainSid == null)
            {
                throw new ArgumentNullException(nameof(domainSid));
            }
            if (azureStorageSid == null)
            {
                throw new ArgumentNullException(nameof(azureStorageSid));
            }

            DomainName = domainName;
            NetBiosDomainName = netBiosDomainName;
            ForestName = forestName;
            DomainGuid = domainGuid;
            DomainSid = domainSid;
            AzureStorageSid = azureStorageSid;
        }

        /// <summary> Initializes a new instance of ActiveDirectoryProperties. </summary>
        /// <param name="domainName"> Specifies the primary domain that the AD DNS server is authoritative for. </param>
        /// <param name="netBiosDomainName"> Specifies the NetBIOS domain name. </param>
        /// <param name="forestName"> Specifies the Active Directory forest to get. </param>
        /// <param name="domainGuid"> Specifies the domain GUID. </param>
        /// <param name="domainSid"> Specifies the security identifier (SID). </param>
        /// <param name="azureStorageSid"> Specifies the security identifier (SID) for Azure Storage. </param>
        /// <param name="samAccountName"> Specifies the Active Directory SAMAccountName for Azure Storage. </param>
        /// <param name="accountType"> Specifies the Active Directory account type for Azure Storage. </param>
        internal ActiveDirectoryProperties(string domainName, string netBiosDomainName, string forestName, string domainGuid, string domainSid, string azureStorageSid, string samAccountName, ActiveDirectoryPropertiesAccountType? accountType)
        {
            DomainName = domainName;
            NetBiosDomainName = netBiosDomainName;
            ForestName = forestName;
            DomainGuid = domainGuid;
            DomainSid = domainSid;
            AzureStorageSid = azureStorageSid;
            SamAccountName = samAccountName;
            AccountType = accountType;
        }

        /// <summary> Specifies the primary domain that the AD DNS server is authoritative for. </summary>
        public string DomainName { get; set; }
        /// <summary> Specifies the NetBIOS domain name. </summary>
        public string NetBiosDomainName { get; set; }
        /// <summary> Specifies the Active Directory forest to get. </summary>
        public string ForestName { get; set; }
        /// <summary> Specifies the domain GUID. </summary>
        public string DomainGuid { get; set; }
        /// <summary> Specifies the security identifier (SID). </summary>
        public string DomainSid { get; set; }
        /// <summary> Specifies the security identifier (SID) for Azure Storage. </summary>
        public string AzureStorageSid { get; set; }
        /// <summary> Specifies the Active Directory SAMAccountName for Azure Storage. </summary>
        public string SamAccountName { get; set; }
        /// <summary> Specifies the Active Directory account type for Azure Storage. </summary>
        public ActiveDirectoryPropertiesAccountType? AccountType { get; set; }
    }
}
