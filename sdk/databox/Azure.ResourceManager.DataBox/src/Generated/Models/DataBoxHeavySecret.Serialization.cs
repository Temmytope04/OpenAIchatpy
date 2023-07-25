// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxHeavySecret
    {
        internal static DataBoxHeavySecret DeserializeDataBoxHeavySecret(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceSerialNumber = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<ApplianceNetworkConfiguration>> networkConfigurations = default;
            Optional<string> encodedValidationCertPubKey = default;
            Optional<IReadOnlyList<DataBoxAccountCredentialDetails>> accountCredentialDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceSerialNumber"u8))
                {
                    deviceSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceNetworkConfiguration> array = new List<ApplianceNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceNetworkConfiguration.DeserializeApplianceNetworkConfiguration(item));
                    }
                    networkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("encodedValidationCertPubKey"u8))
                {
                    encodedValidationCertPubKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountCredentialDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxAccountCredentialDetails> array = new List<DataBoxAccountCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxAccountCredentialDetails.DeserializeDataBoxAccountCredentialDetails(item));
                    }
                    accountCredentialDetails = array;
                    continue;
                }
            }
            return new DataBoxHeavySecret(deviceSerialNumber.Value, devicePassword.Value, Optional.ToList(networkConfigurations), encodedValidationCertPubKey.Value, Optional.ToList(accountCredentialDetails));
        }
    }
}
