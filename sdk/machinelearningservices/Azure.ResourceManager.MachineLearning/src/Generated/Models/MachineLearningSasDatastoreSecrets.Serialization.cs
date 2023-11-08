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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSasDatastoreSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningSasDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSasDatastoreSecrets>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningSasDatastoreSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken"u8);
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
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

        MachineLearningSasDatastoreSecrets IJsonModel<MachineLearningSasDatastoreSecrets>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSasDatastoreSecrets(document.RootElement, options);
        }

        internal static MachineLearningSasDatastoreSecrets DeserializeMachineLearningSasDatastoreSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sasToken = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasToken = null;
                        continue;
                    }
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSasDatastoreSecrets(secretsType, serializedAdditionalRawData, sasToken.Value);
        }

        BinaryData IModel<MachineLearningSasDatastoreSecrets>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningSasDatastoreSecrets IModel<MachineLearningSasDatastoreSecrets>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningSasDatastoreSecrets)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningSasDatastoreSecrets(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningSasDatastoreSecrets>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
