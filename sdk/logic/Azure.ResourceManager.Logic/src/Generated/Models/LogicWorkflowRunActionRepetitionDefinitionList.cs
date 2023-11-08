// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A collection of workflow run action repetitions. </summary>
    internal partial class LogicWorkflowRunActionRepetitionDefinitionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunActionRepetitionDefinitionList"/>. </summary>
        internal LogicWorkflowRunActionRepetitionDefinitionList()
        {
            Value = new ChangeTrackingList<LogicWorkflowRunActionRepetitionDefinitionData>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunActionRepetitionDefinitionList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of recommendations. </param>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRunActionRepetitionDefinitionList(string nextLink, IReadOnlyList<LogicWorkflowRunActionRepetitionDefinitionData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of recommendations. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<LogicWorkflowRunActionRepetitionDefinitionData> Value { get; }
    }
}
