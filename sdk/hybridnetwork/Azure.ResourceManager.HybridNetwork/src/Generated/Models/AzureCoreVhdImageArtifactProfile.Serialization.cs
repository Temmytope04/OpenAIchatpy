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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureCoreVhdImageArtifactProfile : IUtf8JsonSerializable, IJsonModel<AzureCoreVhdImageArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCoreVhdImageArtifactProfile>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AzureCoreVhdImageArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VhdArtifactProfile))
            {
                writer.WritePropertyName("vhdArtifactProfile"u8);
                writer.WriteObjectValue(VhdArtifactProfile);
            }
            if (Optional.IsDefined(ArtifactStore))
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
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

        AzureCoreVhdImageArtifactProfile IJsonModel<AzureCoreVhdImageArtifactProfile>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCoreVhdImageArtifactProfile(document.RootElement, options);
        }

        internal static AzureCoreVhdImageArtifactProfile DeserializeAzureCoreVhdImageArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VhdImageArtifactProfile> vhdArtifactProfile = default;
            Optional<WritableSubResource> artifactStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vhdArtifactProfile = VhdImageArtifactProfile.DeserializeVhdImageArtifactProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCoreVhdImageArtifactProfile(artifactStore, serializedAdditionalRawData, vhdArtifactProfile.Value);
        }

        BinaryData IModel<AzureCoreVhdImageArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureCoreVhdImageArtifactProfile IModel<AzureCoreVhdImageArtifactProfile>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageArtifactProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureCoreVhdImageArtifactProfile(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AzureCoreVhdImageArtifactProfile>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
