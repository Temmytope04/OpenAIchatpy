// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class OAuth2AuthTypeWorkspaceConnectionProperties : IUtf8JsonSerializable, IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByWorkspaceArmId))
            {
                writer.WritePropertyName("createdByWorkspaceArmId"u8);
                writer.WriteStringValue(CreatedByWorkspaceArmId);
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group.Value.ToString());
            }
            if (Optional.IsDefined(IsSharedToAll))
            {
                writer.WritePropertyName("isSharedToAll"u8);
                writer.WriteBooleanValue(IsSharedToAll.Value);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SharedUserList))
            {
                writer.WritePropertyName("sharedUserList"u8);
                writer.WriteStartArray();
                foreach (var item in SharedUserList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ValueFormat))
            {
                writer.WritePropertyName("valueFormat"u8);
                writer.WriteStringValue(ValueFormat.Value.ToString());
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

        OAuth2AuthTypeWorkspaceConnectionProperties IJsonModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(document.RootElement, options);
        }

        internal static OAuth2AuthTypeWorkspaceConnectionProperties DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WorkspaceConnectionOAuth2 credentials = default;
            MachineLearningConnectionAuthType authType = default;
            MachineLearningConnectionCategory? category = default;
            ResourceIdentifier createdByWorkspaceArmId = default;
            DateTimeOffset? expiryTime = default;
            WorkspaceConnectionGroup? group = default;
            bool? isSharedToAll = default;
            string target = default;
            IDictionary<string, string> metadata = default;
            IList<string> sharedUserList = default;
            string value = default;
            MachineLearningValueFormat? valueFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = WorkspaceConnectionOAuth2.DeserializeWorkspaceConnectionOAuth2(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdByWorkspaceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByWorkspaceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    group = new WorkspaceConnectionGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSharedToAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSharedToAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
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
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("sharedUserList"u8))
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
                    sharedUserList = array;
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFormat = new MachineLearningValueFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OAuth2AuthTypeWorkspaceConnectionProperties(
                authType,
                category,
                createdByWorkspaceArmId,
                expiryTime,
                group,
                isSharedToAll,
                target,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                sharedUserList ?? new ChangeTrackingList<string>(),
                value,
                valueFormat,
                serializedAdditionalRawData,
                credentials);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credentials))
                {
                    builder.Append("  credentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credentials, options, 2, false, "  credentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  authType: ");
                builder.AppendLine($"'{AuthType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Category), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  category: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Category))
                {
                    builder.Append("  category: ");
                    builder.AppendLine($"'{Category.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedByWorkspaceArmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createdByWorkspaceArmId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedByWorkspaceArmId))
                {
                    builder.Append("  createdByWorkspaceArmId: ");
                    builder.AppendLine($"'{CreatedByWorkspaceArmId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpiryOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiryTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpiryOn))
                {
                    builder.Append("  expiryTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpiryOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Group), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  group: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Group))
                {
                    builder.Append("  group: ");
                    builder.AppendLine($"'{Group.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSharedToAll), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSharedToAll: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSharedToAll))
                {
                    builder.Append("  isSharedToAll: ");
                    var boolValue = IsSharedToAll.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    if (Target.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Target}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Target}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metadata), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metadata: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Metadata))
                {
                    if (Metadata.Any())
                    {
                        builder.Append("  metadata: ");
                        builder.AppendLine("{");
                        foreach (var item in Metadata)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SharedUserList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sharedUserList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SharedUserList))
                {
                    if (SharedUserList.Any())
                    {
                        builder.Append("  sharedUserList: ");
                        builder.AppendLine("[");
                        foreach (var item in SharedUserList)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Value))
                {
                    builder.Append("  value: ");
                    if (Value.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Value}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Value}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValueFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  valueFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValueFormat))
                {
                    builder.Append("  valueFormat: ");
                    builder.AppendLine($"'{ValueFormat.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OAuth2AuthTypeWorkspaceConnectionProperties IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOAuth2AuthTypeWorkspaceConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OAuth2AuthTypeWorkspaceConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OAuth2AuthTypeWorkspaceConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
