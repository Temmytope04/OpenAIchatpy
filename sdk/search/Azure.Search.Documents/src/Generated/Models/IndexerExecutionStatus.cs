// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents the status of an individual indexer execution. </summary>
    public enum IndexerExecutionStatus
    {
        /// <summary> An indexer invocation has failed, but the failure may be transient. Indexer invocations will continue per schedule. </summary>
        TransientFailure,
        /// <summary> Indexer execution completed successfully. </summary>
        Success,
        /// <summary> Indexer execution is in progress. </summary>
        InProgress,
        /// <summary> Indexer has been reset. </summary>
        Reset
    }
}
