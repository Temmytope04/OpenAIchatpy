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
    internal partial class UnknownConfigurationGroupValuePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupValuePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupValuePropertiesFormat>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ConfigurationGroupValuePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PublisherName))
                {
                    writer.WritePropertyName("publisherName"u8);
                    writer.WriteStringValue(PublisherName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PublisherScope))
                {
                    writer.WritePropertyName("publisherScope"u8);
                    writer.WriteStringValue(PublisherScope.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ConfigurationGroupSchemaName))
                {
                    writer.WritePropertyName("configurationGroupSchemaName"u8);
                    writer.WriteStringValue(ConfigurationGroupSchemaName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ConfigurationGroupSchemaOfferingLocation))
                {
                    writer.WritePropertyName("configurationGroupSchemaOfferingLocation"u8);
                    writer.WriteStringValue(ConfigurationGroupSchemaOfferingLocation);
                }
            }
            if (Optional.IsDefined(ConfigurationGroupSchemaResourceReference))
            {
                writer.WritePropertyName("configurationGroupSchemaResourceReference"u8);
                writer.WriteObjectValue(ConfigurationGroupSchemaResourceReference);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        ConfigurationGroupValuePropertiesFormat IJsonModel<ConfigurationGroupValuePropertiesFormat>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        internal static UnknownConfigurationGroupValuePropertiesFormat DeserializeUnknownConfigurationGroupValuePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> configurationGroupSchemaName = default;
            Optional<string> configurationGroupSchemaOfferingLocation = default;
            Optional<DeploymentResourceIdReference> configurationGroupSchemaResourceReference = default;
            ConfigurationGroupValueConfigurationType configurationType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaName"u8))
                {
                    configurationGroupSchemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaOfferingLocation"u8))
                {
                    configurationGroupSchemaOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationGroupSchemaResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationGroupValueConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownConfigurationGroupValuePropertiesFormat(Optional.ToNullable(provisioningState), publisherName.Value, Optional.ToNullable(publisherScope), configurationGroupSchemaName.Value, configurationGroupSchemaOfferingLocation.Value, configurationGroupSchemaResourceReference.Value, configurationType, serializedAdditionalRawData);
        }

        BinaryData IModel<ConfigurationGroupValuePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConfigurationGroupValuePropertiesFormat IModel<ConfigurationGroupValuePropertiesFormat>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUnknownConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ConfigurationGroupValuePropertiesFormat>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
