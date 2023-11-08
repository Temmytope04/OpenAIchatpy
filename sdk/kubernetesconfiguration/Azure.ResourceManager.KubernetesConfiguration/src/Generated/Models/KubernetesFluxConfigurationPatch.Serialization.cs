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
    public partial class KubernetesFluxConfigurationPatch : IUtf8JsonSerializable, IJsonModel<KubernetesFluxConfigurationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesFluxConfigurationPatch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<KubernetesFluxConfigurationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceKind))
            {
                if (SourceKind != null)
                {
                    writer.WritePropertyName("sourceKind"u8);
                    writer.WriteStringValue(SourceKind.Value.ToString());
                }
                else
                {
                    writer.WriteNull("sourceKind");
                }
            }
            if (Optional.IsDefined(Suspend))
            {
                if (Suspend != null)
                {
                    writer.WritePropertyName("suspend"u8);
                    writer.WriteBooleanValue(Suspend.Value);
                }
                else
                {
                    writer.WriteNull("suspend");
                }
            }
            if (Optional.IsDefined(GitRepository))
            {
                if (GitRepository != null)
                {
                    writer.WritePropertyName("gitRepository"u8);
                    writer.WriteObjectValue(GitRepository);
                }
                else
                {
                    writer.WriteNull("gitRepository");
                }
            }
            if (Optional.IsDefined(Bucket))
            {
                if (Bucket != null)
                {
                    writer.WritePropertyName("bucket"u8);
                    writer.WriteObjectValue(Bucket);
                }
                else
                {
                    writer.WriteNull("bucket");
                }
            }
            if (Optional.IsDefined(AzureBlob))
            {
                if (AzureBlob != null)
                {
                    writer.WritePropertyName("azureBlob"u8);
                    writer.WriteObjectValue(AzureBlob);
                }
                else
                {
                    writer.WriteNull("azureBlob");
                }
            }
            if (Optional.IsCollectionDefined(Kustomizations))
            {
                if (Kustomizations != null)
                {
                    writer.WritePropertyName("kustomizations"u8);
                    writer.WriteStartObject();
                    foreach (var item in Kustomizations)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("kustomizations");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                if (ConfigurationProtectedSettings != null)
                {
                    writer.WritePropertyName("configurationProtectedSettings"u8);
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationProtectedSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationProtectedSettings");
                }
            }
            writer.WriteEndObject();
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

        KubernetesFluxConfigurationPatch IJsonModel<KubernetesFluxConfigurationPatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesFluxConfigurationPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesFluxConfigurationPatch(document.RootElement, options);
        }

        internal static KubernetesFluxConfigurationPatch DeserializeKubernetesFluxConfigurationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KubernetesConfigurationSourceKind?> sourceKind = default;
            Optional<bool?> suspend = default;
            Optional<KubernetesGitRepositoryUpdateContent> gitRepository = default;
            Optional<KubernetesBucketUpdateContent> bucket = default;
            Optional<KubernetesAzureBlobUpdateContent> azureBlob = default;
            Optional<IDictionary<string, KustomizationUpdateContent>> kustomizations = default;
            Optional<IDictionary<string, string>> configurationProtectedSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceKind = null;
                                continue;
                            }
                            sourceKind = new KubernetesConfigurationSourceKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("suspend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                suspend = null;
                                continue;
                            }
                            suspend = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gitRepository"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gitRepository = null;
                                continue;
                            }
                            gitRepository = KubernetesGitRepositoryUpdateContent.DeserializeKubernetesGitRepositoryUpdateContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bucket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                bucket = null;
                                continue;
                            }
                            bucket = KubernetesBucketUpdateContent.DeserializeKubernetesBucketUpdateContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("azureBlob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                azureBlob = null;
                                continue;
                            }
                            azureBlob = KubernetesAzureBlobUpdateContent.DeserializeKubernetesAzureBlobUpdateContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kustomizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kustomizations = null;
                                continue;
                            }
                            Dictionary<string, KustomizationUpdateContent> dictionary = new Dictionary<string, KustomizationUpdateContent>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, KustomizationUpdateContent.DeserializeKustomizationUpdateContent(property1.Value));
                            }
                            kustomizations = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("configurationProtectedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationProtectedSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationProtectedSettings = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesFluxConfigurationPatch(Optional.ToNullable(sourceKind), Optional.ToNullable(suspend), gitRepository.Value, bucket.Value, azureBlob.Value, Optional.ToDictionary(kustomizations), Optional.ToDictionary(configurationProtectedSettings), serializedAdditionalRawData);
        }

        BinaryData IModel<KubernetesFluxConfigurationPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesFluxConfigurationPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KubernetesFluxConfigurationPatch IModel<KubernetesFluxConfigurationPatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesFluxConfigurationPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKubernetesFluxConfigurationPatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<KubernetesFluxConfigurationPatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
