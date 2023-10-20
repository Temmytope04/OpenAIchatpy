// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class RouterQueueAssignment
    {
        internal static RouterQueueAssignment DeserializeRouterQueueAssignment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            foreach (var property in element.EnumerateObject())
            {
            }
            return new RouterQueueAssignment();
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterQueueAssignment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterQueueAssignment(document.RootElement);
        }
    }
}
