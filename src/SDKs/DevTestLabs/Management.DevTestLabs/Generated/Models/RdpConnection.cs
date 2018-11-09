// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a .rdp file
    /// </summary>
    public partial class RdpConnection
    {
        /// <summary>
        /// Initializes a new instance of the RdpConnection class.
        /// </summary>
        public RdpConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RdpConnection class.
        /// </summary>
        /// <param name="contents">The contents of the .rdp file</param>
        public RdpConnection(string contents = default(string))
        {
            Contents = contents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the contents of the .rdp file
        /// </summary>
        [JsonProperty(PropertyName = "contents")]
        public string Contents { get; set; }

    }
}
