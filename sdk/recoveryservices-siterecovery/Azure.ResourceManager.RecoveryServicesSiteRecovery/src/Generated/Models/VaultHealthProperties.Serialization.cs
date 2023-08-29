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
    public partial class VaultHealthProperties : IUtf8JsonSerializable, IModelJsonSerializable<VaultHealthProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VaultHealthProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VaultHealthProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VaultErrors))
            {
                writer.WritePropertyName("vaultErrors"u8);
                writer.WriteStartArray();
                foreach (var item in VaultErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProtectedItemsHealth))
            {
                writer.WritePropertyName("protectedItemsHealth"u8);
                writer.WriteObjectValue(ProtectedItemsHealth);
            }
            if (Optional.IsDefined(FabricsHealth))
            {
                writer.WritePropertyName("fabricsHealth"u8);
                writer.WriteObjectValue(FabricsHealth);
            }
            if (Optional.IsDefined(ContainersHealth))
            {
                writer.WritePropertyName("containersHealth"u8);
                writer.WriteObjectValue(ContainersHealth);
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

        internal static VaultHealthProperties DeserializeVaultHealthProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoveryHealthError>> vaultErrors = default;
            Optional<ResourceHealthSummary> protectedItemsHealth = default;
            Optional<ResourceHealthSummary> fabricsHealth = default;
            Optional<ResourceHealthSummary> containersHealth = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    vaultErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("fabricsHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricsHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("containersHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containersHealth = ResourceHealthSummary.DeserializeResourceHealthSummary(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VaultHealthProperties(Optional.ToList(vaultErrors), protectedItemsHealth.Value, fabricsHealth.Value, containersHealth.Value, rawData);
        }

        VaultHealthProperties IModelJsonSerializable<VaultHealthProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultHealthProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VaultHealthProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VaultHealthProperties IModelSerializable<VaultHealthProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVaultHealthProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VaultHealthProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VaultHealthProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVaultHealthProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
