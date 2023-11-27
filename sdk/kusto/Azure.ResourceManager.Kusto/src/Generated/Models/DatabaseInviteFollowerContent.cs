// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The request to invite a follower to a database. </summary>
    public partial class DatabaseInviteFollowerContent
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerContent"/>. </summary>
        /// <param name="inviteeEmail"> The email of the invited user for which the follower invitation is generated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inviteeEmail"/> is null. </exception>
        public DatabaseInviteFollowerContent(string inviteeEmail)
        {
            Argument.AssertNotNull(inviteeEmail, nameof(inviteeEmail));

            InviteeEmail = inviteeEmail;
        }

        /// <summary> The email of the invited user for which the follower invitation is generated. </summary>
        public string InviteeEmail { get; }
        /// <summary> Table level sharing specifications. </summary>
        public KustoDatabaseTableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
