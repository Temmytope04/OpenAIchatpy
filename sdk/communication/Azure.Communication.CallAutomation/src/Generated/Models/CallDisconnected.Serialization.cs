// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class CallDisconnected
    {
        internal static CallDisconnected DeserializeCallDisconnected(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            string operationContext = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
            }
            return new CallDisconnected(callConnectionId, serverCallId, correlationId, operationContext);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CallDisconnected FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCallDisconnected(document.RootElement);
        }
    }
}
