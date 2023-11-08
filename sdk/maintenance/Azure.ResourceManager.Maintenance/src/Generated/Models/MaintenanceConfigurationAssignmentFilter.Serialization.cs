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

namespace Azure.ResourceManager.Maintenance.Models
{
    public partial class MaintenanceConfigurationAssignmentFilter : IUtf8JsonSerializable, IJsonModel<MaintenanceConfigurationAssignmentFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceConfigurationAssignmentFilter>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MaintenanceConfigurationAssignmentFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceGroups))
            {
                writer.WritePropertyName("resourceGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OSTypes))
            {
                writer.WritePropertyName("osTypes"u8);
                writer.WriteStartArray();
                foreach (var item in OSTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TagSettings))
            {
                writer.WritePropertyName("tagSettings"u8);
                writer.WriteObjectValue(TagSettings);
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

        MaintenanceConfigurationAssignmentFilter IJsonModel<MaintenanceConfigurationAssignmentFilter>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceConfigurationAssignmentFilter(document.RootElement, options);
        }

        internal static MaintenanceConfigurationAssignmentFilter DeserializeMaintenanceConfigurationAssignmentFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ResourceType>> resourceTypes = default;
            Optional<IList<string>> resourceGroups = default;
            Optional<IList<string>> osTypes = default;
            Optional<IList<AzureLocation>> locations = default;
            Optional<VmTagSettings> tagSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceType> array = new List<ResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ResourceType(item.GetString()));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("resourceGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGroups = array;
                    continue;
                }
                if (property.NameEquals("osTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    osTypes = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("tagSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagSettings = VmTagSettings.DeserializeVmTagSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaintenanceConfigurationAssignmentFilter(Optional.ToList(resourceTypes), Optional.ToList(resourceGroups), Optional.ToList(osTypes), Optional.ToList(locations), tagSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<MaintenanceConfigurationAssignmentFilter>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MaintenanceConfigurationAssignmentFilter IModel<MaintenanceConfigurationAssignmentFilter>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MaintenanceConfigurationAssignmentFilter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMaintenanceConfigurationAssignmentFilter(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MaintenanceConfigurationAssignmentFilter>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
