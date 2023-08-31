// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the origin group override configuration. </summary>
    public partial class OriginGroupOverride
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverride"/>. </summary>
        public OriginGroupOverride()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverride"/>. </summary>
        /// <param name="originGroup"> defines the OriginGroup that would override the DefaultOriginGroup on route. </param>
        /// <param name="forwardingProtocol"> Protocol this rule will use when forwarding traffic to backends. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OriginGroupOverride(WritableSubResource originGroup, ForwardingProtocol? forwardingProtocol, Dictionary<string, BinaryData> rawData)
        {
            OriginGroup = originGroup;
            ForwardingProtocol = forwardingProtocol;
            _rawData = rawData;
        }

        /// <summary> defines the OriginGroup that would override the DefaultOriginGroup on route. </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }

        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public ForwardingProtocol? ForwardingProtocol { get; set; }
    }
}
