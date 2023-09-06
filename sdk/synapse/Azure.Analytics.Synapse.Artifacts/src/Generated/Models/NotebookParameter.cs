// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Notebook parameter. </summary>
    public partial class NotebookParameter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotebookParameter"/>. </summary>
        public NotebookParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotebookParameter"/>. </summary>
        /// <param name="value"> Notebook parameter value. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> Notebook parameter type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotebookParameter(object value, NotebookParameterType? type, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            Type = type;
            _rawData = rawData;
        }

        /// <summary> Notebook parameter value. Type: string (or Expression with resultType string). </summary>
        public object Value { get; set; }
        /// <summary> Notebook parameter type. </summary>
        public NotebookParameterType? Type { get; set; }
    }
}
