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

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class AzureKeyVaultProperties : IUtf8JsonSerializable, IModelJsonSerializable<AzureKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureKeyVaultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureKeyVaultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureKeyVaultProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DoesConnectAsKubernetesCsiDriver))
            {
                if (DoesConnectAsKubernetesCsiDriver != null)
                {
                    writer.WritePropertyName("connectAsKubernetesCsiDriver"u8);
                    writer.WriteBooleanValue(DoesConnectAsKubernetesCsiDriver.Value);
                }
                else
                {
                    writer.WriteNull("connectAsKubernetesCsiDriver");
                }
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AzureResourceType.ToString());
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

        internal static AzureKeyVaultProperties DeserializeAzureKeyVaultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool?> connectAsKubernetesCsiDriver = default;
            AzureResourceType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectAsKubernetesCsiDriver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectAsKubernetesCsiDriver = null;
                        continue;
                    }
                    connectAsKubernetesCsiDriver = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new AzureResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureKeyVaultProperties(type, Optional.ToNullable(connectAsKubernetesCsiDriver), rawData);
        }

        AzureKeyVaultProperties IModelJsonSerializable<AzureKeyVaultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureKeyVaultProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureKeyVaultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureKeyVaultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureKeyVaultProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureKeyVaultProperties IModelSerializable<AzureKeyVaultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureKeyVaultProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureKeyVaultProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AzureKeyVaultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AzureKeyVaultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureKeyVaultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
