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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmReleaseProperties : IUtf8JsonSerializable, IJsonModel<HelmReleaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmReleaseProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<HelmReleaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LastRevisionApplied))
            {
                if (LastRevisionApplied != null)
                {
                    writer.WritePropertyName("lastRevisionApplied"u8);
                    writer.WriteNumberValue(LastRevisionApplied.Value);
                }
                else
                {
                    writer.WriteNull("lastRevisionApplied");
                }
            }
            if (Optional.IsDefined(HelmChartRef))
            {
                if (HelmChartRef != null)
                {
                    writer.WritePropertyName("helmChartRef"u8);
                    writer.WriteObjectValue(HelmChartRef);
                }
                else
                {
                    writer.WriteNull("helmChartRef");
                }
            }
            if (Optional.IsDefined(FailureCount))
            {
                if (FailureCount != null)
                {
                    writer.WritePropertyName("failureCount"u8);
                    writer.WriteNumberValue(FailureCount.Value);
                }
                else
                {
                    writer.WriteNull("failureCount");
                }
            }
            if (Optional.IsDefined(InstallFailureCount))
            {
                if (InstallFailureCount != null)
                {
                    writer.WritePropertyName("installFailureCount"u8);
                    writer.WriteNumberValue(InstallFailureCount.Value);
                }
                else
                {
                    writer.WriteNull("installFailureCount");
                }
            }
            if (Optional.IsDefined(UpgradeFailureCount))
            {
                if (UpgradeFailureCount != null)
                {
                    writer.WritePropertyName("upgradeFailureCount"u8);
                    writer.WriteNumberValue(UpgradeFailureCount.Value);
                }
                else
                {
                    writer.WriteNull("upgradeFailureCount");
                }
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

        HelmReleaseProperties IJsonModel<HelmReleaseProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmReleaseProperties(document.RootElement, options);
        }

        internal static HelmReleaseProperties DeserializeHelmReleaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long?> lastRevisionApplied = default;
            Optional<KubernetesObjectReference> helmChartRef = default;
            Optional<long?> failureCount = default;
            Optional<long?> installFailureCount = default;
            Optional<long?> upgradeFailureCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastRevisionApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastRevisionApplied = null;
                        continue;
                    }
                    lastRevisionApplied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("helmChartRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmChartRef = null;
                        continue;
                    }
                    helmChartRef = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value);
                    continue;
                }
                if (property.NameEquals("failureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        failureCount = null;
                        continue;
                    }
                    failureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("installFailureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        installFailureCount = null;
                        continue;
                    }
                    installFailureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("upgradeFailureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        upgradeFailureCount = null;
                        continue;
                    }
                    upgradeFailureCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmReleaseProperties(Optional.ToNullable(lastRevisionApplied), helmChartRef.Value, Optional.ToNullable(failureCount), Optional.ToNullable(installFailureCount), Optional.ToNullable(upgradeFailureCount), serializedAdditionalRawData);
        }

        BinaryData IModel<HelmReleaseProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HelmReleaseProperties IModel<HelmReleaseProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHelmReleaseProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<HelmReleaseProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
