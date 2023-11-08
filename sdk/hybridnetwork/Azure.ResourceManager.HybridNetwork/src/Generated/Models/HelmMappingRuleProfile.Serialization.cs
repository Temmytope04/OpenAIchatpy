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
    public partial class HelmMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<HelmMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmMappingRuleProfile>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<HelmMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ReleaseNamespace))
            {
                writer.WritePropertyName("releaseNamespace"u8);
                writer.WriteStringValue(ReleaseNamespace);
            }
            if (Optional.IsDefined(ReleaseName))
            {
                writer.WritePropertyName("releaseName"u8);
                writer.WriteStringValue(ReleaseName);
            }
            if (Optional.IsDefined(HelmPackageVersion))
            {
                writer.WritePropertyName("helmPackageVersion"u8);
                writer.WriteStringValue(HelmPackageVersion);
            }
            if (Optional.IsDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStringValue(Values);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue(Options);
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

        HelmMappingRuleProfile IJsonModel<HelmMappingRuleProfile>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmMappingRuleProfile(document.RootElement, options);
        }

        internal static HelmMappingRuleProfile DeserializeHelmMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> releaseNamespace = default;
            Optional<string> releaseName = default;
            Optional<string> helmPackageVersion = default;
            Optional<string> values = default;
            Optional<HelmMappingRuleProfileConfig> options0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("releaseNamespace"u8))
                {
                    releaseNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("releaseName"u8))
                {
                    releaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helmPackageVersion"u8))
                {
                    helmPackageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    values = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    options0 = HelmMappingRuleProfileConfig.DeserializeHelmMappingRuleProfileConfig(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmMappingRuleProfile(releaseNamespace.Value, releaseName.Value, helmPackageVersion.Value, values.Value, options0.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<HelmMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HelmMappingRuleProfile IModel<HelmMappingRuleProfile>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHelmMappingRuleProfile(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<HelmMappingRuleProfile>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
