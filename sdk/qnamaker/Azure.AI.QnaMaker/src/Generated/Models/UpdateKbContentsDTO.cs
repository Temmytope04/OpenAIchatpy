// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    /// <summary> PATCH body schema for Update operation in Update Kb. </summary>
    internal partial class UpdateKbContentsDTO
    {
        /// <summary> Initializes a new instance of UpdateKbContentsDTO. </summary>
        public UpdateKbContentsDTO()
        {
            QnaList = new ChangeTrackingList<UpdateQnaDTO>();
            Urls = new ChangeTrackingList<string>();
        }

        /// <summary> Friendly name for the knowledgebase. </summary>
        public string Name { get; set; }
        /// <summary> List of Q-A (UpdateQnaDTO) to be added to the knowledgebase. </summary>
        public IList<UpdateQnaDTO> QnaList { get; }
        /// <summary> List of existing URLs to be refreshed. The content will be extracted again and re-indexed. </summary>
        public IList<string> Urls { get; }
        /// <summary> Default answer sent to user if no good match is found in the KB. </summary>
        public string DefaultAnswer { get; set; }
    }
}
