// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the DeploymentOperation data model. </summary>
    public partial class DeploymentOperationData : SubResource
    {
        /// <summary> Initializes a new instance of DeploymentOperationData. </summary>
        internal DeploymentOperationData()
        {
        }

        /// <summary> Initializes a new instance of DeploymentOperationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="operationId"> Deployment operation ID. </param>
        /// <param name="properties"> Deployment properties. </param>
        internal DeploymentOperationData(string id, string operationId, DeploymentOperationProperties properties) : base(id)
        {
            OperationId = operationId;
            Properties = properties;
        }

        /// <summary> Deployment operation ID. </summary>
        public string OperationId { get; }
        /// <summary> Deployment properties. </summary>
        public DeploymentOperationProperties Properties { get; }
    }
}
