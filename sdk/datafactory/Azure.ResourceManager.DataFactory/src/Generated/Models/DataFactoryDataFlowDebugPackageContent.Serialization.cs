// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataFlowDebugPackageContent : IUtf8JsonSerializable, IJsonModel<DataFactoryDataFlowDebugPackageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataFlowDebugPackageContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryDataFlowDebugPackageContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugPackageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugPackageContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SessionId.HasValue)
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (DataFlow != null)
            {
                writer.WritePropertyName("dataFlow"u8);
                writer.WriteObjectValue(DataFlow);
            }
            if (!(DataFlows is ChangeTrackingList<DataFactoryDataFlowDebugInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Datasets is ChangeTrackingList<DataFactoryDatasetDebugInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LinkedServices is ChangeTrackingList<DataFactoryLinkedServiceDebugInfo> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Staging != null)
            {
                writer.WritePropertyName("staging"u8);
                writer.WriteObjectValue(Staging);
            }
            if (DebugSettings != null)
            {
                writer.WritePropertyName("debugSettings"u8);
                writer.WriteObjectValue(DebugSettings);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryDataFlowDebugPackageContent IJsonModel<DataFactoryDataFlowDebugPackageContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugPackageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugPackageContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataFlowDebugPackageContent(document.RootElement, options);
        }

        internal static DataFactoryDataFlowDebugPackageContent DeserializeDataFactoryDataFlowDebugPackageContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            DataFactoryDataFlowDebugInfo dataFlow = default;
            IList<DataFactoryDataFlowDebugInfo> dataFlows = default;
            IList<DataFactoryDatasetDebugInfo> datasets = default;
            IList<DataFactoryLinkedServiceDebugInfo> linkedServices = default;
            DataFlowStagingInfo staging = default;
            DataFlowDebugPackageDebugSettings debugSettings = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("dataFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlow = DataFactoryDataFlowDebugInfo.DeserializeDataFactoryDataFlowDebugInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataFlows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryDataFlowDebugInfo> array = new List<DataFactoryDataFlowDebugInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryDataFlowDebugInfo.DeserializeDataFactoryDataFlowDebugInfo(item, options));
                    }
                    dataFlows = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryDatasetDebugInfo> array = new List<DataFactoryDatasetDebugInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryDatasetDebugInfo.DeserializeDataFactoryDatasetDebugInfo(item, options));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryLinkedServiceDebugInfo> array = new List<DataFactoryLinkedServiceDebugInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryLinkedServiceDebugInfo.DeserializeDataFactoryLinkedServiceDebugInfo(item, options));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("staging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("debugSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSettings = DataFlowDebugPackageDebugSettings.DeserializeDataFlowDebugPackageDebugSettings(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryDataFlowDebugPackageContent(
                sessionId,
                dataFlow,
                dataFlows ?? new ChangeTrackingList<DataFactoryDataFlowDebugInfo>(),
                datasets ?? new ChangeTrackingList<DataFactoryDatasetDebugInfo>(),
                linkedServices ?? new ChangeTrackingList<DataFactoryLinkedServiceDebugInfo>(),
                staging,
                debugSettings,
                additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryDataFlowDebugPackageContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugPackageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugPackageContent)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryDataFlowDebugPackageContent IPersistableModel<DataFactoryDataFlowDebugPackageContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugPackageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryDataFlowDebugPackageContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugPackageContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataFlowDebugPackageContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
