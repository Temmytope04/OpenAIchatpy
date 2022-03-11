// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the CapacityReservation data model. </summary>
    public partial class CapacityReservationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CapacityReservationData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called &apos;CapacityReservationSupported&apos; set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public CapacityReservationData(AzureLocation location, ComputeSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            Zones = new ChangeTrackingList<string>();
            VirtualMachinesAssociated = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> Initializes a new instance of CapacityReservationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called &apos;CapacityReservationSupported&apos; set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </param>
        /// <param name="zones"> Availability Zone to use for this capacity reservation. The zone has to be single value and also should be part for the list of zones specified during the capacity reservation group creation. The zone can be assigned only during creation. If not provided, the reservation supports only non-zonal deployments. If provided, enforces VM/VMSS using this capacity reservation to be in same zone. </param>
        /// <param name="reservationId"> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </param>
        /// <param name="virtualMachinesAssociated"> A list of all virtual machine resource ids that are associated with the capacity reservation. </param>
        /// <param name="provisioningTime"> The date time when the capacity reservation was last updated. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The Capacity reservation instance view. </param>
        internal CapacityReservationData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ComputeSku sku, IList<string> zones, string reservationId, IReadOnlyList<Resources.Models.SubResource> virtualMachinesAssociated, DateTimeOffset? provisioningTime, string provisioningState, CapacityReservationInstanceView instanceView) : base(id, name, type, systemData, tags, location)
        {
            Sku = sku;
            Zones = zones;
            ReservationId = reservationId;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            ProvisioningTime = provisioningTime;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
        }

        /// <summary> SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called &apos;CapacityReservationSupported&apos; set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> Availability Zone to use for this capacity reservation. The zone has to be single value and also should be part for the list of zones specified during the capacity reservation group creation. The zone can be assigned only during creation. If not provided, the reservation supports only non-zonal deployments. If provided, enforces VM/VMSS using this capacity reservation to be in same zone. </summary>
        public IList<string> Zones { get; }
        /// <summary> A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource. </summary>
        public string ReservationId { get; }
        /// <summary> A list of all virtual machine resource ids that are associated with the capacity reservation. </summary>
        public IReadOnlyList<Resources.Models.SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The date time when the capacity reservation was last updated. </summary>
        public DateTimeOffset? ProvisioningTime { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The Capacity reservation instance view. </summary>
        public CapacityReservationInstanceView InstanceView { get; }
    }
}
