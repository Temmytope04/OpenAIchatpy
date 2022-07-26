// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents a resource name availability. </summary>
    public partial class PostgreSqlFlexibleServerNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerNameAvailabilityResult. </summary>
        internal PostgreSqlFlexibleServerNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerNameAvailabilityResult. </summary>
        /// <param name="message"> Error Message. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="name"> name of the PostgreSQL server. </param>
        /// <param name="resourceType"> type of the server. </param>
        /// <param name="reason"> The name availability reason. </param>
        internal PostgreSqlFlexibleServerNameAvailabilityResult(string message, bool? isNameAvailable, string name, ResourceType? resourceType, PostgreSqlFlexibleServerNameUnavailableReason? reason)
        {
            Message = message;
            IsNameAvailable = isNameAvailable;
            Name = name;
            ResourceType = resourceType;
            Reason = reason;
        }

        /// <summary> Error Message. </summary>
        public string Message { get; }
        /// <summary> Indicates whether the resource name is available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> name of the PostgreSQL server. </summary>
        public string Name { get; }
        /// <summary> type of the server. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The name availability reason. </summary>
        public PostgreSqlFlexibleServerNameUnavailableReason? Reason { get; }
    }
}
