// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.QnaMaker.Models
{
    internal partial class EndpointKeysDTO
    {
        internal static EndpointKeysDTO DeserializeEndpointKeysDTO(JsonElement element)
        {
            Optional<string> primaryEndpointKey = default;
            Optional<string> secondaryEndpointKey = default;
            Optional<string> installedVersion = default;
            Optional<string> lastStableVersion = default;
            Optional<string> language = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryEndpointKey"))
                {
                    primaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryEndpointKey"))
                {
                    secondaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installedVersion"))
                {
                    installedVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastStableVersion"))
                {
                    lastStableVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    language = property.Value.GetString();
                    continue;
                }
            }
            return new EndpointKeysDTO(primaryEndpointKey.Value, secondaryEndpointKey.Value, installedVersion.Value, lastStableVersion.Value, language.Value);
        }
    }
}
