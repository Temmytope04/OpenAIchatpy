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
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapsePrivateLinkResourceListResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapsePrivateLinkResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapsePrivateLinkResourceListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapsePrivateLinkResourceListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static SynapsePrivateLinkResourceListResult DeserializeSynapsePrivateLinkResourceListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapsePrivateLinkResourceData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapsePrivateLinkResourceData> array = new List<SynapsePrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapsePrivateLinkResourceData.DeserializeSynapsePrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapsePrivateLinkResourceListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        SynapsePrivateLinkResourceListResult IModelJsonSerializable<SynapsePrivateLinkResourceListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapsePrivateLinkResourceListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapsePrivateLinkResourceListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapsePrivateLinkResourceListResult IModelSerializable<SynapsePrivateLinkResourceListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapsePrivateLinkResourceListResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SynapsePrivateLinkResourceListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SynapsePrivateLinkResourceListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapsePrivateLinkResourceListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
