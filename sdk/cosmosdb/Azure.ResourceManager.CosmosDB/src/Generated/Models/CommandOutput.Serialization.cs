// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CommandOutput
    {
        internal static CommandOutput DeserializeCommandOutput(JsonElement element)
        {
            Optional<string> commandOutput = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commandOutput"))
                {
                    commandOutput = property.Value.GetString();
                    continue;
                }
            }
            return new CommandOutput(commandOutput.Value);
        }
    }
}
