// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// Deploy SAP Infrastructure Details.
    /// Please note <see cref="InfrastructureConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SingleServerConfiguration"/> and <see cref="ThreeTierConfiguration"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownInfrastructureConfiguration))]
    public abstract partial class InfrastructureConfiguration
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="InfrastructureConfiguration"/>. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appResourceGroup"/> is null. </exception>
        protected InfrastructureConfiguration(string appResourceGroup)
        {
            Argument.AssertNotNull(appResourceGroup, nameof(appResourceGroup));

            AppResourceGroup = appResourceGroup;
        }

        /// <summary> Initializes a new instance of <see cref="InfrastructureConfiguration"/>. </summary>
        /// <param name="deploymentType"> The type of SAP deployment, single server or Three tier. </param>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InfrastructureConfiguration(SapDeploymentType deploymentType, string appResourceGroup, Dictionary<string, BinaryData> rawData)
        {
            DeploymentType = deploymentType;
            AppResourceGroup = appResourceGroup;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="InfrastructureConfiguration"/> for deserialization. </summary>
        internal InfrastructureConfiguration()
        {
        }

        /// <summary> The type of SAP deployment, single server or Three tier. </summary>
        internal SapDeploymentType DeploymentType { get; set; }
        /// <summary> The application resource group where SAP system resources will be deployed. </summary>
        public string AppResourceGroup { get; set; }
    }
}
