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
    public partial class AwsOrganizationalDataMaster : IUtf8JsonSerializable, IModelJsonSerializable<AwsOrganizationalDataMaster>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AwsOrganizationalDataMaster>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AwsOrganizationalDataMaster>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMaster>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StacksetName))
            {
                writer.WritePropertyName("stacksetName"u8);
                writer.WriteStringValue(StacksetName);
            }
            if (Optional.IsCollectionDefined(ExcludedAccountIds))
            {
                writer.WritePropertyName("excludedAccountIds"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedAccountIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
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

        internal static AwsOrganizationalDataMaster DeserializeAwsOrganizationalDataMaster(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stacksetName = default;
            Optional<IList<string>> excludedAccountIds = default;
            OrganizationMembershipType organizationMembershipType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stacksetName"u8))
                {
                    stacksetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedAccountIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedAccountIds = array;
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AwsOrganizationalDataMaster(organizationMembershipType, stacksetName.Value, Optional.ToList(excludedAccountIds), rawData);
        }

        AwsOrganizationalDataMaster IModelJsonSerializable<AwsOrganizationalDataMaster>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMaster>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsOrganizationalDataMaster(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AwsOrganizationalDataMaster>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMaster>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AwsOrganizationalDataMaster IModelSerializable<AwsOrganizationalDataMaster>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AwsOrganizationalDataMaster>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAwsOrganizationalDataMaster(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AwsOrganizationalDataMaster model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AwsOrganizationalDataMaster(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAwsOrganizationalDataMaster(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
