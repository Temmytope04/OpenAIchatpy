// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Language info. </summary>
    public partial class NotebookLanguageInfo
    {
        /// <summary> Initializes a new instance of <see cref="NotebookLanguageInfo"/>. </summary>
        /// <param name="name"> The programming language which this kernel runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public NotebookLanguageInfo(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="NotebookLanguageInfo"/>. </summary>
        /// <param name="name"> The programming language which this kernel runs. </param>
        /// <param name="codemirrorMode"> The codemirror mode to use for code in this language. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal NotebookLanguageInfo(string name, string codemirrorMode, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            CodemirrorMode = codemirrorMode;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The programming language which this kernel runs. </summary>
        public string Name { get; set; }
        /// <summary> The codemirror mode to use for code in this language. </summary>
        public string CodemirrorMode { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
