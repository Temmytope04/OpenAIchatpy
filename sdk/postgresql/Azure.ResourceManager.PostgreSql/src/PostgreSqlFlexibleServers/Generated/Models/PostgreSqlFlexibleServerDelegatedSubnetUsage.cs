// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Delegated subnet usage data. </summary>
    public partial class PostgreSqlFlexibleServerDelegatedSubnetUsage
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerDelegatedSubnetUsage. </summary>
        internal PostgreSqlFlexibleServerDelegatedSubnetUsage()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerDelegatedSubnetUsage. </summary>
        /// <param name="subnetName"> Name of the delegated subnet for which IP addresses are in use. </param>
        /// <param name="usage"> Number of IP addresses used by the delegated subnet. </param>
        internal PostgreSqlFlexibleServerDelegatedSubnetUsage(string subnetName, long? usage)
        {
            SubnetName = subnetName;
            Usage = usage;
        }

        /// <summary> Name of the delegated subnet for which IP addresses are in use. </summary>
        public string SubnetName { get; }
        /// <summary> Number of IP addresses used by the delegated subnet. </summary>
        public long? Usage { get; }
    }
}
