// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ARecoveryPointDetails : IUtf8JsonSerializable, IJsonModel<A2ARecoveryPointDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ARecoveryPointDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ARecoveryPointDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ARecoveryPointDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointSyncType))
            {
                writer.WritePropertyName("recoveryPointSyncType"u8);
                writer.WriteStringValue(RecoveryPointSyncType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks"u8);
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        A2ARecoveryPointDetails IJsonModel<A2ARecoveryPointDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ARecoveryPointDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ARecoveryPointDetails(document.RootElement, options);
        }

        internal static A2ARecoveryPointDetails DeserializeA2ARecoveryPointDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPointSyncType? recoveryPointSyncType = default;
            IReadOnlyList<string> disks = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointSyncType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointSyncType = new RecoveryPointSyncType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disks"u8))
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
                    disks = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2ARecoveryPointDetails(instanceType, serializedAdditionalRawData, recoveryPointSyncType, disks ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<A2ARecoveryPointDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2ARecoveryPointDetails)} does not support '{options.Format}' format.");
            }
        }

        A2ARecoveryPointDetails IPersistableModel<A2ARecoveryPointDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ARecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2ARecoveryPointDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2ARecoveryPointDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2ARecoveryPointDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
