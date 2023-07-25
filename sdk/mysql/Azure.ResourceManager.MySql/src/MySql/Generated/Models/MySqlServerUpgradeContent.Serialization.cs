// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlServerUpgradeContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetServerVersion))
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
