﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs.Specialized;

namespace Microsoft.Azure.WebJobs.Host.Blobs.Listeners
{
    internal class BlobTriggerExecutorContext
    {
        public BlobBaseClient Blob { get; set; }

        /// <summary>
        /// The Id of the parent polling operation. This can be the ClientRequestId used to poll the container or
        /// the unique Id given to the log scan.
        /// </summary>
        public string PollId { get; set; }

        public BlobTriggerSource TriggerSource { get; set; }
    }
}
