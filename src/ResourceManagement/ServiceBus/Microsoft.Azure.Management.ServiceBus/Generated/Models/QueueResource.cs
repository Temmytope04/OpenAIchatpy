// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Azure;
    using Management;
    using ServiceBus;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of queue Resource.
    /// </summary>
    [JsonTransformation]
    public partial class QueueResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the QueueResource class.
        /// </summary>
        public QueueResource() { }

        /// <summary>
        /// Initializes a new instance of the QueueResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="lockDuration">The duration of a peek-lock; that is,
        /// the amount of time that the message is locked for other receivers.
        /// The maximum value for LockDuration is 5 minutes; the default value
        /// is 1 minute.</param>
        /// <param name="accessedAt">Last time a message was sent, or the last
        /// time there was a receive request to this queue.</param>
        /// <param name="autoDeleteOnIdle">the TimeSpan idle interval after
        /// which the queue is automatically deleted. The minimum duration is 5
        /// minutes.</param>
        /// <param name="entityAvailabilityStatus">Entity availability status
        /// for the queue. Possible values include: 'Available', 'Limited',
        /// 'Renaming', 'Restoring', 'Unknown'</param>
        /// <param name="createdAt">The exact time the message was
        /// created.</param>
        /// <param name="defaultMessageTimeToLive">The default message time to
        /// live value. This is the duration after which the message expires,
        /// starting from when the message is sent to Service Bus. This is the
        /// default value used when TimeToLive is not set on a message
        /// itself.</param>
        /// <param name="duplicateDetectionHistoryTimeWindow">TimeSpan
        /// structure that defines the duration of the duplicate detection
        /// history. The default value is 10 minutes.</param>
        /// <param name="enableBatchedOperations">A value that indicates
        /// whether server-side batched operations are enabled.</param>
        /// <param name="deadLetteringOnMessageExpiration">A value that
        /// indicates whether this queue has dead letter support when a message
        /// expires.</param>
        /// <param name="enableExpress">A value that indicates whether Express
        /// Entities are enabled. An express queue holds a message in memory
        /// temporarily before writing it to persistent storage.</param>
        /// <param name="enablePartitioning">A value that indicates whether the
        /// queue is to be partitioned across multiple message brokers.</param>
        /// <param name="isAnonymousAccessible">A value that indicates whether
        /// the message is accessible anonymously.</param>
        /// <param name="maxDeliveryCount">The maximum delivery count. A
        /// message is automatically deadlettered after this number of
        /// deliveries.</param>
        /// <param name="maxSizeInMegabytes">The maximum size of the queue in
        /// megabytes, which is the size of memory allocated for the
        /// queue.</param>
        /// <param name="messageCount">The number of messages in the
        /// queue.</param>
        /// <param name="requiresDuplicateDetection">A value indicating if this
        /// queue requires duplicate detection.</param>
        /// <param name="requiresSession">A value that indicates whether the
        /// queue supports the concept of sessions.</param>
        /// <param name="sizeInBytes">The size of the queue, in bytes.</param>
        /// <param name="status">Enumerates the possible values for the status
        /// of a messaging entity. Possible values include: 'Active',
        /// 'Creating', 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming',
        /// 'Restoring', 'SendDisabled', 'Unknown'</param>
        /// <param name="supportOrdering">A value that indicates whether the
        /// queue supports ordering.</param>
        /// <param name="updatedAt">The exact time the message was
        /// updated.</param>
        public QueueResource(string id = default(string), string name = default(string), string type = default(string), string lockDuration = default(string), System.DateTime? accessedAt = default(System.DateTime?), string autoDeleteOnIdle = default(string), EntityAvailabilityStatus? entityAvailabilityStatus = default(EntityAvailabilityStatus?), System.DateTime? createdAt = default(System.DateTime?), string defaultMessageTimeToLive = default(string), string duplicateDetectionHistoryTimeWindow = default(string), bool? enableBatchedOperations = default(bool?), bool? deadLetteringOnMessageExpiration = default(bool?), bool? enableExpress = default(bool?), bool? enablePartitioning = default(bool?), bool? isAnonymousAccessible = default(bool?), int? maxDeliveryCount = default(int?), long? maxSizeInMegabytes = default(long?), long? messageCount = default(long?), MessageCountDetails countDetails = default(MessageCountDetails), bool? requiresDuplicateDetection = default(bool?), bool? requiresSession = default(bool?), long? sizeInBytes = default(long?), EntityStatus? status = default(EntityStatus?), bool? supportOrdering = default(bool?), System.DateTime? updatedAt = default(System.DateTime?))
            : base(id, name, type)
        {
            LockDuration = lockDuration;
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            EntityAvailabilityStatus = entityAvailabilityStatus;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            EnableExpress = enableExpress;
            EnablePartitioning = enablePartitioning;
            IsAnonymousAccessible = isAnonymousAccessible;
            MaxDeliveryCount = maxDeliveryCount;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MessageCount = messageCount;
            CountDetails = countDetails;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            RequiresSession = requiresSession;
            SizeInBytes = sizeInBytes;
            Status = status;
            SupportOrdering = supportOrdering;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or sets the duration of a peek-lock; that is, the amount of
        /// time that the message is locked for other receivers. The maximum
        /// value for LockDuration is 5 minutes; the default value is 1 minute.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lockDuration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Gets last time a message was sent, or the last time there was a
        /// receive request to this queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessedAt")]
        public System.DateTime? AccessedAt { get; protected set; }

        /// <summary>
        /// Gets or sets the TimeSpan idle interval after which the queue is
        /// automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDeleteOnIdle")]
        public string AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// Gets or sets entity availability status for the queue. Possible
        /// values include: 'Available', 'Limited', 'Renaming', 'Restoring',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityAvailabilityStatus")]
        public EntityAvailabilityStatus? EntityAvailabilityStatus { get; set; }

        /// <summary>
        /// Gets the exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; protected set; }

        /// <summary>
        /// Gets or sets the default message time to live value. This is the
        /// duration after which the message expires, starting from when the
        /// message is sent to Service Bus. This is the default value used when
        /// TimeToLive is not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultMessageTimeToLive")]
        public string DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// Gets or sets timeSpan structure that defines the duration of the
        /// duplicate detection history. The default value is 10 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.duplicateDetectionHistoryTimeWindow")]
        public string DuplicateDetectionHistoryTimeWindow { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether server-side batched
        /// operations are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether this queue has dead
        /// letter support when a message expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnMessageExpiration")]
        public bool? DeadLetteringOnMessageExpiration { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether Express Entities are
        /// enabled. An express queue holds a message in memory temporarily
        /// before writing it to persistent storage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableExpress")]
        public bool? EnableExpress { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the queue is to be
        /// partitioned across multiple message brokers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePartitioning")]
        public bool? EnablePartitioning { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the message is
        /// accessible anonymously.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAnonymousAccessible")]
        public bool? IsAnonymousAccessible { get; set; }

        /// <summary>
        /// Gets or sets the maximum delivery count. A message is automatically
        /// deadlettered after this number of deliveries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the queue in megabytes, which is
        /// the size of memory allocated for the queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeInMegabytes")]
        public long? MaxSizeInMegabytes { get; set; }

        /// <summary>
        /// Gets the number of messages in the queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageCount")]
        public long? MessageCount { get; protected set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.countDetails")]
        public MessageCountDetails CountDetails { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating if this queue requires duplicate
        /// detection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresDuplicateDetection")]
        public bool? RequiresDuplicateDetection { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the queue supports the
        /// concept of sessions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresSession")]
        public bool? RequiresSession { get; set; }

        /// <summary>
        /// Gets the size of the queue, in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeInBytes")]
        public long? SizeInBytes { get; protected set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the status of a
        /// messaging entity. Possible values include: 'Active', 'Creating',
        /// 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming', 'Restoring',
        /// 'SendDisabled', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the queue supports
        /// ordering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportOrdering")]
        public bool? SupportOrdering { get; set; }

        /// <summary>
        /// Gets the exact time the message was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; protected set; }

    }
}

