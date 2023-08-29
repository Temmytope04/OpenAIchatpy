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
    public partial class RecoveryPlanScriptActionDetails : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryPlanScriptActionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryPlanScriptActionDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryPlanScriptActionDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanScriptActionDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("path"u8);
            writer.WriteStringValue(Path);
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
            }
            writer.WritePropertyName("fabricLocation"u8);
            writer.WriteStringValue(FabricLocation.ToString());
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

        internal static RecoveryPlanScriptActionDetails DeserializeRecoveryPlanScriptActionDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            Optional<string> timeout = default;
            RecoveryPlanActionLocation fabricLocation = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    timeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricLocation"u8))
                {
                    fabricLocation = new RecoveryPlanActionLocation(property.Value.GetString());
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
            return new RecoveryPlanScriptActionDetails(instanceType, path, timeout.Value, fabricLocation, rawData);
        }

        RecoveryPlanScriptActionDetails IModelJsonSerializable<RecoveryPlanScriptActionDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanScriptActionDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanScriptActionDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryPlanScriptActionDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanScriptActionDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryPlanScriptActionDetails IModelSerializable<RecoveryPlanScriptActionDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanScriptActionDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanScriptActionDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RecoveryPlanScriptActionDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RecoveryPlanScriptActionDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryPlanScriptActionDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
