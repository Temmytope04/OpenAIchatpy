// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ThreeTierConfiguration : IUtf8JsonSerializable, IJsonModel<ThreeTierConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreeTierConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreeTierConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreeTierConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            writer.WritePropertyName("centralServer"u8);
            writer.WriteObjectValue(CentralServer);
            writer.WritePropertyName("applicationServer"u8);
            writer.WriteObjectValue(ApplicationServer);
            writer.WritePropertyName("databaseServer"u8);
            writer.WriteObjectValue(DatabaseServer);
            if (Optional.IsDefined(HighAvailabilityConfig))
            {
                writer.WritePropertyName("highAvailabilityConfig"u8);
                writer.WriteObjectValue(HighAvailabilityConfig);
            }
            if (Optional.IsDefined(StorageConfiguration))
            {
                writer.WritePropertyName("storageConfiguration"u8);
                writer.WriteObjectValue(StorageConfiguration);
            }
            if (Optional.IsDefined(CustomResourceNames))
            {
                writer.WritePropertyName("customResourceNames"u8);
                writer.WriteObjectValue(CustomResourceNames);
            }
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup"u8);
            writer.WriteStringValue(AppResourceGroup);
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

        ThreeTierConfiguration IJsonModel<ThreeTierConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreeTierConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreeTierConfiguration(document.RootElement, options);
        }

        internal static ThreeTierConfiguration DeserializeThreeTierConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkConfiguration networkConfiguration = default;
            CentralServerConfiguration centralServer = default;
            ApplicationServerConfiguration applicationServer = default;
            DatabaseConfiguration databaseServer = default;
            HighAvailabilityConfiguration highAvailabilityConfig = default;
            SapStorageConfiguration storageConfiguration = default;
            ThreeTierCustomResourceNames customResourceNames = default;
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("centralServer"u8))
                {
                    centralServer = CentralServerConfiguration.DeserializeCentralServerConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationServer"u8))
                {
                    applicationServer = ApplicationServerConfiguration.DeserializeApplicationServerConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("databaseServer"u8))
                {
                    databaseServer = DatabaseConfiguration.DeserializeDatabaseConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("highAvailabilityConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilityConfig = HighAvailabilityConfiguration.DeserializeHighAvailabilityConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageConfiguration = SapStorageConfiguration.DeserializeSapStorageConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customResourceNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customResourceNames = ThreeTierCustomResourceNames.DeserializeThreeTierCustomResourceNames(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"u8))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreeTierConfiguration(
                deploymentType,
                appResourceGroup,
                serializedAdditionalRawData,
                networkConfiguration,
                centralServer,
                applicationServer,
                databaseServer,
                highAvailabilityConfig,
                storageConfiguration,
                customResourceNames);
        }

        BinaryData IPersistableModel<ThreeTierConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreeTierConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ThreeTierConfiguration IPersistableModel<ThreeTierConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreeTierConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreeTierConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreeTierConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreeTierConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
