// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Legacy similarity algorithm which uses the Lucene TFIDFSimilarity implementation of TF-IDF. This variation of TF-IDF introduces static document length normalization as well as coordinating factors that penalize documents that only partially match the searched queries. </summary>
    public partial class ClassicSimilarity : SimilarityAlgorithm
    {
        /// <summary> Initializes a new instance of <see cref="ClassicSimilarity"/>. </summary>
        public ClassicSimilarity()
        {
            ODataType = "#Microsoft.Azure.Search.ClassicSimilarity";
        }

        /// <summary> Initializes a new instance of <see cref="ClassicSimilarity"/>. </summary>
        /// <param name="oDataType"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClassicSimilarity(string oDataType, Dictionary<string, BinaryData> rawData) : base(oDataType, rawData)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.ClassicSimilarity";
        }
    }
}
