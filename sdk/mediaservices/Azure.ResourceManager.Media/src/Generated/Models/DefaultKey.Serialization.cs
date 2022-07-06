// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class DefaultKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName);
            }
            writer.WriteEndObject();
        }

        internal static DefaultKey DeserializeDefaultKey(JsonElement element)
        {
            Optional<string> label = default;
            Optional<string> policyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
            }
            return new DefaultKey(label.Value, policyName.Value);
        }
    }
}
