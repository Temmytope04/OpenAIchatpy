// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownDistributionConfiguration))]
    public partial class MachineLearningDistributionConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningDistributionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDistributionConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningDistributionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningDistributionConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningDistributionConfiguration>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("distributionType"u8);
            writer.WriteStringValue(DistributionType.ToString());
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

        MachineLearningDistributionConfiguration IJsonModel<MachineLearningDistributionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDistributionConfiguration(document.RootElement, options);
        }

        internal static MachineLearningDistributionConfiguration DeserializeMachineLearningDistributionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("distributionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Mpi": return MpiDistributionConfiguration.DeserializeMpiDistributionConfiguration(element);
                    case "PyTorch": return PyTorchDistributionConfiguration.DeserializePyTorchDistributionConfiguration(element);
                    case "Ray": return RayDistributionConfiguration.DeserializeRayDistributionConfiguration(element);
                    case "TensorFlow": return TensorFlowDistributionConfiguration.DeserializeTensorFlowDistributionConfiguration(element);
                }
            }
            return UnknownDistributionConfiguration.DeserializeUnknownDistributionConfiguration(element);
        }

        BinaryData IPersistableModel<MachineLearningDistributionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningDistributionConfiguration IPersistableModel<MachineLearningDistributionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningDistributionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningDistributionConfiguration(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningDistributionConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
