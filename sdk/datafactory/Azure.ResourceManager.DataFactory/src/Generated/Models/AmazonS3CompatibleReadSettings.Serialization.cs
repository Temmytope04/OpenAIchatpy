// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AmazonS3CompatibleReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Recursive);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Recursive.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WildcardFolderPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WildcardFolderPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WildcardFileName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WildcardFileName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Prefix);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Prefix.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileListPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileListPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery");
                writer.WriteBooleanValue(EnablePartitionDiscovery.Value);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionRootPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionRootPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DeleteFilesAfterCompletion);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DeleteFilesAfterCompletion.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ModifiedDatetimeStart);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ModifiedDatetimeStart.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ModifiedDatetimeEnd);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ModifiedDatetimeEnd.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(StoreReadSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableMetricsCollection);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableMetricsCollection.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AmazonS3CompatibleReadSettings DeserializeAmazonS3CompatibleReadSettings(JsonElement element)
        {
            Optional<BinaryData> recursive = default;
            Optional<BinaryData> wildcardFolderPath = default;
            Optional<BinaryData> wildcardFileName = default;
            Optional<BinaryData> prefix = default;
            Optional<BinaryData> fileListPath = default;
            Optional<bool> enablePartitionDiscovery = default;
            Optional<BinaryData> partitionRootPath = default;
            Optional<BinaryData> deleteFilesAfterCompletion = default;
            Optional<BinaryData> modifiedDatetimeStart = default;
            Optional<BinaryData> modifiedDatetimeEnd = default;
            string type = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            Optional<BinaryData> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recursive = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFolderPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFileName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("prefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prefix = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileListPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileListPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionRootPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteFilesAfterCompletion = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeStart"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedDatetimeStart = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeEnd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedDatetimeEnd = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableMetricsCollection = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonS3CompatibleReadSettings(type, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, prefix.Value, fileListPath.Value, Optional.ToNullable(enablePartitionDiscovery), partitionRootPath.Value, deleteFilesAfterCompletion.Value, modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value);
        }
    }
}
