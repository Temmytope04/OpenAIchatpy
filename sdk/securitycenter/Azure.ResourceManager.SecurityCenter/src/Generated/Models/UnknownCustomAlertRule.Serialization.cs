// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownCustomAlertRule : IUtf8JsonSerializable, IModelJsonSerializable<CustomAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomAlertRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomAlertRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static CustomAlertRule DeserializeUnknownCustomAlertRule(JsonElement element, ModelSerializerOptions options = default) => DeserializeCustomAlertRule(element, options);

        CustomAlertRule IModelJsonSerializable<CustomAlertRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownCustomAlertRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomAlertRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomAlertRule IModelSerializable<CustomAlertRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomAlertRule(doc.RootElement, options);
        }
    }
}
