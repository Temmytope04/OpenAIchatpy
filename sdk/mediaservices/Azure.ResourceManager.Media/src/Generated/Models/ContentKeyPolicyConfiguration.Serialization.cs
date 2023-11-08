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
    [ModelReaderProxy(typeof(UnknownContentKeyPolicyConfiguration))]
    public partial class ContentKeyPolicyConfiguration : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ContentKeyPolicyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyConfiguration IJsonModel<ContentKeyPolicyConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyConfiguration(document.RootElement, options);
        }

        internal static ContentKeyPolicyConfiguration DeserializeContentKeyPolicyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyClearKeyConfiguration": return ContentKeyPolicyClearKeyConfiguration.DeserializeContentKeyPolicyClearKeyConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyFairPlayConfiguration": return ContentKeyPolicyFairPlayConfiguration.DeserializeContentKeyPolicyFairPlayConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyPlayReadyConfiguration": return ContentKeyPolicyPlayReadyConfiguration.DeserializeContentKeyPolicyPlayReadyConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyUnknownConfiguration": return ContentKeyPolicyUnknownConfiguration.DeserializeContentKeyPolicyUnknownConfiguration(element);
                    case "#Microsoft.Media.ContentKeyPolicyWidevineConfiguration": return ContentKeyPolicyWidevineConfiguration.DeserializeContentKeyPolicyWidevineConfiguration(element);
                }
            }
            return UnknownContentKeyPolicyConfiguration.DeserializeUnknownContentKeyPolicyConfiguration(element);
        }

        BinaryData IModel<ContentKeyPolicyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContentKeyPolicyConfiguration IModel<ContentKeyPolicyConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ContentKeyPolicyConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
