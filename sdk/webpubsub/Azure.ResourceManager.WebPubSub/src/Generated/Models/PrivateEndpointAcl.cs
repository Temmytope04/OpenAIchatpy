// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> ACL for a private endpoint. </summary>
    public partial class PrivateEndpointAcl : NetworkAcl
    {
        /// <summary> Initializes a new instance of PrivateEndpointAcl. </summary>
        /// <param name="name"> Name of the private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PrivateEndpointAcl(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of PrivateEndpointAcl. </summary>
        /// <param name="allow"> Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="deny"> Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="name"> Name of the private endpoint connection. </param>
        internal PrivateEndpointAcl(IList<WebPubSubRequestType> allow, IList<WebPubSubRequestType> deny, string name) : base(allow, deny)
        {
            Name = name;
        }

        /// <summary> Name of the private endpoint connection. </summary>
        public string Name { get; set; }
    }
}
