// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedServerDnsAlias data model.
    /// A managed server DNS alias.
    /// </summary>
    public partial class ManagedServerDnsAliasData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedServerDnsAliasData. </summary>
        public ManagedServerDnsAliasData()
        {
        }

        /// <summary> Initializes a new instance of ManagedServerDnsAliasData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azureDnsRecord"> The fully qualified DNS record for managed server alias. </param>
        /// <param name="publicAzureDnsRecord"> The fully qualified public DNS record for managed server alias. </param>
        internal ManagedServerDnsAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string azureDnsRecord, string publicAzureDnsRecord) : base(id, name, resourceType, systemData)
        {
            AzureDnsRecord = azureDnsRecord;
            PublicAzureDnsRecord = publicAzureDnsRecord;
        }

        /// <summary> The fully qualified DNS record for managed server alias. </summary>
        public string AzureDnsRecord { get; }
        /// <summary> The fully qualified public DNS record for managed server alias. </summary>
        public string PublicAzureDnsRecord { get; }
    }
}
