// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsWatchlistItemData : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsWatchlistItemData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsWatchlistItemData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsWatchlistItemData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WatchlistItemType))
            {
                writer.WritePropertyName("watchlistItemType"u8);
                writer.WriteStringValue(WatchlistItemType);
            }
            if (Optional.IsDefined(WatchlistItemId))
            {
                writer.WritePropertyName("watchlistItemId"u8);
                writer.WriteStringValue(WatchlistItemId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IsDeleted))
            {
                writer.WritePropertyName("isDeleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteObjectValue(CreatedBy);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteObjectValue(UpdatedBy);
            }
            if (Optional.IsDefined(ItemsKeyValue))
            {
                writer.WritePropertyName("itemsKeyValue"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ItemsKeyValue);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ItemsKeyValue.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EntityMapping))
            {
                writer.WritePropertyName("entityMapping"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EntityMapping);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EntityMapping.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SecurityInsightsWatchlistItemData DeserializeSecurityInsightsWatchlistItemData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> watchlistItemType = default;
            Optional<string> watchlistItemId = default;
            Optional<Guid> tenantId = default;
            Optional<bool> isDeleted = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<SecurityInsightsUserInfo> createdBy = default;
            Optional<SecurityInsightsUserInfo> updatedBy = default;
            Optional<BinaryData> itemsKeyValue = default;
            Optional<BinaryData> entityMapping = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("watchlistItemType"u8))
                        {
                            watchlistItemType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistItemId"u8))
                        {
                            watchlistItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isDeleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("itemsKeyValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            itemsKeyValue = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("entityMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            entityMapping = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsWatchlistItemData(id, name, type, systemData.Value, watchlistItemType.Value, watchlistItemId.Value, Optional.ToNullable(tenantId), Optional.ToNullable(isDeleted), Optional.ToNullable(created), Optional.ToNullable(updated), createdBy.Value, updatedBy.Value, itemsKeyValue.Value, entityMapping.Value, Optional.ToNullable(etag), rawData);
        }

        SecurityInsightsWatchlistItemData IModelJsonSerializable<SecurityInsightsWatchlistItemData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsWatchlistItemData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsWatchlistItemData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsWatchlistItemData IModelSerializable<SecurityInsightsWatchlistItemData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsWatchlistItemData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityInsightsWatchlistItemData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityInsightsWatchlistItemData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsWatchlistItemData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
