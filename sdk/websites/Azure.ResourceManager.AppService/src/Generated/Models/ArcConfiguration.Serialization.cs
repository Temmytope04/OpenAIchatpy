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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ArcConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ArcConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArcConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArcConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactsStorageType))
            {
                writer.WritePropertyName("artifactsStorageType"u8);
                writer.WriteStringValue(ArtifactsStorageType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ArtifactStorageClassName))
            {
                writer.WritePropertyName("artifactStorageClassName"u8);
                writer.WriteStringValue(ArtifactStorageClassName);
            }
            if (Optional.IsDefined(ArtifactStorageMountPath))
            {
                writer.WritePropertyName("artifactStorageMountPath"u8);
                writer.WriteStringValue(ArtifactStorageMountPath);
            }
            if (Optional.IsDefined(ArtifactStorageNodeName))
            {
                writer.WritePropertyName("artifactStorageNodeName"u8);
                writer.WriteStringValue(ArtifactStorageNodeName);
            }
            if (Optional.IsDefined(ArtifactStorageAccessMode))
            {
                writer.WritePropertyName("artifactStorageAccessMode"u8);
                writer.WriteStringValue(ArtifactStorageAccessMode);
            }
            if (Optional.IsDefined(FrontEndServiceConfiguration))
            {
                writer.WritePropertyName("frontEndServiceConfiguration"u8);
                writer.WriteObjectValue(FrontEndServiceConfiguration);
            }
            if (Optional.IsDefined(KubeConfig))
            {
                writer.WritePropertyName("kubeConfig"u8);
                writer.WriteStringValue(KubeConfig);
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

        internal static ArcConfiguration DeserializeArcConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArtifactStorageType> artifactsStorageType = default;
            Optional<string> artifactStorageClassName = default;
            Optional<string> artifactStorageMountPath = default;
            Optional<string> artifactStorageNodeName = default;
            Optional<string> artifactStorageAccessMode = default;
            Optional<FrontEndConfiguration> frontEndServiceConfiguration = default;
            Optional<string> kubeConfig = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactsStorageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactsStorageType = property.Value.GetString().ToArtifactStorageType();
                    continue;
                }
                if (property.NameEquals("artifactStorageClassName"u8))
                {
                    artifactStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageMountPath"u8))
                {
                    artifactStorageMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageNodeName"u8))
                {
                    artifactStorageNodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageAccessMode"u8))
                {
                    artifactStorageAccessMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontEndServiceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontEndServiceConfiguration = FrontEndConfiguration.DeserializeFrontEndConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("kubeConfig"u8))
                {
                    kubeConfig = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArcConfiguration(Optional.ToNullable(artifactsStorageType), artifactStorageClassName.Value, artifactStorageMountPath.Value, artifactStorageNodeName.Value, artifactStorageAccessMode.Value, frontEndServiceConfiguration.Value, kubeConfig.Value, rawData);
        }

        ArcConfiguration IModelJsonSerializable<ArcConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArcConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArcConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArcConfiguration IModelSerializable<ArcConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArcConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ArcConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ArcConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArcConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
