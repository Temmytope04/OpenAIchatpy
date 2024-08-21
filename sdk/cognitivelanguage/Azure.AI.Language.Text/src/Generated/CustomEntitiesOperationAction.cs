// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the custom text LRO task. </summary>
    public partial class CustomEntitiesOperationAction : AnalyzeTextOperationAction
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntitiesOperationAction"/>. </summary>
        public CustomEntitiesOperationAction()
        {
            Kind = AnalyzeTextOperationActionKind.CustomEntityRecognition;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntitiesOperationAction"/>. </summary>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="actionContent"> task parameters. </param>
        internal CustomEntitiesOperationAction(string name, AnalyzeTextOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, CustomEntitiesActionContent actionContent) : base(name, kind, serializedAdditionalRawData)
        {
            ActionContent = actionContent;
        }

        /// <summary> task parameters. </summary>
        public CustomEntitiesActionContent ActionContent { get; set; }
    }
}
