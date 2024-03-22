// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class PathRecommendation : IUtf8JsonSerializable, IJsonModel<PathRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PathRecommendation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PathRecommendation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PathRecommendation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(IotSecurityRecommendationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IotSecurityRecommendationType.Value.ToString());
            }
            if (Optional.IsDefined(PublisherInfo))
            {
                writer.WritePropertyName("publisherInfo"u8);
                writer.WriteObjectValue<SecurityCenterPublisherInfo>(PublisherInfo, options);
            }
            if (Optional.IsDefined(IsCommon))
            {
                writer.WritePropertyName("common"u8);
                writer.WriteBooleanValue(IsCommon.Value);
            }
            if (Optional.IsCollectionDefined(UserSids))
            {
                writer.WritePropertyName("userSids"u8);
                writer.WriteStartArray();
                foreach (var item in UserSids)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Usernames))
            {
                writer.WritePropertyName("usernames"u8);
                writer.WriteStartArray();
                foreach (var item in Usernames)
                {
                    writer.WriteObjectValue<UserRecommendation>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FileType))
            {
                writer.WritePropertyName("fileType"u8);
                writer.WriteStringValue(FileType.Value.ToString());
            }
            if (Optional.IsDefined(ConfigurationStatus))
            {
                writer.WritePropertyName("configurationStatus"u8);
                writer.WriteStringValue(ConfigurationStatus.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PathRecommendation IJsonModel<PathRecommendation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PathRecommendation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePathRecommendation(document.RootElement, options);
        }

        internal static PathRecommendation DeserializePathRecommendation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            RecommendationAction? action = default;
            IotSecurityRecommendationType? type = default;
            SecurityCenterPublisherInfo publisherInfo = default;
            bool? common = default;
            IList<string> userSids = default;
            IList<UserRecommendation> usernames = default;
            PathRecommendationFileType? fileType = default;
            SecurityCenterConfigurationStatus? configurationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new RecommendationAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new IotSecurityRecommendationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherInfo = SecurityCenterPublisherInfo.DeserializeSecurityCenterPublisherInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("common"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    common = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userSids"u8))
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
                    userSids = array;
                    continue;
                }
                if (property.NameEquals("usernames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserRecommendation> array = new List<UserRecommendation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserRecommendation.DeserializeUserRecommendation(item, options));
                    }
                    usernames = array;
                    continue;
                }
                if (property.NameEquals("fileType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileType = new PathRecommendationFileType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationStatus = new SecurityCenterConfigurationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PathRecommendation(
                path,
                action,
                type,
                publisherInfo,
                common,
                userSids ?? new ChangeTrackingList<string>(),
                usernames ?? new ChangeTrackingList<UserRecommendation>(),
                fileType,
                configurationStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PathRecommendation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PathRecommendation)} does not support writing '{options.Format}' format.");
            }
        }

        PathRecommendation IPersistableModel<PathRecommendation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePathRecommendation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PathRecommendation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PathRecommendation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
