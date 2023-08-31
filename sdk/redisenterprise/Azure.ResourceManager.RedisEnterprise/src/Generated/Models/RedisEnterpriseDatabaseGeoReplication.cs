// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Optional set of properties to configure geo replication for this database. </summary>
    public partial class RedisEnterpriseDatabaseGeoReplication
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseGeoReplication"/>. </summary>
        public RedisEnterpriseDatabaseGeoReplication()
        {
            LinkedDatabases = new ChangeTrackingList<RedisEnterpriseLinkedDatabase>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseGeoReplication"/>. </summary>
        /// <param name="groupNickname"> Name for the group of linked database resources. </param>
        /// <param name="linkedDatabases"> List of database resources to link with this database. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseDatabaseGeoReplication(string groupNickname, IList<RedisEnterpriseLinkedDatabase> linkedDatabases, Dictionary<string, BinaryData> rawData)
        {
            GroupNickname = groupNickname;
            LinkedDatabases = linkedDatabases;
            _rawData = rawData;
        }

        /// <summary> Name for the group of linked database resources. </summary>
        public string GroupNickname { get; set; }
        /// <summary> List of database resources to link with this database. </summary>
        public IList<RedisEnterpriseLinkedDatabase> LinkedDatabases { get; }
    }
}
