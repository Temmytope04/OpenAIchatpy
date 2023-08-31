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
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkDnsServiceData : IUtf8JsonSerializable, IModelJsonSerializable<WorkloadNetworkDnsServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkloadNetworkDnsServiceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkloadNetworkDnsServiceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIp"u8);
                writer.WriteStringValue(DnsServiceIP.ToString());
            }
            if (Optional.IsDefined(DefaultDnsZone))
            {
                writer.WritePropertyName("defaultDnsZone"u8);
                writer.WriteStringValue(DefaultDnsZone);
            }
            if (Optional.IsCollectionDefined(FqdnZones))
            {
                writer.WritePropertyName("fqdnZones"u8);
                writer.WriteStartArray();
                foreach (var item in FqdnZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel"u8);
                writer.WriteStringValue(LogLevel.Value.ToString());
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision"u8);
                writer.WriteNumberValue(Revision.Value);
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

        internal static WorkloadNetworkDnsServiceData DeserializeWorkloadNetworkDnsServiceData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<IPAddress> dnsServiceIP = default;
            Optional<string> defaultDnsZone = default;
            Optional<IList<string>> fqdnZones = default;
            Optional<DnsServiceLogLevel> logLevel = default;
            Optional<DnsServiceStatus> status = default;
            Optional<WorkloadNetworkDnsServiceProvisioningState> provisioningState = default;
            Optional<long> revision = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsServiceIp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsServiceIP = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultDnsZone"u8))
                        {
                            defaultDnsZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fqdnZones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fqdnZones = array;
                            continue;
                        }
                        if (property0.NameEquals("logLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logLevel = new DnsServiceLogLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DnsServiceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WorkloadNetworkDnsServiceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("revision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revision = property0.Value.GetInt64();
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
            return new WorkloadNetworkDnsServiceData(id, name, type, systemData.Value, displayName.Value, dnsServiceIP.Value, defaultDnsZone.Value, Optional.ToList(fqdnZones), Optional.ToNullable(logLevel), Optional.ToNullable(status), Optional.ToNullable(provisioningState), Optional.ToNullable(revision), rawData);
        }

        WorkloadNetworkDnsServiceData IModelJsonSerializable<WorkloadNetworkDnsServiceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadNetworkDnsServiceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkloadNetworkDnsServiceData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkloadNetworkDnsServiceData IModelSerializable<WorkloadNetworkDnsServiceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkloadNetworkDnsServiceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WorkloadNetworkDnsServiceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WorkloadNetworkDnsServiceData"/> to convert. </param>
        public static implicit operator RequestContent(WorkloadNetworkDnsServiceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WorkloadNetworkDnsServiceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WorkloadNetworkDnsServiceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWorkloadNetworkDnsServiceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
