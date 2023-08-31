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
    public partial class SecurityAutomationActionLogicApp : IUtf8JsonSerializable, IModelJsonSerializable<SecurityAutomationActionLogicApp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityAutomationActionLogicApp>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityAutomationActionLogicApp>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAutomationActionLogicApp>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LogicAppResourceId))
            {
                writer.WritePropertyName("logicAppResourceId"u8);
                writer.WriteStringValue(LogicAppResourceId);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        internal static SecurityAutomationActionLogicApp DeserializeSecurityAutomationActionLogicApp(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> logicAppResourceId = default;
            Optional<Uri> uri = default;
            ActionType actionType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logicAppResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logicAppResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityAutomationActionLogicApp(actionType, logicAppResourceId.Value, uri.Value, rawData);
        }

        SecurityAutomationActionLogicApp IModelJsonSerializable<SecurityAutomationActionLogicApp>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAutomationActionLogicApp>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAutomationActionLogicApp(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityAutomationActionLogicApp>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAutomationActionLogicApp>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityAutomationActionLogicApp IModelSerializable<SecurityAutomationActionLogicApp>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAutomationActionLogicApp>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityAutomationActionLogicApp(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SecurityAutomationActionLogicApp model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SecurityAutomationActionLogicApp(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityAutomationActionLogicApp(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
