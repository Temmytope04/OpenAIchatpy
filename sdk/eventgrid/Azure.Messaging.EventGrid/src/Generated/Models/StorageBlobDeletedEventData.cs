// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Storage.BlobDeleted event. </summary>
    internal partial class StorageBlobDeletedEventData
    {
        /// <summary> Initializes a new instance of StorageBlobDeletedEventData. </summary>
        internal StorageBlobDeletedEventData()
        {
        }

        /// <summary> The name of the API/operation that triggered this event. </summary>
        public string Api { get; }
        /// <summary> A request id provided by the client of the storage API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The request id generated by the Storage service for the storage API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> The content type of the blob. This is the same as what would be returned in the Content-Type header from the blob. </summary>
        public string ContentType { get; }
        /// <summary> The type of blob. </summary>
        public string BlobType { get; }
        /// <summary> The path to the blob. </summary>
        public string Url { get; }
        /// <summary> An opaque string value representing the logical sequence of events for any particular blob name. Users can use standard string comparison to understand the relative sequence of two events on the same blob name. </summary>
        public string Sequencer { get; }
        /// <summary> The identity of the requester that triggered this event. </summary>
        public string Identity { get; }
        /// <summary> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </summary>
        public object StorageDiagnostics { get; }
    }
}
