// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class VmPlacementPolicyProperties : IUtf8JsonSerializable, IJsonModel<VmPlacementPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmPlacementPolicyProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmPlacementPolicyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmPlacementPolicyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vmMembers"u8);
            writer.WriteStartArray();
            foreach (var item in VmMembers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("affinityType"u8);
            writer.WriteStringValue(AffinityType.ToString());
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        VmPlacementPolicyProperties IJsonModel<VmPlacementPolicyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmPlacementPolicyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmPlacementPolicyProperties(document.RootElement, options);
        }

        internal static VmPlacementPolicyProperties DeserializeVmPlacementPolicyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> vmMembers = default;
            AvsPlacementPolicyAffinityType affinityType = default;
            PlacementPolicyType type = default;
            PlacementPolicyState? state = default;
            string displayName = default;
            PlacementPolicyProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmMembers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vmMembers = array;
                    continue;
                }
                if (property.NameEquals("affinityType"u8))
                {
                    affinityType = new AvsPlacementPolicyAffinityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new PlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PlacementPolicyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PlacementPolicyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmPlacementPolicyProperties(
                type,
                state,
                displayName,
                provisioningState,
                serializedAdditionalRawData,
                vmMembers,
                affinityType);
        }

        BinaryData IPersistableModel<VmPlacementPolicyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmPlacementPolicyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VmPlacementPolicyProperties IPersistableModel<VmPlacementPolicyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmPlacementPolicyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmPlacementPolicyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmPlacementPolicyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
