// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class CniConfig
    {
        internal static CniConfig DeserializeCniConfig(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> version = default;
            Optional<string> podSubnet = default;
            Optional<string> serviceSubnet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("podSubnet"))
                {
                    podSubnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceSubnet"))
                {
                    serviceSubnet = property.Value.GetString();
                    continue;
                }
            }
            return new CniConfig(type.Value, version.Value, podSubnet.Value, serviceSubnet.Value);
        }
    }
}
