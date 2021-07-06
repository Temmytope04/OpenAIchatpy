// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class StartCallRecordingResult
    {
        internal static StartCallRecordingResult DeserializeStartCallRecordingResult(JsonElement element)
        {
            Optional<string> recordingId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
            }
            return new StartCallRecordingResult(recordingId.Value);
        }
    }
}
