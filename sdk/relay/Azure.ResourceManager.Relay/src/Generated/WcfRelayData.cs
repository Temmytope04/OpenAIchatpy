// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing the WcfRelay data model.
    /// Description of the WCF relay resource.
    /// </summary>
    public partial class WcfRelayData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WcfRelayData"/>. </summary>
        public WcfRelayData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WcfRelayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isDynamic"> Returns true if the relay is dynamic; otherwise, false. </param>
        /// <param name="createdOn"> The time the WCF relay was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="listenerCount"> The number of listeners for this relay. Note that min :1 and max:25 are supported. </param>
        /// <param name="relayType"> WCF relay type. </param>
        /// <param name="isClientAuthorizationRequired"> Returns true if client authorization is needed for this relay; otherwise, false. </param>
        /// <param name="isTransportSecurityRequired"> Returns true if transport security is needed for this relay; otherwise, false. </param>
        /// <param name="userMetadata"> The usermetadata is a placeholder to store user-defined string data for the WCF Relay endpoint. For example, it can be used to store descriptive data, such as list of teams and their contact information. Also, user-defined configuration settings can be stored. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WcfRelayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isDynamic, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, int? listenerCount, RelayType? relayType, bool? isClientAuthorizationRequired, bool? isTransportSecurityRequired, string userMetadata, AzureLocation? location, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            IsDynamic = isDynamic;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ListenerCount = listenerCount;
            RelayType = relayType;
            IsClientAuthorizationRequired = isClientAuthorizationRequired;
            IsTransportSecurityRequired = isTransportSecurityRequired;
            UserMetadata = userMetadata;
            Location = location;
            _rawData = rawData;
        }

        /// <summary> Returns true if the relay is dynamic; otherwise, false. </summary>
        public bool? IsDynamic { get; }
        /// <summary> The time the WCF relay was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The number of listeners for this relay. Note that min :1 and max:25 are supported. </summary>
        public int? ListenerCount { get; }
        /// <summary> WCF relay type. </summary>
        public RelayType? RelayType { get; set; }
        /// <summary> Returns true if client authorization is needed for this relay; otherwise, false. </summary>
        public bool? IsClientAuthorizationRequired { get; set; }
        /// <summary> Returns true if transport security is needed for this relay; otherwise, false. </summary>
        public bool? IsTransportSecurityRequired { get; set; }
        /// <summary> The usermetadata is a placeholder to store user-defined string data for the WCF Relay endpoint. For example, it can be used to store descriptive data, such as list of teams and their contact information. Also, user-defined configuration settings can be stored. </summary>
        public string UserMetadata { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
