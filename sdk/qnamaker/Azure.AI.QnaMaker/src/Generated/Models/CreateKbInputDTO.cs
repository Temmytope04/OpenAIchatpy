// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    /// <summary> Input to create KB. </summary>
    internal partial class CreateKbInputDTO
    {
        /// <summary> Initializes a new instance of CreateKbInputDTO. </summary>
        public CreateKbInputDTO()
        {
            QnaList = new ChangeTrackingList<QnAdto>();
            Urls = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<FileDTO>();
        }

        /// <summary> List of QNA to be added to the index. Ids are generated by the service and should be omitted. </summary>
        public IList<QnAdto> QnaList { get; }
        /// <summary> List of URLs to be added to knowledgebase. </summary>
        public IList<string> Urls { get; }
        /// <summary> List of files to be added to knowledgebase. </summary>
        public IList<FileDTO> Files { get; }
    }
}
