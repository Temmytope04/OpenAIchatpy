// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptExecutionParameterDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
            writer.WriteEndObject();
        }

        internal static ScriptExecutionParameterDetails DeserializeScriptExecutionParameterDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Credential": return PSCredentialExecutionParameterDetails.DeserializePSCredentialExecutionParameterDetails(element);
                    case "SecureValue": return ScriptSecureStringExecutionParameterDetails.DeserializeScriptSecureStringExecutionParameterDetails(element);
                    case "Value": return ScriptStringExecutionParameterDetails.DeserializeScriptStringExecutionParameterDetails(element);
                }
            }
            return UnknownScriptExecutionParameter.DeserializeUnknownScriptExecutionParameter(element);
        }
    }
}
