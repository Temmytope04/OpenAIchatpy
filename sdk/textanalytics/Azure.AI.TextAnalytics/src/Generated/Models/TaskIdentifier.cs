// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Base task object. </summary>
    internal partial class TaskIdentifier
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TaskIdentifier"/>. </summary>
        public TaskIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TaskIdentifier"/>. </summary>
        /// <param name="taskName"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TaskIdentifier(string taskName, Dictionary<string, BinaryData> rawData)
        {
            TaskName = taskName;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; set; }
    }
}
