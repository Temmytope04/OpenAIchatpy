// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a data deletion detection policy utilizing Azure Blob Storage's native soft delete feature for deletion detection. </summary>
    public partial class NativeBlobSoftDeleteDeletionDetectionPolicy : DataDeletionDetectionPolicy
    {
        /// <summary> Initializes a new instance of NativeBlobSoftDeleteDeletionDetectionPolicy. </summary>
        public NativeBlobSoftDeleteDeletionDetectionPolicy()
        {
            ODataType = "#Microsoft.Azure.Search.NativeBlobSoftDeleteDeletionDetectionPolicy";
        }

        /// <summary> Initializes a new instance of NativeBlobSoftDeleteDeletionDetectionPolicy. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the data deletion detection policy. </param>
        internal NativeBlobSoftDeleteDeletionDetectionPolicy(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.NativeBlobSoftDeleteDeletionDetectionPolicy";
        }
    }
}
