// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class WindowsServerFailoverClusterDomainProfile : IUtf8JsonSerializable, IJsonModel<WindowsServerFailoverClusterDomainProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsServerFailoverClusterDomainProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WindowsServerFailoverClusterDomainProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DomainFqdn))
            {
                writer.WritePropertyName("domainFqdn"u8);
                writer.WriteStringValue(DomainFqdn);
            }
            if (Optional.IsDefined(OrganizationalUnitPath))
            {
                writer.WritePropertyName("ouPath"u8);
                writer.WriteStringValue(OrganizationalUnitPath);
            }
            if (Optional.IsDefined(ClusterBootstrapAccount))
            {
                writer.WritePropertyName("clusterBootstrapAccount"u8);
                writer.WriteStringValue(ClusterBootstrapAccount);
            }
            if (Optional.IsDefined(ClusterOperatorAccount))
            {
                writer.WritePropertyName("clusterOperatorAccount"u8);
                writer.WriteStringValue(ClusterOperatorAccount);
            }
            if (Optional.IsDefined(SqlServiceAccount))
            {
                writer.WritePropertyName("sqlServiceAccount"u8);
                writer.WriteStringValue(SqlServiceAccount);
            }
            if (Optional.IsDefined(FileShareWitnessPath))
            {
                writer.WritePropertyName("fileShareWitnessPath"u8);
                writer.WriteStringValue(FileShareWitnessPath);
            }
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountPrimaryKey))
            {
                writer.WritePropertyName("storageAccountPrimaryKey"u8);
                writer.WriteStringValue(StorageAccountPrimaryKey);
            }
            if (Optional.IsDefined(ClusterSubnetType))
            {
                writer.WritePropertyName("clusterSubnetType"u8);
                writer.WriteStringValue(ClusterSubnetType.Value.ToString());
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
        }

        WindowsServerFailoverClusterDomainProfile IJsonModel<WindowsServerFailoverClusterDomainProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsServerFailoverClusterDomainProfile(document.RootElement, options);
        }

        internal static WindowsServerFailoverClusterDomainProfile DeserializeWindowsServerFailoverClusterDomainProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainFqdn = default;
            string ouPath = default;
            string clusterBootstrapAccount = default;
            string clusterOperatorAccount = default;
            string sqlServiceAccount = default;
            string fileShareWitnessPath = default;
            Uri storageAccountUrl = default;
            string storageAccountPrimaryKey = default;
            SqlVmClusterSubnetType? clusterSubnetType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainFqdn"u8))
                {
                    domainFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ouPath"u8))
                {
                    ouPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterBootstrapAccount"u8))
                {
                    clusterBootstrapAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterOperatorAccount"u8))
                {
                    clusterOperatorAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServiceAccount"u8))
                {
                    sqlServiceAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileShareWitnessPath"u8))
                {
                    fileShareWitnessPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountPrimaryKey"u8))
                {
                    storageAccountPrimaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterSubnetType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterSubnetType = new SqlVmClusterSubnetType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WindowsServerFailoverClusterDomainProfile(
                domainFqdn,
                ouPath,
                clusterBootstrapAccount,
                clusterOperatorAccount,
                sqlServiceAccount,
                fileShareWitnessPath,
                storageAccountUrl,
                storageAccountPrimaryKey,
                clusterSubnetType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsServerFailoverClusterDomainProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support writing '{options.Format}' format.");
            }
        }

        WindowsServerFailoverClusterDomainProfile IPersistableModel<WindowsServerFailoverClusterDomainProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsServerFailoverClusterDomainProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsServerFailoverClusterDomainProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
