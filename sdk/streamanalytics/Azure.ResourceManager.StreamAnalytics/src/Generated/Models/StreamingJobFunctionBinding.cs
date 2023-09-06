// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The physical binding of the function. For example, in the Azure Machine Learning web service’s case, this describes the endpoint.
    /// Please note <see cref="StreamingJobFunctionBinding"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EMachineLearningStudioFunctionBinding"/>, <see cref="MachineLearningServiceFunctionBinding"/>, <see cref="CSharpFunctionBinding"/> and <see cref="JavaScriptFunctionBinding"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownFunctionBinding))]
    public abstract partial class StreamingJobFunctionBinding
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamingJobFunctionBinding"/>. </summary>
        protected StreamingJobFunctionBinding()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobFunctionBinding"/>. </summary>
        /// <param name="functionBindingType"> Indicates the function binding type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingJobFunctionBinding(string functionBindingType, Dictionary<string, BinaryData> rawData)
        {
            FunctionBindingType = functionBindingType;
            _rawData = rawData;
        }

        /// <summary> Indicates the function binding type. </summary>
        internal string FunctionBindingType { get; set; }
    }
}
