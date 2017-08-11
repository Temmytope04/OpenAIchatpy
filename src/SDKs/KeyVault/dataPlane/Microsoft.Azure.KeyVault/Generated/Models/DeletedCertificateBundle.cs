// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.KeyVault;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Deleted Certificate consisting of its previous id, attributes and its
    /// tags, as well as information on when it will be purged.
    /// </summary>
    public partial class DeletedCertificateBundle : CertificateBundle
    {
        /// <summary>
        /// Initializes a new instance of the DeletedCertificateBundle class.
        /// </summary>
        public DeletedCertificateBundle()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeletedCertificateBundle class.
        /// </summary>
        /// <param name="id">The certificate id.</param>
        /// <param name="kid">The key id.</param>
        /// <param name="sid">The secret id.</param>
        /// <param name="x509Thumbprint">Thumbprint of the certificate.</param>
        /// <param name="policy">The management policy.</param>
        /// <param name="cer">CER contents of x509 certificate.</param>
        /// <param name="contentType">The content type of the secret.</param>
        /// <param name="attributes">The certificate attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs</param>
        /// <param name="recoveryId">The url of the recovery object, used to
        /// identify and recover the deleted certificate.</param>
        /// <param name="scheduledPurgeDate">The time when the certificate is
        /// scheduled to be purged, in UTC</param>
        /// <param name="deletedDate">The time when the certificate was
        /// deleted, in UTC</param>
        public DeletedCertificateBundle(string id = default(string), string kid = default(string), string sid = default(string), byte[] x509Thumbprint = default(byte[]), CertificatePolicy policy = default(CertificatePolicy), byte[] cer = default(byte[]), string contentType = default(string), CertificateAttributes attributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), string recoveryId = default(string), System.DateTime? scheduledPurgeDate = default(System.DateTime?), System.DateTime? deletedDate = default(System.DateTime?))
            : base(id, kid, sid, x509Thumbprint, policy, cer, contentType, attributes, tags)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the url of the recovery object, used to identify and
        /// recover the deleted certificate.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryId")]
        public string RecoveryId { get; set; }

        /// <summary>
        /// Gets the time when the certificate is scheduled to be purged, in
        /// UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "scheduledPurgeDate")]
        public System.DateTime? ScheduledPurgeDate { get; private set; }

        /// <summary>
        /// Gets the time when the certificate was deleted, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "deletedDate")]
        public System.DateTime? DeletedDate { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
