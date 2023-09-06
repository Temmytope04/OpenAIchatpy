// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
    internal partial class ResourceLogConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceLogConfiguration"/>. </summary>
        public ResourceLogConfiguration()
        {
            Categories = new ChangeTrackingList<ResourceLogCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceLogConfiguration"/>. </summary>
        /// <param name="categories"> Gets or sets the list of category configurations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceLogConfiguration(IList<ResourceLogCategory> categories, Dictionary<string, BinaryData> rawData)
        {
            Categories = categories;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the list of category configurations. </summary>
        public IList<ResourceLogCategory> Categories { get; }
    }
}
