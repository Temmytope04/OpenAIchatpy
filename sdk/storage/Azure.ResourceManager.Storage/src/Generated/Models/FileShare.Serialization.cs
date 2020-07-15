// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class FileShare : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LastModifiedTime))
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedTime.Value, "O");
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShareQuota))
            {
                writer.WritePropertyName("shareQuota");
                writer.WriteNumberValue(ShareQuota.Value);
            }
            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols");
                writer.WriteStringValue(EnabledProtocols.Value.ToString());
            }
            if (Optional.IsDefined(RootSquash))
            {
                writer.WritePropertyName("rootSquash");
                writer.WriteStringValue(RootSquash.Value.ToString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Deleted))
            {
                writer.WritePropertyName("deleted");
                writer.WriteBooleanValue(Deleted.Value);
            }
            if (Optional.IsDefined(DeletedTime))
            {
                writer.WritePropertyName("deletedTime");
                writer.WriteStringValue(DeletedTime.Value, "O");
            }
            if (Optional.IsDefined(RemainingRetentionDays))
            {
                writer.WritePropertyName("remainingRetentionDays");
                writer.WriteNumberValue(RemainingRetentionDays.Value);
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToString());
            }
            if (Optional.IsDefined(AccessTierChangeTime))
            {
                writer.WritePropertyName("accessTierChangeTime");
                writer.WriteStringValue(AccessTierChangeTime.Value, "O");
            }
            if (Optional.IsDefined(AccessTierStatus))
            {
                writer.WritePropertyName("accessTierStatus");
                writer.WriteStringValue(AccessTierStatus);
            }
            if (Optional.IsDefined(ShareUsageBytes))
            {
                writer.WritePropertyName("shareUsageBytes");
                writer.WriteNumberValue(ShareUsageBytes.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FileShare DeserializeFileShare(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<int> shareQuota = default;
            Optional<EnabledProtocols> enabledProtocols = default;
            Optional<RootSquashType> rootSquash = default;
            Optional<string> version = default;
            Optional<bool> deleted = default;
            Optional<DateTimeOffset> deletedTime = default;
            Optional<int> remainingRetentionDays = default;
            Optional<ShareAccessTier> accessTier = default;
            Optional<DateTimeOffset> accessTierChangeTime = default;
            Optional<string> accessTierStatus = default;
            Optional<long> shareUsageBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shareQuota"))
                        {
                            shareQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabledProtocols"))
                        {
                            enabledProtocols = new EnabledProtocols(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rootSquash"))
                        {
                            rootSquash = new RootSquashType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleted"))
                        {
                            deleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deletedTime"))
                        {
                            deletedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remainingRetentionDays"))
                        {
                            remainingRetentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            accessTier = new ShareAccessTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accessTierChangeTime"))
                        {
                            accessTierChangeTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessTierStatus"))
                        {
                            accessTierStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareUsageBytes"))
                        {
                            shareUsageBytes = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FileShare(id.Value, name.Value, type.Value, etag.Value, Optional.ToNullable(lastModifiedTime), Optional.ToDictionary(metadata), Optional.ToNullable(shareQuota), Optional.ToNullable(enabledProtocols), Optional.ToNullable(rootSquash), version.Value, Optional.ToNullable(deleted), Optional.ToNullable(deletedTime), Optional.ToNullable(remainingRetentionDays), Optional.ToNullable(accessTier), Optional.ToNullable(accessTierChangeTime), accessTierStatus.Value, Optional.ToNullable(shareUsageBytes));
        }
    }
}
