// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing the CloudLink data model. </summary>
    public partial class CloudLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of CloudLinkData. </summary>
        public CloudLinkData()
        {
        }

        /// <summary> Initializes a new instance of CloudLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The state of the cloud link. </param>
        /// <param name="linkedCloud"> Identifier of the other private cloud participating in the link. </param>
        internal CloudLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CloudLinkStatus? status, string linkedCloud) : base(id, name, resourceType, systemData)
        {
            Status = status;
            LinkedCloud = linkedCloud;
        }

        /// <summary> The state of the cloud link. </summary>
        public CloudLinkStatus? Status { get; }
        /// <summary> Identifier of the other private cloud participating in the link. </summary>
        public string LinkedCloud { get; set; }
    }
}
