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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceStatus : IUtf8JsonSerializable, IModelJsonSerializable<MoverResourceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MoverResourceStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MoverResourceStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JobStatus))
            {
                if (JobStatus != null)
                {
                    writer.WritePropertyName("jobStatus"u8);
                    writer.WriteObjectValue(JobStatus);
                }
                else
                {
                    writer.WriteNull("jobStatus");
                }
            }
            if (Optional.IsDefined(Errors))
            {
                if (Errors != null)
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteObjectValue(Errors);
                }
                else
                {
                    writer.WriteNull("errors");
                }
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

        internal static MoverResourceStatus DeserializeMoverResourceStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MoverResourceMoveState> moveState = default;
            Optional<MoverResourceJobStatus> jobStatus = default;
            Optional<MoveResourceError> errors = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("moveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveState = new MoverResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobStatus = null;
                        continue;
                    }
                    jobStatus = MoverResourceJobStatus.DeserializeMoverResourceJobStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    errors = MoveResourceError.DeserializeMoveResourceError(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MoverResourceStatus(Optional.ToNullable(moveState), jobStatus.Value, errors.Value, rawData);
        }

        MoverResourceStatus IModelJsonSerializable<MoverResourceStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MoverResourceStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MoverResourceStatus IModelSerializable<MoverResourceStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMoverResourceStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MoverResourceStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MoverResourceStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMoverResourceStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
