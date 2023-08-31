// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class LogAnalyticsIdentifier : IUtf8JsonSerializable, IModelJsonSerializable<LogAnalyticsIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogAnalyticsIdentifier>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogAnalyticsIdentifier>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogAnalyticsIdentifier>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceIdentifierType.ToString());
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static LogAnalyticsIdentifier DeserializeLogAnalyticsIdentifier(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> workspaceId = default;
            Optional<string> workspaceSubscriptionId = default;
            Optional<string> workspaceResourceGroup = default;
            Optional<Guid> agentId = default;
            ResourceIdentifierType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("workspaceSubscriptionId"u8))
                {
                    workspaceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceGroup"u8))
                {
                    workspaceResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceIdentifierType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogAnalyticsIdentifier(type, Optional.ToNullable(workspaceId), workspaceSubscriptionId.Value, workspaceResourceGroup.Value, Optional.ToNullable(agentId), rawData);
        }

        LogAnalyticsIdentifier IModelJsonSerializable<LogAnalyticsIdentifier>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogAnalyticsIdentifier>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogAnalyticsIdentifier(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogAnalyticsIdentifier>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogAnalyticsIdentifier>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogAnalyticsIdentifier IModelSerializable<LogAnalyticsIdentifier>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogAnalyticsIdentifier>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogAnalyticsIdentifier(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LogAnalyticsIdentifier model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LogAnalyticsIdentifier(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogAnalyticsIdentifier(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
