// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class PrometheusHAClusterProviderInstanceProperties : IUtf8JsonSerializable, IModelJsonSerializable<PrometheusHAClusterProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrometheusHAClusterProviderInstanceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrometheusHAClusterProviderInstanceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PrometheusHAClusterProviderInstanceProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrometheusUri))
            {
                writer.WritePropertyName("prometheusUrl"u8);
                writer.WriteStringValue(PrometheusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PrometheusHAClusterProviderInstanceProperties DeserializePrometheusHAClusterProviderInstanceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> prometheusUrl = default;
            Optional<string> hostname = default;
            Optional<string> sid = default;
            Optional<string> clusterName = default;
            Optional<SapSslPreference> sslPreference = default;
            Optional<Uri> sslCertificateUri = default;
            string providerType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prometheusUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterName"u8))
                {
                    clusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrometheusHAClusterProviderInstanceProperties(providerType, prometheusUrl.Value, hostname.Value, sid.Value, clusterName.Value, Optional.ToNullable(sslPreference), sslCertificateUri.Value, rawData);
        }

        PrometheusHAClusterProviderInstanceProperties IModelJsonSerializable<PrometheusHAClusterProviderInstanceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PrometheusHAClusterProviderInstanceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrometheusHAClusterProviderInstanceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrometheusHAClusterProviderInstanceProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PrometheusHAClusterProviderInstanceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrometheusHAClusterProviderInstanceProperties IModelSerializable<PrometheusHAClusterProviderInstanceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PrometheusHAClusterProviderInstanceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrometheusHAClusterProviderInstanceProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PrometheusHAClusterProviderInstanceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PrometheusHAClusterProviderInstanceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrometheusHAClusterProviderInstanceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
