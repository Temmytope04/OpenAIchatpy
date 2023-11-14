// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownContentKeyPolicyPlayReadyContentKeyLocation))]
    public partial class ContentKeyPolicyPlayReadyContentKeyLocation : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyPlayReadyContentKeyLocation IJsonModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyContentKeyLocation(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyContentKeyLocation DeserializeContentKeyPolicyPlayReadyContentKeyLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader": return ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader.DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader(element);
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier": return ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier.DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(element);
                }
            }
            return UnknownContentKeyPolicyPlayReadyContentKeyLocation.DeserializeUnknownContentKeyPolicyPlayReadyContentKeyLocation(element);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContentKeyPolicyPlayReadyContentKeyLocation IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentKeyLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyContentKeyLocation(document.RootElement, options);
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyContentKeyLocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
