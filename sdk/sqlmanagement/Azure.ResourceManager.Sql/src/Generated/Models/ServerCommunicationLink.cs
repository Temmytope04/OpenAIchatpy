// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Server communication link. </summary>
    public partial class ServerCommunicationLink : Resource
    {
        /// <summary> Initializes a new instance of ServerCommunicationLink. </summary>
        public ServerCommunicationLink()
        {
        }

        /// <summary> Initializes a new instance of ServerCommunicationLink. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Communication link location. </param>
        /// <param name="kind"> Communication link kind.  This property is used for Azure Portal metadata. </param>
        /// <param name="state"> The state. </param>
        /// <param name="partnerServer"> The name of the partner server. </param>
        internal ServerCommunicationLink(string id, string name, string type, string location, string kind, string state, string partnerServer) : base(id, name, type)
        {
            Location = location;
            Kind = kind;
            State = state;
            PartnerServer = partnerServer;
        }

        /// <summary> Communication link location. </summary>
        public string Location { get; }
        /// <summary> Communication link kind.  This property is used for Azure Portal metadata. </summary>
        public string Kind { get; }
        /// <summary> The state. </summary>
        public string State { get; }
        /// <summary> The name of the partner server. </summary>
        public string PartnerServer { get; set; }
    }
}
