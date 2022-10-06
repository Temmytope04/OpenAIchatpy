// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeRegistrationPropertiesTemplateDeploymentOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreflightSupported))
            {
                writer.WritePropertyName("preflightSupported");
                writer.WriteBooleanValue(PreflightSupported.Value);
            }
            if (Optional.IsCollectionDefined(PreflightOptions))
            {
                writer.WritePropertyName("preflightOptions");
                writer.WriteStartArray();
                foreach (var item in PreflightOptions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeRegistrationPropertiesTemplateDeploymentOptions DeserializeResourceTypeRegistrationPropertiesTemplateDeploymentOptions(JsonElement element)
        {
            Optional<bool> preflightSupported = default;
            Optional<IList<PreflightOption>> preflightOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preflightSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preflightSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preflightOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PreflightOption> array = new List<PreflightOption>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreflightOption(item.GetString()));
                    }
                    preflightOptions = array;
                    continue;
                }
            }
            return new ResourceTypeRegistrationPropertiesTemplateDeploymentOptions(Optional.ToNullable(preflightSupported), Optional.ToList(preflightOptions));
        }
    }
}
