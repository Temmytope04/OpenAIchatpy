// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> a plain text value execution parameter. </summary>
    public partial class ScriptStringExecutionParameterDetails : ScriptExecutionParameterDetails
    {
        /// <summary> Initializes a new instance of <see cref="ScriptStringExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScriptStringExecutionParameterDetails(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ParameterType = ScriptExecutionParameterType.Value;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptStringExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="parameterType"> The type of execution parameter. </param>
        /// <param name="value"> The value for the passed parameter. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptStringExecutionParameterDetails(string name, ScriptExecutionParameterType parameterType, string value, Dictionary<string, BinaryData> rawData) : base(name, parameterType, rawData)
        {
            Value = value;
            ParameterType = parameterType;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptStringExecutionParameterDetails"/> for deserialization. </summary>
        internal ScriptStringExecutionParameterDetails()
        {
        }

        /// <summary> The value for the passed parameter. </summary>
        public string Value { get; set; }
    }
}
