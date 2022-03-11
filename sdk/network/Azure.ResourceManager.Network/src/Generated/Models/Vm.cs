// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes a Virtual Machine. </summary>
    internal partial class Vm : NetworkResourceData
    {
        /// <summary> Initializes a new instance of Vm. </summary>
        public Vm()
        {
        }

        /// <summary> Initializes a new instance of Vm. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal Vm(string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type, location, tags)
        {
        }
    }
}
