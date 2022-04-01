// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(ArmPlanConverter))]
    public partial class ArmPlan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher");
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("product");
            writer.WriteStringValue(Product);
            if (Optional.IsDefined(PromotionCode))
            {
                writer.WritePropertyName("promotionCode");
                writer.WriteStringValue(PromotionCode);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static ArmPlan DeserializeArmPlan(JsonElement element)
        {
            string name = default;
            string publisher = default;
            string product = default;
            Optional<string> promotionCode = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product"))
                {
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("promotionCode"))
                {
                    promotionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new ArmPlan(name, publisher, product, promotionCode.Value, version.Value);
        }

        internal partial class ArmPlanConverter : JsonConverter<ArmPlan>
        {
            public override void Write(Utf8JsonWriter writer, ArmPlan model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ArmPlan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeArmPlan(document.RootElement);
            }
        }
    }
}
