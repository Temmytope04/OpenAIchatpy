// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A DDoS protection plan in a resource group. </summary>
    public partial class DdosProtectionPlan
    {
        /// <summary> Initializes a new instance of DdosProtectionPlan. </summary>
        public DdosProtectionPlan()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            VirtualNetworks = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of DdosProtectionPlan. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DDoS protection plan resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </param>
        /// <param name="provisioningState"> The provisioning state of the DDoS protection plan resource. </param>
        /// <param name="virtualNetworks"> The list of virtual networks associated with the DDoS protection plan resource. This list is read-only. </param>
        internal DdosProtectionPlan(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, string resourceGuid, ProvisioningState? provisioningState, IList<SubResource> virtualNetworks)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Etag = etag;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            VirtualNetworks = virtualNetworks;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource GUID property of the DDoS protection plan resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the DDoS protection plan resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The list of virtual networks associated with the DDoS protection plan resource. This list is read-only. </summary>
        public IList<SubResource> VirtualNetworks { get; }
    }
}
