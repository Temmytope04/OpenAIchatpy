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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountPatch : IUtf8JsonSerializable, IModelJsonSerializable<StorageAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageAccountPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageAccountPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomDomain))
            {
                writer.WritePropertyName("customDomain"u8);
                writer.WriteObjectValue(CustomDomain);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(SasPolicy))
            {
                writer.WritePropertyName("sasPolicy"u8);
                writer.WriteObjectValue(SasPolicy);
            }
            if (Optional.IsDefined(KeyPolicy))
            {
                writer.WritePropertyName("keyPolicy"u8);
                writer.WriteObjectValue(KeyPolicy);
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier"u8);
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication"u8);
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly"u8);
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(IsSftpEnabled))
            {
                writer.WritePropertyName("isSftpEnabled"u8);
                writer.WriteBooleanValue(IsSftpEnabled.Value);
            }
            if (Optional.IsDefined(IsLocalUserEnabled))
            {
                writer.WritePropertyName("isLocalUserEnabled"u8);
                writer.WriteBooleanValue(IsLocalUserEnabled.Value);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState"u8);
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference"u8);
                writer.WriteObjectValue(RoutingPreference);
            }
            if (Optional.IsDefined(AllowBlobPublicAccess))
            {
                writer.WritePropertyName("allowBlobPublicAccess"u8);
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(AllowSharedKeyAccess))
            {
                writer.WritePropertyName("allowSharedKeyAccess"u8);
                writer.WriteBooleanValue(AllowSharedKeyAccess.Value);
            }
            if (Optional.IsDefined(AllowCrossTenantReplication))
            {
                writer.WritePropertyName("allowCrossTenantReplication"u8);
                writer.WriteBooleanValue(AllowCrossTenantReplication.Value);
            }
            if (Optional.IsDefined(IsDefaultToOAuthAuthentication))
            {
                writer.WritePropertyName("defaultToOAuthAuthentication"u8);
                writer.WriteBooleanValue(IsDefaultToOAuthAuthentication.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(ImmutableStorageWithVersioning))
            {
                writer.WritePropertyName("immutableStorageWithVersioning"u8);
                writer.WriteObjectValue(ImmutableStorageWithVersioning);
            }
            if (Optional.IsDefined(AllowedCopyScope))
            {
                writer.WritePropertyName("allowedCopyScope"u8);
                writer.WriteStringValue(AllowedCopyScope.Value.ToString());
            }
            if (Optional.IsDefined(DnsEndpointType))
            {
                writer.WritePropertyName("dnsEndpointType"u8);
                writer.WriteStringValue(DnsEndpointType.Value.ToString());
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

        internal static StorageAccountPatch DeserializeStorageAccountPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<StorageKind> kind = default;
            Optional<StorageCustomDomain> customDomain = default;
            Optional<StorageAccountEncryption> encryption = default;
            Optional<StorageAccountSasPolicy> sasPolicy = default;
            Optional<StorageAccountKeyPolicy> keyPolicy = default;
            Optional<StorageAccountAccessTier> accessTier = default;
            Optional<FilesIdentityBasedAuthentication> azureFilesIdentityBasedAuthentication = default;
            Optional<bool> supportsHttpsTrafficOnly = default;
            Optional<bool> isSftpEnabled = default;
            Optional<bool> isLocalUserEnabled = default;
            Optional<StorageAccountNetworkRuleSet> networkAcls = default;
            Optional<LargeFileSharesState> largeFileSharesState = default;
            Optional<StorageRoutingPreference> routingPreference = default;
            Optional<bool> allowBlobPublicAccess = default;
            Optional<StorageMinimumTlsVersion> minimumTlsVersion = default;
            Optional<bool> allowSharedKeyAccess = default;
            Optional<bool> allowCrossTenantReplication = default;
            Optional<bool> defaultToOAuthAuthentication = default;
            Optional<StoragePublicNetworkAccess> publicNetworkAccess = default;
            Optional<ImmutableStorageAccount> immutableStorageWithVersioning = default;
            Optional<AllowedCopyScope> allowedCopyScope = default;
            Optional<StorageDnsEndpointType> dnsEndpointType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageSku.DeserializeStorageSku(property.Value);
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
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new StorageKind(property.Value.GetString());
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
                        if (property0.NameEquals("customDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomain = StorageCustomDomain.DeserializeStorageCustomDomain(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = StorageAccountEncryption.DeserializeStorageAccountEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasPolicy = StorageAccountSasPolicy.DeserializeStorageAccountSasPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyPolicy = StorageAccountKeyPolicy.DeserializeStorageAccountKeyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTier = property0.Value.GetString().ToStorageAccountAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFilesIdentityBasedAuthentication = FilesIdentityBasedAuthentication.DeserializeFilesIdentityBasedAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isSftpEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSftpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isLocalUserEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLocalUserEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = StorageAccountNetworkRuleSet.DeserializeStorageAccountNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            largeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingPreference = StorageRoutingPreference.DeserializeStorageRoutingPreference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowBlobPublicAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowBlobPublicAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new StorageMinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowSharedKeyAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowSharedKeyAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowCrossTenantReplication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowCrossTenantReplication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultToOAuthAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultToOAuthAuthentication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new StoragePublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("immutableStorageWithVersioning"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutableStorageWithVersioning = ImmutableStorageAccount.DeserializeImmutableStorageAccount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowedCopyScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowedCopyScope = new AllowedCopyScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dnsEndpointType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsEndpointType = new StorageDnsEndpointType(property0.Value.GetString());
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
            return new StorageAccountPatch(sku.Value, Optional.ToDictionary(tags), identity, Optional.ToNullable(kind), customDomain.Value, encryption.Value, sasPolicy.Value, keyPolicy.Value, Optional.ToNullable(accessTier), azureFilesIdentityBasedAuthentication.Value, Optional.ToNullable(supportsHttpsTrafficOnly), Optional.ToNullable(isSftpEnabled), Optional.ToNullable(isLocalUserEnabled), networkAcls.Value, Optional.ToNullable(largeFileSharesState), routingPreference.Value, Optional.ToNullable(allowBlobPublicAccess), Optional.ToNullable(minimumTlsVersion), Optional.ToNullable(allowSharedKeyAccess), Optional.ToNullable(allowCrossTenantReplication), Optional.ToNullable(defaultToOAuthAuthentication), Optional.ToNullable(publicNetworkAccess), immutableStorageWithVersioning.Value, Optional.ToNullable(allowedCopyScope), Optional.ToNullable(dnsEndpointType), rawData);
        }

        StorageAccountPatch IModelJsonSerializable<StorageAccountPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageAccountPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageAccountPatch IModelSerializable<StorageAccountPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageAccountPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StorageAccountPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StorageAccountPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageAccountPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
