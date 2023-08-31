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

namespace Azure.ResourceManager.Automanage.Models
{
    public partial class AutomanageConfigurationProfileAssignmentProperties : IUtf8JsonSerializable, IModelJsonSerializable<AutomanageConfigurationProfileAssignmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomanageConfigurationProfileAssignmentProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomanageConfigurationProfileAssignmentProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConfigurationProfile))
            {
                writer.WritePropertyName("configurationProfile"u8);
                writer.WriteStringValue(ConfigurationProfile);
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

        internal static AutomanageConfigurationProfileAssignmentProperties DeserializeAutomanageConfigurationProfileAssignmentProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> configurationProfile = default;
            Optional<ResourceIdentifier> targetId = default;
            Optional<string> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationProfile = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomanageConfigurationProfileAssignmentProperties(configurationProfile.Value, targetId.Value, status.Value, rawData);
        }

        AutomanageConfigurationProfileAssignmentProperties IModelJsonSerializable<AutomanageConfigurationProfileAssignmentProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomanageConfigurationProfileAssignmentProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomanageConfigurationProfileAssignmentProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomanageConfigurationProfileAssignmentProperties IModelSerializable<AutomanageConfigurationProfileAssignmentProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomanageConfigurationProfileAssignmentProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomanageConfigurationProfileAssignmentProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomanageConfigurationProfileAssignmentProperties"/> to convert. </param>
        public static implicit operator RequestContent(AutomanageConfigurationProfileAssignmentProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomanageConfigurationProfileAssignmentProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomanageConfigurationProfileAssignmentProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomanageConfigurationProfileAssignmentProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
