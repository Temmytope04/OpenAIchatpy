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
    public partial class Assessment : IUtf8JsonSerializable, IModelJsonSerializable<Assessment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Assessment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Assessment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static Assessment DeserializeAssessment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AssessmentSeverity> severity = default;
            Optional<string> description = default;
            Optional<string> remediation = default;
            Optional<IsPass> isPass = default;
            Optional<string> policyId = default;
            Optional<IReadOnlyList<AssessmentResource>> resourceList = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new AssessmentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediation"u8))
                {
                    remediation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPass = new IsPass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssessmentResource> array = new List<AssessmentResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssessmentResource.DeserializeAssessmentResource(item));
                    }
                    resourceList = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Assessment(name.Value, Optional.ToNullable(severity), description.Value, remediation.Value, Optional.ToNullable(isPass), policyId.Value, Optional.ToList(resourceList), rawData);
        }

        Assessment IModelJsonSerializable<Assessment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssessment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Assessment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Assessment IModelSerializable<Assessment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssessment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Assessment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Assessment"/> to convert. </param>
        public static implicit operator RequestContent(Assessment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Assessment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Assessment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssessment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
