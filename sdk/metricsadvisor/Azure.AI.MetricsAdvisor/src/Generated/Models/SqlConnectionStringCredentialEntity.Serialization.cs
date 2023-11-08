// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class SqlConnectionStringCredentialEntity : IUtf8JsonSerializable, IJsonModel<SqlConnectionStringCredentialEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlConnectionStringCredentialEntity>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SqlConnectionStringCredentialEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(CredentialKind.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("dataSourceCredentialId"u8);
                    writer.WriteStringValue(Id);
                }
            }
            writer.WritePropertyName("dataSourceCredentialName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(Description);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SqlConnectionStringCredentialEntity IJsonModel<SqlConnectionStringCredentialEntity>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlConnectionStringCredentialEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlConnectionStringCredentialEntity(document.RootElement, options);
        }

        internal static SqlConnectionStringCredentialEntity DeserializeSqlConnectionStringCredentialEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureSQLConnectionStringParam parameters = default;
            DataSourceCredentialKind dataSourceCredentialType = default;
            Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Optional<string> dataSourceCredentialDescription = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = AzureSQLConnectionStringParam.DeserializeAzureSQLConnectionStringParam(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"u8))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlConnectionStringCredentialEntity(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value, serializedAdditionalRawData, parameters);
        }

        BinaryData IModel<SqlConnectionStringCredentialEntity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlConnectionStringCredentialEntity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SqlConnectionStringCredentialEntity IModel<SqlConnectionStringCredentialEntity>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlConnectionStringCredentialEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSqlConnectionStringCredentialEntity(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SqlConnectionStringCredentialEntity>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
