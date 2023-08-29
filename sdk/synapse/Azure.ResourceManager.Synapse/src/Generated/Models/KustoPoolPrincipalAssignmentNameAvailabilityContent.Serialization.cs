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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class KustoPoolPrincipalAssignmentNameAvailabilityContent : IUtf8JsonSerializable, IModelJsonSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceType.ToString());
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

        internal static KustoPoolPrincipalAssignmentNameAvailabilityContent DeserializeKustoPoolPrincipalAssignmentNameAvailabilityContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            SynapsePrincipalAssignmentType type = default;
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
                    type = new SynapsePrincipalAssignmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KustoPoolPrincipalAssignmentNameAvailabilityContent(name, type, rawData);
        }

        KustoPoolPrincipalAssignmentNameAvailabilityContent IModelJsonSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoPoolPrincipalAssignmentNameAvailabilityContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KustoPoolPrincipalAssignmentNameAvailabilityContent IModelSerializable<KustoPoolPrincipalAssignmentNameAvailabilityContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKustoPoolPrincipalAssignmentNameAvailabilityContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(KustoPoolPrincipalAssignmentNameAvailabilityContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator KustoPoolPrincipalAssignmentNameAvailabilityContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKustoPoolPrincipalAssignmentNameAvailabilityContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
