// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information for connecting to MySQL server
    /// </summary>
    public partial class MySqlConnectionInfo : ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the MySqlConnectionInfo class.
        /// </summary>
        public MySqlConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MySqlConnectionInfo class.
        /// </summary>
        /// <param name="serverName">Name of the server</param>
        /// <param name="port">Port for Server</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential.</param>
        public MySqlConnectionInfo(string serverName, int port, string userName = default(string), string password = default(string))
            : base(userName, password)
        {
            ServerName = serverName;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the server
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets port for Server
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerName");
            }
        }
    }
}
