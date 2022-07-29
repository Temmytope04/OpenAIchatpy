// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Server version capabilities. </summary>
    public partial class PostgreSqlFlexibleServerServerVersionCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerServerVersionCapability. </summary>
        internal PostgreSqlFlexibleServerServerVersionCapability()
        {
            SupportedVcores = new ChangeTrackingList<PostgreSqlFlexibleServerVCoreCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerServerVersionCapability. </summary>
        /// <param name="name"> server version. </param>
        /// <param name="supportedVcores"></param>
        /// <param name="status"> The status. </param>
        internal PostgreSqlFlexibleServerServerVersionCapability(string name, IReadOnlyList<PostgreSqlFlexibleServerVCoreCapability> supportedVcores, string status)
        {
            Name = name;
            SupportedVcores = supportedVcores;
            Status = status;
        }

        /// <summary> server version. </summary>
        public string Name { get; }
        /// <summary> Gets the supported vcores. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerVCoreCapability> SupportedVcores { get; }
        /// <summary> The status. </summary>
        public string Status { get; }
    }
}
