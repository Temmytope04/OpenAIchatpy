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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ExternalInstallationSoftwareConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ExternalInstallationSoftwareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExternalInstallationSoftwareConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExternalInstallationSoftwareConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalInstallationSoftwareConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CentralServerVmId))
            {
                writer.WritePropertyName("centralServerVmId"u8);
                writer.WriteStringValue(CentralServerVmId);
            }
            writer.WritePropertyName("softwareInstallationType"u8);
            writer.WriteStringValue(SoftwareInstallationType.ToString());
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

        internal static ExternalInstallationSoftwareConfiguration DeserializeExternalInstallationSoftwareConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> centralServerVmId = default;
            SapSoftwareInstallationType softwareInstallationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("centralServerVmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    centralServerVmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softwareInstallationType"u8))
                {
                    softwareInstallationType = new SapSoftwareInstallationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExternalInstallationSoftwareConfiguration(softwareInstallationType, centralServerVmId.Value, rawData);
        }

        ExternalInstallationSoftwareConfiguration IModelJsonSerializable<ExternalInstallationSoftwareConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalInstallationSoftwareConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExternalInstallationSoftwareConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExternalInstallationSoftwareConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalInstallationSoftwareConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExternalInstallationSoftwareConfiguration IModelSerializable<ExternalInstallationSoftwareConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalInstallationSoftwareConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExternalInstallationSoftwareConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExternalInstallationSoftwareConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExternalInstallationSoftwareConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ExternalInstallationSoftwareConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExternalInstallationSoftwareConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExternalInstallationSoftwareConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExternalInstallationSoftwareConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
