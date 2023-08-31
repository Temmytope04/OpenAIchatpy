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
    public partial class VMwareCbtTestMigrateContent : IUtf8JsonSerializable, IModelJsonSerializable<VMwareCbtTestMigrateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareCbtTestMigrateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareCbtTestMigrateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtTestMigrateContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSUpgradeVersion))
            {
                writer.WritePropertyName("osUpgradeVersion"u8);
                writer.WriteStringValue(OSUpgradeVersion);
            }
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

        internal static VMwareCbtTestMigrateContent DeserializeVMwareCbtTestMigrateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryPointId = default;
            ResourceIdentifier networkId = default;
            Optional<IList<VMwareCbtNicContent>> vmNics = default;
            Optional<string> osUpgradeVersion = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtNicContent> array = new List<VMwareCbtNicContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtNicContent.DeserializeVMwareCbtNicContent(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("osUpgradeVersion"u8))
                {
                    osUpgradeVersion = property.Value.GetString();
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
            return new VMwareCbtTestMigrateContent(instanceType, recoveryPointId, networkId, Optional.ToList(vmNics), osUpgradeVersion.Value, rawData);
        }

        VMwareCbtTestMigrateContent IModelJsonSerializable<VMwareCbtTestMigrateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtTestMigrateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtTestMigrateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareCbtTestMigrateContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtTestMigrateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareCbtTestMigrateContent IModelSerializable<VMwareCbtTestMigrateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VMwareCbtTestMigrateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareCbtTestMigrateContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VMwareCbtTestMigrateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VMwareCbtTestMigrateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareCbtTestMigrateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
