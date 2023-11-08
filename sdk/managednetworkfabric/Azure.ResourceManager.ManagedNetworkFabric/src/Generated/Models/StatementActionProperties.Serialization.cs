// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class StatementActionProperties : IUtf8JsonSerializable, IJsonModel<StatementActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatementActionProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<StatementActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LocalPreference))
            {
                writer.WritePropertyName("localPreference"u8);
                writer.WriteNumberValue(LocalPreference.Value);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            if (Optional.IsDefined(IPCommunityProperties))
            {
                writer.WritePropertyName("ipCommunityProperties"u8);
                writer.WriteObjectValue(IPCommunityProperties);
            }
            if (Optional.IsDefined(IPExtendedCommunityProperties))
            {
                writer.WritePropertyName("ipExtendedCommunityProperties"u8);
                writer.WriteObjectValue(IPExtendedCommunityProperties);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        StatementActionProperties IJsonModel<StatementActionProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatementActionProperties(document.RootElement, options);
        }

        internal static StatementActionProperties DeserializeStatementActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> localPreference = default;
            RoutePolicyActionType actionType = default;
            Optional<ActionIPCommunityProperties> ipCommunityProperties = default;
            Optional<ActionIPExtendedCommunityProperties> ipExtendedCommunityProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localPreference = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new RoutePolicyActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipCommunityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipCommunityProperties = ActionIPCommunityProperties.DeserializeActionIPCommunityProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("ipExtendedCommunityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipExtendedCommunityProperties = ActionIPExtendedCommunityProperties.DeserializeActionIPExtendedCommunityProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatementActionProperties(Optional.ToNullable(localPreference), actionType, ipCommunityProperties.Value, ipExtendedCommunityProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<StatementActionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StatementActionProperties IModel<StatementActionProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStatementActionProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<StatementActionProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
