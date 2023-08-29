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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseKustoPoolData : IUtf8JsonSerializable, IModelJsonSerializable<SynapseKustoPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseKustoPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseKustoPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OptimizedAutoscale))
            {
                writer.WritePropertyName("optimizedAutoscale"u8);
                writer.WriteObjectValue(OptimizedAutoscale);
            }
            if (Optional.IsDefined(EnableStreamingIngest))
            {
                writer.WritePropertyName("enableStreamingIngest"u8);
                writer.WriteBooleanValue(EnableStreamingIngest.Value);
            }
            if (Optional.IsDefined(EnablePurge))
            {
                writer.WritePropertyName("enablePurge"u8);
                writer.WriteBooleanValue(EnablePurge.Value);
            }
            if (Optional.IsDefined(WorkspaceUid))
            {
                writer.WritePropertyName("workspaceUID"u8);
                writer.WriteStringValue(WorkspaceUid.Value);
            }
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

        internal static SynapseKustoPoolData DeserializeSynapseKustoPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseDataSourceSku sku = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoPoolState> state = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<Uri> uri = default;
            Optional<Uri> dataIngestionUri = default;
            Optional<string> stateReason = default;
            Optional<SynapseOptimizedAutoscale> optimizedAutoscale = default;
            Optional<bool> enableStreamingIngest = default;
            Optional<bool> enablePurge = default;
            Optional<SynapseLanguageExtensionsList> languageExtensions = default;
            Optional<Guid> workspaceUID = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = SynapseDataSourceSku.DeserializeSynapseDataSourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new KustoPoolState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedAutoscale = SynapseOptimizedAutoscale.DeserializeSynapseOptimizedAutoscale(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            languageExtensions = SynapseLanguageExtensionsList.DeserializeSynapseLanguageExtensionsList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceUID = property0.Value.GetGuid();
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
            return new SynapseKustoPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, Optional.ToNullable(etag), Optional.ToNullable(state), Optional.ToNullable(provisioningState), uri.Value, dataIngestionUri.Value, stateReason.Value, optimizedAutoscale.Value, Optional.ToNullable(enableStreamingIngest), Optional.ToNullable(enablePurge), languageExtensions.Value, Optional.ToNullable(workspaceUID), rawData);
        }

        SynapseKustoPoolData IModelJsonSerializable<SynapseKustoPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseKustoPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseKustoPoolData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseKustoPoolData IModelSerializable<SynapseKustoPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseKustoPoolData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SynapseKustoPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SynapseKustoPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseKustoPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
