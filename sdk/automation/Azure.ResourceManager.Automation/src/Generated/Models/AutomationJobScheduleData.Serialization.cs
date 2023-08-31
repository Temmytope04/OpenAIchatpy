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
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationJobScheduleData : IUtf8JsonSerializable, IModelJsonSerializable<AutomationJobScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutomationJobScheduleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutomationJobScheduleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(JobScheduleId))
            {
                writer.WritePropertyName("jobScheduleId"u8);
                writer.WriteStringValue(JobScheduleId.Value);
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                if (Schedule is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ScheduleAssociationProperty>)Schedule).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Runbook))
            {
                writer.WritePropertyName("runbook"u8);
                if (Runbook is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunbookAssociationProperty>)Runbook).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RunOn))
            {
                writer.WritePropertyName("runOn"u8);
                writer.WriteStringValue(RunOn);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        internal static AutomationJobScheduleData DeserializeAutomationJobScheduleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> jobScheduleId = default;
            Optional<ScheduleAssociationProperty> schedule = default;
            Optional<RunbookAssociationProperty> runbook = default;
            Optional<string> runOn = default;
            Optional<IReadOnlyDictionary<string, string>> parameters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("jobScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobScheduleId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("schedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schedule = ScheduleAssociationProperty.DeserializeScheduleAssociationProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("runbook"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runbook = RunbookAssociationProperty.DeserializeRunbookAssociationProperty(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("runOn"u8))
                        {
                            runOn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutomationJobScheduleData(id, name, type, systemData.Value, Optional.ToNullable(jobScheduleId), schedule.Value, runbook.Value, runOn.Value, Optional.ToDictionary(parameters), rawData);
        }

        AutomationJobScheduleData IModelJsonSerializable<AutomationJobScheduleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationJobScheduleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutomationJobScheduleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutomationJobScheduleData IModelSerializable<AutomationJobScheduleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutomationJobScheduleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutomationJobScheduleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutomationJobScheduleData"/> to convert. </param>
        public static implicit operator RequestContent(AutomationJobScheduleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutomationJobScheduleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutomationJobScheduleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutomationJobScheduleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
