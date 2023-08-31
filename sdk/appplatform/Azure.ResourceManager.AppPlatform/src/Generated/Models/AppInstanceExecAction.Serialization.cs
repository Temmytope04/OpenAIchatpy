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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppInstanceExecAction : IUtf8JsonSerializable, IModelJsonSerializable<AppInstanceExecAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppInstanceExecAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppInstanceExecAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AppInstanceExecAction>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ProbeActionType.ToString());
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

        internal static AppInstanceExecAction DeserializeAppInstanceExecAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> command = default;
            ProbeActionType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
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
                    command = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ProbeActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppInstanceExecAction(type, Optional.ToList(command), rawData);
        }

        AppInstanceExecAction IModelJsonSerializable<AppInstanceExecAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AppInstanceExecAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInstanceExecAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppInstanceExecAction>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AppInstanceExecAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppInstanceExecAction IModelSerializable<AppInstanceExecAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AppInstanceExecAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppInstanceExecAction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppInstanceExecAction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppInstanceExecAction"/> to convert. </param>
        public static implicit operator RequestContent(AppInstanceExecAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppInstanceExecAction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppInstanceExecAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppInstanceExecAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
