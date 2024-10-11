// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class UserPlaneDataRoutesItem : IUtf8JsonSerializable, IJsonModel<UserPlaneDataRoutesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserPlaneDataRoutesItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserPlaneDataRoutesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserPlaneDataRoutesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserPlaneDataRoutesItem)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AttachedDataNetwork))
            {
                writer.WritePropertyName("attachedDataNetwork"u8);
                JsonSerializer.Serialize(writer, AttachedDataNetwork);
            }
            if (Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        UserPlaneDataRoutesItem IJsonModel<UserPlaneDataRoutesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserPlaneDataRoutesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserPlaneDataRoutesItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserPlaneDataRoutesItem(document.RootElement, options);
        }

        internal static UserPlaneDataRoutesItem DeserializeUserPlaneDataRoutesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource attachedDataNetwork = default;
            IList<MobileNetworkIPv4Route> routes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachedDataNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachedDataNetwork = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkIPv4Route> array = new List<MobileNetworkIPv4Route>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobileNetworkIPv4Route.DeserializeMobileNetworkIPv4Route(item, options));
                    }
                    routes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserPlaneDataRoutesItem(attachedDataNetwork, routes ?? new ChangeTrackingList<MobileNetworkIPv4Route>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AttachedDataNetworkId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  attachedDataNetwork: ");
                builder.AppendLine("{");
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AttachedDataNetwork))
                {
                    builder.Append("  attachedDataNetwork: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AttachedDataNetwork, options, 2, false, "  attachedDataNetwork: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Routes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  routes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Routes))
                {
                    if (Routes.Any())
                    {
                        builder.Append("  routes: ");
                        builder.AppendLine("[");
                        foreach (var item in Routes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  routes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UserPlaneDataRoutesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserPlaneDataRoutesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UserPlaneDataRoutesItem)} does not support writing '{options.Format}' format.");
            }
        }

        UserPlaneDataRoutesItem IPersistableModel<UserPlaneDataRoutesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserPlaneDataRoutesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserPlaneDataRoutesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserPlaneDataRoutesItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserPlaneDataRoutesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
