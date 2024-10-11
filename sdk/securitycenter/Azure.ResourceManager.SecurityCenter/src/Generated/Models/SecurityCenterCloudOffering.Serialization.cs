// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownCloudOffering))]
    public partial class SecurityCenterCloudOffering : IUtf8JsonSerializable, IJsonModel<SecurityCenterCloudOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterCloudOffering>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityCenterCloudOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterCloudOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterCloudOffering)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SecurityCenterCloudOffering IJsonModel<SecurityCenterCloudOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterCloudOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterCloudOffering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterCloudOffering(document.RootElement, options);
        }

        internal static SecurityCenterCloudOffering DeserializeSecurityCenterCloudOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("offeringType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CspmMonitorAws": return CspmMonitorAwsOffering.DeserializeCspmMonitorAwsOffering(element, options);
                    case "CspmMonitorAzureDevOps": return CspmMonitorAzureDevOpsOffering.DeserializeCspmMonitorAzureDevOpsOffering(element, options);
                    case "CspmMonitorGcp": return CspmMonitorGcpOffering.DeserializeCspmMonitorGcpOffering(element, options);
                    case "CspmMonitorGithub": return CspmMonitorGithubOffering.DeserializeCspmMonitorGithubOffering(element, options);
                    case "CspmMonitorGitLab": return CspmMonitorGitLabOffering.DeserializeCspmMonitorGitLabOffering(element, options);
                    case "DefenderCspmAws": return DefenderCspmAwsOffering.DeserializeDefenderCspmAwsOffering(element, options);
                    case "DefenderCspmGcp": return DefenderCspmGcpOffering.DeserializeDefenderCspmGcpOffering(element, options);
                    case "DefenderForContainersAws": return DefenderForContainersAwsOffering.DeserializeDefenderForContainersAwsOffering(element, options);
                    case "DefenderForContainersGcp": return DefenderForContainersGcpOffering.DeserializeDefenderForContainersGcpOffering(element, options);
                    case "DefenderForDatabasesAws": return DefenderForDatabasesAwsOffering.DeserializeDefenderForDatabasesAwsOffering(element, options);
                    case "DefenderForDatabasesGcp": return DefenderForDatabasesGcpOffering.DeserializeDefenderForDatabasesGcpOffering(element, options);
                    case "DefenderForDevOpsAzureDevOps": return DefenderForDevOpsAzureDevOpsOffering.DeserializeDefenderForDevOpsAzureDevOpsOffering(element, options);
                    case "DefenderForDevOpsGithub": return DefenderForDevOpsGithubOffering.DeserializeDefenderForDevOpsGithubOffering(element, options);
                    case "DefenderForDevOpsGitLab": return DefenderForDevOpsGitLabOffering.DeserializeDefenderForDevOpsGitLabOffering(element, options);
                    case "DefenderForServersAws": return DefenderForServersAwsOffering.DeserializeDefenderForServersAwsOffering(element, options);
                    case "DefenderForServersGcp": return DefenderForServersGcpOffering.DeserializeDefenderForServersGcpOffering(element, options);
                    case "InformationProtectionAws": return InformationProtectionAwsOffering.DeserializeInformationProtectionAwsOffering(element, options);
                }
            }
            return UnknownCloudOffering.DeserializeUnknownCloudOffering(element, options);
        }

        BinaryData IPersistableModel<SecurityCenterCloudOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterCloudOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterCloudOffering)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityCenterCloudOffering IPersistableModel<SecurityCenterCloudOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterCloudOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityCenterCloudOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterCloudOffering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterCloudOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
