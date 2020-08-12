// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class Activity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Activity DeserializeActivity(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AppendVariable": return AppendVariableActivity.DeserializeAppendVariableActivity(element);
                    case "AzureDataExplorerCommand": return AzureDataExplorerCommandActivity.DeserializeAzureDataExplorerCommandActivity(element);
                    case "AzureFunctionActivity": return AzureFunctionActivity.DeserializeAzureFunctionActivity(element);
                    case "AzureMLBatchExecution": return AzureMLBatchExecutionActivity.DeserializeAzureMLBatchExecutionActivity(element);
                    case "AzureMLExecutePipeline": return AzureMLExecutePipelineActivity.DeserializeAzureMLExecutePipelineActivity(element);
                    case "AzureMLUpdateResource": return AzureMLUpdateResourceActivity.DeserializeAzureMLUpdateResourceActivity(element);
                    case "Container": return ControlActivity.DeserializeControlActivity(element);
                    case "Copy": return CopyActivity.DeserializeCopyActivity(element);
                    case "Custom": return CustomActivity.DeserializeCustomActivity(element);
                    case "DataLakeAnalyticsU-SQL": return DataLakeAnalyticsUsqlActivity.DeserializeDataLakeAnalyticsUsqlActivity(element);
                    case "DatabricksNotebook": return DatabricksNotebookActivity.DeserializeDatabricksNotebookActivity(element);
                    case "DatabricksSparkJar": return DatabricksSparkJarActivity.DeserializeDatabricksSparkJarActivity(element);
                    case "DatabricksSparkPython": return DatabricksSparkPythonActivity.DeserializeDatabricksSparkPythonActivity(element);
                    case "Delete": return DeleteActivity.DeserializeDeleteActivity(element);
                    case "ExecuteDataFlow": return ExecuteDataFlowActivity.DeserializeExecuteDataFlowActivity(element);
                    case "ExecutePipeline": return ExecutePipelineActivity.DeserializeExecutePipelineActivity(element);
                    case "ExecuteSSISPackage": return ExecuteSsisPackageActivity.DeserializeExecuteSsisPackageActivity(element);
                    case "Execution": return ExecutionActivity.DeserializeExecutionActivity(element);
                    case "Filter": return FilterActivity.DeserializeFilterActivity(element);
                    case "ForEach": return ForEachActivity.DeserializeForEachActivity(element);
                    case "GetMetadata": return GetMetadataActivity.DeserializeGetMetadataActivity(element);
                    case "HDInsightHive": return HDInsightHiveActivity.DeserializeHDInsightHiveActivity(element);
                    case "HDInsightMapReduce": return HDInsightMapReduceActivity.DeserializeHDInsightMapReduceActivity(element);
                    case "HDInsightPig": return HDInsightPigActivity.DeserializeHDInsightPigActivity(element);
                    case "HDInsightSpark": return HDInsightSparkActivity.DeserializeHDInsightSparkActivity(element);
                    case "HDInsightStreaming": return HDInsightStreamingActivity.DeserializeHDInsightStreamingActivity(element);
                    case "IfCondition": return IfConditionActivity.DeserializeIfConditionActivity(element);
                    case "Lookup": return LookupActivity.DeserializeLookupActivity(element);
                    case "SetVariable": return SetVariableActivity.DeserializeSetVariableActivity(element);
                    case "SqlServerStoredProcedure": return SqlServerStoredProcedureActivity.DeserializeSqlServerStoredProcedureActivity(element);
                    case "Switch": return SwitchActivity.DeserializeSwitchActivity(element);
                    case "Until": return UntilActivity.DeserializeUntilActivity(element);
                    case "Validation": return ValidationActivity.DeserializeValidationActivity(element);
                    case "Wait": return WaitActivity.DeserializeWaitActivity(element);
                    case "WebActivity": return WebActivity.DeserializeWebActivity(element);
                    case "WebHook": return WebHookActivity.DeserializeWebHookActivity(element);
                }
            }
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Activity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties);
        }
    }
}
