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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class InstancePoolFamilyCapability : IUtf8JsonSerializable, IModelJsonSerializable<InstancePoolFamilyCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstancePoolFamilyCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InstancePoolFamilyCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
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

        internal static InstancePoolFamilyCapability DeserializeInstancePoolFamilyCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<IReadOnlyList<InstancePoolVcoresCapability>> supportedVcoresValues = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedVcoresValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancePoolVcoresCapability> array = new List<InstancePoolVcoresCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancePoolVcoresCapability.DeserializeInstancePoolVcoresCapability(item));
                    }
                    supportedVcoresValues = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InstancePoolFamilyCapability(name.Value, Optional.ToList(supportedLicenseTypes), Optional.ToList(supportedVcoresValues), Optional.ToNullable(status), reason.Value, rawData);
        }

        InstancePoolFamilyCapability IModelJsonSerializable<InstancePoolFamilyCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancePoolFamilyCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstancePoolFamilyCapability>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstancePoolFamilyCapability IModelSerializable<InstancePoolFamilyCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstancePoolFamilyCapability(doc.RootElement, options);
        }

        public static implicit operator RequestContent(InstancePoolFamilyCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator InstancePoolFamilyCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstancePoolFamilyCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
