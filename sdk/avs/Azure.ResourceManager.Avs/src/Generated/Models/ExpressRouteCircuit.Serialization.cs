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
    public partial class ExpressRouteCircuit : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRouteCircuit>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRouteCircuit>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRouteCircuit>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ExpressRouteCircuit DeserializeExpressRouteCircuit(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primarySubnet = default;
            Optional<string> secondarySubnet = default;
            Optional<ResourceIdentifier> expressRouteId = default;
            Optional<ResourceIdentifier> expressRoutePrivatePeeringId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySubnet"u8))
                {
                    primarySubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySubnet"u8))
                {
                    secondarySubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expressRouteID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressRouteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressRoutePrivatePeeringID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressRoutePrivatePeeringId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRouteCircuit(primarySubnet.Value, secondarySubnet.Value, expressRouteId.Value, expressRoutePrivatePeeringId.Value, rawData);
        }

        ExpressRouteCircuit IModelJsonSerializable<ExpressRouteCircuit>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuit(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRouteCircuit>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRouteCircuit IModelSerializable<ExpressRouteCircuit>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRouteCircuit(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExpressRouteCircuit"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExpressRouteCircuit"/> to convert. </param>
        public static implicit operator RequestContent(ExpressRouteCircuit model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExpressRouteCircuit"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExpressRouteCircuit(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRouteCircuit(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
