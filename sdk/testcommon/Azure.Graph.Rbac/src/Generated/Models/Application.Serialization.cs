// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class Application
    {
        internal static Application DeserializeApplication(JsonElement element)
        {
            Optional<string> appId = default;
            Optional<bool> allowGuestsSignIn = default;
            Optional<bool> allowPassthroughUsers = default;
            Optional<string> appLogoUrl = default;
            Optional<IReadOnlyList<AppRole>> appRoles = default;
            Optional<IReadOnlyList<string>> appPermissions = default;
            Optional<bool> availableToOtherTenants = default;
            Optional<string> displayName = default;
            Optional<string> errorUrl = default;
            Optional<GroupMembershipClaimTypes> groupMembershipClaims = default;
            Optional<string> homepage = default;
            Optional<IReadOnlyList<string>> identifierUris = default;
            Optional<InformationalUrl> informationalUrls = default;
            Optional<bool> isDeviceOnlyAuthSupported = default;
            Optional<IReadOnlyList<KeyCredential>> keyCredentials = default;
            Optional<IReadOnlyList<string>> knownClientApplications = default;
            Optional<string> logoutUrl = default;
            Optional<bool> oauth2AllowImplicitFlow = default;
            Optional<bool> oauth2AllowUrlPathMatching = default;
            Optional<IReadOnlyList<OAuth2Permission>> oauth2Permissions = default;
            Optional<bool> oauth2RequirePostResponse = default;
            Optional<IReadOnlyList<string>> orgRestrictions = default;
            Optional<OptionalClaims> optionalClaims = default;
            Optional<IReadOnlyList<PasswordCredential>> passwordCredentials = default;
            Optional<IReadOnlyList<PreAuthorizedApplication>> preAuthorizedApplications = default;
            Optional<bool> publicClient = default;
            Optional<string> publisherDomain = default;
            Optional<IReadOnlyList<string>> replyUrls = default;
            Optional<IReadOnlyList<RequiredResourceAccess>> requiredResourceAccess = default;
            Optional<string> samlMetadataUrl = default;
            Optional<string> signInAudience = default;
            Optional<string> wwwHomepage = default;
            Optional<string> objectId = default;
            Optional<string> objectType = default;
            Optional<DateTimeOffset> deletionTimestamp = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowGuestsSignIn"))
                {
                    allowGuestsSignIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPassthroughUsers"))
                {
                    allowPassthroughUsers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appLogoUrl"))
                {
                    appLogoUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appRoles"))
                {
                    List<AppRole> array = new List<AppRole>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppRole.DeserializeAppRole(item));
                    }
                    appRoles = array;
                    continue;
                }
                if (property.NameEquals("appPermissions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    appPermissions = array;
                    continue;
                }
                if (property.NameEquals("availableToOtherTenants"))
                {
                    availableToOtherTenants = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorUrl"))
                {
                    errorUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupMembershipClaims"))
                {
                    groupMembershipClaims = new GroupMembershipClaimTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("homepage"))
                {
                    homepage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifierUris"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    identifierUris = array;
                    continue;
                }
                if (property.NameEquals("informationalUrls"))
                {
                    informationalUrls = InformationalUrl.DeserializeInformationalUrl(property.Value);
                    continue;
                }
                if (property.NameEquals("isDeviceOnlyAuthSupported"))
                {
                    isDeviceOnlyAuthSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyCredentials"))
                {
                    List<KeyCredential> array = new List<KeyCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyCredential.DeserializeKeyCredential(item));
                    }
                    keyCredentials = array;
                    continue;
                }
                if (property.NameEquals("knownClientApplications"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    knownClientApplications = array;
                    continue;
                }
                if (property.NameEquals("logoutUrl"))
                {
                    logoutUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oauth2AllowImplicitFlow"))
                {
                    oauth2AllowImplicitFlow = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("oauth2AllowUrlPathMatching"))
                {
                    oauth2AllowUrlPathMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("oauth2Permissions"))
                {
                    List<OAuth2Permission> array = new List<OAuth2Permission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OAuth2Permission.DeserializeOAuth2Permission(item));
                    }
                    oauth2Permissions = array;
                    continue;
                }
                if (property.NameEquals("oauth2RequirePostResponse"))
                {
                    oauth2RequirePostResponse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("orgRestrictions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    orgRestrictions = array;
                    continue;
                }
                if (property.NameEquals("optionalClaims"))
                {
                    optionalClaims = OptionalClaims.DeserializeOptionalClaims(property.Value);
                    continue;
                }
                if (property.NameEquals("passwordCredentials"))
                {
                    List<PasswordCredential> array = new List<PasswordCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PasswordCredential.DeserializePasswordCredential(item));
                    }
                    passwordCredentials = array;
                    continue;
                }
                if (property.NameEquals("preAuthorizedApplications"))
                {
                    List<PreAuthorizedApplication> array = new List<PreAuthorizedApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PreAuthorizedApplication.DeserializePreAuthorizedApplication(item));
                    }
                    preAuthorizedApplications = array;
                    continue;
                }
                if (property.NameEquals("publicClient"))
                {
                    publicClient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publisherDomain"))
                {
                    publisherDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyUrls"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    replyUrls = array;
                    continue;
                }
                if (property.NameEquals("requiredResourceAccess"))
                {
                    List<RequiredResourceAccess> array = new List<RequiredResourceAccess>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RequiredResourceAccess.DeserializeRequiredResourceAccess(item));
                    }
                    requiredResourceAccess = array;
                    continue;
                }
                if (property.NameEquals("samlMetadataUrl"))
                {
                    samlMetadataUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("signInAudience"))
                {
                    signInAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wwwHomepage"))
                {
                    wwwHomepage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionTimestamp"))
                {
                    deletionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Application(objectId.Value, objectType.Value, Optional.ToNullable(deletionTimestamp), additionalProperties, appId.Value, Optional.ToNullable(allowGuestsSignIn), Optional.ToNullable(allowPassthroughUsers), appLogoUrl.Value, Optional.ToList(appRoles), Optional.ToList(appPermissions), Optional.ToNullable(availableToOtherTenants), displayName.Value, errorUrl.Value, Optional.ToNullable(groupMembershipClaims), homepage.Value, Optional.ToList(identifierUris), informationalUrls.Value, Optional.ToNullable(isDeviceOnlyAuthSupported), Optional.ToList(keyCredentials), Optional.ToList(knownClientApplications), logoutUrl.Value, Optional.ToNullable(oauth2AllowImplicitFlow), Optional.ToNullable(oauth2AllowUrlPathMatching), Optional.ToList(oauth2Permissions), Optional.ToNullable(oauth2RequirePostResponse), Optional.ToList(orgRestrictions), optionalClaims.Value, Optional.ToList(passwordCredentials), Optional.ToList(preAuthorizedApplications), Optional.ToNullable(publicClient), publisherDomain.Value, Optional.ToList(replyUrls), Optional.ToList(requiredResourceAccess), samlMetadataUrl.Value, signInAudience.Value, wwwHomepage.Value);
        }
    }
}
