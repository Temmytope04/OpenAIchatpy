// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class EncryptionDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cmk))
            {
                writer.WritePropertyName("cmk");
                writer.WriteObjectValue(Cmk);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionDetails DeserializeEncryptionDetails(JsonElement element)
        {
            Optional<bool> doubleEncryptionEnabled = default;
            Optional<CustomerManagedKeyDetails> cmk = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("doubleEncryptionEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    doubleEncryptionEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cmk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cmk = CustomerManagedKeyDetails.DeserializeCustomerManagedKeyDetails(property.Value);
                    continue;
                }
            }
            return new EncryptionDetails(Optional.ToNullable(doubleEncryptionEnabled), cmk.Value);
        }
    }
}
