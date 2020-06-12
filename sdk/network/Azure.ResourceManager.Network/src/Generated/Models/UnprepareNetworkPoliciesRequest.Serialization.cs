// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class UnprepareNetworkPoliciesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ServiceName != null)
            {
                writer.WritePropertyName("serviceName");
                writer.WriteStringValue(ServiceName);
            }
            writer.WriteEndObject();
        }
    }
}
