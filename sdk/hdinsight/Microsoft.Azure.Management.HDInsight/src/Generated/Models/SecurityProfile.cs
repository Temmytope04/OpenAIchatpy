// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The security profile which contains Ssh public key for the HDInsight
    /// cluster.
    /// </summary>
    public partial class SecurityProfile
    {
        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        public SecurityProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        /// <param name="directoryType">The directory type. Possible values
        /// include: 'ActiveDirectory'</param>
        /// <param name="domain">The organization's active directory
        /// domain.</param>
        /// <param name="organizationalUnitDN">The organizational unit within
        /// the Active Directory to place the cluster and service
        /// accounts.</param>
        /// <param name="ldapsUrls">The LDAPS protocol URLs to communicate with
        /// the Active Directory.</param>
        /// <param name="domainUsername">The domain user account that will have
        /// admin privileges on the cluster.</param>
        /// <param name="domainUserPassword">The domain admin password.</param>
        /// <param name="clusterUsersGroupDNs">Optional. The Distinguished
        /// Names for cluster user groups</param>
        /// <param name="aaddsResourceId">The resource ID of the user's Azure
        /// Active Directory Domain Service.</param>
        /// <param name="msiResourceId">User assigned identity that has
        /// permissions to read and create cluster-related artifacts in the
        /// user's AADDS.</param>
        public SecurityProfile(string directoryType = default(string), string domain = default(string), string organizationalUnitDN = default(string), IList<string> ldapsUrls = default(IList<string>), string domainUsername = default(string), string domainUserPassword = default(string), IList<string> clusterUsersGroupDNs = default(IList<string>), string aaddsResourceId = default(string), string msiResourceId = default(string))
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
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the directory type. Possible values include:
        /// 'ActiveDirectory'
        /// </summary>
        [JsonProperty(PropertyName = "directoryType")]
        public string DirectoryType { get; set; }

        /// <summary>
        /// Gets or sets the organization's active directory domain.
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the organizational unit within the Active Directory to
        /// place the cluster and service accounts.
        /// </summary>
        [JsonProperty(PropertyName = "organizationalUnitDN")]
        public string OrganizationalUnitDN { get; set; }

        /// <summary>
        /// Gets or sets the LDAPS protocol URLs to communicate with the Active
        /// Directory.
        /// </summary>
        [JsonProperty(PropertyName = "ldapsUrls")]
        public IList<string> LdapsUrls { get; set; }

        /// <summary>
        /// Gets or sets the domain user account that will have admin
        /// privileges on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "domainUsername")]
        public string DomainUsername { get; set; }

        /// <summary>
        /// Gets or sets the domain admin password.
        /// </summary>
        [JsonProperty(PropertyName = "domainUserPassword")]
        public string DomainUserPassword { get; set; }

        /// <summary>
        /// Gets or sets optional. The Distinguished Names for cluster user
        /// groups
        /// </summary>
        [JsonProperty(PropertyName = "clusterUsersGroupDNs")]
        public IList<string> ClusterUsersGroupDNs { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the user's Azure Active Directory
        /// Domain Service.
        /// </summary>
        [JsonProperty(PropertyName = "aaddsResourceId")]
        public string AaddsResourceId { get; set; }

        /// <summary>
        /// Gets or sets user assigned identity that has permissions to read
        /// and create cluster-related artifacts in the user's AADDS.
        /// </summary>
        [JsonProperty(PropertyName = "msiResourceId")]
        public string MsiResourceId { get; set; }

    }
}
