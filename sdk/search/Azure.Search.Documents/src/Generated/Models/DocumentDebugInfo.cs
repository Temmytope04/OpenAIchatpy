// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Contains debugging information that can be used to further explore your search results. </summary>
    public partial class DocumentDebugInfo
    {
        /// <summary> Initializes a new instance of <see cref="DocumentDebugInfo"/>. </summary>
        internal DocumentDebugInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DocumentDebugInfo"/>. </summary>
        /// <param name="semantic"> Contains debugging information specific to semantic ranking requests. </param>
        internal DocumentDebugInfo(SemanticDebugInfo semantic)
        {
            Semantic = semantic;
        }

        /// <summary> Contains debugging information specific to semantic ranking requests. </summary>
        public SemanticDebugInfo Semantic { get; }
    }
}
