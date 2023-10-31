// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(FtpReadSettingsConverter))]
    public partial class FtpReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive"u8);
                writer.WriteObjectValue(Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath"u8);
                writer.WriteObjectValue(WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName"u8);
                writer.WriteObjectValue(WildcardFileName);
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                writer.WriteObjectValue(EnablePartitionDiscovery);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath"u8);
                writer.WriteObjectValue(PartitionRootPath);
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion"u8);
                writer.WriteObjectValue(DeleteFilesAfterCompletion);
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath"u8);
                writer.WriteObjectValue(FileListPath);
            }
            if (Optional.IsDefined(UseBinaryTransfer))
            {
                writer.WritePropertyName("useBinaryTransfer"u8);
                writer.WriteObjectValue(UseBinaryTransfer);
            }
            if (Optional.IsDefined(DisableChunking))
            {
                writer.WritePropertyName("disableChunking"u8);
                writer.WriteObjectValue(DisableChunking);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static FtpReadSettings DeserializeFtpReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> recursive = default;
            Optional<object> wildcardFolderPath = default;
            Optional<object> wildcardFileName = default;
            Optional<object> enablePartitionDiscovery = default;
            Optional<object> partitionRootPath = default;
            Optional<object> deleteFilesAfterCompletion = default;
            Optional<object> fileListPath = default;
            Optional<object> useBinaryTransfer = default;
            Optional<object> disableChunking = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recursive = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFolderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFileName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteFilesAfterCompletion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileListPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileListPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("useBinaryTransfer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useBinaryTransfer = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("disableChunking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableChunking = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FtpReadSettings(type, maxConcurrentConnections.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, enablePartitionDiscovery.Value, partitionRootPath.Value, deleteFilesAfterCompletion.Value, fileListPath.Value, useBinaryTransfer.Value, disableChunking.Value);
        }

        internal partial class FtpReadSettingsConverter : JsonConverter<FtpReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, FtpReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override FtpReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFtpReadSettings(document.RootElement);
            }
        }
    }
}
