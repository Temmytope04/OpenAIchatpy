// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProcessServerDetails : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryProcessServerDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryProcessServerDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryProcessServerDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static SiteRecoveryProcessServerDetails DeserializeSiteRecoveryProcessServerDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> biosId = default;
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<string> fqdn = default;
            Optional<IReadOnlyList<IPAddress>> ipAddresses = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<long> totalMemoryInBytes = default;
            Optional<long> availableMemoryInBytes = default;
            Optional<long> usedMemoryInBytes = default;
            Optional<double> memoryUsagePercentage = default;
            Optional<long> totalSpaceInBytes = default;
            Optional<long> availableSpaceInBytes = default;
            Optional<long> usedSpaceInBytes = default;
            Optional<double> freeSpacePercentage = default;
            Optional<long> throughputUploadPendingDataInBytes = default;
            Optional<long> throughputInBytes = default;
            Optional<double> processorUsagePercentage = default;
            Optional<RcmComponentStatus> throughputStatus = default;
            Optional<long> systemLoad = default;
            Optional<RcmComponentStatus> systemLoadStatus = default;
            Optional<RcmComponentStatus> diskUsageStatus = default;
            Optional<RcmComponentStatus> memoryUsageStatus = default;
            Optional<RcmComponentStatus> processorUsageStatus = default;
            Optional<SiteRecoveryProtectionHealth> health = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Optional<int> protectedItemCount = default;
            Optional<SiteRecoveryProtectionHealth> historicHealth = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("usedMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsagePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryUsagePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("usedSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("freeSpacePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeSpacePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("throughputUploadPendingDataInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputUploadPendingDataInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("throughputInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processorUsagePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorUsagePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("throughputStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemLoad = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemLoadStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("processorUsageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorUsageStatus = new RcmComponentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
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
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("historicHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    historicHealth = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryProcessServerDetails(id.Value, name.Value, biosId.Value, fabricObjectId.Value, fqdn.Value, Optional.ToList(ipAddresses), version.Value, Optional.ToNullable(lastHeartbeatUtc), Optional.ToNullable(totalMemoryInBytes), Optional.ToNullable(availableMemoryInBytes), Optional.ToNullable(usedMemoryInBytes), Optional.ToNullable(memoryUsagePercentage), Optional.ToNullable(totalSpaceInBytes), Optional.ToNullable(availableSpaceInBytes), Optional.ToNullable(usedSpaceInBytes), Optional.ToNullable(freeSpacePercentage), Optional.ToNullable(throughputUploadPendingDataInBytes), Optional.ToNullable(throughputInBytes), Optional.ToNullable(processorUsagePercentage), Optional.ToNullable(throughputStatus), Optional.ToNullable(systemLoad), Optional.ToNullable(systemLoadStatus), Optional.ToNullable(diskUsageStatus), Optional.ToNullable(memoryUsageStatus), Optional.ToNullable(processorUsageStatus), Optional.ToNullable(health), Optional.ToList(healthErrors), Optional.ToNullable(protectedItemCount), Optional.ToNullable(historicHealth), rawData);
        }

        SiteRecoveryProcessServerDetails IModelJsonSerializable<SiteRecoveryProcessServerDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProcessServerDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryProcessServerDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryProcessServerDetails IModelSerializable<SiteRecoveryProcessServerDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryProcessServerDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SiteRecoveryProcessServerDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SiteRecoveryProcessServerDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryProcessServerDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
