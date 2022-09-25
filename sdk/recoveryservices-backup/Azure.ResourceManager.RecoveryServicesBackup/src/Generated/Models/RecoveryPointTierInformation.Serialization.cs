// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointTierInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TierType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TierType.Value.ToSerialString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo");
                writer.WriteStartObject();
                foreach (var item in ExtendedInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static RecoveryPointTierInformation DeserializeRecoveryPointTierInformation(JsonElement element)
        {
            Optional<RecoveryPointTierType> type = default;
            Optional<RecoveryPointTierStatus> status = default;
            Optional<IDictionary<string, string>> extendedInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToRecoveryPointTierType();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToRecoveryPointTierStatus();
                    continue;
                }
                if (property.NameEquals("extendedInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    extendedInfo = dictionary;
                    continue;
                }
            }
            return new RecoveryPointTierInformation(Optional.ToNullable(type), Optional.ToNullable(status), Optional.ToDictionary(extendedInfo));
        }
    }
}
