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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackPolicyDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageRcmFailbackPolicyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageRcmFailbackPolicyDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageRcmFailbackPolicyDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmFailbackPolicyDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(CrashConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("crashConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(CrashConsistentFrequencyInMinutes.Value);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static InMageRcmFailbackPolicyDetails DeserializeInMageRcmFailbackPolicyDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> appConsistentFrequencyInMinutes = default;
            Optional<int> crashConsistentFrequencyInMinutes = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("crashConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crashConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageRcmFailbackPolicyDetails(instanceType, Optional.ToNullable(appConsistentFrequencyInMinutes), Optional.ToNullable(crashConsistentFrequencyInMinutes), rawData);
        }

        InMageRcmFailbackPolicyDetails IModelJsonSerializable<InMageRcmFailbackPolicyDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmFailbackPolicyDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackPolicyDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageRcmFailbackPolicyDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmFailbackPolicyDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageRcmFailbackPolicyDetails IModelSerializable<InMageRcmFailbackPolicyDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmFailbackPolicyDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageRcmFailbackPolicyDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InMageRcmFailbackPolicyDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InMageRcmFailbackPolicyDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageRcmFailbackPolicyDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
