// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> Type of data source credential. </summary>
    public readonly partial struct DataFeedSourceType : IEquatable<DataFeedSourceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataFeedSourceType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFeedSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureApplicationInsightsValue = "AzureApplicationInsights";
        private const string AzureBlobValue = "AzureBlob";
        private const string AzureCosmosDbValue = "AzureCosmosDB";
        private const string AzureDataExplorerValue = "AzureDataExplorer";
        private const string AzureDataLakeStorageGen2Value = "AzureDataLakeStorageGen2";
        private const string AzureEventHubsValue = "AzureEventHubs";
        private const string AzureTableValue = "AzureTable";
        private const string ElasticsearchValue = "Elasticsearch";
        private const string HttpRequestValue = "HttpRequest";
        private const string InfluxDbValue = "InfluxDB";
        private const string MongoDbValue = "MongoDB";
        private const string MySqlValue = "MySql";
        private const string PostgreSqlValue = "PostgreSql";
        private const string SqlServerValue = "SqlServer";
        /// <summary> AzureEventHubs. </summary>
        public static DataFeedSourceType AzureEventHubs { get; } = new DataFeedSourceType(AzureEventHubsValue);
        /// <summary> Determines if two <see cref="DataFeedSourceType"/> values are the same. </summary>
        public static bool operator ==(DataFeedSourceType left, DataFeedSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFeedSourceType"/> values are not the same. </summary>
        public static bool operator !=(DataFeedSourceType left, DataFeedSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFeedSourceType"/>. </summary>
        public static implicit operator DataFeedSourceType(string value) => new DataFeedSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFeedSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFeedSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
