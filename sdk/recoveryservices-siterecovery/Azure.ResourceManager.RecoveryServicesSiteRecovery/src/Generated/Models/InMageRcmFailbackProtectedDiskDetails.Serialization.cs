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
    public partial class InMageRcmFailbackProtectedDiskDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageRcmFailbackProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageRcmFailbackProtectedDiskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageRcmFailbackProtectedDiskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IrDetails))
            {
                writer.WritePropertyName("irDetails"u8);
                writer.WriteObjectValue(IrDetails);
            }
            if (Optional.IsDefined(ResyncDetails))
            {
                writer.WritePropertyName("resyncDetails"u8);
                writer.WriteObjectValue(ResyncDetails);
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

        internal static InMageRcmFailbackProtectedDiskDetails DeserializeInMageRcmFailbackProtectedDiskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<string> isOSDisk = default;
            Optional<long> capacityInBytes = default;
            Optional<string> diskUuid = default;
            Optional<double> dataPendingInLogDataStoreInMB = default;
            Optional<double> dataPendingAtSourceAgentInMB = default;
            Optional<string> isInitialReplicationComplete = default;
            Optional<InMageRcmFailbackSyncDetails> irDetails = default;
            Optional<InMageRcmFailbackSyncDetails> resyncDetails = default;
            Optional<DateTimeOffset> lastSyncTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskUuid"u8))
                {
                    diskUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInLogDataStoreInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInLogDataStoreInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isInitialReplicationComplete"u8))
                {
                    isInitialReplicationComplete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("irDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    irDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("resyncDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageRcmFailbackProtectedDiskDetails(diskId.Value, diskName.Value, isOSDisk.Value, Optional.ToNullable(capacityInBytes), diskUuid.Value, Optional.ToNullable(dataPendingInLogDataStoreInMB), Optional.ToNullable(dataPendingAtSourceAgentInMB), isInitialReplicationComplete.Value, irDetails.Value, resyncDetails.Value, Optional.ToNullable(lastSyncTime), rawData);
        }

        InMageRcmFailbackProtectedDiskDetails IModelJsonSerializable<InMageRcmFailbackProtectedDiskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackProtectedDiskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageRcmFailbackProtectedDiskDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageRcmFailbackProtectedDiskDetails IModelSerializable<InMageRcmFailbackProtectedDiskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageRcmFailbackProtectedDiskDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InMageRcmFailbackProtectedDiskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InMageRcmFailbackProtectedDiskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageRcmFailbackProtectedDiskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
