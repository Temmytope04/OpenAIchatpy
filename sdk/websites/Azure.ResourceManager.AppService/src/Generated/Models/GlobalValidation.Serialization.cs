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
    public partial class GlobalValidation : IUtf8JsonSerializable, IModelJsonSerializable<GlobalValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GlobalValidation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GlobalValidation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAuthenticationRequired))
            {
                writer.WritePropertyName("requireAuthentication"u8);
                writer.WriteBooleanValue(IsAuthenticationRequired.Value);
            }
            if (Optional.IsDefined(UnauthenticatedClientAction))
            {
                writer.WritePropertyName("unauthenticatedClientAction"u8);
                writer.WriteStringValue(UnauthenticatedClientAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(RedirectToProvider))
            {
                writer.WritePropertyName("redirectToProvider"u8);
                writer.WriteStringValue(RedirectToProvider);
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteStringValue(item);
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

        internal static GlobalValidation DeserializeGlobalValidation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> requireAuthentication = default;
            Optional<UnauthenticatedClientActionV2> unauthenticatedClientAction = default;
            Optional<string> redirectToProvider = default;
            Optional<IList<string>> excludedPaths = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unauthenticatedClientAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unauthenticatedClientAction = property.Value.GetString().ToUnauthenticatedClientActionV2();
                    continue;
                }
                if (property.NameEquals("redirectToProvider"u8))
                {
                    redirectToProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedPaths = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GlobalValidation(Optional.ToNullable(requireAuthentication), Optional.ToNullable(unauthenticatedClientAction), redirectToProvider.Value, Optional.ToList(excludedPaths), rawData);
        }

        GlobalValidation IModelJsonSerializable<GlobalValidation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGlobalValidation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GlobalValidation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GlobalValidation IModelSerializable<GlobalValidation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGlobalValidation(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GlobalValidation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GlobalValidation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGlobalValidation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
