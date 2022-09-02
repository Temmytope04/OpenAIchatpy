// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A Synapse Workspace Sql Pool Table data set mapping. </summary>
    public partial class SynapseWorkspaceSqlPoolTableDataSetMapping : DataSetMappingData
    {
        /// <summary> Initializes a new instance of SynapseWorkspaceSqlPoolTableDataSetMapping. </summary>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetId"/> or <paramref name="synapseWorkspaceSqlPoolTableResourceId"/> is null. </exception>
        public SynapseWorkspaceSqlPoolTableDataSetMapping(string dataSetId, string synapseWorkspaceSqlPoolTableResourceId)
        {
            if (dataSetId == null)
            {
                throw new ArgumentNullException(nameof(dataSetId));
            }
            if (synapseWorkspaceSqlPoolTableResourceId == null)
            {
                throw new ArgumentNullException(nameof(synapseWorkspaceSqlPoolTableResourceId));
            }

            DataSetId = dataSetId;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = DataSetMappingKind.SynapseWorkspaceSqlPoolTable;
        }

        /// <summary> Initializes a new instance of SynapseWorkspaceSqlPoolTableDataSetMapping. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        internal SynapseWorkspaceSqlPoolTableDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, string dataSetId, DataSetMappingStatus? dataSetMappingStatus, ProvisioningState? provisioningState, string synapseWorkspaceSqlPoolTableResourceId) : base(id, name, resourceType, systemData, kind)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            ProvisioningState = provisioningState;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = kind;
        }

        /// <summary> The id of the source data set. </summary>
        public string DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Resource id of the Synapse Workspace SQL Pool Table. </summary>
        public string SynapseWorkspaceSqlPoolTableResourceId { get; set; }
    }
}
