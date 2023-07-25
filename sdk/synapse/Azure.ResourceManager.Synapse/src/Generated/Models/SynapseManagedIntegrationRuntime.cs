// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Managed integration runtime, including managed elastic and managed dedicated integration runtimes. </summary>
    public partial class SynapseManagedIntegrationRuntime : SynapseIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntime. </summary>
        public SynapseManagedIntegrationRuntime()
        {
            IntegrationRuntimeType = IntegrationRuntimeType.Managed;
        }

        /// <summary> Initializes a new instance of SynapseManagedIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="state"> Integration runtime state, only valid for managed dedicated integration runtime. </param>
        /// <param name="referenceName"> The reference name of the managed virtual network. </param>
        /// <param name="typeManagedVirtualNetworkType"> The type of the managed virtual network. </param>
        /// <param name="id"> The id of the managed virtual network. </param>
        /// <param name="computeProperties"> The compute resource for managed integration runtime. </param>
        /// <param name="ssisProperties"> SSIS properties for managed integration runtime. </param>
        internal SynapseManagedIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, BinaryData> additionalProperties, SynapseIntegrationRuntimeState? state, string referenceName, string typeManagedVirtualNetworkType, string id, SynapseIntegrationRuntimeComputeProperties computeProperties, SynapseIntegrationRuntimeSsisProperties ssisProperties) : base(integrationRuntimeType, description, additionalProperties)
        {
            State = state;
            ReferenceName = referenceName;
            TypeManagedVirtualNetworkType = typeManagedVirtualNetworkType;
            Id = id;
            ComputeProperties = computeProperties;
            SsisProperties = ssisProperties;
            IntegrationRuntimeType = integrationRuntimeType;
        }

        /// <summary> Integration runtime state, only valid for managed dedicated integration runtime. </summary>
        public SynapseIntegrationRuntimeState? State { get; }
        /// <summary> The reference name of the managed virtual network. </summary>
        public string ReferenceName { get; set; }
        /// <summary> The type of the managed virtual network. </summary>
        public string TypeManagedVirtualNetworkType { get; set; }
        /// <summary> The id of the managed virtual network. </summary>
        public string Id { get; set; }
        /// <summary> The compute resource for managed integration runtime. </summary>
        public SynapseIntegrationRuntimeComputeProperties ComputeProperties { get; set; }
        /// <summary> SSIS properties for managed integration runtime. </summary>
        public SynapseIntegrationRuntimeSsisProperties SsisProperties { get; set; }
    }
}
