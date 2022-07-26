// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The properties used to create a new server by restoring to a different region from a geo replicated backup. </summary>
    public partial class PostgreSqlServerPropertiesForGeoRestore : PostgreSqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of PostgreSqlServerPropertiesForGeoRestore. </summary>
        /// <param name="sourceServerId"> The source server id to restore from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceServerId"/> is null. </exception>
        public PostgreSqlServerPropertiesForGeoRestore(ResourceIdentifier sourceServerId)
        {
            if (sourceServerId == null)
            {
                throw new ArgumentNullException(nameof(sourceServerId));
            }

            SourceServerId = sourceServerId;
            CreateMode = PostgreSqlCreateMode.GeoRestore;
        }

        /// <summary> The source server id to restore from. </summary>
        public ResourceIdentifier SourceServerId { get; }
    }
}
