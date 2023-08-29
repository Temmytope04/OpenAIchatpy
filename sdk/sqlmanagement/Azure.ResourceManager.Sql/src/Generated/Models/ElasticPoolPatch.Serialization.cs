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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolPatch : IUtf8JsonSerializable, IModelJsonSerializable<ElasticPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticPoolPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticPoolPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes"u8);
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(PerDatabaseSettings))
            {
                writer.WritePropertyName("perDatabaseSettings"u8);
                writer.WriteObjectValue(PerDatabaseSettings);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount"u8);
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(PreferredEnclaveType))
            {
                writer.WritePropertyName("preferredEnclaveType"u8);
                writer.WriteStringValue(PreferredEnclaveType.Value.ToString());
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static ElasticPoolPatch DeserializeElasticPoolPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<long> maxSizeBytes = default;
            Optional<double> minCapacity = default;
            Optional<ElasticPoolPerDatabaseSettings> perDatabaseSettings = default;
            Optional<bool> zoneRedundant = default;
            Optional<ElasticPoolLicenseType> licenseType = default;
            Optional<ResourceIdentifier> maintenanceConfigurationId = default;
            Optional<int> highAvailabilityReplicaCount = default;
            Optional<SqlAlwaysEncryptedEnclaveType> preferredEnclaveType = default;
            Optional<SqlAvailabilityZoneType> availabilityZone = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxSizeBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minCapacity = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("perDatabaseSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perDatabaseSettings = ElasticPoolPerDatabaseSettings.DeserializeElasticPoolPerDatabaseSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new ElasticPoolLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceConfigurationId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("highAvailabilityReplicaCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailabilityReplicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("preferredEnclaveType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredEnclaveType = new SqlAlwaysEncryptedEnclaveType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityZone = new SqlAvailabilityZoneType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticPoolPatch(sku.Value, Optional.ToDictionary(tags), Optional.ToNullable(maxSizeBytes), Optional.ToNullable(minCapacity), perDatabaseSettings.Value, Optional.ToNullable(zoneRedundant), Optional.ToNullable(licenseType), maintenanceConfigurationId.Value, Optional.ToNullable(highAvailabilityReplicaCount), Optional.ToNullable(preferredEnclaveType), Optional.ToNullable(availabilityZone), rawData);
        }

        ElasticPoolPatch IModelJsonSerializable<ElasticPoolPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticPoolPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticPoolPatch IModelSerializable<ElasticPoolPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticPoolPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ElasticPoolPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ElasticPoolPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticPoolPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
