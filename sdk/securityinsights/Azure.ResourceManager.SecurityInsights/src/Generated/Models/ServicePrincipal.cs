// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Service principal metadata.
    /// Serialized Name: ServicePrincipal
    /// </summary>
    public partial class ServicePrincipal
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServicePrincipal"/>. </summary>
        public ServicePrincipal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipal"/>. </summary>
        /// <param name="id">
        /// Id of service principal.
        /// Serialized Name: ServicePrincipal.id
        /// </param>
        /// <param name="tenantId">
        /// Tenant id of service principal.
        /// Serialized Name: ServicePrincipal.tenantId
        /// </param>
        /// <param name="appId">
        /// App id of service principal.
        /// Serialized Name: ServicePrincipal.appId
        /// </param>
        /// <param name="credentialsExpireOn">
        /// Expiration time of service principal credentials.
        /// Serialized Name: ServicePrincipal.credentialsExpireOn
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipal(string id, Guid? tenantId, string appId, DateTimeOffset? credentialsExpireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            TenantId = tenantId;
            AppId = appId;
            CredentialsExpireOn = credentialsExpireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Id of service principal.
        /// Serialized Name: ServicePrincipal.id
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Tenant id of service principal.
        /// Serialized Name: ServicePrincipal.tenantId
        /// </summary>
        public Guid? TenantId { get; }
        /// <summary>
        /// App id of service principal.
        /// Serialized Name: ServicePrincipal.appId
        /// </summary>
        public string AppId { get; }
        /// <summary>
        /// Expiration time of service principal credentials.
        /// Serialized Name: ServicePrincipal.credentialsExpireOn
        /// </summary>
        public DateTimeOffset? CredentialsExpireOn { get; set; }
    }
}
