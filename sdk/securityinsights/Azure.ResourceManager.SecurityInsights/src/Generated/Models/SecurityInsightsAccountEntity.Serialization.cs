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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAccountEntity : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAccountEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAccountEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAccountEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAccountEntity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static SecurityInsightsAccountEntity DeserializeSecurityInsightsAccountEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> aadTenantId = default;
            Optional<string> aadUserId = default;
            Optional<string> accountName = default;
            Optional<string> displayName = default;
            Optional<string> hostEntityId = default;
            Optional<bool> isDomainJoined = default;
            Optional<string> ntDomain = default;
            Optional<Guid> objectGuid = default;
            Optional<string> puid = default;
            Optional<string> sid = default;
            Optional<string> upnSuffix = default;
            Optional<string> dnsDomain = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            aadTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadUserId"u8))
                        {
                            aadUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDomainJoined"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDomainJoined = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ntDomain"u8))
                        {
                            ntDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("objectGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            objectGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("puid"u8))
                        {
                            puid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            sid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("upnSuffix"u8))
                        {
                            upnSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsDomain"u8))
                        {
                            dnsDomain = property0.Value.GetString();
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
            return new SecurityInsightsAccountEntity(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, aadTenantId.Value, aadUserId.Value, accountName.Value, displayName.Value, hostEntityId.Value, Optional.ToNullable(isDomainJoined), ntDomain.Value, Optional.ToNullable(objectGuid), puid.Value, sid.Value, upnSuffix.Value, dnsDomain.Value, rawData);
        }

        SecurityInsightsAccountEntity IModelJsonSerializable<SecurityInsightsAccountEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAccountEntity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAccountEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAccountEntity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAccountEntity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAccountEntity IModelSerializable<SecurityInsightsAccountEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAccountEntity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAccountEntity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityInsightsAccountEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityInsightsAccountEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAccountEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
