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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GovernanceRuleEmailNotification : IUtf8JsonSerializable, IModelJsonSerializable<GovernanceRuleEmailNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GovernanceRuleEmailNotification>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GovernanceRuleEmailNotification>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsManagerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableManagerEmailNotification"u8);
                writer.WriteBooleanValue(IsManagerEmailNotificationDisabled.Value);
            }
            if (Optional.IsDefined(IsOwnerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableOwnerEmailNotification"u8);
                writer.WriteBooleanValue(IsOwnerEmailNotificationDisabled.Value);
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

        internal static GovernanceRuleEmailNotification DeserializeGovernanceRuleEmailNotification(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> disableManagerEmailNotification = default;
            Optional<bool> disableOwnerEmailNotification = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disableManagerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableManagerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableOwnerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableOwnerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GovernanceRuleEmailNotification(Optional.ToNullable(disableManagerEmailNotification), Optional.ToNullable(disableOwnerEmailNotification), rawData);
        }

        GovernanceRuleEmailNotification IModelJsonSerializable<GovernanceRuleEmailNotification>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceRuleEmailNotification(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GovernanceRuleEmailNotification>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GovernanceRuleEmailNotification IModelSerializable<GovernanceRuleEmailNotification>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGovernanceRuleEmailNotification(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GovernanceRuleEmailNotification model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GovernanceRuleEmailNotification(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGovernanceRuleEmailNotification(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
