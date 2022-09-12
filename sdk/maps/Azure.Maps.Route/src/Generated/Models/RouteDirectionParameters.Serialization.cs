// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class RouteDirectionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SupportingPoints))
            {
                writer.WritePropertyName("supportingPoints");
                writer.WriteObjectValue(SupportingPoints);
            }
            if (Optional.IsCollectionDefined(AvoidVignette))
            {
                writer.WritePropertyName("avoidVignette");
                writer.WriteStartArray();
                foreach (var item in AvoidVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowVignette))
            {
                writer.WritePropertyName("allowVignette");
                writer.WriteStartArray();
                foreach (var item in AllowVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AvoidAreas))
            {
                writer.WritePropertyName("avoidAreas");
                writer.WriteObjectValue(AvoidAreas);
            }
            writer.WriteEndObject();
        }
    }
}
