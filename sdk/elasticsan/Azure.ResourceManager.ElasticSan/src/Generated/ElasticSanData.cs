// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary> A class representing the ElasticSan data model. </summary>
    public partial class ElasticSanData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ElasticSanData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> resource sku. </param>
        /// <param name="baseSizeTiB"> Base size of the Elastic San appliance in TiB. </param>
        /// <param name="extendedCapacitySizeTiB"> Extended size of the Elastic San appliance in TiB. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public ElasticSanData(AzureLocation location, ElasticSanSku sku, long baseSizeTiB, long extendedCapacitySizeTiB) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            AvailabilityZones = new ChangeTrackingList<string>();
            BaseSizeTiB = baseSizeTiB;
            ExtendedCapacitySizeTiB = extendedCapacitySizeTiB;
        }

        /// <summary> Initializes a new instance of ElasticSanData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> resource sku. </param>
        /// <param name="availabilityZones"> Logical zone for Elastic San resource; example: [&quot;1&quot;]. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="baseSizeTiB"> Base size of the Elastic San appliance in TiB. </param>
        /// <param name="extendedCapacitySizeTiB"> Extended size of the Elastic San appliance in TiB. </param>
        /// <param name="totalElasticSanVolumeSizeGiB"> Total size of the provisioned Volumes in GiB. </param>
        /// <param name="elasticSanVolumeGroupCount"> Total number of volume groups in this Elastic San appliance. </param>
        /// <param name="totalIops"> Total Provisioned IOPS of the Elastic San appliance. </param>
        /// <param name="totalMbps"> Total Provisioned MBps Elastic San appliance. </param>
        /// <param name="totalSizeTiB"> Total size of the Elastic San appliance in TB. </param>
        internal ElasticSanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ElasticSanSku sku, IList<string> availabilityZones, ProvisioningState? provisioningState, long baseSizeTiB, long extendedCapacitySizeTiB, long? totalElasticSanVolumeSizeGiB, long? elasticSanVolumeGroupCount, long? totalIops, long? totalMbps, long? totalSizeTiB) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            AvailabilityZones = availabilityZones;
            ProvisioningState = provisioningState;
            BaseSizeTiB = baseSizeTiB;
            ExtendedCapacitySizeTiB = extendedCapacitySizeTiB;
            TotalElasticSanVolumeSizeGiB = totalElasticSanVolumeSizeGiB;
            ElasticSanVolumeGroupCount = elasticSanVolumeGroupCount;
            TotalIops = totalIops;
            TotalMbps = totalMbps;
            TotalSizeTiB = totalSizeTiB;
        }

        /// <summary> resource sku. </summary>
        public ElasticSanSku Sku { get; set; }
        /// <summary> Logical zone for Elastic San resource; example: [&quot;1&quot;]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Base size of the Elastic San appliance in TiB. </summary>
        public long BaseSizeTiB { get; set; }
        /// <summary> Extended size of the Elastic San appliance in TiB. </summary>
        public long ExtendedCapacitySizeTiB { get; set; }
        /// <summary> Total size of the provisioned Volumes in GiB. </summary>
        public long? TotalElasticSanVolumeSizeGiB { get; }
        /// <summary> Total number of volume groups in this Elastic San appliance. </summary>
        public long? ElasticSanVolumeGroupCount { get; }
        /// <summary> Total Provisioned IOPS of the Elastic San appliance. </summary>
        public long? TotalIops { get; }
        /// <summary> Total Provisioned MBps Elastic San appliance. </summary>
        public long? TotalMbps { get; }
        /// <summary> Total size of the Elastic San appliance in TB. </summary>
        public long? TotalSizeTiB { get; }
    }
}
