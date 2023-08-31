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
    public partial class JitNetworkAccessRequestInfo : IUtf8JsonSerializable, IModelJsonSerializable<JitNetworkAccessRequestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JitNetworkAccessRequestInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JitNetworkAccessRequestInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("virtualMachines"u8);
            writer.WriteStartArray();
            foreach (var item in VirtualMachines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("startTimeUtc"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("requestor"u8);
            writer.WriteStringValue(Requestor);
            if (Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
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

        internal static JitNetworkAccessRequestInfo DeserializeJitNetworkAccessRequestInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<JitNetworkAccessRequestVirtualMachine> virtualMachines = default;
            DateTimeOffset startTimeUtc = default;
            string requestor = default;
            Optional<string> justification = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachines"u8))
                {
                    List<JitNetworkAccessRequestVirtualMachine> array = new List<JitNetworkAccessRequestVirtualMachine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitNetworkAccessRequestVirtualMachine.DeserializeJitNetworkAccessRequestVirtualMachine(item));
                    }
                    virtualMachines = array;
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("requestor"u8))
                {
                    requestor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JitNetworkAccessRequestInfo(virtualMachines, startTimeUtc, requestor, justification.Value, rawData);
        }

        JitNetworkAccessRequestInfo IModelJsonSerializable<JitNetworkAccessRequestInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessRequestInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JitNetworkAccessRequestInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JitNetworkAccessRequestInfo IModelSerializable<JitNetworkAccessRequestInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJitNetworkAccessRequestInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(JitNetworkAccessRequestInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator JitNetworkAccessRequestInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJitNetworkAccessRequestInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
