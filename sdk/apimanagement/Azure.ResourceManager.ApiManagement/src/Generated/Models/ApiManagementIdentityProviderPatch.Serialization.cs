// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementIdentityProviderPatch : IUtf8JsonSerializable, IJsonModel<ApiManagementIdentityProviderPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementIdentityProviderPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementIdentityProviderPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityProviderType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityProviderType.Value.ToString());
            }
            if (Optional.IsDefined(SignInTenant))
            {
                writer.WritePropertyName("signinTenant"u8);
                writer.WriteStringValue(SignInTenant);
            }
            if (Optional.IsCollectionDefined(AllowedTenants))
            {
                writer.WritePropertyName("allowedTenants"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedTenants)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Authority))
            {
                writer.WritePropertyName("authority"u8);
                writer.WriteStringValue(Authority);
            }
            if (Optional.IsDefined(SignUpPolicyName))
            {
                writer.WritePropertyName("signupPolicyName"u8);
                writer.WriteStringValue(SignUpPolicyName);
            }
            if (Optional.IsDefined(SignInPolicyName))
            {
                writer.WritePropertyName("signinPolicyName"u8);
                writer.WriteStringValue(SignInPolicyName);
            }
            if (Optional.IsDefined(ProfileEditingPolicyName))
            {
                writer.WritePropertyName("profileEditingPolicyName"u8);
                writer.WriteStringValue(ProfileEditingPolicyName);
            }
            if (Optional.IsDefined(PasswordResetPolicyName))
            {
                writer.WritePropertyName("passwordResetPolicyName"u8);
                writer.WriteStringValue(PasswordResetPolicyName);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApiManagementIdentityProviderPatch IJsonModel<ApiManagementIdentityProviderPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementIdentityProviderPatch(document.RootElement, options);
        }

        internal static ApiManagementIdentityProviderPatch DeserializeApiManagementIdentityProviderPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IdentityProviderType? type = default;
            string signinTenant = default;
            IList<string> allowedTenants = default;
            string authority = default;
            string signupPolicyName = default;
            string signinPolicyName = default;
            string profileEditingPolicyName = default;
            string passwordResetPolicyName = default;
            string clientId = default;
            string clientSecret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new IdentityProviderType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("signinTenant"u8))
                        {
                            signinTenant = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedTenants"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            allowedTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("authority"u8))
                        {
                            authority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signupPolicyName"u8))
                        {
                            signupPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signinPolicyName"u8))
                        {
                            signinPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("profileEditingPolicyName"u8))
                        {
                            profileEditingPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("passwordResetPolicyName"u8))
                        {
                            passwordResetPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementIdentityProviderPatch(
                type,
                signinTenant,
                allowedTenants ?? new ChangeTrackingList<string>(),
                authority,
                signupPolicyName,
                signinPolicyName,
                profileEditingPolicyName,
                passwordResetPolicyName,
                clientId,
                clientSecret,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementIdentityProviderPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderPatch)} does not support '{options.Format}' format.");
            }
        }

        ApiManagementIdentityProviderPatch IPersistableModel<ApiManagementIdentityProviderPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementIdentityProviderPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementIdentityProviderPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
