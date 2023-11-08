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

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmMappingRuleProfileConfig : IUtf8JsonSerializable, IJsonModel<HelmMappingRuleProfileConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmMappingRuleProfileConfig>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<HelmMappingRuleProfileConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InstallOptions))
            {
                writer.WritePropertyName("installOptions"u8);
                writer.WriteObjectValue(InstallOptions);
            }
            if (Optional.IsDefined(UpgradeOptions))
            {
                writer.WritePropertyName("upgradeOptions"u8);
                writer.WriteObjectValue(UpgradeOptions);
            }
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

        HelmMappingRuleProfileConfig IJsonModel<HelmMappingRuleProfileConfig>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
        }

        internal static HelmMappingRuleProfileConfig DeserializeHelmMappingRuleProfileConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HelmInstallConfig> installOptions = default;
            Optional<HelmUpgradeConfig> upgradeOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("installOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installOptions = HelmInstallConfig.DeserializeHelmInstallConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("upgradeOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeOptions = HelmUpgradeConfig.DeserializeHelmUpgradeConfig(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmMappingRuleProfileConfig(installOptions.Value, upgradeOptions.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<HelmMappingRuleProfileConfig>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HelmMappingRuleProfileConfig IModel<HelmMappingRuleProfileConfig>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<HelmMappingRuleProfileConfig>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
