// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownFunctionBinding. </summary>
    internal partial class UnknownFunctionBinding : StreamingJobFunctionBinding
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFunctionBinding"/>. </summary>
        /// <param name="functionBindingType"> Indicates the function binding type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFunctionBinding(string functionBindingType, Dictionary<string, BinaryData> rawData) : base(functionBindingType, rawData)
        {
            FunctionBindingType = functionBindingType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFunctionBinding"/> for deserialization. </summary>
        internal UnknownFunctionBinding()
        {
        }
    }
}
