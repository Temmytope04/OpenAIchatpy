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
    [PersistableModelProxy(typeof(UnknownContentKeyPolicyRestrictionTokenKey))]
    public partial class ContentKeyPolicyRestrictionTokenKey : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyRestrictionTokenKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyRestrictionTokenKey>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContentKeyPolicyRestrictionTokenKey>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContentKeyPolicyRestrictionTokenKey>)} interface");
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

        ContentKeyPolicyRestrictionTokenKey IJsonModel<ContentKeyPolicyRestrictionTokenKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
        }

        internal static ContentKeyPolicyRestrictionTokenKey DeserializeContentKeyPolicyRestrictionTokenKey(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "#Microsoft.Media.ContentKeyPolicyRsaTokenKey": return ContentKeyPolicyRsaTokenKey.DeserializeContentKeyPolicyRsaTokenKey(element);
                    case "#Microsoft.Media.ContentKeyPolicySymmetricTokenKey": return ContentKeyPolicySymmetricTokenKey.DeserializeContentKeyPolicySymmetricTokenKey(element);
                    case "#Microsoft.Media.ContentKeyPolicyX509CertificateTokenKey": return ContentKeyPolicyX509CertificateTokenKey.DeserializeContentKeyPolicyX509CertificateTokenKey(element);
                }
            }
            return UnknownContentKeyPolicyRestrictionTokenKey.DeserializeUnknownContentKeyPolicyRestrictionTokenKey(element);
        }

        BinaryData IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContentKeyPolicyRestrictionTokenKey IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyRestrictionTokenKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyRestrictionTokenKey(document.RootElement, options);
        }

        string IPersistableModel<ContentKeyPolicyRestrictionTokenKey>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
