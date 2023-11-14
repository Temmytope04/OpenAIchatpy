// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Dto object representing compute resource. </summary>
    internal partial class MaterializationComputeResource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MaterializationComputeResource"/>. </summary>
        public MaterializationComputeResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaterializationComputeResource"/>. </summary>
        /// <param name="instanceType"> Specifies the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaterializationComputeResource(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the instance type. </summary>
        public string InstanceType { get; set; }
    }
}
