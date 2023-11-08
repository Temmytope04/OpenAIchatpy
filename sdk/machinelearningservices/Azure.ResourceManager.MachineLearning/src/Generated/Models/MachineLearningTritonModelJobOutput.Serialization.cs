// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningTritonModelJobOutput : IUtf8JsonSerializable, IJsonModel<MachineLearningTritonModelJobOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningTritonModelJobOutput>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningTritonModelJobOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AssetName))
            {
                if (AssetName != null)
                {
                    writer.WritePropertyName("assetName"u8);
                    writer.WriteStringValue(AssetName);
                }
                else
                {
                    writer.WriteNull("assetName");
                }
            }
            if (Optional.IsDefined(AssetVersion))
            {
                if (AssetVersion != null)
                {
                    writer.WritePropertyName("assetVersion"u8);
                    writer.WriteStringValue(AssetVersion);
                }
                else
                {
                    writer.WriteNull("assetVersion");
                }
            }
            if (Optional.IsDefined(AutoDeleteSetting))
            {
                if (AutoDeleteSetting != null)
                {
                    writer.WritePropertyName("autoDeleteSetting"u8);
                    writer.WriteObjectValue(AutoDeleteSetting);
                }
                else
                {
                    writer.WriteNull("autoDeleteSetting");
                }
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("uri"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MachineLearningTritonModelJobOutput IJsonModel<MachineLearningTritonModelJobOutput>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningTritonModelJobOutput(document.RootElement, options);
        }

        internal static MachineLearningTritonModelJobOutput DeserializeMachineLearningTritonModelJobOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> assetName = default;
            Optional<string> assetVersion = default;
            Optional<AutoDeleteSetting> autoDeleteSetting = default;
            Optional<MachineLearningOutputDeliveryMode> mode = default;
            Optional<Uri> uri = default;
            Optional<string> description = default;
            JobOutputType jobOutputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetName = null;
                        continue;
                    }
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetVersion = null;
                        continue;
                    }
                    assetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDeleteSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoDeleteSetting = null;
                        continue;
                    }
                    autoDeleteSetting = AutoDeleteSetting.DeserializeAutoDeleteSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningOutputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningTritonModelJobOutput(description.Value, jobOutputType, serializedAdditionalRawData, assetName.Value, assetVersion.Value, autoDeleteSetting.Value, Optional.ToNullable(mode), uri.Value);
        }

        BinaryData IModel<MachineLearningTritonModelJobOutput>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningTritonModelJobOutput IModel<MachineLearningTritonModelJobOutput>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningTritonModelJobOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningTritonModelJobOutput(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningTritonModelJobOutput>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
