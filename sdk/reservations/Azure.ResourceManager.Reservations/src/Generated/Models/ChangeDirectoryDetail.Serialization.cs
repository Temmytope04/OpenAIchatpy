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

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ChangeDirectoryDetail : IUtf8JsonSerializable, IModelJsonSerializable<ChangeDirectoryDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ChangeDirectoryDetail>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ChangeDirectoryDetail>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ReservationOrder))
            {
                writer.WritePropertyName("reservationOrder"u8);
                writer.WriteObjectValue(ReservationOrder);
            }
            if (Optional.IsCollectionDefined(Reservations))
            {
                writer.WritePropertyName("reservations"u8);
                writer.WriteStartArray();
                foreach (var item in Reservations)
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

        internal static ChangeDirectoryDetail DeserializeChangeDirectoryDetail(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ChangeDirectoryResult> reservationOrder = default;
            Optional<IReadOnlyList<ChangeDirectoryResult>> reservations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationOrder = ChangeDirectoryResult.DeserializeChangeDirectoryResult(property.Value);
                    continue;
                }
                if (property.NameEquals("reservations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChangeDirectoryResult> array = new List<ChangeDirectoryResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChangeDirectoryResult.DeserializeChangeDirectoryResult(item));
                    }
                    reservations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ChangeDirectoryDetail(reservationOrder.Value, Optional.ToList(reservations), rawData);
        }

        ChangeDirectoryDetail IModelJsonSerializable<ChangeDirectoryDetail>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeDirectoryDetail(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ChangeDirectoryDetail>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ChangeDirectoryDetail IModelSerializable<ChangeDirectoryDetail>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChangeDirectoryDetail(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ChangeDirectoryDetail model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ChangeDirectoryDetail(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChangeDirectoryDetail(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
