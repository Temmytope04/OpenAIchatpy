// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class RecognizeCompleted
    {
        internal static RecognizeCompleted DeserializeRecognizeCompleted(JsonElement element)
        {
            Optional<string> operationContext = default;
            Optional<CallMediaRecognitionType> recognitionType = default;
            Optional<CollectTonesResult> collectTonesResult = default;
            Optional<ResultInformation> resultInfo = default;
            Optional<AcsEventType> type = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recognitionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recognitionType = new CallMediaRecognitionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("collectTonesResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    collectTonesResult = CollectTonesResult.DeserializeCollectTonesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("resultInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultInfo = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AcsEventType(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("correlationId"))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
            }
            return new RecognizeCompleted(operationContext.Value, recognitionType, collectTonesResult.Value, resultInfo.Value, type, callConnectionId.Value, serverCallId.Value, correlationId.Value);
        }
    }
}
