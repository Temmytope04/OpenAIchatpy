// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary>
    /// A class representing the WebPubSubHub data model.
    /// A hub setting
    /// </summary>
    public partial class WebPubSubHubData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebPubSubHubData"/>. </summary>
        /// <param name="properties"> Properties of a hub. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public WebPubSubHubData(WebPubSubHubProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubHubData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a hub. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebPubSubHubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WebPubSubHubProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubHubData"/> for deserialization. </summary>
        internal WebPubSubHubData()
        {
        }

        /// <summary> Properties of a hub. </summary>
        public WebPubSubHubProperties Properties { get; set; }
    }
}
