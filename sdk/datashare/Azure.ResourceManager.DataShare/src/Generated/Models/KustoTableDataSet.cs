// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A kusto table data set. </summary>
    public partial class KustoTableDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of <see cref="KustoTableDataSet"/>. </summary>
        /// <param name="kustoDatabaseResourceId"> Resource id of the kusto database. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing properties for kusto database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kustoDatabaseResourceId"/> or <paramref name="tableLevelSharingProperties"/> is null. </exception>
        public KustoTableDataSet(ResourceIdentifier kustoDatabaseResourceId, TableLevelSharingProperties tableLevelSharingProperties)
        {
            if (kustoDatabaseResourceId == null)
            {
                throw new ArgumentNullException(nameof(kustoDatabaseResourceId));
            }
            if (tableLevelSharingProperties == null)
            {
                throw new ArgumentNullException(nameof(tableLevelSharingProperties));
            }

            KustoDatabaseResourceId = kustoDatabaseResourceId;
            TableLevelSharingProperties = tableLevelSharingProperties;
            Kind = DataSetKind.KustoTable;
        }

        /// <summary> Initializes a new instance of <see cref="KustoTableDataSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="kustoDatabaseResourceId"> Resource id of the kusto database. </param>
        /// <param name="location"> Location of the kusto cluster. </param>
        /// <param name="provisioningState"> Provisioning state of the kusto table data set. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing properties for kusto database. </param>
        internal KustoTableDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? dataSetId, ResourceIdentifier kustoDatabaseResourceId, AzureLocation? location, DataShareProvisioningState? provisioningState, TableLevelSharingProperties tableLevelSharingProperties) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            DataSetId = dataSetId;
            KustoDatabaseResourceId = kustoDatabaseResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            TableLevelSharingProperties = tableLevelSharingProperties;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="KustoTableDataSet"/> for deserialization. </summary>
        internal KustoTableDataSet()
        {
        }

        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Resource id of the kusto database. </summary>
        public ResourceIdentifier KustoDatabaseResourceId { get; set; }
        /// <summary> Location of the kusto cluster. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Provisioning state of the kusto table data set. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Table level sharing properties for kusto database. </summary>
        public TableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
