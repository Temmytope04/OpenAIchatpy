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

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class ProofOfPossessionNonceResponse : IUtf8JsonSerializable, IModelJsonSerializable<ProofOfPossessionNonceResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProofOfPossessionNonceResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProofOfPossessionNonceResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ProofOfPossessionNonceResponse>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ProofOfPossessionNonceResponse DeserializeProofOfPossessionNonceResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            Optional<SphereCertificateStatus> status = default;
            Optional<string> subject = default;
            Optional<string> thumbprint = default;
            Optional<DateTimeOffset> expiryUtc = default;
            Optional<DateTimeOffset> notBeforeUtc = default;
            Optional<SphereProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SphereCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("notBeforeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBeforeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SphereProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProofOfPossessionNonceResponse(certificate.Value, Optional.ToNullable(status), subject.Value, thumbprint.Value, Optional.ToNullable(expiryUtc), Optional.ToNullable(notBeforeUtc), Optional.ToNullable(provisioningState), rawData);
        }

        ProofOfPossessionNonceResponse IModelJsonSerializable<ProofOfPossessionNonceResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ProofOfPossessionNonceResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProofOfPossessionNonceResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProofOfPossessionNonceResponse>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ProofOfPossessionNonceResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProofOfPossessionNonceResponse IModelSerializable<ProofOfPossessionNonceResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ProofOfPossessionNonceResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProofOfPossessionNonceResponse(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ProofOfPossessionNonceResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ProofOfPossessionNonceResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProofOfPossessionNonceResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
