// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SynapseSparkJobDefinitionActivityConverter))]
    public partial class SynapseSparkJobDefinitionActivity : IUtf8JsonSerializable, IModelJsonSerializable<SynapseSparkJobDefinitionActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseSparkJobDefinitionActivity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseSparkJobDefinitionActivity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SynapseSparkJobDefinitionActivity>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sparkJob"u8);
            writer.WriteObjectValue(SparkJob);
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue(File);
            }
            if (Optional.IsDefined(ScanFolder))
            {
                writer.WritePropertyName("scanFolder"u8);
                writer.WriteObjectValue(ScanFolder);
            }
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className"u8);
                writer.WriteObjectValue(ClassName);
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PythonCodeReference))
            {
                writer.WritePropertyName("pythonCodeReference"u8);
                writer.WriteStartArray();
                foreach (var item in PythonCodeReference)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FilesV2))
            {
                writer.WritePropertyName("filesV2"u8);
                writer.WriteStartArray();
                foreach (var item in FilesV2)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetBigDataPool))
            {
                writer.WritePropertyName("targetBigDataPool"u8);
                writer.WriteObjectValue(TargetBigDataPool);
            }
            if (Optional.IsDefined(ExecutorSize))
            {
                writer.WritePropertyName("executorSize"u8);
                writer.WriteObjectValue(ExecutorSize);
            }
            if (Optional.IsDefined(Conf))
            {
                writer.WritePropertyName("conf"u8);
                writer.WriteObjectValue(Conf);
            }
            if (Optional.IsDefined(DriverSize))
            {
                writer.WritePropertyName("driverSize"u8);
                writer.WriteObjectValue(DriverSize);
            }
            if (Optional.IsDefined(NumExecutors))
            {
                writer.WritePropertyName("numExecutors"u8);
                writer.WriteObjectValue(NumExecutors);
            }
            if (Optional.IsDefined(ConfigurationType))
            {
                writer.WritePropertyName("configurationType"u8);
                writer.WriteStringValue(ConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(TargetSparkConfiguration))
            {
                writer.WritePropertyName("targetSparkConfiguration"u8);
                writer.WriteObjectValue(TargetSparkConfiguration);
            }
            if (Optional.IsCollectionDefined(SparkConfig))
            {
                writer.WritePropertyName("sparkConfig"u8);
                writer.WriteStartObject();
                foreach (var item in SparkConfig)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SynapseSparkJobDefinitionActivity DeserializeSynapseSparkJobDefinitionActivity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<ActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            SynapseSparkJobReference sparkJob = default;
            Optional<IList<object>> args = default;
            Optional<object> file = default;
            Optional<object> scanFolder = default;
            Optional<object> className = default;
            Optional<IList<object>> files = default;
            Optional<IList<object>> pythonCodeReference = default;
            Optional<IList<object>> filesV2 = default;
            Optional<BigDataPoolParametrizationReference> targetBigDataPool = default;
            Optional<object> executorSize = default;
            Optional<object> conf = default;
            Optional<object> driverSize = default;
            Optional<object> numExecutors = default;
            Optional<ConfigurationType> configurationType = default;
            Optional<SparkConfigurationParametrizationReference> targetSparkConfiguration = default;
            Optional<IDictionary<string, object>> sparkConfig = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sparkJob"u8))
                        {
                            sparkJob = SynapseSparkJobReference.DeserializeSynapseSparkJobReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("args"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            args = array;
                            continue;
                        }
                        if (property0.NameEquals("file"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            file = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scanFolder"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scanFolder = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("className"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            className = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("files"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            files = array;
                            continue;
                        }
                        if (property0.NameEquals("pythonCodeReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            pythonCodeReference = array;
                            continue;
                        }
                        if (property0.NameEquals("filesV2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            filesV2 = array;
                            continue;
                        }
                        if (property0.NameEquals("targetBigDataPool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetBigDataPool = BigDataPoolParametrizationReference.DeserializeBigDataPoolParametrizationReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("executorSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executorSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("conf"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conf = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("driverSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            driverSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("numExecutors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numExecutors = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("configurationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationType = new ConfigurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetSparkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetSparkConfiguration = SparkConfigurationParametrizationReference.DeserializeSparkConfigurationParametrizationReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            sparkConfig = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSparkJobDefinitionActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, sparkJob, Optional.ToList(args), file.Value, scanFolder.Value, className.Value, Optional.ToList(files), Optional.ToList(pythonCodeReference), Optional.ToList(filesV2), targetBigDataPool.Value, executorSize.Value, conf.Value, driverSize.Value, numExecutors.Value, Optional.ToNullable(configurationType), targetSparkConfiguration.Value, Optional.ToDictionary(sparkConfig));
        }

        SynapseSparkJobDefinitionActivity IModelJsonSerializable<SynapseSparkJobDefinitionActivity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SynapseSparkJobDefinitionActivity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSparkJobDefinitionActivity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseSparkJobDefinitionActivity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SynapseSparkJobDefinitionActivity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseSparkJobDefinitionActivity IModelSerializable<SynapseSparkJobDefinitionActivity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SynapseSparkJobDefinitionActivity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseSparkJobDefinitionActivity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SynapseSparkJobDefinitionActivity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SynapseSparkJobDefinitionActivity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseSparkJobDefinitionActivity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SynapseSparkJobDefinitionActivityConverter : JsonConverter<SynapseSparkJobDefinitionActivity>
        {
            public override void Write(Utf8JsonWriter writer, SynapseSparkJobDefinitionActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SynapseSparkJobDefinitionActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSynapseSparkJobDefinitionActivity(document.RootElement);
            }
        }
    }
}
