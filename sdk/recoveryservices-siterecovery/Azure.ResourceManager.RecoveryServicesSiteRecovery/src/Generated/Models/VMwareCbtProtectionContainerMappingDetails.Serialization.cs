// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectionContainerMappingDetails
    {
        internal static VMwareCbtProtectionContainerMappingDetails DeserializeVMwareCbtProtectionContainerMappingDetails(JsonElement element)
        {
            Optional<string> keyVaultId = default;
            Optional<Uri> keyVaultUri = default;
            Optional<string> storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<string> serviceBusConnectionStringSecretName = default;
            Optional<string> targetLocation = default;
            Optional<IReadOnlyDictionary<string, int>> roleSizeToNicCountMap = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultUri = null;
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleSizeToNicCountMap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    roleSizeToNicCountMap = dictionary;
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareCbtProtectionContainerMappingDetails(instanceType, keyVaultId.Value, keyVaultUri.Value, storageAccountId.Value, storageAccountSasSecretName.Value, serviceBusConnectionStringSecretName.Value, targetLocation.Value, Optional.ToDictionary(roleSizeToNicCountMap));
        }
    }
}
