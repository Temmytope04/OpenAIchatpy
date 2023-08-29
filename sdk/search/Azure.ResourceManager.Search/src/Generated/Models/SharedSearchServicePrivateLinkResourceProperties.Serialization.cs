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

namespace Azure.ResourceManager.Search.Models
{
    public partial class SharedSearchServicePrivateLinkResourceProperties : IUtf8JsonSerializable, IModelJsonSerializable<SharedSearchServicePrivateLinkResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SharedSearchServicePrivateLinkResourceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SharedSearchServicePrivateLinkResourceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(ResourceRegion))
            {
                writer.WritePropertyName("resourceRegion"u8);
                writer.WriteStringValue(ResourceRegion.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
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

        internal static SharedSearchServicePrivateLinkResourceProperties DeserializeSharedSearchServicePrivateLinkResourceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> privateLinkResourceId = default;
            Optional<string> groupId = default;
            Optional<string> requestMessage = default;
            Optional<AzureLocation> resourceRegion = default;
            Optional<SharedSearchServicePrivateLinkResourceStatus> status = default;
            Optional<SharedSearchServicePrivateLinkResourceProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestMessage"u8))
                {
                    requestMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSharedSearchServicePrivateLinkResourceStatus();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = property.Value.GetString().ToSharedSearchServicePrivateLinkResourceProvisioningState();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SharedSearchServicePrivateLinkResourceProperties(privateLinkResourceId.Value, groupId.Value, requestMessage.Value, Optional.ToNullable(resourceRegion), Optional.ToNullable(status), Optional.ToNullable(provisioningState), rawData);
        }

        SharedSearchServicePrivateLinkResourceProperties IModelJsonSerializable<SharedSearchServicePrivateLinkResourceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedSearchServicePrivateLinkResourceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SharedSearchServicePrivateLinkResourceProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SharedSearchServicePrivateLinkResourceProperties IModelSerializable<SharedSearchServicePrivateLinkResourceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSharedSearchServicePrivateLinkResourceProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SharedSearchServicePrivateLinkResourceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SharedSearchServicePrivateLinkResourceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSharedSearchServicePrivateLinkResourceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
