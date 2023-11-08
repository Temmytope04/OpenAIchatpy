// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    [ModelReaderProxy(typeof(UnknownArtifactAccessCredential))]
    public partial class ArtifactAccessCredential : IUtf8JsonSerializable, IJsonModel<ArtifactAccessCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArtifactAccessCredential>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ArtifactAccessCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
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

        ArtifactAccessCredential IJsonModel<ArtifactAccessCredential>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArtifactAccessCredential)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArtifactAccessCredential(document.RootElement, options);
        }

        internal static ArtifactAccessCredential DeserializeArtifactAccessCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("credentialType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureContainerRegistryScopedToken": return AzureContainerRegistryScopedTokenCredential.DeserializeAzureContainerRegistryScopedTokenCredential(element);
                    case "AzureStorageAccountToken": return AzureStorageAccountCredential.DeserializeAzureStorageAccountCredential(element);
                }
            }
            return UnknownArtifactAccessCredential.DeserializeUnknownArtifactAccessCredential(element);
        }

        BinaryData IModel<ArtifactAccessCredential>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArtifactAccessCredential)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ArtifactAccessCredential IModel<ArtifactAccessCredential>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArtifactAccessCredential)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeArtifactAccessCredential(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ArtifactAccessCredential>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
