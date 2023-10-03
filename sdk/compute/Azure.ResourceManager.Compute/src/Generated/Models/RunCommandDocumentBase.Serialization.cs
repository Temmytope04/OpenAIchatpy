// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RunCommandDocumentBase
    {
        internal static RunCommandDocumentBase DeserializeRunCommandDocumentBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string schema = default;
            string id = default;
            SupportedOperatingSystemType osType = default;
            string label = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("$schema"u8))
                {
                    schema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString().ToSupportedOperatingSystemType();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new RunCommandDocumentBase(schema, id, osType, label, description);
        }
    }
}
