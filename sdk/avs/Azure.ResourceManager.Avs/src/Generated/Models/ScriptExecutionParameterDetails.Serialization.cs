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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptExecutionParameterDetails : IUtf8JsonSerializable, IModelJsonSerializable<ScriptExecutionParameterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScriptExecutionParameterDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScriptExecutionParameterDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
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

        internal static ScriptExecutionParameterDetails DeserializeScriptExecutionParameterDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Credential": return PSCredentialExecutionParameterDetails.DeserializePSCredentialExecutionParameterDetails(element);
                    case "SecureValue": return ScriptSecureStringExecutionParameterDetails.DeserializeScriptSecureStringExecutionParameterDetails(element);
                    case "Value": return ScriptStringExecutionParameterDetails.DeserializeScriptStringExecutionParameterDetails(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string name = default;
            ScriptExecutionParameterType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ScriptExecutionParameterType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownScriptExecutionParameter(name, type, rawData);
        }

        ScriptExecutionParameterDetails IModelJsonSerializable<ScriptExecutionParameterDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptExecutionParameterDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScriptExecutionParameterDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScriptExecutionParameterDetails IModelSerializable<ScriptExecutionParameterDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScriptExecutionParameterDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScriptExecutionParameterDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScriptExecutionParameterDetails"/> to convert. </param>
        public static implicit operator RequestContent(ScriptExecutionParameterDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScriptExecutionParameterDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScriptExecutionParameterDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScriptExecutionParameterDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
