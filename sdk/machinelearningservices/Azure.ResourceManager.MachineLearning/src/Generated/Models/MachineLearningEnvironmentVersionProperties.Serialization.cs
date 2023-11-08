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
    public partial class MachineLearningEnvironmentVersionProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningEnvironmentVersionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEnvironmentVersionProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningEnvironmentVersionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoRebuild))
            {
                writer.WritePropertyName("autoRebuild"u8);
                writer.WriteStringValue(AutoRebuild.Value.ToString());
            }
            if (Optional.IsDefined(Build))
            {
                writer.WritePropertyName("build"u8);
                writer.WriteObjectValue(Build);
            }
            if (Optional.IsDefined(CondaFile))
            {
                writer.WritePropertyName("condaFile"u8);
                writer.WriteStringValue(CondaFile);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EnvironmentType))
                {
                    writer.WritePropertyName("environmentType"u8);
                    writer.WriteStringValue(EnvironmentType.Value.ToString());
                }
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(InferenceConfig))
            {
                writer.WritePropertyName("inferenceConfig"u8);
                writer.WriteObjectValue(InferenceConfig);
            }
            if (Optional.IsDefined(IntellectualProperty))
            {
                if (IntellectualProperty != null)
                {
                    writer.WritePropertyName("intellectualProperty"u8);
                    writer.WriteObjectValue(IntellectualProperty);
                }
                else
                {
                    writer.WriteNull("intellectualProperty");
                }
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Stage))
            {
                if (Stage != null)
                {
                    writer.WritePropertyName("stage"u8);
                    writer.WriteStringValue(Stage);
                }
                else
                {
                    writer.WriteNull("stage");
                }
            }
            if (Optional.IsDefined(AutoDeleteSetting))
            {
                if (AutoDeleteSetting != null)
                {
                    writer.WritePropertyName("autoDeleteSetting"u8);
                    writer.WriteObjectValue(AutoDeleteSetting);
                }
                else
                {
                    writer.WriteNull("autoDeleteSetting");
                }
            }
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
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

        MachineLearningEnvironmentVersionProperties IJsonModel<MachineLearningEnvironmentVersionProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEnvironmentVersionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEnvironmentVersionProperties(document.RootElement, options);
        }

        internal static MachineLearningEnvironmentVersionProperties DeserializeMachineLearningEnvironmentVersionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutoRebuildSetting> autoRebuild = default;
            Optional<MachineLearningBuildContext> build = default;
            Optional<string> condaFile = default;
            Optional<MachineLearningEnvironmentType> environmentType = default;
            Optional<string> image = default;
            Optional<MachineLearningInferenceContainerProperties> inferenceConfig = default;
            Optional<IntellectualProperty> intellectualProperty = default;
            Optional<MachineLearningOperatingSystemType> osType = default;
            Optional<RegistryAssetProvisioningState> provisioningState = default;
            Optional<string> stage = default;
            Optional<AutoDeleteSetting> autoDeleteSetting = default;
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoRebuild"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoRebuild = new AutoRebuildSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("build"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    build = MachineLearningBuildContext.DeserializeMachineLearningBuildContext(property.Value);
                    continue;
                }
                if (property.NameEquals("condaFile"u8))
                {
                    condaFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environmentType = new MachineLearningEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inferenceConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inferenceConfig = MachineLearningInferenceContainerProperties.DeserializeMachineLearningInferenceContainerProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("intellectualProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        intellectualProperty = null;
                        continue;
                    }
                    intellectualProperty = IntellectualProperty.DeserializeIntellectualProperty(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new MachineLearningOperatingSystemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new RegistryAssetProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stage = null;
                        continue;
                    }
                    stage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDeleteSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoDeleteSetting = null;
                        continue;
                    }
                    autoDeleteSetting = AutoDeleteSetting.DeserializeAutoDeleteSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningEnvironmentVersionProperties(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), serializedAdditionalRawData, autoDeleteSetting.Value, Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), Optional.ToNullable(autoRebuild), build.Value, condaFile.Value, Optional.ToNullable(environmentType), image.Value, inferenceConfig.Value, intellectualProperty.Value, Optional.ToNullable(osType), Optional.ToNullable(provisioningState), stage.Value);
        }

        BinaryData IModel<MachineLearningEnvironmentVersionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEnvironmentVersionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningEnvironmentVersionProperties IModel<MachineLearningEnvironmentVersionProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningEnvironmentVersionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningEnvironmentVersionProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningEnvironmentVersionProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
