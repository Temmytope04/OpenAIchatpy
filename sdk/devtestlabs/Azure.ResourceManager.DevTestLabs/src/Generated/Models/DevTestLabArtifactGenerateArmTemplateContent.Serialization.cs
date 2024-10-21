// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArtifactGenerateArmTemplateContent : IUtf8JsonSerializable, IJsonModel<DevTestLabArtifactGenerateArmTemplateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabArtifactGenerateArmTemplateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabArtifactGenerateArmTemplateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArtifactGenerateArmTemplateContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("virtualMachineName"u8);
                writer.WriteStringValue(VmName);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(FileUploadOptions))
            {
                writer.WritePropertyName("fileUploadOptions"u8);
                writer.WriteStringValue(FileUploadOptions.Value.ToString());
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

        DevTestLabArtifactGenerateArmTemplateContent IJsonModel<DevTestLabArtifactGenerateArmTemplateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArtifactGenerateArmTemplateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArtifactGenerateArmTemplateContent(document.RootElement, options);
        }

        internal static DevTestLabArtifactGenerateArmTemplateContent DeserializeDevTestLabArtifactGenerateArmTemplateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmName = default;
            IList<DevTestLabParameter> parameters = default;
            AzureLocation? location = default;
            DevTestLabFileUploadOption? fileUploadOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabParameter> array = new List<DevTestLabParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabParameter.DeserializeDevTestLabParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fileUploadOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadOptions = new DevTestLabFileUploadOption(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabArtifactGenerateArmTemplateContent(vmName, parameters ?? new ChangeTrackingList<DevTestLabParameter>(), location, fileUploadOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArtifactGenerateArmTemplateContent)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabArtifactGenerateArmTemplateContent IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabArtifactGenerateArmTemplateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArtifactGenerateArmTemplateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabArtifactGenerateArmTemplateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
