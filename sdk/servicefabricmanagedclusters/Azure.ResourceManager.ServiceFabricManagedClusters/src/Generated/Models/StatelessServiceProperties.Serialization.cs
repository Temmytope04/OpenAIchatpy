// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class StatelessServiceProperties : IUtf8JsonSerializable, IJsonModel<StatelessServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatelessServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StatelessServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatelessServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatelessServiceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceCount"u8);
            writer.WriteNumberValue(InstanceCount);
            if (Optional.IsDefined(MinInstanceCount))
            {
                writer.WritePropertyName("minInstanceCount"u8);
                writer.WriteNumberValue(MinInstanceCount.Value);
            }
            if (Optional.IsDefined(MinInstancePercentage))
            {
                writer.WritePropertyName("minInstancePercentage"u8);
                writer.WriteNumberValue(MinInstancePercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("serviceKind"u8);
            writer.WriteStringValue(ServiceKind.ToString());
            writer.WritePropertyName("serviceTypeName"u8);
            writer.WriteStringValue(ServiceTypeName);
            writer.WritePropertyName("partitionDescription"u8);
            writer.WriteObjectValue<ManagedServicePartitionScheme>(PartitionDescription, options);
            if (Optional.IsDefined(ServicePackageActivationMode))
            {
                writer.WritePropertyName("servicePackageActivationMode"u8);
                writer.WriteStringValue(ServicePackageActivationMode.Value.ToString());
            }
            if (Optional.IsDefined(ServiceDnsName))
            {
                writer.WritePropertyName("serviceDnsName"u8);
                writer.WriteStringValue(ServiceDnsName);
            }
            if (Optional.IsDefined(PlacementConstraints))
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (Optional.IsCollectionDefined(CorrelationScheme))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue<ManagedServiceCorrelation>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceLoadMetrics))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue<ManagedServiceLoadMetric>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServicePlacementPolicies))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue<ManagedServicePlacementPolicy>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultMoveCost))
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScalingPolicies))
            {
                writer.WritePropertyName("scalingPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ScalingPolicies)
                {
                    writer.WriteObjectValue<ManagedServiceScalingPolicy>(item, options);
                }
                writer.WriteEndArray();
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

        StatelessServiceProperties IJsonModel<StatelessServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatelessServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatelessServiceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatelessServiceProperties(document.RootElement, options);
        }

        internal static StatelessServiceProperties DeserializeStatelessServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int instanceCount = default;
            int? minInstanceCount = default;
            int? minInstancePercentage = default;
            string provisioningState = default;
            ServiceKind serviceKind = default;
            string serviceTypeName = default;
            ManagedServicePartitionScheme partitionDescription = default;
            ManagedServicePackageActivationMode? servicePackageActivationMode = default;
            string serviceDnsName = default;
            string placementConstraints = default;
            IList<ManagedServiceCorrelation> correlationScheme = default;
            IList<ManagedServiceLoadMetric> serviceLoadMetrics = default;
            IList<ManagedServicePlacementPolicy> servicePlacementPolicies = default;
            ServiceFabricManagedServiceMoveCost? defaultMoveCost = default;
            IList<ManagedServiceScalingPolicy> scalingPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCount"u8))
                {
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstancePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstancePercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceKind"u8))
                {
                    serviceKind = new ServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceTypeName"u8))
                {
                    serviceTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionDescription"u8))
                {
                    partitionDescription = ManagedServicePartitionScheme.DeserializeManagedServicePartitionScheme(property.Value, options);
                    continue;
                }
                if (property.NameEquals("servicePackageActivationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePackageActivationMode = new ManagedServicePackageActivationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceDnsName"u8))
                {
                    serviceDnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("placementConstraints"u8))
                {
                    placementConstraints = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationScheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceCorrelation> array = new List<ManagedServiceCorrelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceCorrelation.DeserializeManagedServiceCorrelation(item, options));
                    }
                    correlationScheme = array;
                    continue;
                }
                if (property.NameEquals("serviceLoadMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceLoadMetric> array = new List<ManagedServiceLoadMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceLoadMetric.DeserializeManagedServiceLoadMetric(item, options));
                    }
                    serviceLoadMetrics = array;
                    continue;
                }
                if (property.NameEquals("servicePlacementPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicePlacementPolicy> array = new List<ManagedServicePlacementPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicePlacementPolicy.DeserializeManagedServicePlacementPolicy(item, options));
                    }
                    servicePlacementPolicies = array;
                    continue;
                }
                if (property.NameEquals("defaultMoveCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMoveCost = new ServiceFabricManagedServiceMoveCost(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceScalingPolicy> array = new List<ManagedServiceScalingPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceScalingPolicy.DeserializeManagedServiceScalingPolicy(item, options));
                    }
                    scalingPolicies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatelessServiceProperties(
                placementConstraints,
                correlationScheme ?? new ChangeTrackingList<ManagedServiceCorrelation>(),
                serviceLoadMetrics ?? new ChangeTrackingList<ManagedServiceLoadMetric>(),
                servicePlacementPolicies ?? new ChangeTrackingList<ManagedServicePlacementPolicy>(),
                defaultMoveCost,
                scalingPolicies ?? new ChangeTrackingList<ManagedServiceScalingPolicy>(),
                serializedAdditionalRawData,
                provisioningState,
                serviceKind,
                serviceTypeName,
                partitionDescription,
                servicePackageActivationMode,
                serviceDnsName,
                instanceCount,
                minInstanceCount,
                minInstancePercentage);
        }

        BinaryData IPersistableModel<StatelessServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatelessServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StatelessServiceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StatelessServiceProperties IPersistableModel<StatelessServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatelessServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStatelessServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StatelessServiceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StatelessServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
