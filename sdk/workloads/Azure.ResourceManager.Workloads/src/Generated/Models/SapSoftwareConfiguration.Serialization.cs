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
    public partial class SapSoftwareConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<SapSoftwareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapSoftwareConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapSoftwareConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSoftwareConfiguration>(this, options.Format);

            writer.WriteStartObject();
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

        internal static SapSoftwareConfiguration DeserializeSapSoftwareConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("softwareInstallationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "External": return ExternalInstallationSoftwareConfiguration.DeserializeExternalInstallationSoftwareConfiguration(element);
                    case "SAPInstallWithoutOSConfig": return SapInstallWithoutOSConfigSoftwareConfiguration.DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(element);
                    case "ServiceInitiated": return ServiceInitiatedSoftwareConfiguration.DeserializeServiceInitiatedSoftwareConfiguration(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            SapSoftwareInstallationType softwareInstallationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownSoftwareConfiguration(softwareInstallationType, rawData);
        }

        SapSoftwareConfiguration IModelJsonSerializable<SapSoftwareConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSoftwareConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSoftwareConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapSoftwareConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSoftwareConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapSoftwareConfiguration IModelSerializable<SapSoftwareConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSoftwareConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapSoftwareConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapSoftwareConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapSoftwareConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(SapSoftwareConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapSoftwareConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapSoftwareConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapSoftwareConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
