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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    public partial class StorageMoverAgentData : IUtf8JsonSerializable, IModelJsonSerializable<StorageMoverAgentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageMoverAgentData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageMoverAgentData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("arcResourceId"u8);
            writer.WriteStringValue(ArcResourceId);
            writer.WritePropertyName("arcVmUuid"u8);
            writer.WriteStringValue(ArcVmUuid);
            writer.WriteEndObject();
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

        internal static StorageMoverAgentData DeserializeStorageMoverAgentData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> agentVersion = default;
            string arcResourceId = default;
            string arcVmUuid = default;
            Optional<StorageMoverAgentStatus> agentStatus = default;
            Optional<DateTimeOffset> lastStatusUpdate = default;
            Optional<string> localIPAddress = default;
            Optional<long> memoryInMB = default;
            Optional<long> numberOfCores = default;
            Optional<long> uptimeInSeconds = default;
            Optional<StorageMoverAgentPropertiesErrorDetails> errorDetails = default;
            Optional<StorageMoverProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arcResourceId"u8))
                        {
                            arcResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arcVmUuid"u8))
                        {
                            arcVmUuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentStatus = new StorageMoverAgentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastStatusUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastStatusUpdate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("localIPAddress"u8))
                        {
                            localIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memoryInMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memoryInMB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfCores = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("uptimeInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uptimeInSeconds = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("errorDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorDetails = StorageMoverAgentPropertiesErrorDetails.DeserializeStorageMoverAgentPropertiesErrorDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageMoverProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageMoverAgentData(id, name, type, systemData.Value, description.Value, agentVersion.Value, arcResourceId, arcVmUuid, Optional.ToNullable(agentStatus), Optional.ToNullable(lastStatusUpdate), localIPAddress.Value, Optional.ToNullable(memoryInMB), Optional.ToNullable(numberOfCores), Optional.ToNullable(uptimeInSeconds), errorDetails.Value, Optional.ToNullable(provisioningState), rawData);
        }

        StorageMoverAgentData IModelJsonSerializable<StorageMoverAgentData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageMoverAgentData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageMoverAgentData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageMoverAgentData IModelSerializable<StorageMoverAgentData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageMoverAgentData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StorageMoverAgentData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StorageMoverAgentData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageMoverAgentData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
