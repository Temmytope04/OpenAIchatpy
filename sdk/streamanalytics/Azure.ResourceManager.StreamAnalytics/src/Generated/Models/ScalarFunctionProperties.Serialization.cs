// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ScalarFunctionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(FunctionPropertiesType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output");
                writer.WriteObjectValue(Output);
            }
            if (Optional.IsDefined(Binding))
            {
                writer.WritePropertyName("binding");
                writer.WriteObjectValue(Binding);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScalarFunctionProperties DeserializeScalarFunctionProperties(JsonElement element)
        {
            string type = default;
            Optional<ETag> etag = default;
            Optional<IList<FunctionInput>> inputs = default;
            Optional<FunctionOutput> output = default;
            Optional<FunctionBinding> binding = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("inputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FunctionInput> array = new List<FunctionInput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FunctionInput.DeserializeFunctionInput(item));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("output"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            output = FunctionOutput.DeserializeFunctionOutput(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("binding"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            binding = FunctionBinding.DeserializeFunctionBinding(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScalarFunctionProperties(type, Optional.ToNullable(etag), Optional.ToList(inputs), output.Value, binding.Value);
        }
    }
}
