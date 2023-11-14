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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCve : IUtf8JsonSerializable, IJsonModel<FirmwareCve>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirmwareCve>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FirmwareCve>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FirmwareCve>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FirmwareCve>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CveId))
            {
                if (CveId != null)
                {
                    writer.WritePropertyName("cveId"u8);
                    writer.WriteStringValue(CveId);
                }
                else
                {
                    writer.WriteNull("cveId");
                }
            }
            if (Optional.IsDefined(Component))
            {
                writer.WritePropertyName("component"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Component);
#else
                using (JsonDocument document = JsonDocument.Parse(Component))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Severity))
            {
                if (Severity != null)
                {
                    writer.WritePropertyName("severity"u8);
                    writer.WriteStringValue(Severity);
                }
                else
                {
                    writer.WriteNull("severity");
                }
            }
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Optional.IsDefined(CvssScore))
            {
                if (CvssScore != null)
                {
                    writer.WritePropertyName("cvssScore"u8);
                    writer.WriteStringValue(CvssScore);
                }
                else
                {
                    writer.WriteNull("cvssScore");
                }
            }
            if (Optional.IsDefined(CvssVersion))
            {
                if (CvssVersion != null)
                {
                    writer.WritePropertyName("cvssVersion"u8);
                    writer.WriteStringValue(CvssVersion);
                }
                else
                {
                    writer.WriteNull("cvssVersion");
                }
            }
            if (Optional.IsDefined(CvssV2Score))
            {
                if (CvssV2Score != null)
                {
                    writer.WritePropertyName("cvssV2Score"u8);
                    writer.WriteStringValue(CvssV2Score);
                }
                else
                {
                    writer.WriteNull("cvssV2Score");
                }
            }
            if (Optional.IsDefined(CvssV3Score))
            {
                if (CvssV3Score != null)
                {
                    writer.WritePropertyName("cvssV3Score"u8);
                    writer.WriteStringValue(CvssV3Score);
                }
                else
                {
                    writer.WriteNull("cvssV3Score");
                }
            }
            if (Optional.IsDefined(PublishOn))
            {
                writer.WritePropertyName("publishDate"u8);
                writer.WriteStringValue(PublishOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedDate"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Links))
                {
                    writer.WritePropertyName("links"u8);
                    writer.WriteStartArray();
                    foreach (var item in Links)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        FirmwareCve IJsonModel<FirmwareCve>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCve)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCve(document.RootElement, options);
        }

        internal static FirmwareCve DeserializeFirmwareCve(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cveId = default;
            Optional<BinaryData> component = default;
            Optional<string> severity = default;
            Optional<string> name = default;
            Optional<string> cvssScore = default;
            Optional<string> cvssVersion = default;
            Optional<string> cvssV2Score = default;
            Optional<string> cvssV3Score = default;
            Optional<DateTimeOffset> publishDate = default;
            Optional<DateTimeOffset> updatedDate = default;
            Optional<IReadOnlyList<CveLink>> links = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cveId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cveId = null;
                        continue;
                    }
                    cveId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    component = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        severity = null;
                        continue;
                    }
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvssScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvssScore = null;
                        continue;
                    }
                    cvssScore = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvssVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvssVersion = null;
                        continue;
                    }
                    cvssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvssV2Score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvssV2Score = null;
                        continue;
                    }
                    cvssV2Score = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvssV3Score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvssV3Score = null;
                        continue;
                    }
                    cvssV3Score = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CveLink> array = new List<CveLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CveLink.DeserializeCveLink(item));
                    }
                    links = array;
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirmwareCve(cveId.Value, component.Value, severity.Value, name.Value, cvssScore.Value, cvssVersion.Value, cvssV2Score.Value, cvssV3Score.Value, Optional.ToNullable(publishDate), Optional.ToNullable(updatedDate), Optional.ToList(links), description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirmwareCve>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCve)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirmwareCve IPersistableModel<FirmwareCve>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCve)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirmwareCve(document.RootElement, options);
        }

        string IPersistableModel<FirmwareCve>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
