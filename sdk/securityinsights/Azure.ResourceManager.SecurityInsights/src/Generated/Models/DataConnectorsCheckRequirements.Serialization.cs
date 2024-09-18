// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    [PersistableModelProxy(typeof(UnknownDataConnectorsCheckRequirements))]
    public partial class DataConnectorsCheckRequirements : IUtf8JsonSerializable, IJsonModel<DataConnectorsCheckRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataConnectorsCheckRequirements>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataConnectorsCheckRequirements>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectorsCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnectorsCheckRequirements)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        DataConnectorsCheckRequirements IJsonModel<DataConnectorsCheckRequirements>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectorsCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataConnectorsCheckRequirements)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataConnectorsCheckRequirements(document.RootElement, options);
        }

        internal static DataConnectorsCheckRequirements DeserializeDataConnectorsCheckRequirements(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonWebServicesCloudTrail": return AwsCloudTrailCheckRequirements.DeserializeAwsCloudTrailCheckRequirements(element, options);
                    case "AmazonWebServicesS3": return AwsS3CheckRequirements.DeserializeAwsS3CheckRequirements(element, options);
                    case "AzureActiveDirectory": return AadCheckRequirements.DeserializeAadCheckRequirements(element, options);
                    case "AzureAdvancedThreatProtection": return AatpCheckRequirements.DeserializeAatpCheckRequirements(element, options);
                    case "AzureSecurityCenter": return AscCheckRequirements.DeserializeAscCheckRequirements(element, options);
                    case "Dynamics365": return Dynamics365CheckRequirements.DeserializeDynamics365CheckRequirements(element, options);
                    case "IOT": return IotCheckRequirements.DeserializeIotCheckRequirements(element, options);
                    case "MicrosoftCloudAppSecurity": return McasCheckRequirements.DeserializeMcasCheckRequirements(element, options);
                    case "MicrosoftDefenderAdvancedThreatProtection": return MdatpCheckRequirements.DeserializeMdatpCheckRequirements(element, options);
                    case "MicrosoftPurviewInformationProtection": return MicrosoftPurviewInformationProtectionCheckRequirements.DeserializeMicrosoftPurviewInformationProtectionCheckRequirements(element, options);
                    case "MicrosoftThreatIntelligence": return MstiCheckRequirements.DeserializeMstiCheckRequirements(element, options);
                    case "MicrosoftThreatProtection": return MtpCheckRequirements.DeserializeMtpCheckRequirements(element, options);
                    case "Office365Project": return Office365ProjectCheckRequirements.DeserializeOffice365ProjectCheckRequirements(element, options);
                    case "OfficeATP": return OfficeAtpCheckRequirements.DeserializeOfficeAtpCheckRequirements(element, options);
                    case "OfficeIRM": return OfficeIrmCheckRequirements.DeserializeOfficeIrmCheckRequirements(element, options);
                    case "OfficePowerBI": return OfficePowerBICheckRequirements.DeserializeOfficePowerBICheckRequirements(element, options);
                    case "ThreatIntelligence": return ThreatIntelligenceCheckRequirements.DeserializeThreatIntelligenceCheckRequirements(element, options);
                    case "ThreatIntelligenceTaxii": return ThreatIntelligenceTaxiiCheckRequirements.DeserializeThreatIntelligenceTaxiiCheckRequirements(element, options);
                }
            }
            return UnknownDataConnectorsCheckRequirements.DeserializeUnknownDataConnectorsCheckRequirements(element, options);
        }

        BinaryData IPersistableModel<DataConnectorsCheckRequirements>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectorsCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataConnectorsCheckRequirements)} does not support writing '{options.Format}' format.");
            }
        }

        DataConnectorsCheckRequirements IPersistableModel<DataConnectorsCheckRequirements>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataConnectorsCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataConnectorsCheckRequirements(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataConnectorsCheckRequirements)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataConnectorsCheckRequirements>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
