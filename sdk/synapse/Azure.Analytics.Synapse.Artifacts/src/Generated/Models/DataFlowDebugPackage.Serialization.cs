// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugPackageConverter))]
    public partial class DataFlowDebugPackage : IUtf8JsonSerializable, IModelJsonSerializable<DataFlowDebugPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFlowDebugPackage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFlowDebugPackage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugPackage>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlow))
            {
                writer.WritePropertyName("dataFlow"u8);
                if (DataFlow is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFlowDebugResource>)DataFlow).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(DataFlows))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataFlowDebugResource>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DatasetDebugResource>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LinkedServiceDebugResource>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging"u8);
                if (Staging is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFlowStagingInfo>)Staging).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DebugSettings))
            {
                writer.WritePropertyName("debugSettings"u8);
                if (DebugSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFlowDebugPackageDebugSettings>)DebugSettings).Serialize(writer, options);
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugPackage DeserializeDataFlowDebugPackage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<DataFlowDebugResource> dataFlow = default;
            Optional<IList<DataFlowDebugResource>> dataFlows = default;
            Optional<IList<DatasetDebugResource>> datasets = default;
            Optional<IList<LinkedServiceDebugResource>> linkedServices = default;
            Optional<DataFlowStagingInfo> staging = default;
            Optional<DataFlowDebugPackageDebugSettings> debugSettings = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlow = DataFlowDebugResource.DeserializeDataFlowDebugResource(property.Value);
                    continue;
                }
                if (property.NameEquals("dataFlows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowDebugResource> array = new List<DataFlowDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowDebugResource.DeserializeDataFlowDebugResource(item));
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
                    List<DatasetDebugResource> array = new List<DatasetDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetDebugResource.DeserializeDatasetDebugResource(item));
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
                    List<LinkedServiceDebugResource> array = new List<LinkedServiceDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceDebugResource.DeserializeLinkedServiceDebugResource(item));
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
                    staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("debugSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSettings = DataFlowDebugPackageDebugSettings.DeserializeDataFlowDebugPackageDebugSettings(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowDebugPackage(sessionId.Value, dataFlow.Value, Optional.ToList(dataFlows), Optional.ToList(datasets), Optional.ToList(linkedServices), staging.Value, debugSettings.Value, additionalProperties);
        }

        DataFlowDebugPackage IModelJsonSerializable<DataFlowDebugPackage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugPackage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugPackage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFlowDebugPackage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugPackage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFlowDebugPackage IModelSerializable<DataFlowDebugPackage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugPackage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFlowDebugPackage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFlowDebugPackage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFlowDebugPackage"/> to convert. </param>
        public static implicit operator RequestContent(DataFlowDebugPackage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFlowDebugPackage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFlowDebugPackage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFlowDebugPackage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DataFlowDebugPackageConverter : JsonConverter<DataFlowDebugPackage>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugPackage model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugPackage(document.RootElement);
            }
        }
    }
}
