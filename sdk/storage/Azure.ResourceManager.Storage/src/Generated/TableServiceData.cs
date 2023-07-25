// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the TableService data model.
    /// The properties of a storage account’s Table service.
    /// </summary>
    public partial class TableServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of TableServiceData. </summary>
        public TableServiceData()
        {
        }

        /// <summary> Initializes a new instance of TableServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="cors"> Specifies CORS rules for the Table service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Table service. </param>
        internal TableServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StorageCorsRules cors) : base(id, name, resourceType, systemData)
        {
            Cors = cors;
        }

        /// <summary> Specifies CORS rules for the Table service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Table service. </summary>
        internal StorageCorsRules Cors { get; set; }
        /// <summary> The List of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<StorageCorsRule> CorsRules
        {
            get
            {
                if (Cors is null)
                    Cors = new StorageCorsRules();
                return Cors.CorsRules;
            }
        }
    }
}
