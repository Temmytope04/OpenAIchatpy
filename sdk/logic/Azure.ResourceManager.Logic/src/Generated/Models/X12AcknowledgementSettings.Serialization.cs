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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12AcknowledgementSettings : IUtf8JsonSerializable, IJsonModel<X12AcknowledgementSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12AcknowledgementSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<X12AcknowledgementSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<X12AcknowledgementSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<X12AcknowledgementSettings>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("needTechnicalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedTechnicalAcknowledgement);
            writer.WritePropertyName("batchTechnicalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchTechnicalAcknowledgement);
            writer.WritePropertyName("needFunctionalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedFunctionalAcknowledgement);
            if (Optional.IsDefined(FunctionalAcknowledgementVersion))
            {
                writer.WritePropertyName("functionalAcknowledgementVersion"u8);
                writer.WriteStringValue(FunctionalAcknowledgementVersion);
            }
            writer.WritePropertyName("batchFunctionalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchFunctionalAcknowledgement);
            writer.WritePropertyName("needImplementationAcknowledgement"u8);
            writer.WriteBooleanValue(NeedImplementationAcknowledgement);
            if (Optional.IsDefined(ImplementationAcknowledgementVersion))
            {
                writer.WritePropertyName("implementationAcknowledgementVersion"u8);
                writer.WriteStringValue(ImplementationAcknowledgementVersion);
            }
            writer.WritePropertyName("batchImplementationAcknowledgements"u8);
            writer.WriteBooleanValue(BatchImplementationAcknowledgement);
            writer.WritePropertyName("needLoopForValidMessages"u8);
            writer.WriteBooleanValue(NeedLoopForValidMessages);
            writer.WritePropertyName("sendSynchronousAcknowledgement"u8);
            writer.WriteBooleanValue(SendSynchronousAcknowledgement);
            if (Optional.IsDefined(AcknowledgementControlNumberPrefix))
            {
                writer.WritePropertyName("acknowledgementControlNumberPrefix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberPrefix);
            }
            if (Optional.IsDefined(AcknowledgementControlNumberSuffix))
            {
                writer.WritePropertyName("acknowledgementControlNumberSuffix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberSuffix);
            }
            writer.WritePropertyName("acknowledgementControlNumberLowerBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberLowerBound);
            writer.WritePropertyName("acknowledgementControlNumberUpperBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberUpperBound);
            writer.WritePropertyName("rolloverAcknowledgementControlNumber"u8);
            writer.WriteBooleanValue(RolloverAcknowledgementControlNumber);
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

        X12AcknowledgementSettings IJsonModel<X12AcknowledgementSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12AcknowledgementSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12AcknowledgementSettings(document.RootElement, options);
        }

        internal static X12AcknowledgementSettings DeserializeX12AcknowledgementSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool needTechnicalAcknowledgement = default;
            bool batchTechnicalAcknowledgements = default;
            bool needFunctionalAcknowledgement = default;
            Optional<string> functionalAcknowledgementVersion = default;
            bool batchFunctionalAcknowledgements = default;
            bool needImplementationAcknowledgement = default;
            Optional<string> implementationAcknowledgementVersion = default;
            bool batchImplementationAcknowledgements = default;
            bool needLoopForValidMessages = default;
            bool sendSynchronousAcknowledgement = default;
            Optional<string> acknowledgementControlNumberPrefix = default;
            Optional<string> acknowledgementControlNumberSuffix = default;
            int acknowledgementControlNumberLowerBound = default;
            int acknowledgementControlNumberUpperBound = default;
            bool rolloverAcknowledgementControlNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("needTechnicalAcknowledgement"u8))
                {
                    needTechnicalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchTechnicalAcknowledgements"u8))
                {
                    batchTechnicalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needFunctionalAcknowledgement"u8))
                {
                    needFunctionalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("functionalAcknowledgementVersion"u8))
                {
                    functionalAcknowledgementVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("batchFunctionalAcknowledgements"u8))
                {
                    batchFunctionalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needImplementationAcknowledgement"u8))
                {
                    needImplementationAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("implementationAcknowledgementVersion"u8))
                {
                    implementationAcknowledgementVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("batchImplementationAcknowledgements"u8))
                {
                    batchImplementationAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needLoopForValidMessages"u8))
                {
                    needLoopForValidMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSynchronousAcknowledgement"u8))
                {
                    sendSynchronousAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberPrefix"u8))
                {
                    acknowledgementControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberSuffix"u8))
                {
                    acknowledgementControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberLowerBound"u8))
                {
                    acknowledgementControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberUpperBound"u8))
                {
                    acknowledgementControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverAcknowledgementControlNumber"u8))
                {
                    rolloverAcknowledgementControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new X12AcknowledgementSettings(needTechnicalAcknowledgement, batchTechnicalAcknowledgements, needFunctionalAcknowledgement, functionalAcknowledgementVersion.Value, batchFunctionalAcknowledgements, needImplementationAcknowledgement, implementationAcknowledgementVersion.Value, batchImplementationAcknowledgements, needLoopForValidMessages, sendSynchronousAcknowledgement, acknowledgementControlNumberPrefix.Value, acknowledgementControlNumberSuffix.Value, acknowledgementControlNumberLowerBound, acknowledgementControlNumberUpperBound, rolloverAcknowledgementControlNumber, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12AcknowledgementSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12AcknowledgementSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        X12AcknowledgementSettings IPersistableModel<X12AcknowledgementSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12AcknowledgementSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeX12AcknowledgementSettings(document.RootElement, options);
        }

        string IPersistableModel<X12AcknowledgementSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
