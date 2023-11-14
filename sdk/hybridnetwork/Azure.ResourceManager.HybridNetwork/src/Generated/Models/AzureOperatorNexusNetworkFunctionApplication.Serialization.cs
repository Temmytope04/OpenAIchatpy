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
    public partial class AzureOperatorNexusNetworkFunctionApplication : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionApplication>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AzureOperatorNexusNetworkFunctionApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureOperatorNexusNetworkFunctionApplication>)} interface");
            }

            writer.WriteStartObject();
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

        AzureOperatorNexusNetworkFunctionApplication IJsonModel<AzureOperatorNexusNetworkFunctionApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionApplication(document.RootElement, options);
        }

        internal static AzureOperatorNexusNetworkFunctionApplication DeserializeAzureOperatorNexusNetworkFunctionApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("artifactType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ArmTemplate": return AzureOperatorNexusNetworkFunctionArmTemplateApplication.DeserializeAzureOperatorNexusNetworkFunctionArmTemplateApplication(element);
                    case "ImageFile": return AzureOperatorNexusNetworkFunctionImageApplication.DeserializeAzureOperatorNexusNetworkFunctionImageApplication(element);
                }
            }
            AzureOperatorNexusArtifactType artifactType = default;
            Optional<string> name = default;
            Optional<DependsOnProfile> dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new AzureOperatorNexusNetworkFunctionApplication(name.Value, dependsOnProfile.Value, serializedAdditionalRawData, artifactType);
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureOperatorNexusNetworkFunctionApplication IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureOperatorNexusNetworkFunctionApplication(document.RootElement, options);
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
