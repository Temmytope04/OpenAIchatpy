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
    public partial class KubernetesGitRepositoryRef : IUtf8JsonSerializable, IJsonModel<KubernetesGitRepositoryRef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesGitRepositoryRef>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<KubernetesGitRepositoryRef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Branch))
            {
                if (Branch != null)
                {
                    writer.WritePropertyName("branch"u8);
                    writer.WriteStringValue(Branch);
                }
                else
                {
                    writer.WriteNull("branch");
                }
            }
            if (Optional.IsDefined(Tag))
            {
                if (Tag != null)
                {
                    writer.WritePropertyName("tag"u8);
                    writer.WriteStringValue(Tag);
                }
                else
                {
                    writer.WriteNull("tag");
                }
            }
            if (Optional.IsDefined(Semver))
            {
                if (Semver != null)
                {
                    writer.WritePropertyName("semver"u8);
                    writer.WriteStringValue(Semver);
                }
                else
                {
                    writer.WriteNull("semver");
                }
            }
            if (Optional.IsDefined(Commit))
            {
                if (Commit != null)
                {
                    writer.WritePropertyName("commit"u8);
                    writer.WriteStringValue(Commit);
                }
                else
                {
                    writer.WriteNull("commit");
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

        KubernetesGitRepositoryRef IJsonModel<KubernetesGitRepositoryRef>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesGitRepositoryRef(document.RootElement, options);
        }

        internal static KubernetesGitRepositoryRef DeserializeKubernetesGitRepositoryRef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> branch = default;
            Optional<string> tag = default;
            Optional<string> semver = default;
            Optional<string> commit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("branch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        branch = null;
                        continue;
                    }
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tag = null;
                        continue;
                    }
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semver = null;
                        continue;
                    }
                    semver = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        commit = null;
                        continue;
                    }
                    commit = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesGitRepositoryRef(branch.Value, tag.Value, semver.Value, commit.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<KubernetesGitRepositoryRef>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KubernetesGitRepositoryRef IModel<KubernetesGitRepositoryRef>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesGitRepositoryRef)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKubernetesGitRepositoryRef(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<KubernetesGitRepositoryRef>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
