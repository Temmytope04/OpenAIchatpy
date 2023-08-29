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
    public partial class VirtualApplication : IUtf8JsonSerializable, IModelJsonSerializable<VirtualApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualApplication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualApplication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualPath))
            {
                writer.WritePropertyName("virtualPath"u8);
                writer.WriteStringValue(VirtualPath);
            }
            if (Optional.IsDefined(PhysicalPath))
            {
                writer.WritePropertyName("physicalPath"u8);
                writer.WriteStringValue(PhysicalPath);
            }
            if (Optional.IsDefined(IsPreloadEnabled))
            {
                writer.WritePropertyName("preloadEnabled"u8);
                writer.WriteBooleanValue(IsPreloadEnabled.Value);
            }
            if (Optional.IsCollectionDefined(VirtualDirectories))
            {
                writer.WritePropertyName("virtualDirectories"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualDirectories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static VirtualApplication DeserializeVirtualApplication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> virtualPath = default;
            Optional<string> physicalPath = default;
            Optional<bool> preloadEnabled = default;
            Optional<IList<VirtualDirectory>> virtualDirectories = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualPath"u8))
                {
                    virtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalPath"u8))
                {
                    physicalPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preloadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preloadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualDirectories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualDirectory> array = new List<VirtualDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualDirectory.DeserializeVirtualDirectory(item));
                    }
                    virtualDirectories = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualApplication(virtualPath.Value, physicalPath.Value, Optional.ToNullable(preloadEnabled), Optional.ToList(virtualDirectories), rawData);
        }

        VirtualApplication IModelJsonSerializable<VirtualApplication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualApplication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualApplication>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualApplication IModelSerializable<VirtualApplication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualApplication(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VirtualApplication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VirtualApplication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualApplication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
