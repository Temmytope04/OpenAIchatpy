// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ContainerAppData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(KubeEnvironmentId))
            {
                writer.WritePropertyName("kubeEnvironmentId");
                writer.WriteStringValue(KubeEnvironmentId);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteObjectValue(Configuration);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
                writer.WriteObjectValue(Template);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerAppData DeserializeContainerAppData(JsonElement element)
        {
            Optional<string> kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ContainerAppProvisioningState> provisioningState = default;
            Optional<string> kubeEnvironmentId = default;
            Optional<string> latestRevisionName = default;
            Optional<string> latestRevisionFqdn = default;
            Optional<Configuration> configuration = default;
            Optional<Template> template = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ContainerAppProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kubeEnvironmentId"))
                        {
                            kubeEnvironmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestRevisionName"))
                        {
                            latestRevisionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestRevisionFqdn"))
                        {
                            latestRevisionFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configuration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            configuration = Configuration.DeserializeConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("template"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            template = Template.DeserializeTemplate(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerAppData(id, name, type, systemData, tags, location, kind.Value, Optional.ToNullable(provisioningState), kubeEnvironmentId.Value, latestRevisionName.Value, latestRevisionFqdn.Value, configuration.Value, template.Value);
        }
    }
}
