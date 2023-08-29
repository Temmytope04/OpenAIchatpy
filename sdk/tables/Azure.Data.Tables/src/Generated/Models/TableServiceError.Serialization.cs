// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Data.Tables.Models
{
    internal partial class TableServiceError : IUtf8JsonSerializable, IModelJsonSerializable<TableServiceError>, IXmlSerializable, IModelSerializable<TableServiceError>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "TableServiceError");
            if (Optional.IsDefined(Message))
            {
                writer.WriteStartElement("Message");
                writer.WriteValue(Message);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static TableServiceError DeserializeTableServiceError(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            string message = default;
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new TableServiceError(message, default);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TableServiceError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TableServiceError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("Message"u8);
                writer.WriteStringValue(Message);
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

        internal static TableServiceError DeserializeTableServiceError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TableServiceError(message.Value, rawData);
        }

        TableServiceError IModelJsonSerializable<TableServiceError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTableServiceError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TableServiceError>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            if (options.Format == ModelSerializerFormat.Json)
            {
                return ModelSerializer.SerializeCore(this, options);
            }
            else
            {
                options ??= ModelSerializerOptions.DefaultWireOptions;
                using MemoryStream stream = new MemoryStream();
                using XmlWriter writer = XmlWriter.Create(stream);
                Serialize(writer, null, options);
                writer.Flush();
                if (stream.Position > int.MaxValue)
                {
                    return BinaryData.FromStream(stream);
                }
                else
                {
                    return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                }
            }
        }

        TableServiceError IModelSerializable<TableServiceError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            if (data.ToMemory().Span.StartsWith("{"u8))
            {
                using var doc = JsonDocument.Parse(data);
                return DeserializeTableServiceError(doc.RootElement, options);
            }
            else
            {
                return DeserializeTableServiceError(XElement.Load(data.ToStream()), options);
            }
        }

        public static implicit operator RequestContent(TableServiceError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create((IModelSerializable<TableServiceError>)model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TableServiceError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeTableServiceError(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
