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
    [JsonConverter(typeof(IntegrationRuntimeDebugResourceConverter))]
    public partial class IntegrationRuntimeDebugResource : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationRuntimeDebugResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationRuntimeDebugResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationRuntimeDebugResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IntegrationRuntimeDebugResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static IntegrationRuntimeDebugResource DeserializeIntegrationRuntimeDebugResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntime properties = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = IntegrationRuntime.DeserializeIntegrationRuntime(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationRuntimeDebugResource(name.Value, properties, rawData);
        }

        IntegrationRuntimeDebugResource IModelJsonSerializable<IntegrationRuntimeDebugResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IntegrationRuntimeDebugResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeDebugResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationRuntimeDebugResource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IntegrationRuntimeDebugResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationRuntimeDebugResource IModelSerializable<IntegrationRuntimeDebugResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IntegrationRuntimeDebugResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationRuntimeDebugResource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IntegrationRuntimeDebugResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IntegrationRuntimeDebugResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationRuntimeDebugResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class IntegrationRuntimeDebugResourceConverter : JsonConverter<IntegrationRuntimeDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IntegrationRuntimeDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeDebugResource(document.RootElement);
            }
        }
    }
}
