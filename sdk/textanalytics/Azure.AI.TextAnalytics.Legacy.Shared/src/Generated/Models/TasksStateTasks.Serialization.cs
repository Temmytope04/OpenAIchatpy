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

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasks : IUtf8JsonSerializable, IModelJsonSerializable<TasksStateTasks>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TasksStateTasks>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TasksStateTasks>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TasksStateTasks>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("completed"u8);
            writer.WriteNumberValue(Completed);
            writer.WritePropertyName("failed"u8);
            writer.WriteNumberValue(Failed);
            writer.WritePropertyName("inProgress"u8);
            writer.WriteNumberValue(InProgress);
            writer.WritePropertyName("total"u8);
            writer.WriteNumberValue(Total);
            if (Optional.IsCollectionDefined(EntityRecognitionTasks))
            {
                writer.WritePropertyName("entityRecognitionTasks"u8);
                writer.WriteStartArray();
                foreach (var item in EntityRecognitionTasks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TasksStateTasksEntityRecognitionTasksItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EntityRecognitionPiiTasks))
            {
                writer.WritePropertyName("entityRecognitionPiiTasks"u8);
                writer.WriteStartArray();
                foreach (var item in EntityRecognitionPiiTasks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TasksStateTasksEntityRecognitionPiiTasksItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KeyPhraseExtractionTasks))
            {
                writer.WritePropertyName("keyPhraseExtractionTasks"u8);
                writer.WriteStartArray();
                foreach (var item in KeyPhraseExtractionTasks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TasksStateTasksKeyPhraseExtractionTasksItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EntityLinkingTasks))
            {
                writer.WritePropertyName("entityLinkingTasks"u8);
                writer.WriteStartArray();
                foreach (var item in EntityLinkingTasks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TasksStateTasksEntityLinkingTasksItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SentimentAnalysisTasks))
            {
                writer.WritePropertyName("sentimentAnalysisTasks"u8);
                writer.WriteStartArray();
                foreach (var item in SentimentAnalysisTasks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TasksStateTasksSentimentAnalysisTasksItem>)item).Serialize(writer, options);
                    }
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

        internal static TasksStateTasks DeserializeTasksStateTasks(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Optional<IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem>> entityRecognitionTasks = default;
            Optional<IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem>> entityRecognitionPiiTasks = default;
            Optional<IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem>> keyPhraseExtractionTasks = default;
            Optional<IReadOnlyList<TasksStateTasksEntityLinkingTasksItem>> entityLinkingTasks = default;
            Optional<IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem>> sentimentAnalysisTasks = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completed"u8))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"u8))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityRecognitionTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityRecognitionTasksItem> array = new List<TasksStateTasksEntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionTasksItem.DeserializeTasksStateTasksEntityRecognitionTasksItem(item));
                    }
                    entityRecognitionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityRecognitionPiiTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityRecognitionPiiTasksItem> array = new List<TasksStateTasksEntityRecognitionPiiTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionPiiTasksItem.DeserializeTasksStateTasksEntityRecognitionPiiTasksItem(item));
                    }
                    entityRecognitionPiiTasks = array;
                    continue;
                }
                if (property.NameEquals("keyPhraseExtractionTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksKeyPhraseExtractionTasksItem> array = new List<TasksStateTasksKeyPhraseExtractionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksKeyPhraseExtractionTasksItem.DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(item));
                    }
                    keyPhraseExtractionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityLinkingTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityLinkingTasksItem> array = new List<TasksStateTasksEntityLinkingTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityLinkingTasksItem.DeserializeTasksStateTasksEntityLinkingTasksItem(item));
                    }
                    entityLinkingTasks = array;
                    continue;
                }
                if (property.NameEquals("sentimentAnalysisTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksSentimentAnalysisTasksItem> array = new List<TasksStateTasksSentimentAnalysisTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksSentimentAnalysisTasksItem.DeserializeTasksStateTasksSentimentAnalysisTasksItem(item));
                    }
                    sentimentAnalysisTasks = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TasksStateTasks(completed, failed, inProgress, total, Optional.ToList(entityRecognitionTasks), Optional.ToList(entityRecognitionPiiTasks), Optional.ToList(keyPhraseExtractionTasks), Optional.ToList(entityLinkingTasks), Optional.ToList(sentimentAnalysisTasks), rawData);
        }

        TasksStateTasks IModelJsonSerializable<TasksStateTasks>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TasksStateTasks>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTasksStateTasks(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TasksStateTasks>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TasksStateTasks>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TasksStateTasks IModelSerializable<TasksStateTasks>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TasksStateTasks>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTasksStateTasks(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TasksStateTasks"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TasksStateTasks"/> to convert. </param>
        public static implicit operator RequestContent(TasksStateTasks model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TasksStateTasks"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TasksStateTasks(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTasksStateTasks(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
