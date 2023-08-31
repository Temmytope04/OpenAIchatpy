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
    public partial class FileShareBackupContent : IUtf8JsonSerializable, IModelJsonSerializable<FileShareBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FileShareBackupContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FileShareBackupContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FileShareBackupContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointExpireOn))
            {
                writer.WritePropertyName("recoveryPointExpiryTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointExpireOn.Value, "O");
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static FileShareBackupContent DeserializeFileShareBackupContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> recoveryPointExpiryTimeInUTC = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointExpiryTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointExpiryTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FileShareBackupContent(objectType, Optional.ToNullable(recoveryPointExpiryTimeInUTC), rawData);
        }

        FileShareBackupContent IModelJsonSerializable<FileShareBackupContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FileShareBackupContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFileShareBackupContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FileShareBackupContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FileShareBackupContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FileShareBackupContent IModelSerializable<FileShareBackupContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<FileShareBackupContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFileShareBackupContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(FileShareBackupContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator FileShareBackupContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFileShareBackupContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
