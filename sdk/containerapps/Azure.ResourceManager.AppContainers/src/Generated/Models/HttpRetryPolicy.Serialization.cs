// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class HttpRetryPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxRetries))
            {
                writer.WritePropertyName("maxRetries"u8);
                writer.WriteNumberValue(MaxRetries.Value);
            }
            writer.WritePropertyName("matches"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HttpStatusCodes))
            {
                writer.WritePropertyName("httpStatusCodes"u8);
                writer.WriteStartArray();
                foreach (var item in HttpStatusCodes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WritePropertyName("retryBackOff"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(InitialDelayInMilliseconds))
            {
                writer.WritePropertyName("initialDelayInMilliseconds"u8);
                writer.WriteNumberValue(InitialDelayInMilliseconds.Value);
            }
            if (Optional.IsDefined(MaxIntervalInMilliseconds))
            {
                writer.WritePropertyName("maxIntervalInMilliseconds"u8);
                writer.WriteNumberValue(MaxIntervalInMilliseconds.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HttpRetryPolicy DeserializeHttpRetryPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxRetries = default;
            Optional<IList<HeaderMatch>> headers = default;
            Optional<IList<int>> httpStatusCodes = default;
            Optional<IList<string>> errors = default;
            Optional<long> initialDelayInMilliseconds = default;
            Optional<long> maxIntervalInMilliseconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRetries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRetries = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matches"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("headers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HeaderMatch> array = new List<HeaderMatch>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HeaderMatch.DeserializeHeaderMatch(item));
                            }
                            headers = array;
                            continue;
                        }
                        if (property0.NameEquals("httpStatusCodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<int> array = new List<int>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetInt32());
                            }
                            httpStatusCodes = array;
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            errors = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("retryBackOff"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("initialDelayInMilliseconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            initialDelayInMilliseconds = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxIntervalInMilliseconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxIntervalInMilliseconds = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HttpRetryPolicy(Optional.ToNullable(maxRetries), Optional.ToList(headers), Optional.ToList(httpStatusCodes), Optional.ToList(errors), Optional.ToNullable(initialDelayInMilliseconds), Optional.ToNullable(maxIntervalInMilliseconds));
        }
    }
}
