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
    [JsonConverter(typeof(CreateRunResponseConverter))]
    public partial class CreateRunResponse : IUtf8JsonSerializable, IModelJsonSerializable<CreateRunResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateRunResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateRunResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateRunResponse>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("runId"u8);
            writer.WriteStringValue(RunId);
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

        internal static CreateRunResponse DeserializeCreateRunResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string runId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateRunResponse(runId, rawData);
        }

        CreateRunResponse IModelJsonSerializable<CreateRunResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateRunResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateRunResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateRunResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateRunResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateRunResponse IModelSerializable<CreateRunResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateRunResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateRunResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CreateRunResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CreateRunResponse"/> to convert. </param>
        public static implicit operator RequestContent(CreateRunResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CreateRunResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CreateRunResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateRunResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class CreateRunResponseConverter : JsonConverter<CreateRunResponse>
        {
            public override void Write(Utf8JsonWriter writer, CreateRunResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CreateRunResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCreateRunResponse(document.RootElement);
            }
        }
    }
}
