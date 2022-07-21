// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ImageDescriptor : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Registry))
            {
                writer.WritePropertyName("registry");
                writer.WriteStringValue(Registry);
            }
            if (Optional.IsDefined(Repository))
            {
                writer.WritePropertyName("repository");
                writer.WriteStringValue(Repository);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag");
                writer.WriteStringValue(Tag);
            }
            if (Optional.IsDefined(Digest))
            {
                writer.WritePropertyName("digest");
                writer.WriteStringValue(Digest);
            }
            writer.WriteEndObject();
        }

        internal static ImageDescriptor DeserializeImageDescriptor(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> repository = default;
            Optional<string> tag = default;
            Optional<string> digest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repository"))
                {
                    repository = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
            }
            return new ImageDescriptor(registry.Value, repository.Value, tag.Value, digest.Value);
        }
    }
}
