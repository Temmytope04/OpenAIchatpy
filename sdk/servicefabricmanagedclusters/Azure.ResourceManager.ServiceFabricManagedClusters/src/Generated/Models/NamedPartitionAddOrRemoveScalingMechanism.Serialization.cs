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
    public partial class NamedPartitionAddOrRemoveScalingMechanism : IUtf8JsonSerializable, IModelJsonSerializable<NamedPartitionAddOrRemoveScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NamedPartitionAddOrRemoveScalingMechanism>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NamedPartitionAddOrRemoveScalingMechanism>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NamedPartitionAddOrRemoveScalingMechanism>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("minPartitionCount"u8);
            writer.WriteNumberValue(MinPartitionCount);
            writer.WritePropertyName("maxPartitionCount"u8);
            writer.WriteNumberValue(MaxPartitionCount);
            writer.WritePropertyName("scaleIncrement"u8);
            writer.WriteNumberValue(ScaleIncrement);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static NamedPartitionAddOrRemoveScalingMechanism DeserializeNamedPartitionAddOrRemoveScalingMechanism(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minPartitionCount = default;
            int maxPartitionCount = default;
            int scaleIncrement = default;
            ServiceScalingMechanismKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minPartitionCount"u8))
                {
                    minPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPartitionCount"u8))
                {
                    maxPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleIncrement"u8))
                {
                    scaleIncrement = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingMechanismKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NamedPartitionAddOrRemoveScalingMechanism(kind, minPartitionCount, maxPartitionCount, scaleIncrement, rawData);
        }

        NamedPartitionAddOrRemoveScalingMechanism IModelJsonSerializable<NamedPartitionAddOrRemoveScalingMechanism>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NamedPartitionAddOrRemoveScalingMechanism>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNamedPartitionAddOrRemoveScalingMechanism(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NamedPartitionAddOrRemoveScalingMechanism>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NamedPartitionAddOrRemoveScalingMechanism>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NamedPartitionAddOrRemoveScalingMechanism IModelSerializable<NamedPartitionAddOrRemoveScalingMechanism>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NamedPartitionAddOrRemoveScalingMechanism>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNamedPartitionAddOrRemoveScalingMechanism(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NamedPartitionAddOrRemoveScalingMechanism model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NamedPartitionAddOrRemoveScalingMechanism(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNamedPartitionAddOrRemoveScalingMechanism(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
