// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.AI.Language.QuestionAnswering.Models;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> The question parameters to answer using a knowledge base. </summary>
    public partial class QueryKnowledgeBaseOptions
    {
        /// <summary> Max number of answers to be returned for the question. </summary>
        public int? Top { get; set; }
        /// <summary> Unique identifier for the user. </summary>
        public string UserId { get; set; }
        /// <summary> Minimum threshold score for answers, value ranges from 0 to 1. </summary>
        public double? ConfidenceScoreThreshold { get; set; }
        /// <summary> Context object with previous QnA&apos;s information. </summary>
        public KnowledgeBaseAnswerRequestContext Context { get; set; }
        /// <summary> (Optional) Set to &apos;QuestionOnly&apos; for using a question only Ranker. </summary>
        public RankerType? RankerType { get; set; }
        /// <summary> Filter QnAs based on give metadata list and knowledge base source names. </summary>
        public StrictFilters StrictFilters { get; set; }
        /// <summary> To configure Answer span prediction feature. </summary>
        public AnswerSpanRequest AnswerSpanRequest { get; set; }
        /// <summary> (Optional) Flag to enable Query over Unstructured Sources. </summary>
        public bool? IncludeUnstructuredSources { get; set; }
    }
}
