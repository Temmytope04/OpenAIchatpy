// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    public partial class ChangeProperties : IUtf8JsonSerializable, IModelJsonSerializable<ChangeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ChangeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ChangeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ChangeDetectedOn))
            {
                writer.WritePropertyName("timeStamp"u8);
                writer.WriteStringValue(ChangeDetectedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(InitiatedByList))
            {
                writer.WritePropertyName("initiatedByList"u8);
                writer.WriteStartArray();
                foreach (var item in InitiatedByList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PropertyChanges))
            {
                writer.WritePropertyName("propertyChanges"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyChanges)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PropertyChange>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ChangeProperties DeserializeChangeProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<DateTimeOffset> timeStamp = default;
            Optional<IReadOnlyList<string>> initiatedByList = default;
            Optional<ChangeType> changeType = default;
            Optional<IReadOnlyList<PropertyChange>> propertyChanges = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("initiatedByList"u8))
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
                    initiatedByList = array;
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new ChangeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PropertyChange> array = new List<PropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PropertyChange.DeserializePropertyChange(item));
                    }
                    propertyChanges = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ChangeProperties(resourceId.Value, Optional.ToNullable(timeStamp), Optional.ToList(initiatedByList), Optional.ToNullable(changeType), Optional.ToList(propertyChanges), rawData);
        }

        ChangeProperties IModelJsonSerializable<ChangeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ChangeProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ChangeProperties IModelSerializable<ChangeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChangeProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ChangeProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ChangeProperties"/> to convert. </param>
        public static implicit operator RequestContent(ChangeProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ChangeProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ChangeProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChangeProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
