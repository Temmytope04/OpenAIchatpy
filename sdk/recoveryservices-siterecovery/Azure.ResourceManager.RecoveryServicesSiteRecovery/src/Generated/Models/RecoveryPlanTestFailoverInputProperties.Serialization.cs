// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanTestFailoverInputProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("failoverDirection");
            writer.WriteStringValue(FailoverDirection.ToString());
            writer.WritePropertyName("networkType");
            writer.WriteStringValue(NetworkType);
            if (Optional.IsDefined(NetworkId))
            {
                writer.WritePropertyName("networkId");
                writer.WriteStringValue(NetworkId);
            }
            if (Optional.IsCollectionDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails");
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
