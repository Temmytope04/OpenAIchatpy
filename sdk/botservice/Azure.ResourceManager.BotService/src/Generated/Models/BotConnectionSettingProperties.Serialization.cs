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
    public partial class BotConnectionSettingProperties : IUtf8JsonSerializable, IModelJsonSerializable<BotConnectionSettingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BotConnectionSettingProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BotConnectionSettingProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStringValue(Scopes);
            }
            if (Optional.IsDefined(ServiceProviderId))
            {
                writer.WritePropertyName("serviceProviderId"u8);
                writer.WriteStringValue(ServiceProviderId);
            }
            if (Optional.IsDefined(ServiceProviderDisplayName))
            {
                writer.WritePropertyName("serviceProviderDisplayName"u8);
                writer.WriteStringValue(ServiceProviderDisplayName);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BotConnectionSettingParameter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        internal static BotConnectionSettingProperties DeserializeBotConnectionSettingProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<string> settingId = default;
            Optional<string> clientSecret = default;
            Optional<string> scopes = default;
            Optional<string> serviceProviderId = default;
            Optional<string> serviceProviderDisplayName = default;
            Optional<IList<BotConnectionSettingParameter>> parameters = default;
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settingId"u8))
                {
                    settingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
                {
                    scopes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceProviderId"u8))
                {
                    serviceProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceProviderDisplayName"u8))
                {
                    serviceProviderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BotConnectionSettingParameter> array = new List<BotConnectionSettingParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotConnectionSettingParameter.DeserializeBotConnectionSettingParameter(item));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BotConnectionSettingProperties(clientId.Value, settingId.Value, clientSecret.Value, scopes.Value, serviceProviderId.Value, serviceProviderDisplayName.Value, Optional.ToList(parameters), provisioningState.Value, rawData);
        }

        BotConnectionSettingProperties IModelJsonSerializable<BotConnectionSettingProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBotConnectionSettingProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BotConnectionSettingProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BotConnectionSettingProperties IModelSerializable<BotConnectionSettingProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBotConnectionSettingProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BotConnectionSettingProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BotConnectionSettingProperties"/> to convert. </param>
        public static implicit operator RequestContent(BotConnectionSettingProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BotConnectionSettingProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BotConnectionSettingProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBotConnectionSettingProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
