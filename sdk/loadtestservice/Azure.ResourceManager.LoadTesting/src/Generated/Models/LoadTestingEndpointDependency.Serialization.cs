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

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingEndpointDependency : IUtf8JsonSerializable, IJsonModel<LoadTestingEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestingEndpointDependency>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LoadTestingEndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LoadTestingEndpointDependency>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LoadTestingEndpointDependency>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DomainName))
                {
                    writer.WritePropertyName("domainName"u8);
                    writer.WriteStringValue(DomainName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Description))
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(EndpointDetails))
                {
                    writer.WritePropertyName("endpointDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in EndpointDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        LoadTestingEndpointDependency IJsonModel<LoadTestingEndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadTestingEndpointDependency)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingEndpointDependency(document.RootElement, options);
        }

        internal static LoadTestingEndpointDependency DeserializeLoadTestingEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainName = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<LoadTestingEndpointDetail>> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingEndpointDetail> array = new List<LoadTestingEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingEndpointDetail.DeserializeLoadTestingEndpointDetail(item));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadTestingEndpointDependency(domainName.Value, description.Value, Optional.ToList(endpointDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestingEndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadTestingEndpointDependency)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LoadTestingEndpointDependency IPersistableModel<LoadTestingEndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadTestingEndpointDependency)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLoadTestingEndpointDependency(document.RootElement, options);
        }

        string IPersistableModel<LoadTestingEndpointDependency>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
