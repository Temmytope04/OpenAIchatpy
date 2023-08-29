// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation information. </summary>
    public partial class ArmDeploymentOperation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentOperation"/>. </summary>
        internal ArmDeploymentOperation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentOperation"/>. </summary>
        /// <param name="id"> Full deployment operation ID. </param>
        /// <param name="operationId"> Deployment operation ID. </param>
        /// <param name="properties"> Deployment properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentOperation(string id, string operationId, ArmDeploymentOperationProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            OperationId = operationId;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Full deployment operation ID. </summary>
        public string Id { get; }
        /// <summary> Deployment operation ID. </summary>
        public string OperationId { get; }
        /// <summary> Deployment properties. </summary>
        public ArmDeploymentOperationProperties Properties { get; }
    }
}
