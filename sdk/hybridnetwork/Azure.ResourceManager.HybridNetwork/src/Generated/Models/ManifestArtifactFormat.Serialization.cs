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
    public partial class ManifestArtifactFormat : IUtf8JsonSerializable, IJsonModel<ManifestArtifactFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManifestArtifactFormat>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ManifestArtifactFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManifestArtifactFormat>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManifestArtifactFormat>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactName))
            {
                writer.WritePropertyName("artifactName"u8);
                writer.WriteStringValue(ArtifactName);
            }
            if (Optional.IsDefined(ArtifactType))
            {
                writer.WritePropertyName("artifactType"u8);
                writer.WriteStringValue(ArtifactType.Value.ToString());
            }
            if (Optional.IsDefined(ArtifactVersion))
            {
                writer.WritePropertyName("artifactVersion"u8);
                writer.WriteStringValue(ArtifactVersion);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ManifestArtifactFormat IJsonModel<ManifestArtifactFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManifestArtifactFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManifestArtifactFormat(document.RootElement, options);
        }

        internal static ManifestArtifactFormat DeserializeManifestArtifactFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> artifactName = default;
            Optional<ArtifactType> artifactType = default;
            Optional<string> artifactVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactName"u8))
                {
                    artifactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactType = new ArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("artifactVersion"u8))
                {
                    artifactVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManifestArtifactFormat(artifactName.Value, Optional.ToNullable(artifactType), artifactVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManifestArtifactFormat>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManifestArtifactFormat)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManifestArtifactFormat IPersistableModel<ManifestArtifactFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManifestArtifactFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManifestArtifactFormat(document.RootElement, options);
        }

        string IPersistableModel<ManifestArtifactFormat>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
