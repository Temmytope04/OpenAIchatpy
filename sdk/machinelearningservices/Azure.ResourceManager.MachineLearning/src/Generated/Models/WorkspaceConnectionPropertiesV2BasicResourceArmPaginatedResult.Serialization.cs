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
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult : IUtf8JsonSerializable, IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IJsonModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(document.RootElement, options);
        }

        internal static WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningWorkspaceConnectionData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningWorkspaceConnectionData> array = new List<MachineLearningWorkspaceConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningWorkspaceConnectionData.DeserializeMachineLearningWorkspaceConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult(document.RootElement, options);
        }

        string IPersistableModel<WorkspaceConnectionPropertiesV2BasicResourceArmPaginatedResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
