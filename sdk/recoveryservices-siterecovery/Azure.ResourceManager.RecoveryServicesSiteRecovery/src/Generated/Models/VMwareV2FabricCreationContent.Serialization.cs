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
    public partial class VMwareV2FabricCreationContent : IUtf8JsonSerializable, IModelJsonSerializable<VMwareV2FabricCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareV2FabricCreationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareV2FabricCreationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareV2FabricCreationContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VMwareSiteId))
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VMwareSiteId);
            }
            if (Optional.IsDefined(PhysicalSiteId))
            {
                writer.WritePropertyName("physicalSiteId"u8);
                writer.WriteStringValue(PhysicalSiteId);
            }
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
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

        internal static VMwareV2FabricCreationContent DeserializeVMwareV2FabricCreationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vmwareSiteId = default;
            Optional<ResourceIdentifier> physicalSiteId = default;
            ResourceIdentifier migrationSolutionId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("physicalSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
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
            return new VMwareV2FabricCreationContent(instanceType, vmwareSiteId.Value, physicalSiteId.Value, migrationSolutionId, rawData);
        }

        VMwareV2FabricCreationContent IModelJsonSerializable<VMwareV2FabricCreationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareV2FabricCreationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareV2FabricCreationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareV2FabricCreationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareV2FabricCreationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareV2FabricCreationContent IModelSerializable<VMwareV2FabricCreationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareV2FabricCreationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareV2FabricCreationContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VMwareV2FabricCreationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VMwareV2FabricCreationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareV2FabricCreationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
