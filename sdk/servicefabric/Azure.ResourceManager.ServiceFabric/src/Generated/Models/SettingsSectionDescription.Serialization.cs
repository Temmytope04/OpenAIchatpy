// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class SettingsSectionDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("parameters"u8);
            writer.WriteStartArray();
            foreach (var item in Parameters)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SettingsSectionDescription DeserializeSettingsSectionDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<SettingsParameterDescription> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    List<SettingsParameterDescription> array = new List<SettingsParameterDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SettingsParameterDescription.DeserializeSettingsParameterDescription(item));
                    }
                    parameters = array;
                    continue;
                }
            }
            return new SettingsSectionDescription(name, parameters);
        }
    }
}
