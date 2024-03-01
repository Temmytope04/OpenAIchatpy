// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceCreatedBy : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceCreatedBy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceCreatedBy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeInstanceCreatedBy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && UserName != null)
            {
                if (UserName != null)
                {
                    writer.WritePropertyName("userName"u8);
                    writer.WriteStringValue(UserName);
                }
                else
                {
                    writer.WriteNull("userName");
                }
            }
            if (options.Format != "W" && UserOrgId != null)
            {
                writer.WritePropertyName("userOrgId"u8);
                writer.WriteStringValue(UserOrgId);
            }
            if (options.Format != "W" && UserId != null)
            {
                if (UserId != null)
                {
                    writer.WritePropertyName("userId"u8);
                    writer.WriteStringValue(UserId);
                }
                else
                {
                    writer.WriteNull("userId");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        MachineLearningComputeInstanceCreatedBy IJsonModel<MachineLearningComputeInstanceCreatedBy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceCreatedBy(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceCreatedBy DeserializeMachineLearningComputeInstanceCreatedBy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userName = default;
            string userOrgId = default;
            string userId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userName = null;
                        continue;
                    }
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userOrgId"u8))
                {
                    userOrgId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userId = null;
                        continue;
                    }
                    userId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningComputeInstanceCreatedBy(userName, userOrgId, userId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningComputeInstanceCreatedBy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeInstanceCreatedBy IPersistableModel<MachineLearningComputeInstanceCreatedBy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeInstanceCreatedBy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeInstanceCreatedBy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
