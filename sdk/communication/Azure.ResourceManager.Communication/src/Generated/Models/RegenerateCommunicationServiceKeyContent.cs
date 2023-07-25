// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Parameters describes the request to regenerate access keys. </summary>
    public partial class RegenerateCommunicationServiceKeyContent
    {
        /// <summary> Initializes a new instance of RegenerateCommunicationServiceKeyContent. </summary>
        public RegenerateCommunicationServiceKeyContent()
        {
        }

        /// <summary> The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive). </summary>
        public CommunicationServiceKeyType? KeyType { get; set; }
    }
}
