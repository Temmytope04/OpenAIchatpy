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
    public partial class BanditPolicy : IUtf8JsonSerializable, IJsonModel<BanditPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BanditPolicy>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BanditPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SlackAmount))
            {
                writer.WritePropertyName("slackAmount"u8);
                writer.WriteNumberValue(SlackAmount.Value);
            }
            if (Optional.IsDefined(SlackFactor))
            {
                writer.WritePropertyName("slackFactor"u8);
                writer.WriteNumberValue(SlackFactor.Value);
            }
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation"u8);
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        BanditPolicy IJsonModel<BanditPolicy>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BanditPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBanditPolicy(document.RootElement, options);
        }

        internal static BanditPolicy DeserializeBanditPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> slackAmount = default;
            Optional<float> slackFactor = default;
            Optional<int> delayEvaluation = default;
            Optional<int> evaluationInterval = default;
            EarlyTerminationPolicyType policyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slackAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slackAmount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("slackFactor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slackFactor = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("delayEvaluation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"u8))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BanditPolicy(Optional.ToNullable(delayEvaluation), Optional.ToNullable(evaluationInterval), policyType, serializedAdditionalRawData, Optional.ToNullable(slackAmount), Optional.ToNullable(slackFactor));
        }

        BinaryData IModel<BanditPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BanditPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BanditPolicy IModel<BanditPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BanditPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBanditPolicy(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BanditPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
