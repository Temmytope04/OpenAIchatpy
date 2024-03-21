// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationSqlVmProperties : IUtf8JsonSerializable, IJsonModel<DatabaseMigrationSqlVmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseMigrationSqlVmProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseMigrationSqlVmProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MigrationStatusDetails))
            {
                writer.WritePropertyName("migrationStatusDetails"u8);
                writer.WriteObjectValue(MigrationStatusDetails);
            }
            if (Optional.IsDefined(BackupConfiguration))
            {
                writer.WritePropertyName("backupConfiguration"u8);
                writer.WriteObjectValue(BackupConfiguration);
            }
            if (Optional.IsDefined(OfflineConfiguration))
            {
                writer.WritePropertyName("offlineConfiguration"u8);
                writer.WriteObjectValue(OfflineConfiguration);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationStatus))
            {
                writer.WritePropertyName("migrationStatus"u8);
                writer.WriteStringValue(MigrationStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection"u8);
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerName))
            {
                writer.WritePropertyName("sourceServerName"u8);
                writer.WriteStringValue(SourceServerName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService"u8);
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId"u8);
                writer.WriteStringValue(MigrationOperationId);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationFailureError))
            {
                writer.WritePropertyName("migrationFailureError"u8);
                writer.WriteObjectValue(MigrationFailureError);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation"u8);
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DatabaseMigrationSqlVmProperties IJsonModel<DatabaseMigrationSqlVmProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseMigrationSqlVmProperties(document.RootElement, options);
        }

        internal static DatabaseMigrationSqlVmProperties DeserializeDatabaseMigrationSqlVmProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MigrationStatusDetails migrationStatusDetails = default;
            BackupConfiguration backupConfiguration = default;
            OfflineConfiguration offlineConfiguration = default;
            ResourceType kind = default;
            string scope = default;
            string provisioningState = default;
            string migrationStatus = default;
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            SqlConnectionInformation sourceSqlConnection = default;
            string sourceDatabaseName = default;
            string sourceServerName = default;
            string migrationService = default;
            string migrationOperationId = default;
            ErrorInfo migrationFailureError = default;
            string targetDatabaseCollation = default;
            string provisioningError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationStatusDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationStatusDetails = MigrationStatusDetails.DeserializeMigrationStatusDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupConfiguration = BackupConfiguration.DeserializeBackupConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offlineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineConfiguration = OfflineConfiguration.DeserializeOfflineConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationStatus"u8))
                {
                    migrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceSqlConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerName"u8))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationService"u8))
                {
                    migrationService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationOperationId"u8))
                {
                    migrationOperationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationFailureError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationFailureError = ErrorInfo.DeserializeErrorInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetDatabaseCollation"u8))
                {
                    targetDatabaseCollation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningError"u8))
                {
                    provisioningError = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseMigrationSqlVmProperties(
                kind,
                scope,
                provisioningState,
                migrationStatus,
                startedOn,
                endedOn,
                sourceSqlConnection,
                sourceDatabaseName,
                sourceServerName,
                migrationService,
                migrationOperationId,
                migrationFailureError,
                targetDatabaseCollation,
                provisioningError,
                serializedAdditionalRawData,
                migrationStatusDetails,
                backupConfiguration,
                offlineConfiguration);
        }

        BinaryData IPersistableModel<DatabaseMigrationSqlVmProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmProperties)} does not support '{options.Format}' format.");
            }
        }

        DatabaseMigrationSqlVmProperties IPersistableModel<DatabaseMigrationSqlVmProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationSqlVmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseMigrationSqlVmProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationSqlVmProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseMigrationSqlVmProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
