// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class UserCreateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accountEnabled");
            writer.WriteBooleanValue(AccountEnabled);
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("passwordProfile");
            writer.WriteObjectValue(PasswordProfile);
            writer.WritePropertyName("userPrincipalName");
            writer.WriteStringValue(UserPrincipalName);
            writer.WritePropertyName("mailNickname");
            writer.WriteStringValue(MailNickname);
            if (Optional.IsDefined(Mail))
            {
                writer.WritePropertyName("mail");
                writer.WriteStringValue(Mail);
            }
            if (Optional.IsDefined(ImmutableId))
            {
                writer.WritePropertyName("immutableId");
                writer.WriteStringValue(ImmutableId);
            }
            if (Optional.IsDefined(UsageLocation))
            {
                writer.WritePropertyName("usageLocation");
                writer.WriteStringValue(UsageLocation);
            }
            if (Optional.IsDefined(GivenName))
            {
                writer.WritePropertyName("givenName");
                writer.WriteStringValue(GivenName);
            }
            if (Optional.IsDefined(Surname))
            {
                writer.WritePropertyName("surname");
                writer.WriteStringValue(Surname);
            }
            if (Optional.IsDefined(UserType))
            {
                writer.WritePropertyName("userType");
                writer.WriteStringValue(UserType.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}
