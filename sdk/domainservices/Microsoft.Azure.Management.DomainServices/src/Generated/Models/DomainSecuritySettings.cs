// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DomainServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Domain Security Settings
    /// </summary>
    public partial class DomainSecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the DomainSecuritySettings class.
        /// </summary>
        public DomainSecuritySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainSecuritySettings class.
        /// </summary>
        /// <param name="ntlmV1">A flag to determine whether or not NtlmV1 is
        /// enabled or disabled. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="tlsV1">A flag to determine whether or not TlsV1 is
        /// enabled or disabled. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="syncNtlmPasswords">A flag to determine whether or not
        /// SyncNtlmPasswords is enabled or disabled. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="syncKerberosPasswords">A flag to determine whether or
        /// not SyncKerberosPasswords is enabled or disabled. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="syncOnPremPasswords">A flag to determine whether or
        /// not SyncOnPremPasswords is enabled or disabled. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        public DomainSecuritySettings(string ntlmV1 = default(string), string tlsV1 = default(string), string syncNtlmPasswords = default(string), string syncKerberosPasswords = default(string), string syncOnPremPasswords = default(string))
        {
            NtlmV1 = ntlmV1;
            TlsV1 = tlsV1;
            SyncNtlmPasswords = syncNtlmPasswords;
            SyncKerberosPasswords = syncKerberosPasswords;
            SyncOnPremPasswords = syncOnPremPasswords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a flag to determine whether or not NtlmV1 is enabled
        /// or disabled. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ntlmV1")]
        public string NtlmV1 { get; set; }

        /// <summary>
        /// Gets or sets a flag to determine whether or not TlsV1 is enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "tlsV1")]
        public string TlsV1 { get; set; }

        /// <summary>
        /// Gets or sets a flag to determine whether or not SyncNtlmPasswords
        /// is enabled or disabled. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "syncNtlmPasswords")]
        public string SyncNtlmPasswords { get; set; }

        /// <summary>
        /// Gets or sets a flag to determine whether or not
        /// SyncKerberosPasswords is enabled or disabled. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "syncKerberosPasswords")]
        public string SyncKerberosPasswords { get; set; }

        /// <summary>
        /// Gets or sets a flag to determine whether or not SyncOnPremPasswords
        /// is enabled or disabled. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "syncOnPremPasswords")]
        public string SyncOnPremPasswords { get; set; }

    }
}
