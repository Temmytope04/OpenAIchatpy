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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SubProtectionPolicy : IUtf8JsonSerializable, IModelJsonSerializable<SubProtectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubProtectionPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubProtectionPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType"u8);
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(SchedulePolicy))
            {
                writer.WritePropertyName("schedulePolicy"u8);
                writer.WriteObjectValue(SchedulePolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsCollectionDefined(TieringPolicy))
            {
                writer.WritePropertyName("tieringPolicy"u8);
                writer.WriteStartObject();
                foreach (var item in TieringPolicy)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static SubProtectionPolicy DeserializeSubProtectionPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubProtectionPolicyType> policyType = default;
            Optional<BackupSchedulePolicy> schedulePolicy = default;
            Optional<BackupRetentionPolicy> retentionPolicy = default;
            Optional<IDictionary<string, BackupTieringPolicy>> tieringPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyType = new SubProtectionPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulePolicy = BackupSchedulePolicy.DeserializeBackupSchedulePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPolicy = BackupRetentionPolicy.DeserializeBackupRetentionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("tieringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BackupTieringPolicy> dictionary = new Dictionary<string, BackupTieringPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BackupTieringPolicy.DeserializeBackupTieringPolicy(property0.Value));
                    }
                    tieringPolicy = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubProtectionPolicy(Optional.ToNullable(policyType), schedulePolicy.Value, retentionPolicy.Value, Optional.ToDictionary(tieringPolicy), rawData);
        }

        SubProtectionPolicy IModelJsonSerializable<SubProtectionPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubProtectionPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubProtectionPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubProtectionPolicy IModelSerializable<SubProtectionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubProtectionPolicy(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SubProtectionPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SubProtectionPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubProtectionPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
