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

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSession : IUtf8JsonSerializable, IModelJsonSerializable<SparkSession>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkSession>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkSession>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LivyInfo))
            {
                writer.WritePropertyName("livyInfo"u8);
                writer.WriteObjectValue(LivyInfo);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(WorkspaceName))
            {
                writer.WritePropertyName("workspaceName"u8);
                writer.WriteStringValue(WorkspaceName);
            }
            if (Optional.IsDefined(SparkPoolName))
            {
                writer.WritePropertyName("sparkPoolName"u8);
                writer.WriteStringValue(SparkPoolName);
            }
            if (Optional.IsDefined(SubmitterName))
            {
                writer.WritePropertyName("submitterName"u8);
                writer.WriteStringValue(SubmitterName);
            }
            if (Optional.IsDefined(SubmitterId))
            {
                writer.WritePropertyName("submitterId"u8);
                writer.WriteStringValue(SubmitterId);
            }
            if (Optional.IsDefined(ArtifactId))
            {
                writer.WritePropertyName("artifactId"u8);
                writer.WriteStringValue(ArtifactId);
            }
            if (Optional.IsDefined(JobType))
            {
                writer.WritePropertyName("jobType"u8);
                writer.WriteStringValue(JobType.Value.ToString());
            }
            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result.Value.ToString());
            }
            if (Optional.IsDefined(Scheduler))
            {
                writer.WritePropertyName("schedulerInfo"u8);
                writer.WriteObjectValue(Scheduler);
            }
            if (Optional.IsDefined(Plugin))
            {
                writer.WritePropertyName("pluginInfo"u8);
                writer.WriteObjectValue(Plugin);
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errorInfo"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            if (Optional.IsDefined(AppId))
            {
                if (AppId != null)
                {
                    writer.WritePropertyName("appId"u8);
                    writer.WriteStringValue(AppId);
                }
                else
                {
                    writer.WriteNull("appId");
                }
            }
            if (Optional.IsCollectionDefined(AppInfo))
            {
                if (AppInfo != null)
                {
                    writer.WritePropertyName("appInfo"u8);
                    writer.WriteStartObject();
                    foreach (var item in AppInfo)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("appInfo");
                }
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(LogLines))
            {
                if (LogLines != null)
                {
                    writer.WritePropertyName("log"u8);
                    writer.WriteStartArray();
                    foreach (var item in LogLines)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("log");
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

        internal static SparkSession DeserializeSparkSession(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SparkSessionState> livyInfo = default;
            Optional<string> name = default;
            Optional<string> workspaceName = default;
            Optional<string> sparkPoolName = default;
            Optional<string> submitterName = default;
            Optional<string> submitterId = default;
            Optional<string> artifactId = default;
            Optional<SparkJobType> jobType = default;
            Optional<SparkSessionResultType> result = default;
            Optional<SparkScheduler> schedulerInfo = default;
            Optional<SparkServicePlugin> pluginInfo = default;
            Optional<IReadOnlyList<SparkServiceError>> errorInfo = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            int id = default;
            Optional<string> appId = default;
            Optional<IReadOnlyDictionary<string, string>> appInfo = default;
            Optional<LivyStates> state = default;
            Optional<IReadOnlyList<string>> log = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    livyInfo = SparkSessionState.DeserializeSparkSessionState(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPoolName"u8))
                {
                    sparkPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterName"u8))
                {
                    submitterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterId"u8))
                {
                    submitterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobType = new SparkJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = new SparkSessionResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulerInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulerInfo = SparkScheduler.DeserializeSparkScheduler(property.Value);
                    continue;
                }
                if (property.NameEquals("pluginInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginInfo = SparkServicePlugin.DeserializeSparkServicePlugin(property.Value);
                    continue;
                }
                if (property.NameEquals("errorInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkServiceError> array = new List<SparkServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkServiceError.DeserializeSparkServiceError(item));
                    }
                    errorInfo = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appId = null;
                        continue;
                    }
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new LivyStates(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("log"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    log = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkSession(livyInfo.Value, name.Value, workspaceName.Value, sparkPoolName.Value, submitterName.Value, submitterId.Value, artifactId.Value, Optional.ToNullable(jobType), Optional.ToNullable(result), schedulerInfo.Value, pluginInfo.Value, Optional.ToList(errorInfo), Optional.ToDictionary(tags), id, appId.Value, Optional.ToDictionary(appInfo), Optional.ToNullable(state), Optional.ToList(log), rawData);
        }

        SparkSession IModelJsonSerializable<SparkSession>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkSession(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkSession>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkSession IModelSerializable<SparkSession>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkSession(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SparkSession model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SparkSession(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkSession(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
