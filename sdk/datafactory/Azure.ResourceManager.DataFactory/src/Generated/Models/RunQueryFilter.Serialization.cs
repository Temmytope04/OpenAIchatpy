// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RunQueryFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operand");
            writer.WriteStringValue(Operand.ToString());
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("values");
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
