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

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleWeeklyRecurrence : IUtf8JsonSerializable, IModelJsonSerializable<AlertProcessingRuleWeeklyRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AlertProcessingRuleWeeklyRecurrence>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AlertProcessingRuleWeeklyRecurrence>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AlertProcessingRuleWeeklyRecurrence>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("daysOfWeek"u8);
            writer.WriteStartArray();
            foreach (var item in DaysOfWeek)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("recurrenceType"u8);
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "T");
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

        internal static AlertProcessingRuleWeeklyRecurrence DeserializeAlertProcessingRuleWeeklyRecurrence(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AlertsManagementDayOfWeek> daysOfWeek = default;
            RecurrenceType recurrenceType = default;
            Optional<TimeSpan> startTime = default;
            Optional<TimeSpan> endTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfWeek"u8))
                {
                    List<AlertsManagementDayOfWeek> array = new List<AlertsManagementDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlertsManagementDayOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("recurrenceType"u8))
                {
                    recurrenceType = new RecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AlertProcessingRuleWeeklyRecurrence(recurrenceType, Optional.ToNullable(startTime), Optional.ToNullable(endTime), daysOfWeek, rawData);
        }

        AlertProcessingRuleWeeklyRecurrence IModelJsonSerializable<AlertProcessingRuleWeeklyRecurrence>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AlertProcessingRuleWeeklyRecurrence>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleWeeklyRecurrence(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AlertProcessingRuleWeeklyRecurrence>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AlertProcessingRuleWeeklyRecurrence>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AlertProcessingRuleWeeklyRecurrence IModelSerializable<AlertProcessingRuleWeeklyRecurrence>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AlertProcessingRuleWeeklyRecurrence>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAlertProcessingRuleWeeklyRecurrence(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AlertProcessingRuleWeeklyRecurrence"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AlertProcessingRuleWeeklyRecurrence"/> to convert. </param>
        public static implicit operator RequestContent(AlertProcessingRuleWeeklyRecurrence model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AlertProcessingRuleWeeklyRecurrence"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AlertProcessingRuleWeeklyRecurrence(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAlertProcessingRuleWeeklyRecurrence(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
