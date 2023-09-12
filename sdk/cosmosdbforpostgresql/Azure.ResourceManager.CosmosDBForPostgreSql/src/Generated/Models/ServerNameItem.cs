// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> The name object for a server. </summary>
    public partial class ServerNameItem
    {
        /// <summary> Initializes a new instance of ServerNameItem. </summary>
        internal ServerNameItem()
        {
        }

        /// <summary> Initializes a new instance of ServerNameItem. </summary>
        /// <param name="name"> The name of a server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        internal ServerNameItem(string name, string fullyQualifiedDomainName)
        {
            Name = name;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
        }

        /// <summary> The name of a server. </summary>
        public string Name { get; }
        /// <summary> The fully qualified domain name of a server. </summary>
        public string FullyQualifiedDomainName { get; }
    }
}
