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
    public partial class SapSizingRecommendationContent : IUtf8JsonSerializable, IModelJsonSerializable<SapSizingRecommendationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapSizingRecommendationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapSizingRecommendationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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
            writer.WritePropertyName("saps"u8);
            writer.WriteNumberValue(Saps);
            writer.WritePropertyName("dbMemory"u8);
            writer.WriteNumberValue(DBMemory);
            writer.WritePropertyName("databaseType"u8);
            writer.WriteStringValue(DatabaseType.ToString());
            if (Optional.IsDefined(DBScaleMethod))
            {
                writer.WritePropertyName("dbScaleMethod"u8);
                writer.WriteStringValue(DBScaleMethod.Value.ToString());
            }
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

        internal static SapSizingRecommendationContent DeserializeSapSizingRecommendationContent(JsonElement element, ModelSerializerOptions options = default)
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
            long saps = default;
            long dbMemory = default;
            SapDatabaseType databaseType = default;
            Optional<SapDatabaseScaleMethod> dbScaleMethod = default;
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
                if (property.NameEquals("saps"u8))
                {
                    saps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dbMemory"u8))
                {
                    dbMemory = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("databaseType"u8))
                {
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dbScaleMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbScaleMethod = new SapDatabaseScaleMethod(property.Value.GetString());
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
            return new SapSizingRecommendationContent(appLocation, environment, sapProduct, deploymentType, saps, dbMemory, databaseType, Optional.ToNullable(dbScaleMethod), Optional.ToNullable(highAvailabilityType), rawData);
        }

        SapSizingRecommendationContent IModelJsonSerializable<SapSizingRecommendationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSizingRecommendationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapSizingRecommendationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapSizingRecommendationContent IModelSerializable<SapSizingRecommendationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapSizingRecommendationContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SapSizingRecommendationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SapSizingRecommendationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapSizingRecommendationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
