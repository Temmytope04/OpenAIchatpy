// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class CodelessConnectorPollingRequestProperties : IUtf8JsonSerializable, IJsonModel<CodelessConnectorPollingRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CodelessConnectorPollingRequestProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CodelessConnectorPollingRequestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessConnectorPollingRequestProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("apiEndpoint"u8);
            writer.WriteStringValue(ApiEndpoint);
            if (Optional.IsDefined(RateLimitQps))
            {
                writer.WritePropertyName("rateLimitQps"u8);
                writer.WriteNumberValue(RateLimitQps.Value);
            }
            writer.WritePropertyName("queryWindowInMin"u8);
            writer.WriteNumberValue(QueryWindowInMin);
            writer.WritePropertyName("httpMethod"u8);
            writer.WriteStringValue(HttpMethod);
            writer.WritePropertyName("queryTimeFormat"u8);
            writer.WriteStringValue(QueryTimeFormat);
            if (Optional.IsDefined(RetryCount))
            {
                writer.WritePropertyName("retryCount"u8);
                writer.WriteNumberValue(RetryCount.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Headers);
#else
                using (JsonDocument document = JsonDocument.Parse(Headers))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(QueryParameters))
            {
                writer.WritePropertyName("queryParameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(QueryParameters);
#else
                using (JsonDocument document = JsonDocument.Parse(QueryParameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(QueryParametersTemplate))
            {
                writer.WritePropertyName("queryParametersTemplate"u8);
                writer.WriteStringValue(QueryParametersTemplate);
            }
            if (Optional.IsDefined(StartTimeAttributeName))
            {
                writer.WritePropertyName("startTimeAttributeName"u8);
                writer.WriteStringValue(StartTimeAttributeName);
            }
            if (Optional.IsDefined(EndTimeAttributeName))
            {
                writer.WritePropertyName("endTimeAttributeName"u8);
                writer.WriteStringValue(EndTimeAttributeName);
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

        CodelessConnectorPollingRequestProperties IJsonModel<CodelessConnectorPollingRequestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodelessConnectorPollingRequestProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodelessConnectorPollingRequestProperties(document.RootElement, options);
        }

        internal static CodelessConnectorPollingRequestProperties DeserializeCodelessConnectorPollingRequestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiEndpoint = default;
            int? rateLimitQps = default;
            int queryWindowInMin = default;
            string httpMethod = default;
            string queryTimeFormat = default;
            int? retryCount = default;
            int? timeoutInSeconds = default;
            BinaryData headers = default;
            BinaryData queryParameters = default;
            string queryParametersTemplate = default;
            string startTimeAttributeName = default;
            string endTimeAttributeName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiEndpoint"u8))
                {
                    apiEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rateLimitQps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitQps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queryWindowInMin"u8))
                {
                    queryWindowInMin = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryTimeFormat"u8))
                {
                    queryTimeFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headers = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryParameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("queryParametersTemplate"u8))
                {
                    queryParametersTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeAttributeName"u8))
                {
                    startTimeAttributeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTimeAttributeName"u8))
                {
                    endTimeAttributeName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CodelessConnectorPollingRequestProperties(
                apiEndpoint,
                rateLimitQps,
                queryWindowInMin,
                httpMethod,
                queryTimeFormat,
                retryCount,
                timeoutInSeconds,
                headers,
                queryParameters,
                queryParametersTemplate,
                startTimeAttributeName,
                endTimeAttributeName,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiEndpoint))
                {
                    builder.Append("  apiEndpoint: ");
                    if (ApiEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RateLimitQps), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rateLimitQps: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RateLimitQps))
                {
                    builder.Append("  rateLimitQps: ");
                    builder.AppendLine($"{RateLimitQps.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryWindowInMin), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryWindowInMin: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  queryWindowInMin: ");
                builder.AppendLine($"{QueryWindowInMin}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpMethod), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  httpMethod: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpMethod))
                {
                    builder.Append("  httpMethod: ");
                    if (HttpMethod.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HttpMethod}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HttpMethod}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryTimeFormat), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryTimeFormat: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryTimeFormat))
                {
                    builder.Append("  queryTimeFormat: ");
                    if (QueryTimeFormat.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryTimeFormat}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryTimeFormat}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetryCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  retryCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetryCount))
                {
                    builder.Append("  retryCount: ");
                    builder.AppendLine($"{RetryCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeoutInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("  timeoutInSeconds: ");
                    builder.AppendLine($"{TimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  headers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Headers))
                {
                    builder.Append("  headers: ");
                    builder.AppendLine($"'{Headers.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryParameters))
                {
                    builder.Append("  queryParameters: ");
                    builder.AppendLine($"'{QueryParameters.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueryParametersTemplate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  queryParametersTemplate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QueryParametersTemplate))
                {
                    builder.Append("  queryParametersTemplate: ");
                    if (QueryParametersTemplate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QueryParametersTemplate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QueryParametersTemplate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartTimeAttributeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTimeAttributeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartTimeAttributeName))
                {
                    builder.Append("  startTimeAttributeName: ");
                    if (StartTimeAttributeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StartTimeAttributeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StartTimeAttributeName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndTimeAttributeName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTimeAttributeName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndTimeAttributeName))
                {
                    builder.Append("  endTimeAttributeName: ");
                    if (EndTimeAttributeName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndTimeAttributeName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndTimeAttributeName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CodelessConnectorPollingRequestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CodelessConnectorPollingRequestProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CodelessConnectorPollingRequestProperties IPersistableModel<CodelessConnectorPollingRequestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodelessConnectorPollingRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCodelessConnectorPollingRequestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodelessConnectorPollingRequestProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodelessConnectorPollingRequestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
