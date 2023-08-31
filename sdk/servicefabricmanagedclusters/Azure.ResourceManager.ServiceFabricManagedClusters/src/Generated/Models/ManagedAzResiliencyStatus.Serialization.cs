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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedAzResiliencyStatus : IUtf8JsonSerializable, IModelJsonSerializable<ManagedAzResiliencyStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedAzResiliencyStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedAzResiliencyStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BaseResourceStatus))
            {
                writer.WritePropertyName("baseResourceStatus"u8);
                writer.WriteStartArray();
                foreach (var item in BaseResourceStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static ManagedAzResiliencyStatus DeserializeManagedAzResiliencyStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ResourceAzStatus>> baseResourceStatus = default;
            Optional<bool> isClusterZoneResilient = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseResourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceAzStatus> array = new List<ResourceAzStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceAzStatus.DeserializeResourceAzStatus(item));
                    }
                    baseResourceStatus = array;
                    continue;
                }
                if (property.NameEquals("isClusterZoneResilient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isClusterZoneResilient = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedAzResiliencyStatus(Optional.ToList(baseResourceStatus), Optional.ToNullable(isClusterZoneResilient), rawData);
        }

        ManagedAzResiliencyStatus IModelJsonSerializable<ManagedAzResiliencyStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedAzResiliencyStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedAzResiliencyStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedAzResiliencyStatus IModelSerializable<ManagedAzResiliencyStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedAzResiliencyStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedAzResiliencyStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedAzResiliencyStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedAzResiliencyStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
