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
    public partial class InMageRcmUnplannedFailoverContent : IUtf8JsonSerializable, IModelJsonSerializable<InMageRcmUnplannedFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageRcmUnplannedFailoverContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageRcmUnplannedFailoverContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmUnplannedFailoverContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("performShutdown"u8);
            writer.WriteStringValue(PerformShutdown);
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
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

        internal static InMageRcmUnplannedFailoverContent DeserializeInMageRcmUnplannedFailoverContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string performShutdown = default;
            Optional<ResourceIdentifier> recoveryPointId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("performShutdown"u8))
                {
                    performShutdown = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
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
            return new InMageRcmUnplannedFailoverContent(instanceType, performShutdown, recoveryPointId.Value, rawData);
        }

        InMageRcmUnplannedFailoverContent IModelJsonSerializable<InMageRcmUnplannedFailoverContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmUnplannedFailoverContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmUnplannedFailoverContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageRcmUnplannedFailoverContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmUnplannedFailoverContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageRcmUnplannedFailoverContent IModelSerializable<InMageRcmUnplannedFailoverContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmUnplannedFailoverContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageRcmUnplannedFailoverContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InMageRcmUnplannedFailoverContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InMageRcmUnplannedFailoverContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageRcmUnplannedFailoverContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
