﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Monitor.Ingestion
{
    /// <summary>
    /// Enum to indicate the status of a logs upload operation.
    /// </summary>
    public enum UploadLogsStatus
    {
        /// <summary>
        /// Indicates that all the logs were successfully uploaded to Azure Monitor.
        /// </summary>
        SUCCESS,
        /// <summary>
        /// Indicates that some logs failed to upload to Azure Monitor.
        /// </summary>
        PARTIALFAILURE,
        /// <summary>
        /// Indicates that all the logs failed to upload to Azure Monitor.
        /// </summary>
        FAILURE
    }
}
