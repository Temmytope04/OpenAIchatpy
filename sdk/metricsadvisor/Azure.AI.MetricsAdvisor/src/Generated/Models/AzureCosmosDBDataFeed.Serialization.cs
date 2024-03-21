// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureCosmosDBDataFeed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceParameter"u8);
            writer.WriteObjectValue(DataSourceParameter);
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType.ToString());
            writer.WritePropertyName("dataFeedName"u8);
            writer.WriteStringValue(DataFeedName);
            if (Optional.IsDefined(DataFeedDescription))
            {
                writer.WritePropertyName("dataFeedDescription"u8);
                writer.WriteStringValue(DataFeedDescription);
            }
            writer.WritePropertyName("granularityName"u8);
            writer.WriteStringValue(GranularityName.ToString());
            if (Optional.IsDefined(GranularityAmount))
            {
                if (GranularityAmount != null)
                {
                    writer.WritePropertyName("granularityAmount"u8);
                    writer.WriteNumberValue(GranularityAmount.Value);
                }
                else
                {
                    writer.WriteNull("granularityAmount");
                }
            }
            writer.WritePropertyName("metrics"u8);
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Dimension))
            {
                writer.WritePropertyName("dimension"u8);
                writer.WriteStartArray();
                foreach (var item in Dimension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimestampColumn))
            {
                writer.WritePropertyName("timestampColumn"u8);
                writer.WriteStringValue(TimestampColumn);
            }
            writer.WritePropertyName("dataStartFrom"u8);
            writer.WriteStringValue(DataStartFrom, "O");
            if (Optional.IsDefined(StartOffsetInSeconds))
            {
                writer.WritePropertyName("startOffsetInSeconds"u8);
                writer.WriteNumberValue(StartOffsetInSeconds.Value);
            }
            if (Optional.IsDefined(MaxConcurrency))
            {
                writer.WritePropertyName("maxConcurrency"u8);
                writer.WriteNumberValue(MaxConcurrency.Value);
            }
            if (Optional.IsDefined(MinRetryIntervalInSeconds))
            {
                writer.WritePropertyName("minRetryIntervalInSeconds"u8);
                writer.WriteNumberValue(MinRetryIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(StopRetryAfterInSeconds))
            {
                writer.WritePropertyName("stopRetryAfterInSeconds"u8);
                writer.WriteNumberValue(StopRetryAfterInSeconds.Value);
            }
            if (Optional.IsDefined(NeedRollup))
            {
                writer.WritePropertyName("needRollup"u8);
                writer.WriteStringValue(NeedRollup.Value.ToString());
            }
            if (Optional.IsDefined(RollUpMethod))
            {
                writer.WritePropertyName("rollUpMethod"u8);
                writer.WriteStringValue(RollUpMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RollUpColumns))
            {
                writer.WritePropertyName("rollUpColumns"u8);
                writer.WriteStartArray();
                foreach (var item in RollUpColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllUpIdentification))
            {
                writer.WritePropertyName("allUpIdentification"u8);
                writer.WriteStringValue(AllUpIdentification);
            }
            if (Optional.IsDefined(FillMissingPointType))
            {
                writer.WritePropertyName("fillMissingPointType"u8);
                writer.WriteStringValue(FillMissingPointType.Value.ToString());
            }
            if (Optional.IsDefined(FillMissingPointValue))
            {
                writer.WritePropertyName("fillMissingPointValue"u8);
                writer.WriteNumberValue(FillMissingPointValue.Value);
            }
            if (Optional.IsDefined(ViewMode))
            {
                writer.WritePropertyName("viewMode"u8);
                writer.WriteStringValue(ViewMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Admins))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Admins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Viewers))
            {
                writer.WritePropertyName("viewers"u8);
                writer.WriteStartArray();
                foreach (var item in Viewers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActionLinkTemplate))
            {
                writer.WritePropertyName("actionLinkTemplate"u8);
                writer.WriteStringValue(ActionLinkTemplate);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(CredentialId))
            {
                writer.WritePropertyName("credentialId"u8);
                writer.WriteStringValue(CredentialId);
            }
            writer.WriteEndObject();
        }

        internal static AzureCosmosDBDataFeed DeserializeAzureCosmosDBDataFeed(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureCosmosDBParameter dataSourceParameter = default;
            DataFeedSourceKind dataSourceType = default;
            string dataFeedId = default;
            string dataFeedName = default;
            string dataFeedDescription = default;
            DataFeedGranularityType granularityName = default;
            int? granularityAmount = default;
            IList<DataFeedMetric> metrics = default;
            IList<DataFeedDimension> dimension = default;
            string timestampColumn = default;
            DateTimeOffset dataStartFrom = default;
            long? startOffsetInSeconds = default;
            int? maxConcurrency = default;
            long? minRetryIntervalInSeconds = default;
            long? stopRetryAfterInSeconds = default;
            DataFeedRollupType? needRollup = default;
            DataFeedAutoRollupMethod? rollUpMethod = default;
            IList<string> rollUpColumns = default;
            string allUpIdentification = default;
            DataFeedMissingDataPointFillType? fillMissingPointType = default;
            double? fillMissingPointValue = default;
            DataFeedAccessMode? viewMode = default;
            IList<string> admins = default;
            IList<string> viewers = default;
            bool? isAdmin = default;
            string creator = default;
            DataFeedStatus? status = default;
            DateTimeOffset? createdTime = default;
            string actionLinkTemplate = default;
            AuthenticationTypeEnum? authenticationType = default;
            string credentialId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceParameter"u8))
                {
                    dataSourceParameter = AzureCosmosDBParameter.DeserializeAzureCosmosDBParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = new DataFeedSourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFeedId"u8))
                {
                    dataFeedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedName"u8))
                {
                    dataFeedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedDescription"u8))
                {
                    dataFeedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("granularityName"u8))
                {
                    granularityName = new DataFeedGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("granularityAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        granularityAmount = null;
                        continue;
                    }
                    granularityAmount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    List<DataFeedMetric> array = new List<DataFeedMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedMetric.DeserializeDataFeedMetric(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("dimension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFeedDimension> array = new List<DataFeedDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedDimension.DeserializeDataFeedDimension(item));
                    }
                    dimension = array;
                    continue;
                }
                if (property.NameEquals("timestampColumn"u8))
                {
                    timestampColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStartFrom"u8))
                {
                    dataStartFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startOffsetInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startOffsetInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConcurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minRetryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minRetryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("stopRetryAfterInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopRetryAfterInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("needRollup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    needRollup = new DataFeedRollupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollUpMethod = new DataFeedAutoRollupMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpColumns"u8))
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
                    rollUpColumns = array;
                    continue;
                }
                if (property.NameEquals("allUpIdentification"u8))
                {
                    allUpIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillMissingPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointType = new DataFeedMissingDataPointFillType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillMissingPointValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("viewMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    viewMode = new DataFeedAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("admins"u8))
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
                    admins = array;
                    continue;
                }
                if (property.NameEquals("viewers"u8))
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
                    viewers = array;
                    continue;
                }
                if (property.NameEquals("isAdmin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("creator"u8))
                {
                    creator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataFeedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actionLinkTemplate"u8))
                {
                    actionLinkTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new AuthenticationTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialId"u8))
                {
                    credentialId = property.Value.GetString();
                    continue;
                }
            }
            return new AzureCosmosDBDataFeed(
                dataSourceType,
                dataFeedId,
                dataFeedName,
                dataFeedDescription,
                granularityName,
                granularityAmount,
                metrics,
                dimension ?? new ChangeTrackingList<DataFeedDimension>(),
                timestampColumn,
                dataStartFrom,
                startOffsetInSeconds,
                maxConcurrency,
                minRetryIntervalInSeconds,
                stopRetryAfterInSeconds,
                needRollup,
                rollUpMethod,
                rollUpColumns ?? new ChangeTrackingList<string>(),
                allUpIdentification,
                fillMissingPointType,
                fillMissingPointValue,
                viewMode,
                admins ?? new ChangeTrackingList<string>(),
                viewers ?? new ChangeTrackingList<string>(),
                isAdmin,
                creator,
                status,
                createdTime,
                actionLinkTemplate,
                authenticationType,
                credentialId,
                dataSourceParameter);
        }
    }
}
