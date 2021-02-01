﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// Periodically ingests data from a data source in order to build time series
    /// to be monitored for anomaly detection.
    /// </summary>
    public class DataFeed
    {
        private DataFeedSource _dataSource;

        private DataFeedSourceType? _sourceType;

        private IList<string> _administrators;

        private IList<string> _viewers;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFeed"/> class.
        /// </summary>
        public DataFeed()
        {
            Administrators = new ChangeTrackingList<string>();
            Viewers = new ChangeTrackingList<string>();
        }

        internal DataFeed(DataFeedDetail dataFeedDetail)
        {
            Id = dataFeedDetail.DataFeedId;
            Status = dataFeedDetail.Status;
            CreatedTime = dataFeedDetail.CreatedTime;
            Creator = dataFeedDetail.Creator;
            IsAdministrator = dataFeedDetail.IsAdmin;
            MetricIds = dataFeedDetail.Metrics.ToDictionary(metric => metric.MetricName, metric => metric.MetricId);
            Name = dataFeedDetail.DataFeedName;
            DataSource = DataFeedSource.GetDataFeedSource(dataFeedDetail);
            Schema = new DataFeedSchema(dataFeedDetail);
            Granularity = new DataFeedGranularity(dataFeedDetail);
            IngestionSettings = new DataFeedIngestionSettings(dataFeedDetail);
            Description = dataFeedDetail.DataFeedDescription;
            ActionLinkTemplate = dataFeedDetail.ActionLinkTemplate;
            AccessMode = dataFeedDetail.ViewMode;
            RollupSettings = new DataFeedRollupSettings(dataFeedDetail);
            MissingDataPointFillSettings = new DataFeedMissingDataPointFillSettings(dataFeedDetail);
            Administrators = dataFeedDetail.Admins;
            Viewers = dataFeedDetail.Viewers;
        }

        /// <summary>
        /// The unique identifier of this <see cref="DataFeed"/>. Set by the service.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The current ingestion status of this <see cref="DataFeed"/>.
        /// </summary>
        public DataFeedStatus? Status { get; }

        /// <summary>
        /// Date and time, in UTC, when this <see cref="DataFeed"/> was created.
        /// </summary>
        public DateTimeOffset? CreatedTime { get; }

        /// <summary>
        /// The e-mail address of creator of this <see cref="DataFeed"/>.
        /// </summary>
        public string Creator { get; }

        /// <summary>
        /// Whether or not the user who queried the information about this <see cref="DataFeed"/>
        /// is one of its administrators.
        /// </summary>
        public bool? IsAdministrator { get; }

        /// <summary>
        /// The unique identifiers of the metrics defined in this feed's <see cref="DataFeedSchema"/>.
        /// Set by the service.
        /// </summary>
        public IReadOnlyDictionary<string, string> MetricIds { get; }

        /// <summary>
        /// A custom name for this <see cref="DataFeed"/> to be displayed on the web portal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The source from which data is consumed.
        /// </summary>
        public DataFeedSource DataSource
        {
            get => _dataSource;
            set
            {
                _dataSource = value;

                if (value != null)
                {
                    _sourceType = value.Type;
                }
            }
        }

        /// <summary>
        /// The type of data source that ingests this <see cref="DataFeed"/> with data.
        /// </summary>
        public DataFeedSourceType? SourceType
        {
            get => _sourceType;
            set
            {
                var dataSource = _dataSource;

                if (dataSource != null && dataSource.Type != value)
                {
                    throw new InvalidOperationException($"The source type cannot differ from the type of the set data source ({dataSource.Type}).");
                }

                _sourceType = value;
            }
        }

        /// <summary>
        /// Defines how this <see cref="DataFeed"/> structures the data ingested from the data source
        /// in terms of metrics and dimensions.
        /// </summary>
        public DataFeedSchema Schema { get; set; }

        /// <summary>
        /// The frequency with which ingestion from the data source will happen.
        /// </summary>
        public DataFeedGranularity Granularity { get; set; }

        /// <summary>
        /// Configures how a <see cref="DataFeed"/> behaves during data ingestion from its data source.
        /// </summary>
        public DataFeedIngestionSettings IngestionSettings { get; set; }

        /// <summary>
        /// A description of this <see cref="DataFeed"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Defines actionable HTTP URLs, which consist of the placeholders %datafeed, %metric, %timestamp, %detect_config, and %tagset.
        /// You can use the template to redirect from an anomaly or an incident to a specific URL to drill down.
        /// See the <see href="https://docs.microsoft.com/azure/cognitive-services/metrics-advisor/how-tos/manage-data-feeds#action-link-template">documentation</see> for details.
        /// </summary>
        public string ActionLinkTemplate { get; set; }

        /// <summary>
        /// The access mode for this <see cref="DataFeed"/>.
        /// </summary>
        public DataFeedAccessMode? AccessMode { get; set; }

        /// <summary>
        /// Configures the behavior of this <see cref="DataFeed"/> for rolling-up the ingested data
        /// before detecting anomalies.
        /// </summary>
        public DataFeedRollupSettings RollupSettings { get; set; }

        /// <summary>
        /// Configures the behavior of this <see cref="DataFeed"/> when dealing with missing points
        /// in the data ingested from the data source.
        /// </summary>
        public DataFeedMissingDataPointFillSettings MissingDataPointFillSettings { get; set; }

        /// <summary>
        /// The emails of this data feed's administrators. Administrators have total control over a
        /// data feed, being allowed to update, delete or pause them. They also have access to the
        /// credentials used to authenticate to the data source.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value assigned to <see cref="Administrators"/> is null.</exception>
#pragma warning disable CA2227 // Collection properties should be readonly
        public IList<string> Administrators
        {
            get => _administrators;
            set
            {
                Argument.AssertNotNull(value, nameof(Administrators));
                _administrators = value;
            }
        }
#pragma warning restore CA2227 // Collection properties should be readonly

        /// <summary>
        /// The emails of this data feed's viewers. Viewers have read-only access to a data feed, and
        /// do not have access to the credentials used to authenticate to the data source.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value assigned to <see cref="Viewers"/> is null.</exception>
#pragma warning disable CA2227 // Collection properties should be readonly
        public IList<string> Viewers
        {
            get => _viewers;
            set
            {
                Argument.AssertNotNull(value, nameof(Viewers));
                _viewers = value;
            }
        }
#pragma warning restore CA2227 // Collection properties should be readonly

        internal DataFeedDetail GetDataFeedDetail()
        {
            DataFeedDetail detail = DataSource.InstantiateDataFeedDetail(Name, Granularity.GranularityType, Schema.MetricColumns, IngestionSettings.IngestionStartTime);

            foreach (var column in Schema.DimensionColumns)
            {
                detail.Dimension.Add(column);
            }
            detail.TimestampColumn = Schema.TimestampColumn;

            detail.GranularityAmount = Granularity.CustomGranularityValue;

            detail.MaxConcurrency = IngestionSettings.DataSourceRequestConcurrency;
            detail.MinRetryIntervalInSeconds = (long?)IngestionSettings.IngestionRetryDelay?.TotalSeconds;
            detail.StartOffsetInSeconds = (long?)IngestionSettings.IngestionStartOffset?.TotalSeconds;
            detail.StopRetryAfterInSeconds = (long?)IngestionSettings.StopRetryAfter?.TotalSeconds;

            detail.DataFeedDescription = Description;
            detail.ActionLinkTemplate = ActionLinkTemplate;
            detail.ViewMode = AccessMode;

            if (RollupSettings != null)
            {
                detail.AllUpIdentification = RollupSettings.AlreadyRollupIdentificationValue;
                detail.NeedRollup = RollupSettings.RollupType;
                detail.RollUpMethod = RollupSettings.RollupMethod;
                foreach (string columnName in RollupSettings.AutoRollupGroupByColumnNames)
                {
                    detail.RollUpColumns.Add(columnName);
                }
            }

            if (MissingDataPointFillSettings != null)
            {
                detail.FillMissingPointType = MissingDataPointFillSettings.FillType;
                detail.FillMissingPointValue = MissingDataPointFillSettings.CustomFillValue;
            }

            Administrators = detail.Admins;
            Viewers = detail.Viewers;

            return detail;
        }

        /// <summary>
        /// Converts a data source specific <see cref="DataFeed"/> into its equivalent data source specific <see cref="DataFeedDetailPatch"/>.
        /// </summary>
        internal DataFeedDetailPatch GetPatchModel()
        {
            DataFeedDetailPatch patch = DataSource?.InstantiateDataFeedDetailPatch()
                ?? new AzureApplicationInsightsDataFeedPatch();

            patch.DataFeedName = Name;
            patch.Status = Status.HasValue ? new DataFeedDetailPatchStatus(Status.ToString()) : default(DataFeedDetailPatchStatus?);

            if (Schema != null)
            {
                patch.TimestampColumn = Schema.TimestampColumn;
            }

            if (IngestionSettings != null)
            {
                patch.DataStartFrom = ClientCommon.NormalizeDateTimeOffset(IngestionSettings.IngestionStartTime);
                patch.MaxConcurrency = IngestionSettings.DataSourceRequestConcurrency;
                patch.MinRetryIntervalInSeconds = (long?)IngestionSettings.IngestionRetryDelay?.TotalSeconds;
                patch.StartOffsetInSeconds = (long?)IngestionSettings.IngestionStartOffset?.TotalSeconds;
                patch.StopRetryAfterInSeconds = (long?)IngestionSettings.StopRetryAfter?.TotalSeconds;
            }

            patch.DataFeedDescription = Description;
            patch.ActionLinkTemplate = ActionLinkTemplate;
            patch.ViewMode = AccessMode.HasValue == true ? new DataFeedDetailPatchViewMode(AccessMode.ToString()) : default(DataFeedDetailPatchViewMode?);

            if (RollupSettings != null)
            {
                patch.AllUpIdentification = RollupSettings.AlreadyRollupIdentificationValue;
                patch.NeedRollup = RollupSettings.RollupType.HasValue ? new DataFeedDetailPatchNeedRollup(RollupSettings.RollupType.ToString()) : default(DataFeedDetailPatchNeedRollup?);
                patch.RollUpMethod = RollupSettings.RollupMethod.HasValue ? new DataFeedDetailPatchRollUpMethod(RollupSettings.RollupMethod.ToString()) : default(DataFeedDetailPatchRollUpMethod?);
                patch.RollUpColumns = RollupSettings.AutoRollupGroupByColumnNames;
            }

            if (MissingDataPointFillSettings != null)
            {
                patch.FillMissingPointType = MissingDataPointFillSettings.FillType.HasValue ? new DataFeedDetailPatchFillMissingPointType(MissingDataPointFillSettings.FillType.ToString()) : default(DataFeedDetailPatchFillMissingPointType?);
                patch.FillMissingPointValue = MissingDataPointFillSettings.CustomFillValue;
            }

            patch.Admins = Administrators;
            patch.Viewers = Viewers;

            return patch;
        }

        private DataFeedDetailPatch InstantiateDataFeedDetailPatchFromSourceType()
        {
            if (_sourceType == DataFeedSourceType.AzureApplicationInsights)
            {
                return new AzureApplicationInsightsDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.AzureBlob)
            {
                return new AzureBlobDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.AzureCosmosDb)
            {
                return new AzureCosmosDBDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.AzureDataLakeStorageGen2)
            {
                return new AzureDataLakeStorageGen2DataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.AzureTable)
            {
                return new AzureTableDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.Elasticsearch)
            {
                return new ElasticsearchDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.HttpRequest)
            {
                return new HttpRequestDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.InfluxDb)
            {
                return new InfluxDBDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.AzureDataExplorer)
            {
                return new AzureDataExplorerDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.MySql)
            {
                return new MySqlDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.PostgreSql)
            {
                return new PostgreSqlDataFeedPatch();
            }

            if (_sourceType == DataFeedSourceType.SqlServer)
            {
                return new SQLServerDataFeedPatch();
            }

            throw new InvalidOperationException("Invalid source type.");
        }
    }
}
