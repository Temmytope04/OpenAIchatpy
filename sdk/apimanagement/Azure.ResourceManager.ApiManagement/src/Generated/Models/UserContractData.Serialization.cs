// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class UserContractData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note");
                writer.WriteStringValue(Note);
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities");
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName");
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName");
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(RegistrationOn))
            {
                writer.WritePropertyName("registrationDate");
                writer.WriteStringValue(RegistrationOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static UserContractData DeserializeUserContractData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<UserState> state = default;
            Optional<string> note = default;
            Optional<IList<UserIdentityContract>> identities = default;
            Optional<string> firstName = default;
            Optional<string> lastName = default;
            Optional<string> email = default;
            Optional<DateTimeOffset> registrationDate = default;
            Optional<IReadOnlyList<GroupContractProperties>> groups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new UserState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("note"))
                        {
                            note = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<UserIdentityContract> array = new List<UserIdentityContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UserIdentityContract.DeserializeUserIdentityContract(item));
                            }
                            identities = array;
                            continue;
                        }
                        if (property0.NameEquals("firstName"))
                        {
                            firstName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastName"))
                        {
                            lastName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("email"))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("groups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<GroupContractProperties> array = new List<GroupContractProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GroupContractProperties.DeserializeGroupContractProperties(item));
                            }
                            groups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new UserContractData(id, name, type, systemData.Value, Optional.ToNullable(state), note.Value, Optional.ToList(identities), firstName.Value, lastName.Value, email.Value, Optional.ToNullable(registrationDate), Optional.ToList(groups));
        }
    }
}
