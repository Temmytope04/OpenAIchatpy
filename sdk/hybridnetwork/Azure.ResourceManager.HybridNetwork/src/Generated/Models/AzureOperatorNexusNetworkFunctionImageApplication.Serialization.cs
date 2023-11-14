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

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusNetworkFunctionImageApplication : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactProfile))
            {
                writer.WritePropertyName("artifactProfile"u8);
                writer.WriteObjectValue(ArtifactProfile);
            }
            if (Optional.IsDefined(DeployParametersMappingRuleProfile))
            {
                writer.WritePropertyName("deployParametersMappingRuleProfile"u8);
                writer.WriteObjectValue(DeployParametersMappingRuleProfile);
            }
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
            }
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

        AzureOperatorNexusNetworkFunctionImageApplication IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
        }

        internal static AzureOperatorNexusNetworkFunctionImageApplication DeserializeAzureOperatorNexusNetworkFunctionImageApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureOperatorNexusImageArtifactProfile> artifactProfile = default;
            Optional<AzureOperatorNexusImageDeployMappingRuleProfile> deployParametersMappingRuleProfile = default;
            AzureOperatorNexusArtifactType artifactType = default;
            Optional<string> name = default;
            Optional<DependsOnProfile> dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactProfile = AzureOperatorNexusImageArtifactProfile.DeserializeAzureOperatorNexusImageArtifactProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("deployParametersMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployParametersMappingRuleProfile = AzureOperatorNexusImageDeployMappingRuleProfile.DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureOperatorNexusArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureOperatorNexusNetworkFunctionImageApplication(name.Value, dependsOnProfile.Value, serializedAdditionalRawData, artifactType, artifactProfile.Value, deployParametersMappingRuleProfile.Value);
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureOperatorNexusNetworkFunctionImageApplication IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
