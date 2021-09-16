// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Publishing options for requested profile.
    /// </summary>
    public partial class CsmPublishingProfileOptions
    {
        /// <summary>
        /// Initializes a new instance of the CsmPublishingProfileOptions
        /// class.
        /// </summary>
        public CsmPublishingProfileOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CsmPublishingProfileOptions
        /// class.
        /// </summary>
        /// <param name="format">Name of the format. Valid values are:
        /// FileZilla3
        /// WebDeploy -- default
        /// Ftp. Possible values include: 'FileZilla3', 'WebDeploy',
        /// 'Ftp'</param>
        /// <param name="includeDisasterRecoveryEndpoints">Include the
        /// DisasterRecover endpoint if true</param>
        public CsmPublishingProfileOptions(string format = default(string), bool? includeDisasterRecoveryEndpoints = default(bool?))
        {
            Format = format;
            IncludeDisasterRecoveryEndpoints = includeDisasterRecoveryEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the format. Valid values are:
        /// FileZilla3
        /// WebDeploy -- default
        /// Ftp. Possible values include: 'FileZilla3', 'WebDeploy', 'Ftp'
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets include the DisasterRecover endpoint if true
        /// </summary>
        [JsonProperty(PropertyName = "includeDisasterRecoveryEndpoints")]
        public bool? IncludeDisasterRecoveryEndpoints { get; set; }

    }
}
