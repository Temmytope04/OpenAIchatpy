// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Detail about the webhook object.
    /// Serialized Name: Webhook
    /// </summary>
    public partial class Webhook
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

        /// <summary> Initializes a new instance of <see cref="Webhook"/>. </summary>
        public Webhook()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Webhook"/>. </summary>
        /// <param name="webhookId">
        /// Unique identifier for the webhook.
        /// Serialized Name: Webhook.webhookId
        /// </param>
        /// <param name="webhookUri">
        /// URL that gets invoked by the webhook.
        /// Serialized Name: Webhook.webhookUrl
        /// </param>
        /// <param name="webhookSecretUpdateOn">
        /// Time when the webhook secret was updated.
        /// Serialized Name: Webhook.webhookSecretUpdateTime
        /// </param>
        /// <param name="rotateWebhookSecret">
        /// A flag to instruct the backend service to rotate webhook secret.
        /// Serialized Name: Webhook.rotateWebhookSecret
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Webhook(string webhookId, Uri webhookUri, DateTimeOffset? webhookSecretUpdateOn, bool? rotateWebhookSecret, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WebhookId = webhookId;
            WebhookUri = webhookUri;
            WebhookSecretUpdateOn = webhookSecretUpdateOn;
            RotateWebhookSecret = rotateWebhookSecret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Unique identifier for the webhook.
        /// Serialized Name: Webhook.webhookId
        /// </summary>
        public string WebhookId { get; }
        /// <summary>
        /// URL that gets invoked by the webhook.
        /// Serialized Name: Webhook.webhookUrl
        /// </summary>
        public Uri WebhookUri { get; }
        /// <summary>
        /// Time when the webhook secret was updated.
        /// Serialized Name: Webhook.webhookSecretUpdateTime
        /// </summary>
        public DateTimeOffset? WebhookSecretUpdateOn { get; }
        /// <summary>
        /// A flag to instruct the backend service to rotate webhook secret.
        /// Serialized Name: Webhook.rotateWebhookSecret
        /// </summary>
        public bool? RotateWebhookSecret { get; set; }
    }
}
