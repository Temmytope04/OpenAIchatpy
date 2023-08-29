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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingRecoveryProximityPlacementGroup : IUtf8JsonSerializable, IModelJsonSerializable<ExistingRecoveryProximityPlacementGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExistingRecoveryProximityPlacementGroup>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExistingRecoveryProximityPlacementGroup>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryProximityPlacementGroup>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryProximityPlacementGroupId))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupId"u8);
                writer.WriteStringValue(RecoveryProximityPlacementGroupId);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        internal static ExistingRecoveryProximityPlacementGroup DeserializeExistingRecoveryProximityPlacementGroup(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryProximityPlacementGroupId = default;
            string resourceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExistingRecoveryProximityPlacementGroup(resourceType, recoveryProximityPlacementGroupId.Value, rawData);
        }

        ExistingRecoveryProximityPlacementGroup IModelJsonSerializable<ExistingRecoveryProximityPlacementGroup>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryProximityPlacementGroup>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExistingRecoveryProximityPlacementGroup(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExistingRecoveryProximityPlacementGroup>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryProximityPlacementGroup>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExistingRecoveryProximityPlacementGroup IModelSerializable<ExistingRecoveryProximityPlacementGroup>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExistingRecoveryProximityPlacementGroup>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExistingRecoveryProximityPlacementGroup(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExistingRecoveryProximityPlacementGroup model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExistingRecoveryProximityPlacementGroup(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExistingRecoveryProximityPlacementGroup(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
