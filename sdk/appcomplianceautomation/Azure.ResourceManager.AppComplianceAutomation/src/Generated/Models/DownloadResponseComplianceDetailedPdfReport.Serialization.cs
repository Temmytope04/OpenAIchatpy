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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    internal partial class DownloadResponseComplianceDetailedPdfReport : IUtf8JsonSerializable, IModelJsonSerializable<DownloadResponseComplianceDetailedPdfReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DownloadResponseComplianceDetailedPdfReport>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DownloadResponseComplianceDetailedPdfReport>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static DownloadResponseComplianceDetailedPdfReport DeserializeDownloadResponseComplianceDetailedPdfReport(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> sasUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DownloadResponseComplianceDetailedPdfReport(sasUri.Value, rawData);
        }

        DownloadResponseComplianceDetailedPdfReport IModelJsonSerializable<DownloadResponseComplianceDetailedPdfReport>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDownloadResponseComplianceDetailedPdfReport(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DownloadResponseComplianceDetailedPdfReport>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DownloadResponseComplianceDetailedPdfReport IModelSerializable<DownloadResponseComplianceDetailedPdfReport>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDownloadResponseComplianceDetailedPdfReport(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DownloadResponseComplianceDetailedPdfReport"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DownloadResponseComplianceDetailedPdfReport"/> to convert. </param>
        public static implicit operator RequestContent(DownloadResponseComplianceDetailedPdfReport model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DownloadResponseComplianceDetailedPdfReport"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DownloadResponseComplianceDetailedPdfReport(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDownloadResponseComplianceDetailedPdfReport(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
