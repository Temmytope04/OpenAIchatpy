// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sync Session status object.
    /// </summary>
    public partial class ServerEndpointSyncActivityStatus
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncActivityStatus
        /// class.
        /// </summary>
        public ServerEndpointSyncActivityStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncActivityStatus
        /// class.
        /// </summary>
        /// <param name="timestamp">Timestamp when properties were
        /// updated</param>
        /// <param name="perItemErrorCount">Per item error count</param>
        /// <param name="appliedItemCount">Applied item count.</param>
        /// <param name="totalItemCount">Total item count (if
        /// available)</param>
        /// <param name="appliedBytes">Applied bytes</param>
        /// <param name="totalBytes">Total bytes (if available)</param>
        /// <param name="syncMode">Sync mode. Possible values include:
        /// 'Regular', 'NamespaceDownload', 'InitialUpload', 'SnapshotUpload',
        /// 'InitialFullDownload'</param>
        /// <param name="sessionMinutesRemaining">Session minutes remaining (if
        /// available)</param>
        public ServerEndpointSyncActivityStatus(System.DateTime? timestamp = default(System.DateTime?), long? perItemErrorCount = default(long?), long? appliedItemCount = default(long?), long? totalItemCount = default(long?), long? appliedBytes = default(long?), long? totalBytes = default(long?), string syncMode = default(string), int? sessionMinutesRemaining = default(int?))
        {
            Timestamp = timestamp;
            PerItemErrorCount = perItemErrorCount;
            AppliedItemCount = appliedItemCount;
            TotalItemCount = totalItemCount;
            AppliedBytes = appliedBytes;
            TotalBytes = totalBytes;
            SyncMode = syncMode;
            SessionMinutesRemaining = sessionMinutesRemaining;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets timestamp when properties were updated
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets per item error count
        /// </summary>
        [JsonProperty(PropertyName = "perItemErrorCount")]
        public long? PerItemErrorCount { get; private set; }

        /// <summary>
        /// Gets applied item count.
        /// </summary>
        [JsonProperty(PropertyName = "appliedItemCount")]
        public long? AppliedItemCount { get; private set; }

        /// <summary>
        /// Gets total item count (if available)
        /// </summary>
        [JsonProperty(PropertyName = "totalItemCount")]
        public long? TotalItemCount { get; private set; }

        /// <summary>
        /// Gets applied bytes
        /// </summary>
        [JsonProperty(PropertyName = "appliedBytes")]
        public long? AppliedBytes { get; private set; }

        /// <summary>
        /// Gets total bytes (if available)
        /// </summary>
        [JsonProperty(PropertyName = "totalBytes")]
        public long? TotalBytes { get; private set; }

        /// <summary>
        /// Gets sync mode. Possible values include: 'Regular',
        /// 'NamespaceDownload', 'InitialUpload', 'SnapshotUpload',
        /// 'InitialFullDownload'
        /// </summary>
        [JsonProperty(PropertyName = "syncMode")]
        public string SyncMode { get; private set; }

        /// <summary>
        /// Gets session minutes remaining (if available)
        /// </summary>
        [JsonProperty(PropertyName = "sessionMinutesRemaining")]
        public int? SessionMinutesRemaining { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PerItemErrorCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PerItemErrorCount", 0);
            }
            if (AppliedItemCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AppliedItemCount", 0);
            }
            if (TotalItemCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalItemCount", 0);
            }
            if (AppliedBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AppliedBytes", 0);
            }
            if (TotalBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalBytes", 0);
            }
            if (SessionMinutesRemaining < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "SessionMinutesRemaining", 0);
            }
        }
    }
}
