// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class DeploymentSettingInfrastructureNetwork : IUtf8JsonSerializable, IJsonModel<DeploymentSettingInfrastructureNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentSettingInfrastructureNetwork>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentSettingInfrastructureNetwork>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingInfrastructureNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingInfrastructureNetwork)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetMask))
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
            }
            if (Optional.IsDefined(Gateway))
            {
                writer.WritePropertyName("gateway"u8);
                writer.WriteStringValue(Gateway);
            }
            if (Optional.IsCollectionDefined(IPPools))
            {
                writer.WritePropertyName("ipPools"u8);
                writer.WriteStartArray();
                foreach (var item in IPPools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UseDhcp))
            {
                writer.WritePropertyName("useDhcp"u8);
                writer.WriteBooleanValue(UseDhcp.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DeploymentSettingInfrastructureNetwork IJsonModel<DeploymentSettingInfrastructureNetwork>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingInfrastructureNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingInfrastructureNetwork)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentSettingInfrastructureNetwork(document.RootElement, options);
        }

        internal static DeploymentSettingInfrastructureNetwork DeserializeDeploymentSettingInfrastructureNetwork(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subnetMask = default;
            string gateway = default;
            IList<DeploymentSettingIPPools> ipPools = default;
            IList<string> dnsServers = default;
            bool? useDhcp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gateway"u8))
                {
                    gateway = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeploymentSettingIPPools> array = new List<DeploymentSettingIPPools>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentSettingIPPools.DeserializeDeploymentSettingIPPools(item, options));
                    }
                    ipPools = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("useDhcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useDhcp = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentSettingInfrastructureNetwork(
                subnetMask,
                gateway,
                ipPools ?? new ChangeTrackingList<DeploymentSettingIPPools>(),
                dnsServers ?? new ChangeTrackingList<string>(),
                useDhcp,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubnetMask), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subnetMask: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubnetMask))
                {
                    builder.Append("  subnetMask: ");
                    if (SubnetMask.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubnetMask}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubnetMask}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Gateway), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gateway: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Gateway))
                {
                    builder.Append("  gateway: ");
                    if (Gateway.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Gateway}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Gateway}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IPPools), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ipPools: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IPPools))
                {
                    if (IPPools.Any())
                    {
                        builder.Append("  ipPools: ");
                        builder.AppendLine("[");
                        foreach (var item in IPPools)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  ipPools: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsServers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsServers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DnsServers))
                {
                    if (DnsServers.Any())
                    {
                        builder.Append("  dnsServers: ");
                        builder.AppendLine("[");
                        foreach (var item in DnsServers)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UseDhcp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  useDhcp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UseDhcp))
                {
                    builder.Append("  useDhcp: ");
                    var boolValue = UseDhcp.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeploymentSettingInfrastructureNetwork>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingInfrastructureNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingInfrastructureNetwork)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentSettingInfrastructureNetwork IPersistableModel<DeploymentSettingInfrastructureNetwork>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingInfrastructureNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentSettingInfrastructureNetwork(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingInfrastructureNetwork)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentSettingInfrastructureNetwork>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
