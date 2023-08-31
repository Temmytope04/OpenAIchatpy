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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class SkypeChannelProperties : IUtf8JsonSerializable, IModelJsonSerializable<SkypeChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SkypeChannelProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SkypeChannelProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsMessagingEnabled))
            {
                writer.WritePropertyName("enableMessaging"u8);
                writer.WriteBooleanValue(IsMessagingEnabled.Value);
            }
            if (Optional.IsDefined(IsMediaCardsEnabled))
            {
                writer.WritePropertyName("enableMediaCards"u8);
                writer.WriteBooleanValue(IsMediaCardsEnabled.Value);
            }
            if (Optional.IsDefined(IsVideoEnabled))
            {
                writer.WritePropertyName("enableVideo"u8);
                writer.WriteBooleanValue(IsVideoEnabled.Value);
            }
            if (Optional.IsDefined(IsCallingEnabled))
            {
                writer.WritePropertyName("enableCalling"u8);
                writer.WriteBooleanValue(IsCallingEnabled.Value);
            }
            if (Optional.IsDefined(IsScreenSharingEnabled))
            {
                writer.WritePropertyName("enableScreenSharing"u8);
                writer.WriteBooleanValue(IsScreenSharingEnabled.Value);
            }
            if (Optional.IsDefined(IsGroupsEnabled))
            {
                writer.WritePropertyName("enableGroups"u8);
                writer.WriteBooleanValue(IsGroupsEnabled.Value);
            }
            if (Optional.IsDefined(GroupsMode))
            {
                writer.WritePropertyName("groupsMode"u8);
                writer.WriteStringValue(GroupsMode);
            }
            if (Optional.IsDefined(CallingWebHook))
            {
                writer.WritePropertyName("callingWebHook"u8);
                writer.WriteStringValue(CallingWebHook);
            }
            if (Optional.IsDefined(IncomingCallRoute))
            {
                writer.WritePropertyName("incomingCallRoute"u8);
                writer.WriteStringValue(IncomingCallRoute);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
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

        internal static SkypeChannelProperties DeserializeSkypeChannelProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableMessaging = default;
            Optional<bool> enableMediaCards = default;
            Optional<bool> enableVideo = default;
            Optional<bool> enableCalling = default;
            Optional<bool> enableScreenSharing = default;
            Optional<bool> enableGroups = default;
            Optional<string> groupsMode = default;
            Optional<string> callingWebHook = default;
            Optional<string> incomingCallRoute = default;
            bool isEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableMessaging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableMessaging = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableMediaCards"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableMediaCards = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVideo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVideo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableCalling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCalling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableScreenSharing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableScreenSharing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableGroups = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupsMode"u8))
                {
                    groupsMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callingWebHook"u8))
                {
                    callingWebHook = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("incomingCallRoute"u8))
                {
                    incomingCallRoute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SkypeChannelProperties(Optional.ToNullable(enableMessaging), Optional.ToNullable(enableMediaCards), Optional.ToNullable(enableVideo), Optional.ToNullable(enableCalling), Optional.ToNullable(enableScreenSharing), Optional.ToNullable(enableGroups), groupsMode.Value, callingWebHook.Value, incomingCallRoute.Value, isEnabled, rawData);
        }

        SkypeChannelProperties IModelJsonSerializable<SkypeChannelProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSkypeChannelProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SkypeChannelProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SkypeChannelProperties IModelSerializable<SkypeChannelProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSkypeChannelProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SkypeChannelProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SkypeChannelProperties"/> to convert. </param>
        public static implicit operator RequestContent(SkypeChannelProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SkypeChannelProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SkypeChannelProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSkypeChannelProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
