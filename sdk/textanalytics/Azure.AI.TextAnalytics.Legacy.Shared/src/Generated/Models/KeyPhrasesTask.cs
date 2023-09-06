// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The KeyPhrasesTask. </summary>
    internal partial class KeyPhrasesTask
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesTask"/>. </summary>
        public KeyPhrasesTask()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyPhrasesTask"/>. </summary>
        /// <param name="parameters"></param>
        /// <param name="taskName"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyPhrasesTask(KeyPhrasesTaskParameters parameters, string taskName, Dictionary<string, BinaryData> rawData)
        {
            Parameters = parameters;
            TaskName = taskName;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public KeyPhrasesTaskParameters Parameters { get; set; }
        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; set; }
    }
}
