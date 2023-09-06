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

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class StorageError : IUtf8JsonSerializable, IModelJsonSerializable<StorageError>, IXmlSerializable, IModelSerializable<StorageError>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "StorageError");
            if (Optional.IsDefined(Error))
            {
                writer.WriteObjectValue(Error, "error");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static StorageError DeserializeStorageError(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            StorageErrorError error = default;
            if (element.Element("error") is XElement errorElement)
            {
                error = StorageErrorError.DeserializeStorageErrorError(errorElement);
            }
            return new StorageError(error, default);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageError>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageErrorError>)Error).Serialize(writer, options);
                }
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

        internal static StorageError DeserializeStorageError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageErrorError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = StorageErrorError.DeserializeStorageErrorError(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageError(error.Value, rawData);
        }

        StorageError IModelJsonSerializable<StorageError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageError>(this, options.Format);

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

        StorageError IModelSerializable<StorageError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageError>(this, options.Format);

            if (data.ToMemory().Span.StartsWith("{"u8))
            {
                using var doc = JsonDocument.Parse(data);
                return DeserializeStorageError(doc.RootElement, options);
            }
            else
            {
                return DeserializeStorageError(XElement.Load(data.ToStream()), options);
            }
        }

        /// <summary> Converts a <see cref="StorageError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageError"/> to convert. </param>
        public static implicit operator RequestContent(StorageError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create((IModelSerializable<StorageError>)model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeStorageError(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
