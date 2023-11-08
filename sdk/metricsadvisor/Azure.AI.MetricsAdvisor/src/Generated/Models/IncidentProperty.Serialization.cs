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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class IncidentProperty : IUtf8JsonSerializable, IJsonModel<IncidentProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IncidentProperty>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<IncidentProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("maxSeverity"u8);
            writer.WriteStringValue(MaxSeverity.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("incidentStatus"u8);
                writer.WriteStringValue(IncidentStatus.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("valueOfRootNode"u8);
                writer.WriteNumberValue(ValueOfRootNode);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ExpectedValueOfRootNode))
                {
                    if (ExpectedValueOfRootNode != null)
                    {
                        writer.WritePropertyName("expectedValueOfRootNode"u8);
                        writer.WriteNumberValue(ExpectedValueOfRootNode.Value);
                    }
                    else
                    {
                        writer.WriteNull("expectedValueOfRootNode");
                    }
                }
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

        IncidentProperty IJsonModel<IncidentProperty>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IncidentProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIncidentProperty(document.RootElement, options);
        }

        internal static IncidentProperty DeserializeIncidentProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AnomalySeverity maxSeverity = default;
            AnomalyIncidentStatus incidentStatus = default;
            double valueOfRootNode = default;
            Optional<double?> expectedValueOfRootNode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSeverity"u8))
                {
                    maxSeverity = new AnomalySeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incidentStatus"u8))
                {
                    incidentStatus = new AnomalyIncidentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueOfRootNode"u8))
                {
                    valueOfRootNode = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expectedValueOfRootNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expectedValueOfRootNode = null;
                        continue;
                    }
                    expectedValueOfRootNode = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IncidentProperty(maxSeverity, incidentStatus, valueOfRootNode, Optional.ToNullable(expectedValueOfRootNode), serializedAdditionalRawData);
        }

        BinaryData IModel<IncidentProperty>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IncidentProperty)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IncidentProperty IModel<IncidentProperty>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IncidentProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIncidentProperty(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<IncidentProperty>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
