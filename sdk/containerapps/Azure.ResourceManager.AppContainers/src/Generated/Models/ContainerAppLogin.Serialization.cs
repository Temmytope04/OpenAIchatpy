// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppLogin : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(TokenStore))
            {
                writer.WritePropertyName("tokenStore"u8);
                writer.WriteObjectValue(TokenStore);
            }
            if (Optional.IsDefined(PreserveUrlFragmentsForLogins))
            {
                writer.WritePropertyName("preserveUrlFragmentsForLogins"u8);
                writer.WriteBooleanValue(PreserveUrlFragmentsForLogins.Value);
            }
            if (Optional.IsCollectionDefined(AllowedExternalRedirectUrls))
            {
                writer.WritePropertyName("allowedExternalRedirectUrls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedExternalRedirectUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CookieExpiration))
            {
                writer.WritePropertyName("cookieExpiration"u8);
                writer.WriteObjectValue(CookieExpiration);
            }
            if (Optional.IsDefined(Nonce))
            {
                writer.WritePropertyName("nonce"u8);
                writer.WriteObjectValue(Nonce);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppLogin DeserializeContainerAppLogin(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LoginRoutes> routes = default;
            Optional<TokenStore> tokenStore = default;
            Optional<bool> preserveUrlFragmentsForLogins = default;
            Optional<IList<string>> allowedExternalRedirectUrls = default;
            Optional<ContainerAppCookieExpiration> cookieExpiration = default;
            Optional<ContainerAppLoginNonce> nonce = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = LoginRoutes.DeserializeLoginRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("tokenStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenStore = TokenStore.DeserializeTokenStore(property.Value);
                    continue;
                }
                if (property.NameEquals("preserveUrlFragmentsForLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUrlFragmentsForLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedExternalRedirectUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedExternalRedirectUrls = array;
                    continue;
                }
                if (property.NameEquals("cookieExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cookieExpiration = ContainerAppCookieExpiration.DeserializeContainerAppCookieExpiration(property.Value);
                    continue;
                }
                if (property.NameEquals("nonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonce = ContainerAppLoginNonce.DeserializeContainerAppLoginNonce(property.Value);
                    continue;
                }
            }
            return new ContainerAppLogin(routes.Value, tokenStore.Value, Optional.ToNullable(preserveUrlFragmentsForLogins), Optional.ToList(allowedExternalRedirectUrls), cookieExpiration.Value, nonce.Value);
        }
    }
}
