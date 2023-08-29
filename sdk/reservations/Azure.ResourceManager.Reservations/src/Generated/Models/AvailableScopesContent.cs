// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Available scope. </summary>
    public partial class AvailableScopesContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableScopesContent"/>. </summary>
        public AvailableScopesContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailableScopesContent"/>. </summary>
        /// <param name="properties"> Available scope request properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableScopesContent(AvailableScopeRequestProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Available scope request properties. </summary>
        internal AvailableScopeRequestProperties Properties { get; set; }
        /// <summary> Gets the scopes. </summary>
        public IList<string> Scopes
        {
            get
            {
                if (Properties is null)
                    Properties = new AvailableScopeRequestProperties();
                return Properties.Scopes;
            }
        }
    }
}
