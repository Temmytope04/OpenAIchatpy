// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of MySQL Server keys. </summary>
    internal partial class MySqlServerKeyListResult
    {
        /// <summary> Initializes a new instance of <see cref="MySqlServerKeyListResult"/>. </summary>
        internal MySqlServerKeyListResult()
        {
            Value = new ChangeTrackingList<MySqlServerKeyData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerKeyListResult"/>. </summary>
        /// <param name="value"> A list of MySQL Server keys. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal MySqlServerKeyListResult(IReadOnlyList<MySqlServerKeyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of MySQL Server keys. </summary>
        public IReadOnlyList<MySqlServerKeyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
