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

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileMachineInstanceViewEsuProperties : IUtf8JsonSerializable, IJsonModel<LicenseProfileMachineInstanceViewEsuProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LicenseProfileMachineInstanceViewEsuProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LicenseProfileMachineInstanceViewEsuProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceViewEsuProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(AssignedLicense))
            {
                writer.WritePropertyName("assignedLicense"u8);
                writer.WriteObjectValue(AssignedLicense, options);
            }
            if (Optional.IsDefined(LicenseAssignmentState))
            {
                writer.WritePropertyName("licenseAssignmentState"u8);
                writer.WriteStringValue(LicenseAssignmentState.Value.ToString());
            }
        }

        LicenseProfileMachineInstanceViewEsuProperties IJsonModel<LicenseProfileMachineInstanceViewEsuProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceViewEsuProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLicenseProfileMachineInstanceViewEsuProperties(document.RootElement, options);
        }

        internal static LicenseProfileMachineInstanceViewEsuProperties DeserializeLicenseProfileMachineInstanceViewEsuProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridComputeLicenseData assignedLicense = default;
            LicenseAssignmentState? licenseAssignmentState = default;
            EsuServerType? serverType = default;
            EsuEligibility? esuEligibility = default;
            EsuKeyState? esuKeyState = default;
            Guid? assignedLicenseImmutableId = default;
            IReadOnlyList<EsuKey> esuKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignedLicense"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicense = HybridComputeLicenseData.DeserializeHybridComputeLicenseData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("licenseAssignmentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseAssignmentState = new LicenseAssignmentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverType = new EsuServerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuEligibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuEligibility = new EsuEligibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuKeyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuKeyState = new EsuKeyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignedLicenseImmutableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicenseImmutableId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("esuKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EsuKey> array = new List<EsuKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EsuKey.DeserializeEsuKey(item, options));
                    }
                    esuKeys = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LicenseProfileMachineInstanceViewEsuProperties(
                assignedLicenseImmutableId,
                esuKeys ?? new ChangeTrackingList<EsuKey>(),
                serializedAdditionalRawData,
                serverType,
                esuEligibility,
                esuKeyState,
                assignedLicense,
                licenseAssignmentState);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignedLicense), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  assignedLicense: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignedLicense))
                {
                    builder.Append("  assignedLicense: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AssignedLicense, options, 2, false, "  assignedLicense: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LicenseAssignmentState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  licenseAssignmentState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LicenseAssignmentState))
                {
                    builder.Append("  licenseAssignmentState: ");
                    builder.AppendLine($"'{LicenseAssignmentState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serverType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerType))
                {
                    builder.Append("  serverType: ");
                    builder.AppendLine($"'{ServerType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EsuEligibility), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  esuEligibility: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EsuEligibility))
                {
                    builder.Append("  esuEligibility: ");
                    builder.AppendLine($"'{EsuEligibility.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EsuKeyState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  esuKeyState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EsuKeyState))
                {
                    builder.Append("  esuKeyState: ");
                    builder.AppendLine($"'{EsuKeyState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignedLicenseImmutableId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  assignedLicenseImmutableId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AssignedLicenseImmutableId))
                {
                    builder.Append("  assignedLicenseImmutableId: ");
                    builder.AppendLine($"'{AssignedLicenseImmutableId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EsuKeys), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  esuKeys: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EsuKeys))
                {
                    if (EsuKeys.Any())
                    {
                        builder.Append("  esuKeys: ");
                        builder.AppendLine("[");
                        foreach (var item in EsuKeys)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  esuKeys: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceViewEsuProperties)} does not support writing '{options.Format}' format.");
            }
        }

        LicenseProfileMachineInstanceViewEsuProperties IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLicenseProfileMachineInstanceViewEsuProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceViewEsuProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LicenseProfileMachineInstanceViewEsuProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
