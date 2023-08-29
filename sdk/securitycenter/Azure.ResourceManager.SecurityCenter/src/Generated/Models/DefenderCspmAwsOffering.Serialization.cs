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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmAwsOffering : IUtf8JsonSerializable, IModelJsonSerializable<DefenderCspmAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderCspmAwsOffering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderCspmAwsOffering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderCspmAwsOffering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
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

        internal static DefenderCspmAwsOffering DeserializeDefenderCspmAwsOffering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderCspmAwsOfferingVmScanners> vmScanners = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderCspmAwsOfferingVmScanners.DeserializeDefenderCspmAwsOfferingVmScanners(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderCspmAwsOffering(offeringType, description.Value, vmScanners.Value, rawData);
        }

        DefenderCspmAwsOffering IModelJsonSerializable<DefenderCspmAwsOffering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderCspmAwsOffering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOffering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderCspmAwsOffering>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderCspmAwsOffering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderCspmAwsOffering IModelSerializable<DefenderCspmAwsOffering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderCspmAwsOffering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderCspmAwsOffering(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DefenderCspmAwsOffering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DefenderCspmAwsOffering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderCspmAwsOffering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
