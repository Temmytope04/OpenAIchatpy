// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties required to create a connection to Azure SQL database Managed instance. </summary>
    public partial class MISqlConnectionInfo : ConnectionInfo
    {
        /// <summary> Initializes a new instance of <see cref="MISqlConnectionInfo"/>. </summary>
        /// <param name="managedInstanceResourceId"> Resource id for Azure SQL database Managed instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedInstanceResourceId"/> is null. </exception>
        public MISqlConnectionInfo(string managedInstanceResourceId)
        {
            if (managedInstanceResourceId == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceResourceId));
            }

            ManagedInstanceResourceId = managedInstanceResourceId;
            ConnectionInfoType = "MiSqlConnectionInfo";
        }

        /// <summary> Initializes a new instance of <see cref="MISqlConnectionInfo"/>. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="managedInstanceResourceId"> Resource id for Azure SQL database Managed instance. </param>
        internal MISqlConnectionInfo(string connectionInfoType, string userName, string password, IDictionary<string, BinaryData> serializedAdditionalRawData, string managedInstanceResourceId) : base(connectionInfoType, userName, password, serializedAdditionalRawData)
        {
            ManagedInstanceResourceId = managedInstanceResourceId;
            ConnectionInfoType = connectionInfoType ?? "MiSqlConnectionInfo";
        }

        /// <summary> Initializes a new instance of <see cref="MISqlConnectionInfo"/> for deserialization. </summary>
        internal MISqlConnectionInfo()
        {
        }

        /// <summary> Resource id for Azure SQL database Managed instance. </summary>
        public string ManagedInstanceResourceId { get; set; }
    }
}
