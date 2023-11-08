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

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PrivateStorePlan : IUtf8JsonSerializable, IJsonModel<PrivateStorePlan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStorePlan>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PrivateStorePlan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SkuId))
                {
                    writer.WritePropertyName("skuId"u8);
                    writer.WriteStringValue(SkuId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PlanId))
                {
                    writer.WritePropertyName("planId"u8);
                    writer.WriteStringValue(PlanId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PlanDisplayName))
                {
                    writer.WritePropertyName("planDisplayName"u8);
                    writer.WriteStringValue(PlanDisplayName);
                }
            }
            if (Optional.IsDefined(Accessibility))
            {
                writer.WritePropertyName("accessibility"u8);
                writer.WriteStringValue(Accessibility.Value.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(AltStackReference))
                {
                    writer.WritePropertyName("altStackReference"u8);
                    writer.WriteStringValue(AltStackReference);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StackType))
                {
                    writer.WritePropertyName("stackType"u8);
                    writer.WriteStringValue(StackType);
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

        PrivateStorePlan IJsonModel<PrivateStorePlan>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStorePlan(document.RootElement, options);
        }

        internal static PrivateStorePlan DeserializePrivateStorePlan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skuId = default;
            Optional<string> planId = default;
            Optional<string> planDisplayName = default;
            Optional<PrivateStorePlanAccessibility> accessibility = default;
            Optional<string> altStackReference = default;
            Optional<string> stackType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessibility = new PrivateStorePlanAccessibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("altStackReference"u8))
                {
                    altStackReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackType"u8))
                {
                    stackType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateStorePlan(skuId.Value, planId.Value, planDisplayName.Value, Optional.ToNullable(accessibility), altStackReference.Value, stackType.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<PrivateStorePlan>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PrivateStorePlan IModel<PrivateStorePlan>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PrivateStorePlan)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePrivateStorePlan(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PrivateStorePlan>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
