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
    public partial class GcpProjectEnvironment : IUtf8JsonSerializable, IModelJsonSerializable<GcpProjectEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GcpProjectEnvironment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GcpProjectEnvironment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GcpProjectEnvironment>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OrganizationalData))
            {
                writer.WritePropertyName("organizationalData"u8);
                writer.WriteObjectValue(OrganizationalData);
            }
            if (Optional.IsDefined(ProjectDetails))
            {
                writer.WritePropertyName("projectDetails"u8);
                writer.WriteObjectValue(ProjectDetails);
            }
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentType.ToString());
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

        internal static GcpProjectEnvironment DeserializeGcpProjectEnvironment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GcpOrganizationalInfo> organizationalData = default;
            Optional<GcpProjectDetails> projectDetails = default;
            EnvironmentType environmentType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationalData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    organizationalData = GcpOrganizationalInfo.DeserializeGcpOrganizationalInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("projectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectDetails = GcpProjectDetails.DeserializeGcpProjectDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentType"u8))
                {
                    environmentType = new EnvironmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GcpProjectEnvironment(environmentType, organizationalData.Value, projectDetails.Value, rawData);
        }

        GcpProjectEnvironment IModelJsonSerializable<GcpProjectEnvironment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GcpProjectEnvironment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpProjectEnvironment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GcpProjectEnvironment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GcpProjectEnvironment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GcpProjectEnvironment IModelSerializable<GcpProjectEnvironment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GcpProjectEnvironment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGcpProjectEnvironment(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GcpProjectEnvironment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GcpProjectEnvironment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGcpProjectEnvironment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
