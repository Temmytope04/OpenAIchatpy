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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementApprovalStage : IUtf8JsonSerializable, IModelJsonSerializable<RoleManagementApprovalStage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleManagementApprovalStage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleManagementApprovalStage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApprovalStageTimeOutInDays))
            {
                writer.WritePropertyName("approvalStageTimeOutInDays"u8);
                writer.WriteNumberValue(ApprovalStageTimeOutInDays.Value);
            }
            if (Optional.IsDefined(IsApproverJustificationRequired))
            {
                writer.WritePropertyName("isApproverJustificationRequired"u8);
                writer.WriteBooleanValue(IsApproverJustificationRequired.Value);
            }
            if (Optional.IsDefined(EscalationTimeInMinutes))
            {
                writer.WritePropertyName("escalationTimeInMinutes"u8);
                writer.WriteNumberValue(EscalationTimeInMinutes.Value);
            }
            if (Optional.IsCollectionDefined(PrimaryApprovers))
            {
                writer.WritePropertyName("primaryApprovers"u8);
                writer.WriteStartArray();
                foreach (var item in PrimaryApprovers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoleManagementUserInfo>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEscalationEnabled))
            {
                writer.WritePropertyName("isEscalationEnabled"u8);
                writer.WriteBooleanValue(IsEscalationEnabled.Value);
            }
            if (Optional.IsCollectionDefined(EscalationApprovers))
            {
                writer.WritePropertyName("escalationApprovers"u8);
                writer.WriteStartArray();
                foreach (var item in EscalationApprovers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoleManagementUserInfo>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static RoleManagementApprovalStage DeserializeRoleManagementApprovalStage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> approvalStageTimeOutInDays = default;
            Optional<bool> isApproverJustificationRequired = default;
            Optional<int> escalationTimeInMinutes = default;
            Optional<IList<RoleManagementUserInfo>> primaryApprovers = default;
            Optional<bool> isEscalationEnabled = default;
            Optional<IList<RoleManagementUserInfo>> escalationApprovers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("approvalStageTimeOutInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    approvalStageTimeOutInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isApproverJustificationRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isApproverJustificationRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("escalationTimeInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    escalationTimeInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("primaryApprovers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleManagementUserInfo> array = new List<RoleManagementUserInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleManagementUserInfo.DeserializeRoleManagementUserInfo(item));
                    }
                    primaryApprovers = array;
                    continue;
                }
                if (property.NameEquals("isEscalationEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEscalationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("escalationApprovers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleManagementUserInfo> array = new List<RoleManagementUserInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleManagementUserInfo.DeserializeRoleManagementUserInfo(item));
                    }
                    escalationApprovers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleManagementApprovalStage(Optional.ToNullable(approvalStageTimeOutInDays), Optional.ToNullable(isApproverJustificationRequired), Optional.ToNullable(escalationTimeInMinutes), Optional.ToList(primaryApprovers), Optional.ToNullable(isEscalationEnabled), Optional.ToList(escalationApprovers), rawData);
        }

        RoleManagementApprovalStage IModelJsonSerializable<RoleManagementApprovalStage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementApprovalStage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleManagementApprovalStage>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleManagementApprovalStage IModelSerializable<RoleManagementApprovalStage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleManagementApprovalStage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoleManagementApprovalStage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoleManagementApprovalStage"/> to convert. </param>
        public static implicit operator RequestContent(RoleManagementApprovalStage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoleManagementApprovalStage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoleManagementApprovalStage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleManagementApprovalStage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
