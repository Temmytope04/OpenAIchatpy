// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SharePointOnlineListSourceConverter))]
    public partial class SharePointOnlineListSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteObjectValue(Query);
            }
            if (HttpRequestTimeout != null)
            {
                writer.WritePropertyName("httpRequestTimeout"u8);
                writer.WriteObjectValue(HttpRequestTimeout);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SharePointOnlineListSource DeserializeSharePointOnlineListSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object query = default;
            object httpRequestTimeout = default;
            string type = default;
            object sourceRetryCount = default;
            object sourceRetryWait = default;
            object maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    query = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("httpRequestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequestTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SharePointOnlineListSource(
                type,
                sourceRetryCount,
                sourceRetryWait,
                maxConcurrentConnections,
                additionalProperties,
                query,
                httpRequestTimeout);
        }

        internal partial class SharePointOnlineListSourceConverter : JsonConverter<SharePointOnlineListSource>
        {
            public override void Write(Utf8JsonWriter writer, SharePointOnlineListSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SharePointOnlineListSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSharePointOnlineListSource(document.RootElement);
            }
        }
    }
}
