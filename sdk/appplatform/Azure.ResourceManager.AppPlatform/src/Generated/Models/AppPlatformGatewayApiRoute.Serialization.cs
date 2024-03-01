// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayApiRoute : IUtf8JsonSerializable, IJsonModel<AppPlatformGatewayApiRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformGatewayApiRoute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformGatewayApiRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayApiRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayApiRoute)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Title != null)
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Uri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (IsSsoEnabled.HasValue)
            {
                writer.WritePropertyName("ssoEnabled"u8);
                writer.WriteBooleanValue(IsSsoEnabled.Value);
            }
            if (IsTokenRelayed.HasValue)
            {
                writer.WritePropertyName("tokenRelay"u8);
                writer.WriteBooleanValue(IsTokenRelayed.Value);
            }
            if (!(Predicates is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("predicates"u8);
                writer.WriteStartArray();
                foreach (var item in Predicates)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Filters is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Order.HasValue)
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (!(Tags is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        AppPlatformGatewayApiRoute IJsonModel<AppPlatformGatewayApiRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayApiRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayApiRoute)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformGatewayApiRoute(document.RootElement, options);
        }

        internal static AppPlatformGatewayApiRoute DeserializeAppPlatformGatewayApiRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string title = default;
            string description = default;
            Uri uri = default;
            bool? ssoEnabled = default;
            bool? tokenRelay = default;
            IList<string> predicates = default;
            IList<string> filters = default;
            int? order = default;
            IList<string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ssoEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssoEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenRelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenRelay = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("predicates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    predicates = array;
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    filters = array;
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformGatewayApiRoute(
                title,
                description,
                uri,
                ssoEnabled,
                tokenRelay,
                predicates ?? new ChangeTrackingList<string>(),
                filters ?? new ChangeTrackingList<string>(),
                order,
                tags ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformGatewayApiRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayApiRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayApiRoute)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformGatewayApiRoute IPersistableModel<AppPlatformGatewayApiRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayApiRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformGatewayApiRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayApiRoute)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformGatewayApiRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
