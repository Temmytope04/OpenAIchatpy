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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDatabricksProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningDatabricksProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDatabricksProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningDatabricksProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningDatabricksProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningDatabricksProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabricksAccessToken))
            {
                writer.WritePropertyName("databricksAccessToken"u8);
                writer.WriteStringValue(DatabricksAccessToken);
            }
            if (Optional.IsDefined(WorkspaceUri))
            {
                writer.WritePropertyName("workspaceUrl"u8);
                writer.WriteStringValue(WorkspaceUri.AbsoluteUri);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MachineLearningDatabricksProperties IJsonModel<MachineLearningDatabricksProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDatabricksProperties(document.RootElement, options);
        }

        internal static MachineLearningDatabricksProperties DeserializeMachineLearningDatabricksProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databricksAccessToken = default;
            Optional<Uri> workspaceUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databricksAccessToken"u8))
                {
                    databricksAccessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningDatabricksProperties(databricksAccessToken.Value, workspaceUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningDatabricksProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningDatabricksProperties IPersistableModel<MachineLearningDatabricksProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDatabricksProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningDatabricksProperties(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningDatabricksProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
