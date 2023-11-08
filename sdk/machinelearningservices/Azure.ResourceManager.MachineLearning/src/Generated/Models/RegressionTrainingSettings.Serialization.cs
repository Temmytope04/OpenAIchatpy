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
    public partial class RegressionTrainingSettings : IUtf8JsonSerializable, IJsonModel<RegressionTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegressionTrainingSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RegressionTrainingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedTrainingAlgorithms))
            {
                if (AllowedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("allowedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedTrainingAlgorithms");
                }
            }
            if (Optional.IsCollectionDefined(BlockedTrainingAlgorithms))
            {
                if (BlockedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("blockedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTrainingAlgorithms");
                }
            }
            if (Optional.IsDefined(IsDnnTrainingEnabled))
            {
                writer.WritePropertyName("enableDnnTraining"u8);
                writer.WriteBooleanValue(IsDnnTrainingEnabled.Value);
            }
            if (Optional.IsDefined(IsModelExplainabilityEnabled))
            {
                writer.WritePropertyName("enableModelExplainability"u8);
                writer.WriteBooleanValue(IsModelExplainabilityEnabled.Value);
            }
            if (Optional.IsDefined(IsOnnxCompatibleModelsEnabled))
            {
                writer.WritePropertyName("enableOnnxCompatibleModels"u8);
                writer.WriteBooleanValue(IsOnnxCompatibleModelsEnabled.Value);
            }
            if (Optional.IsDefined(IsStackEnsembleEnabled))
            {
                writer.WritePropertyName("enableStackEnsemble"u8);
                writer.WriteBooleanValue(IsStackEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(IsVoteEnsembleEnabled))
            {
                writer.WritePropertyName("enableVoteEnsemble"u8);
                writer.WriteBooleanValue(IsVoteEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(EnsembleModelDownloadTimeout))
            {
                writer.WritePropertyName("ensembleModelDownloadTimeout"u8);
                writer.WriteStringValue(EnsembleModelDownloadTimeout.Value, "P");
            }
            if (Optional.IsDefined(StackEnsembleSettings))
            {
                if (StackEnsembleSettings != null)
                {
                    writer.WritePropertyName("stackEnsembleSettings"u8);
                    writer.WriteObjectValue(StackEnsembleSettings);
                }
                else
                {
                    writer.WriteNull("stackEnsembleSettings");
                }
            }
            if (Optional.IsDefined(TrainingMode))
            {
                writer.WritePropertyName("trainingMode"u8);
                writer.WriteStringValue(TrainingMode.Value.ToString());
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

        RegressionTrainingSettings IJsonModel<RegressionTrainingSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegressionTrainingSettings(document.RootElement, options);
        }

        internal static RegressionTrainingSettings DeserializeRegressionTrainingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AutoMLVerticalRegressionModel>> allowedTrainingAlgorithms = default;
            Optional<IList<AutoMLVerticalRegressionModel>> blockedTrainingAlgorithms = default;
            Optional<bool> enableDnnTraining = default;
            Optional<bool> enableModelExplainability = default;
            Optional<bool> enableOnnxCompatibleModels = default;
            Optional<bool> enableStackEnsemble = default;
            Optional<bool> enableVoteEnsemble = default;
            Optional<TimeSpan> ensembleModelDownloadTimeout = default;
            Optional<MachineLearningStackEnsembleSettings> stackEnsembleSettings = default;
            Optional<TrainingMode> trainingMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    allowedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("blockedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    blockedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("trainingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingMode = new TrainingMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegressionTrainingSettings(Optional.ToNullable(enableDnnTraining), Optional.ToNullable(enableModelExplainability), Optional.ToNullable(enableOnnxCompatibleModels), Optional.ToNullable(enableStackEnsemble), Optional.ToNullable(enableVoteEnsemble), Optional.ToNullable(ensembleModelDownloadTimeout), stackEnsembleSettings.Value, Optional.ToNullable(trainingMode), serializedAdditionalRawData, Optional.ToList(allowedTrainingAlgorithms), Optional.ToList(blockedTrainingAlgorithms));
        }

        BinaryData IModel<RegressionTrainingSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RegressionTrainingSettings IModel<RegressionTrainingSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRegressionTrainingSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RegressionTrainingSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
