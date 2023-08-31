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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class VmHostPlacementPolicyProperties : IUtf8JsonSerializable, IModelJsonSerializable<VmHostPlacementPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmHostPlacementPolicyProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmHostPlacementPolicyProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmHostPlacementPolicyProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("vmMembers"u8);
            writer.WriteStartArray();
            foreach (var item in VmMembers)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("hostMembers"u8);
            writer.WriteStartArray();
            foreach (var item in HostMembers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("affinityType"u8);
            writer.WriteStringValue(AffinityType.ToString());
            if (Optional.IsDefined(AffinityStrength))
            {
                writer.WritePropertyName("affinityStrength"u8);
                writer.WriteStringValue(AffinityStrength.Value.ToString());
            }
            if (Optional.IsDefined(AzureHybridBenefitType))
            {
                writer.WritePropertyName("azureHybridBenefitType"u8);
                writer.WriteStringValue(AzureHybridBenefitType.Value.ToString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
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

        internal static VmHostPlacementPolicyProperties DeserializeVmHostPlacementPolicyProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> vmMembers = default;
            IList<string> hostMembers = default;
            AvsPlacementPolicyAffinityType affinityType = default;
            Optional<VmHostPlacementPolicyAffinityStrength> affinityStrength = default;
            Optional<AzureHybridBenefitType> azureHybridBenefitType = default;
            PlacementPolicyType type = default;
            Optional<PlacementPolicyState> state = default;
            Optional<string> displayName = default;
            Optional<PlacementPolicyProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmMembers"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    vmMembers = array;
                    continue;
                }
                if (property.NameEquals("hostMembers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hostMembers = array;
                    continue;
                }
                if (property.NameEquals("affinityType"u8))
                {
                    affinityType = new AvsPlacementPolicyAffinityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("affinityStrength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affinityStrength = new VmHostPlacementPolicyAffinityStrength(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureHybridBenefitType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureHybridBenefitType = new AzureHybridBenefitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new PlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PlacementPolicyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PlacementPolicyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmHostPlacementPolicyProperties(type, Optional.ToNullable(state), displayName.Value, Optional.ToNullable(provisioningState), vmMembers, hostMembers, affinityType, Optional.ToNullable(affinityStrength), Optional.ToNullable(azureHybridBenefitType), rawData);
        }

        VmHostPlacementPolicyProperties IModelJsonSerializable<VmHostPlacementPolicyProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmHostPlacementPolicyProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmHostPlacementPolicyProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmHostPlacementPolicyProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmHostPlacementPolicyProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmHostPlacementPolicyProperties IModelSerializable<VmHostPlacementPolicyProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmHostPlacementPolicyProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmHostPlacementPolicyProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VmHostPlacementPolicyProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VmHostPlacementPolicyProperties"/> to convert. </param>
        public static implicit operator RequestContent(VmHostPlacementPolicyProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VmHostPlacementPolicyProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VmHostPlacementPolicyProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmHostPlacementPolicyProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
