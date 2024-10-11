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

namespace Azure.ResourceManager.SignalR.Models
{
    public partial class SignalRNetworkAcls : IUtf8JsonSerializable, IJsonModel<SignalRNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignalRNetworkAcls>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SignalRNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetwork))
            {
                writer.WritePropertyName("publicNetwork"u8);
                writer.WriteObjectValue(PublicNetwork, options);
            }
            if (Optional.IsCollectionDefined(PrivateEndpoints))
            {
                writer.WritePropertyName("privateEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpoints)
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

        SignalRNetworkAcls IJsonModel<SignalRNetworkAcls>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRNetworkAcls(document.RootElement, options);
        }

        internal static SignalRNetworkAcls DeserializeSignalRNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SignalRNetworkAclAction? defaultAction = default;
            SignalRNetworkAcl publicNetwork = default;
            IList<SignalRPrivateEndpointAcl> privateEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new SignalRNetworkAclAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetwork = SignalRNetworkAcl.DeserializeSignalRNetworkAcl(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRPrivateEndpointAcl> array = new List<SignalRPrivateEndpointAcl>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SignalRPrivateEndpointAcl.DeserializeSignalRPrivateEndpointAcl(item, options));
                    }
                    privateEndpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SignalRNetworkAcls(defaultAction, publicNetwork, privateEndpoints ?? new ChangeTrackingList<SignalRPrivateEndpointAcl>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultAction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultAction: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultAction))
                {
                    builder.Append("  defaultAction: ");
                    builder.AppendLine($"'{DefaultAction.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicNetwork), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publicNetwork: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicNetwork))
                {
                    builder.Append("  publicNetwork: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PublicNetwork, options, 2, false, "  publicNetwork: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateEndpoints), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateEndpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(PrivateEndpoints))
                {
                    if (PrivateEndpoints.Any())
                    {
                        builder.Append("  privateEndpoints: ");
                        builder.AppendLine("[");
                        foreach (var item in PrivateEndpoints)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  privateEndpoints: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SignalRNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support writing '{options.Format}' format.");
            }
        }

        SignalRNetworkAcls IPersistableModel<SignalRNetworkAcls>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignalRNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignalRNetworkAcls(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignalRNetworkAcls)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignalRNetworkAcls>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
