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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ApplicationServerConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationServerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationServerConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationServerConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationServerConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("virtualMachineConfiguration"u8);
            if (VirtualMachineConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SapVirtualMachineConfiguration>)VirtualMachineConfiguration).Serialize(writer, options);
            }
            writer.WritePropertyName("instanceCount"u8);
            writer.WriteNumberValue(InstanceCount);
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

        internal static ApplicationServerConfiguration DeserializeApplicationServerConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            SapVirtualMachineConfiguration virtualMachineConfiguration = default;
            long instanceCount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    virtualMachineConfiguration = SapVirtualMachineConfiguration.DeserializeSapVirtualMachineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    instanceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationServerConfiguration(subnetId, virtualMachineConfiguration, instanceCount, rawData);
        }

        ApplicationServerConfiguration IModelJsonSerializable<ApplicationServerConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationServerConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationServerConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationServerConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationServerConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationServerConfiguration IModelSerializable<ApplicationServerConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationServerConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationServerConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationServerConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationServerConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationServerConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationServerConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationServerConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationServerConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
