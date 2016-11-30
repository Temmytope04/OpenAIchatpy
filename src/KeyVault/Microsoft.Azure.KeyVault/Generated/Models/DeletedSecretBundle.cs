// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Deleted Secret consisting of its previous id, attributes and its
    /// tags, as well as information on when it will be purged.
    /// </summary>
    public partial class DeletedSecretBundle : SecretBundle
    {
        /// <summary>
        /// Initializes a new instance of the DeletedSecretBundle class.
        /// </summary>
        public DeletedSecretBundle() { }

        /// <summary>
        /// Initializes a new instance of the DeletedSecretBundle class.
        /// </summary>
        /// <param name="value">The secret value </param>
        /// <param name="id">The secret id</param>
        /// <param name="contentType">The content type of the secret</param>
        /// <param name="attributes">The secret management attributes</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs</param>
        /// <param name="kid">If this is a secret backing a KV certificate,
        /// then this field specifies the corresponding key backing the KV
        /// certificate.</param>
        /// <param name="managed">True if the secret's lifetime is managed by
        /// key vault i.e. if this is a secret backing a certificate, then
        /// managed will be true.</param>
        /// <param name="recoveryId">The url of the recovery object, used to
        /// identify and recover the deleted secret.</param>
        /// <param name="scheduledPurgeDate">The time when the secret is
        /// scheduled to be purged, in UTC</param>
        /// <param name="deletedDate">The time when the secret was deleted, in
        /// UTC</param>
        public DeletedSecretBundle(string value = default(string), string id = default(string), string contentType = default(string), SecretAttributes attributes = default(SecretAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), string kid = default(string), bool? managed = default(bool?), string recoveryId = default(string), DateTime? scheduledPurgeDate = default(DateTime?), DateTime? deletedDate = default(DateTime?))
            : base(value, id, contentType, attributes, tags, kid, managed)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary>
        /// Gets or sets the url of the recovery object, used to identify and
        /// recover the deleted secret.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryId")]
        public string RecoveryId { get; set; }

        /// <summary>
        /// Gets the time when the secret is scheduled to be purged, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "scheduledPurgeDate")]
        public DateTime? ScheduledPurgeDate { get; private set; }

        /// <summary>
        /// Gets the time when the secret was deleted, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "deletedDate")]
        public DateTime? DeletedDate { get; private set; }

    }
}
