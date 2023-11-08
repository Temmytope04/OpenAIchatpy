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
    public partial class KubernetesClusterExtensionStatus : IUtf8JsonSerializable, IJsonModel<KubernetesClusterExtensionStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesClusterExtensionStatus>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<KubernetesClusterExtensionStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(DisplayStatus))
            {
                writer.WritePropertyName("displayStatus"u8);
                writer.WriteStringValue(DisplayStatus);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
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

        KubernetesClusterExtensionStatus IJsonModel<KubernetesClusterExtensionStatus>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesClusterExtensionStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterExtensionStatus(document.RootElement, options);
        }

        internal static KubernetesClusterExtensionStatus DeserializeKubernetesClusterExtensionStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> displayStatus = default;
            Optional<KubernetesClusterExtensionStatusLevel> level = default;
            Optional<string> message = default;
            Optional<string> time = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new KubernetesClusterExtensionStatusLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    time = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesClusterExtensionStatus(code.Value, displayStatus.Value, Optional.ToNullable(level), message.Value, time.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<KubernetesClusterExtensionStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesClusterExtensionStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KubernetesClusterExtensionStatus IModel<KubernetesClusterExtensionStatus>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KubernetesClusterExtensionStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKubernetesClusterExtensionStatus(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<KubernetesClusterExtensionStatus>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
