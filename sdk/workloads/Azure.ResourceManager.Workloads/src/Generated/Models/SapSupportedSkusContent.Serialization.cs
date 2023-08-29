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
    public partial class SapSupportedSkusContent : IUtf8JsonSerializable, IModelJsonSerializable<SapSupportedSkusContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapSupportedSkusContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapSupportedSkusContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("appLocation"u8);
            writer.WriteStringValue(AppLocation);
            writer.WritePropertyName("environment"u8);
            writer.WriteStringValue(Environment.ToString());
            writer.WritePropertyName("sapProduct"u8);
            writer.WriteStringValue(SapProduct.ToString());
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("databaseType"u8);
            writer.WriteStringValue(DatabaseType.ToString());
            if (Optional.IsDefined(HighAvailabilityType))
            {
                writer.WritePropertyName("highAvailabilityType"u8);
                writer.WriteStringValue(HighAvailabilityType.Value.ToString());
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

        internal static SapSupportedSkusContent DeserializeSapSupportedSkusContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation appLocation = default;
            SapEnvironmentType environment = default;
            SapProductType sapProduct = default;
            SapDeploymentType deploymentType = default;
            SapDatabaseType databaseType = default;
            Optional<SapHighAvailabilityType> highAvailabilityType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    environment = new SapEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapProduct"u8))
                {
                    sapProduct = new SapProductType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseType"u8))
                {
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("highAvailabilityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilityType = new SapHighAvailabilityType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SapSupportedSkusContent(appLocation, environment, sapProduct, deploymentType, databaseType, Optional.ToNullable(highAvailabilityType), rawData);
        }

        SapSupportedSkusContent IModelJsonSerializable<SapSupportedSkusContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSupportedSkusContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapSupportedSkusContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapSupportedSkusContent IModelSerializable<SapSupportedSkusContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapSupportedSkusContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SapSupportedSkusContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SapSupportedSkusContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapSupportedSkusContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
