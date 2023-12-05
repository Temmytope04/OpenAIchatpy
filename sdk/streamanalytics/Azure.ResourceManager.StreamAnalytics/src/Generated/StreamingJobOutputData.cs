// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing the StreamingJobOutput data model.
    /// An output object, containing all information associated with the named output. All outputs are contained under a streaming job.
    /// </summary>
    public partial class StreamingJobOutputData : StreamAnalyticsSubResource
    {
        /// <summary> Initializes a new instance of <see cref="StreamingJobOutputData"/>. </summary>
        public StreamingJobOutputData()
        {
            LastOutputEventTimestamps = new ChangeTrackingList<LastOutputEventTimestamp>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobOutputData"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="datasource">
        /// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamingJobOutputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusOutputDataSource"/>, <see cref="FunctionOutputDataSource"/>, <see cref="PostgreSQLOutputDataSource"/>, <see cref="DataLakeStoreOutputDataSource"/>, <see cref="EventHubV2OutputDataSource"/>, <see cref="EventHubOutputDataSource"/>, <see cref="ServiceBusQueueOutputDataSource"/>, <see cref="ServiceBusTopicOutputDataSource"/>, <see cref="SynapseOutputDataSource"/>, <see cref="SqlDatabaseOutputDataSource"/>, <see cref="BlobOutputDataSource"/>, <see cref="DocumentDbOutputDataSource"/>, <see cref="TableOutputDataSource"/>, <see cref="PowerBIOutputDataSource"/> and <see cref="RawOutputDatasource"/>.
        /// </param>
        /// <param name="timeFrame"> The time frame for filtering Stream Analytics job outputs. </param>
        /// <param name="sizeWindow"> The size window to constrain a Stream Analytics output to. </param>
        /// <param name="serialization">
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamAnalyticsDataSerialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormatSerialization"/>, <see cref="CsvFormatSerialization"/>, <see cref="CustomClrFormatSerialization"/>, <see cref="JsonFormatSerialization"/> and <see cref="ParquetFormatSerialization"/>.
        /// </param>
        /// <param name="diagnostics"> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </param>
        /// <param name="etag"> The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="lastOutputEventTimestamps"> A list of the last output event times for each output partition. The index of the array corresponds to the partition number. </param>
        /// <param name="watermarkSettings"> Settings which determine whether to send watermarks to downstream. </param>
        internal StreamingJobOutputData(ResourceIdentifier id, string name, ResourceType? resourceType, StreamingJobOutputDataSource datasource, TimeSpan? timeFrame, float? sizeWindow, StreamAnalyticsDataSerialization serialization, StreamingJobDiagnostics diagnostics, ETag? etag, IReadOnlyList<LastOutputEventTimestamp> lastOutputEventTimestamps, StreamingJobOutputWatermarkProperties watermarkSettings) : base(id, name, resourceType)
        {
            Datasource = datasource;
            TimeFrame = timeFrame;
            SizeWindow = sizeWindow;
            Serialization = serialization;
            Diagnostics = diagnostics;
            ETag = etag;
            LastOutputEventTimestamps = lastOutputEventTimestamps;
            WatermarkSettings = watermarkSettings;
        }

        /// <summary>
        /// Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamingJobOutputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusOutputDataSource"/>, <see cref="FunctionOutputDataSource"/>, <see cref="PostgreSQLOutputDataSource"/>, <see cref="DataLakeStoreOutputDataSource"/>, <see cref="EventHubV2OutputDataSource"/>, <see cref="EventHubOutputDataSource"/>, <see cref="ServiceBusQueueOutputDataSource"/>, <see cref="ServiceBusTopicOutputDataSource"/>, <see cref="SynapseOutputDataSource"/>, <see cref="SqlDatabaseOutputDataSource"/>, <see cref="BlobOutputDataSource"/>, <see cref="DocumentDbOutputDataSource"/>, <see cref="TableOutputDataSource"/>, <see cref="PowerBIOutputDataSource"/> and <see cref="RawOutputDatasource"/>.
        /// </summary>
        public StreamingJobOutputDataSource Datasource { get; set; }
        /// <summary> The time frame for filtering Stream Analytics job outputs. </summary>
        public TimeSpan? TimeFrame { get; set; }
        /// <summary> The size window to constrain a Stream Analytics output to. </summary>
        public float? SizeWindow { get; set; }
        /// <summary>
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamAnalyticsDataSerialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormatSerialization"/>, <see cref="CsvFormatSerialization"/>, <see cref="CustomClrFormatSerialization"/>, <see cref="JsonFormatSerialization"/> and <see cref="ParquetFormatSerialization"/>.
        /// </summary>
        public StreamAnalyticsDataSerialization Serialization { get; set; }
        /// <summary> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </summary>
        internal StreamingJobDiagnostics Diagnostics { get; }
        /// <summary> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </summary>
        public IReadOnlyList<StreamingJobDiagnosticCondition> DiagnosticsConditions
        {
            get => Diagnostics?.Conditions;
        }

        /// <summary> The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of the last output event times for each output partition. The index of the array corresponds to the partition number. </summary>
        public IReadOnlyList<LastOutputEventTimestamp> LastOutputEventTimestamps { get; }
        /// <summary> Settings which determine whether to send watermarks to downstream. </summary>
        public StreamingJobOutputWatermarkProperties WatermarkSettings { get; set; }
    }
}
