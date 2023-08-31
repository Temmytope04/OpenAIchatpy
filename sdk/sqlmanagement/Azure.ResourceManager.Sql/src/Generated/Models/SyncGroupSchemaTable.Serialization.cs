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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchemaTable : IUtf8JsonSerializable, IModelJsonSerializable<SyncGroupSchemaTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SyncGroupSchemaTable>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SyncGroupSchemaTable>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
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

        internal static SyncGroupSchemaTable DeserializeSyncGroupSchemaTable(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SyncGroupSchemaTableColumn>> columns = default;
            Optional<string> quotedName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncGroupSchemaTableColumn> array = new List<SyncGroupSchemaTableColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncGroupSchemaTableColumn.DeserializeSyncGroupSchemaTableColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SyncGroupSchemaTable(Optional.ToList(columns), quotedName.Value, rawData);
        }

        SyncGroupSchemaTable IModelJsonSerializable<SyncGroupSchemaTable>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupSchemaTable(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SyncGroupSchemaTable>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SyncGroupSchemaTable IModelSerializable<SyncGroupSchemaTable>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSyncGroupSchemaTable(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SyncGroupSchemaTable model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SyncGroupSchemaTable(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSyncGroupSchemaTable(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
