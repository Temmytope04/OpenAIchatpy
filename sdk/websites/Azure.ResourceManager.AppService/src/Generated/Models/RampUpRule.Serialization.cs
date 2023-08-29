// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class RampUpRule : IUtf8JsonSerializable, IModelJsonSerializable<RampUpRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RampUpRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RampUpRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActionHostName))
            {
                writer.WritePropertyName("actionHostName"u8);
                writer.WriteStringValue(ActionHostName);
            }
            if (Optional.IsDefined(ReroutePercentage))
            {
                writer.WritePropertyName("reroutePercentage"u8);
                writer.WriteNumberValue(ReroutePercentage.Value);
            }
            if (Optional.IsDefined(ChangeStep))
            {
                writer.WritePropertyName("changeStep"u8);
                writer.WriteNumberValue(ChangeStep.Value);
            }
            if (Optional.IsDefined(ChangeIntervalInMinutes))
            {
                writer.WritePropertyName("changeIntervalInMinutes"u8);
                writer.WriteNumberValue(ChangeIntervalInMinutes.Value);
            }
            if (Optional.IsDefined(MinReroutePercentage))
            {
                writer.WritePropertyName("minReroutePercentage"u8);
                writer.WriteNumberValue(MinReroutePercentage.Value);
            }
            if (Optional.IsDefined(MaxReroutePercentage))
            {
                writer.WritePropertyName("maxReroutePercentage"u8);
                writer.WriteNumberValue(MaxReroutePercentage.Value);
            }
            if (Optional.IsDefined(ChangeDecisionCallbackUri))
            {
                writer.WritePropertyName("changeDecisionCallbackUrl"u8);
                writer.WriteStringValue(ChangeDecisionCallbackUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
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

        internal static RampUpRule DeserializeRampUpRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> actionHostName = default;
            Optional<double> reroutePercentage = default;
            Optional<double> changeStep = default;
            Optional<int> changeIntervalInMinutes = default;
            Optional<double> minReroutePercentage = default;
            Optional<double> maxReroutePercentage = default;
            Optional<Uri> changeDecisionCallbackUrl = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionHostName"u8))
                {
                    actionHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeStep = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeIntervalInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeIntervalInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minReroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minReroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxReroutePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReroutePercentage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("changeDecisionCallbackUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeDecisionCallbackUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RampUpRule(actionHostName.Value, Optional.ToNullable(reroutePercentage), Optional.ToNullable(changeStep), Optional.ToNullable(changeIntervalInMinutes), Optional.ToNullable(minReroutePercentage), Optional.ToNullable(maxReroutePercentage), changeDecisionCallbackUrl.Value, name.Value, rawData);
        }

        RampUpRule IModelJsonSerializable<RampUpRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRampUpRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RampUpRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RampUpRule IModelSerializable<RampUpRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRampUpRule(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RampUpRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RampUpRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRampUpRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
