// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of log files. </summary>
    internal partial class LogFileListResult
    {
        /// <summary> Initializes a new instance of LogFileListResult. </summary>
        internal LogFileListResult()
        {
            Value = new ChangeTrackingList<LogFile>();
        }

        /// <summary> Initializes a new instance of LogFileListResult. </summary>
        /// <param name="value"> The list of log files. </param>
        internal LogFileListResult(IReadOnlyList<LogFile> value)
        {
            Value = value;
        }

        /// <summary> The list of log files. </summary>
        public IReadOnlyList<LogFile> Value { get; }
    }
}
