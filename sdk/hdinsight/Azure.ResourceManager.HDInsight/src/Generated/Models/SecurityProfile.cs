// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The security profile which contains Ssh public key for the HDInsight cluster. </summary>
    public partial class SecurityProfile
    {
        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        public SecurityProfile()
        {
            LdapsUrls = new ChangeTrackingList<string>();
            ClusterUsersGroupDNs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        /// <param name="directoryType"> The directory type. </param>
        /// <param name="domain"> The organization&apos;s active directory domain. </param>
        /// <param name="organizationalUnitDN"> The organizational unit within the Active Directory to place the cluster and service accounts. </param>
        /// <param name="ldapsUrls"> The LDAPS protocol URLs to communicate with the Active Directory. </param>
        /// <param name="domainUsername"> The domain user account that will have admin privileges on the cluster. </param>
        /// <param name="domainUserPassword"> The domain admin password. </param>
        /// <param name="clusterUsersGroupDNs"> Optional. The Distinguished Names for cluster user groups. </param>
        /// <param name="aaddsResourceId"> The resource ID of the user&apos;s Azure Active Directory Domain Service. </param>
        /// <param name="msiResourceId"> User assigned identity that has permissions to read and create cluster-related artifacts in the user&apos;s AADDS. </param>
        internal SecurityProfile(DirectoryType? directoryType, string domain, string organizationalUnitDN, IList<string> ldapsUrls, string domainUsername, string domainUserPassword, IList<string> clusterUsersGroupDNs, string aaddsResourceId, string msiResourceId)
        {
            DirectoryType = directoryType;
            Domain = domain;
            OrganizationalUnitDN = organizationalUnitDN;
            LdapsUrls = ldapsUrls;
            DomainUsername = domainUsername;
            DomainUserPassword = domainUserPassword;
            ClusterUsersGroupDNs = clusterUsersGroupDNs;
            AaddsResourceId = aaddsResourceId;
            MsiResourceId = msiResourceId;
        }

        /// <summary> The directory type. </summary>
        public DirectoryType? DirectoryType { get; set; }
        /// <summary> The organization&apos;s active directory domain. </summary>
        public string Domain { get; set; }
        /// <summary> The organizational unit within the Active Directory to place the cluster and service accounts. </summary>
        public string OrganizationalUnitDN { get; set; }
        /// <summary> The LDAPS protocol URLs to communicate with the Active Directory. </summary>
        public IList<string> LdapsUrls { get; }
        /// <summary> The domain user account that will have admin privileges on the cluster. </summary>
        public string DomainUsername { get; set; }
        /// <summary> The domain admin password. </summary>
        public string DomainUserPassword { get; set; }
        /// <summary> Optional. The Distinguished Names for cluster user groups. </summary>
        public IList<string> ClusterUsersGroupDNs { get; }
        /// <summary> The resource ID of the user&apos;s Azure Active Directory Domain Service. </summary>
        public string AaddsResourceId { get; set; }
        /// <summary> User assigned identity that has permissions to read and create cluster-related artifacts in the user&apos;s AADDS. </summary>
        public string MsiResourceId { get; set; }
    }
}
