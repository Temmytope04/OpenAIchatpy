// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class InputModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("NestedInputModel");
            writer.WriteObjectValue(NestedInputModel);
            writer.WritePropertyName("NestedSharedModel");
            writer.WriteObjectValue(NestedSharedModel);
            writer.WriteEndObject();
        }
    }
}
