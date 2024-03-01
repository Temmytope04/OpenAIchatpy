// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisLinkedServerWithPropertyCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisLinkedServerWithPropertyCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("linkedRedisCacheId"u8);
            writer.WriteStringValue(LinkedRedisCacheId);
            writer.WritePropertyName("linkedRedisCacheLocation"u8);
            writer.WriteStringValue(LinkedRedisCacheLocation);
            writer.WritePropertyName("serverRole"u8);
            writer.WriteStringValue(ServerRole.ToSerialString());
            if (options.Format != "W" && GeoReplicatedPrimaryHostName != null)
            {
                writer.WritePropertyName("geoReplicatedPrimaryHostName"u8);
                writer.WriteStringValue(GeoReplicatedPrimaryHostName);
            }
            if (options.Format != "W" && PrimaryHostName != null)
            {
                writer.WritePropertyName("primaryHostName"u8);
                writer.WriteStringValue(PrimaryHostName);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedisLinkedServerWithPropertyCreateOrUpdateContent IJsonModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisLinkedServerWithPropertyCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisLinkedServerWithPropertyCreateOrUpdateContent(document.RootElement, options);
        }

        internal static RedisLinkedServerWithPropertyCreateOrUpdateContent DeserializeRedisLinkedServerWithPropertyCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier linkedRedisCacheId = default;
            AzureLocation linkedRedisCacheLocation = default;
            RedisLinkedServerRole serverRole = default;
            string geoReplicatedPrimaryHostName = default;
            string primaryHostName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkedRedisCacheId"u8))
                        {
                            linkedRedisCacheId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedRedisCacheLocation"u8))
                        {
                            linkedRedisCacheLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serverRole"u8))
                        {
                            serverRole = property0.Value.GetString().ToRedisLinkedServerRole();
                            continue;
                        }
                        if (property0.NameEquals("geoReplicatedPrimaryHostName"u8))
                        {
                            geoReplicatedPrimaryHostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryHostName"u8))
                        {
                            primaryHostName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisLinkedServerWithPropertyCreateOrUpdateContent(
                linkedRedisCacheId,
                linkedRedisCacheLocation,
                serverRole,
                geoReplicatedPrimaryHostName,
                primaryHostName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisLinkedServerWithPropertyCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        RedisLinkedServerWithPropertyCreateOrUpdateContent IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisLinkedServerWithPropertyCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisLinkedServerWithPropertyCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisLinkedServerWithPropertyCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
