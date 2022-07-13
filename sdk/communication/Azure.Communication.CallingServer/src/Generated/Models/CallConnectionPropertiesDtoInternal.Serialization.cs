// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Communication.CallingServer;
using Azure.Core;

namespace Azure.Communication.CallingServer.Models
{
    internal partial class CallConnectionPropertiesDtoInternal
    {
        internal static CallConnectionPropertiesDtoInternal DeserializeCallConnectionPropertiesDtoInternal(JsonElement element)
        {
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<CommunicationIdentifierModel> source = default;
            Optional<PhoneNumberIdentifierModel> alternateCallerId = default;
            Optional<IReadOnlyList<CommunicationIdentifierModel>> targets = default;
            Optional<CallConnectionState> callConnectionState = default;
            Optional<string> subject = default;
            Optional<string> callbackUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("alternateCallerId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alternateCallerId = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("targets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("callConnectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
            }
            return new CallConnectionPropertiesDtoInternal(callConnectionId.Value, serverCallId.Value, source.Value, alternateCallerId.Value, Optional.ToList(targets), Optional.ToNullable(callConnectionState), subject.Value, callbackUri.Value);
        }
    }
}
