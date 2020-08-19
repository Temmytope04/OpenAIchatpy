// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Server response for Get tenant users API call. </summary>
    public partial class UserListResult
    {
        /// <summary> Initializes a new instance of UserListResult. </summary>
        internal UserListResult()
        {
            Value = new ChangeTrackingList<User>();
        }

        /// <summary> Initializes a new instance of UserListResult. </summary>
        /// <param name="value"> the list of users. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal UserListResult(IReadOnlyList<User> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> the list of users. </summary>
        public IReadOnlyList<User> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
