// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricApplicationTypeVersionData : IUtf8JsonSerializable, IJsonModel<ServiceFabricApplicationTypeVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricApplicationTypeVersionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceFabricApplicationTypeVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AppPackageUri))
            {
                writer.WritePropertyName("appPackageUrl"u8);
                writer.WriteStringValue(AppPackageUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DefaultParameterList))
            {
                writer.WritePropertyName("defaultParameterList"u8);
                writer.WriteStartObject();
                foreach (var item in DefaultParameterList)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        ServiceFabricApplicationTypeVersionData IJsonModel<ServiceFabricApplicationTypeVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricApplicationTypeVersionData(document.RootElement, options);
        }

        internal static ServiceFabricApplicationTypeVersionData DeserializeServiceFabricApplicationTypeVersionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string provisioningState = default;
            Uri appPackageUrl = default;
            IReadOnlyDictionary<string, string> defaultParameterList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appPackageUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appPackageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultParameterList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            defaultParameterList = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServiceFabricApplicationTypeVersionData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                appPackageUrl,
                defaultParameterList ?? new ChangeTrackingDictionary<string, string>(),
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricApplicationTypeVersionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionData)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceFabricApplicationTypeVersionData IPersistableModel<ServiceFabricApplicationTypeVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricApplicationTypeVersionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricApplicationTypeVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
