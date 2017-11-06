// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSL configuration. If configured data-plane calls to user services will
    /// be exposed over SSL only.
    /// </summary>
    public partial class SslConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the SslConfiguration class.
        /// </summary>
        public SslConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SslConfiguration class.
        /// </summary>
        /// <param name="status">SSL status. Allowed values are Enabled and
        /// Disabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="cert">The SSL cert data in PEM format encoded as
        /// base64 string</param>
        /// <param name="key">The SSL key data in PEM format encoded as base64
        /// string. This is not returned in response of GET/PUT on the
        /// resource. To see this please call listKeys API.</param>
        /// <param name="cname">The CName of the certificate.</param>
        public SslConfiguration(string status = default(string), string cert = default(string), string key = default(string), string cname = default(string))
        {
            Status = status;
            Cert = cert;
            Key = key;
            Cname = cname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SSL status. Allowed values are Enabled and Disabled.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the SSL cert data in PEM format encoded as base64
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "cert")]
        public string Cert { get; set; }

        /// <summary>
        /// Gets or sets the SSL key data in PEM format encoded as base64
        /// string. This is not returned in response of GET/PUT on the
        /// resource. To see this please call listKeys API.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the CName of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public string Cname { get; set; }

    }
}
