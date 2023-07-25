// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecuritySubAssessmentAdditionalInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assessedResourceType"u8);
            writer.WriteStringValue(AssessedResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static SecuritySubAssessmentAdditionalInfo DeserializeSecuritySubAssessmentAdditionalInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("assessedResourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ContainerRegistryVulnerability": return ContainerRegistryVulnerabilityProperties.DeserializeContainerRegistryVulnerabilityProperties(element);
                    case "ServerVulnerabilityAssessment": return ServerVulnerabilityProperties.DeserializeServerVulnerabilityProperties(element);
                    case "SqlServerVulnerability": return SqlServerVulnerabilityProperties.DeserializeSqlServerVulnerabilityProperties(element);
                }
            }
            return UnknownAdditionalData.DeserializeUnknownAdditionalData(element);
        }
    }
}
