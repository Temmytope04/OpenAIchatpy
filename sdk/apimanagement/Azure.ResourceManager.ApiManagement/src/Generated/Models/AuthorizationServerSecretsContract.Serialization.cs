// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AuthorizationServerSecretsContract
    {
        internal static AuthorizationServerSecretsContract DeserializeAuthorizationServerSecretsContract(JsonElement element)
        {
            Optional<string> clientSecret = default;
            Optional<string> resourceOwnerUsername = default;
            Optional<string> resourceOwnerPassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSecret"))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceOwnerUsername"))
                {
                    resourceOwnerUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceOwnerPassword"))
                {
                    resourceOwnerPassword = property.Value.GetString();
                    continue;
                }
            }
            return new AuthorizationServerSecretsContract(clientSecret.Value, resourceOwnerUsername.Value, resourceOwnerPassword.Value);
        }
    }
}
