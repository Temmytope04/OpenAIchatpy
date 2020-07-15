// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class GalleryImageVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishingProfile))
            {
                writer.WritePropertyName("publishingProfile");
                writer.WriteObjectValue(PublishingProfile);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(ReplicationStatus))
            {
                writer.WritePropertyName("replicationStatus");
                writer.WriteObjectValue(ReplicationStatus);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GalleryImageVersion DeserializeGalleryImageVersion(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<GalleryArtifactPublishingProfileBase> publishingProfile = default;
            Optional<GalleryImageVersionPropertiesProvisioningState> provisioningState = default;
            Optional<GalleryImageVersionStorageProfile> storageProfile = default;
            Optional<ReplicationStatus> replicationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publishingProfile"))
                        {
                            publishingProfile = GalleryArtifactPublishingProfileBase.DeserializeGalleryArtifactPublishingProfileBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new GalleryImageVersionPropertiesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"))
                        {
                            storageProfile = GalleryImageVersionStorageProfile.DeserializeGalleryImageVersionStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("replicationStatus"))
                        {
                            replicationStatus = ReplicationStatus.DeserializeReplicationStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GalleryImageVersion(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), publishingProfile.Value, Optional.ToNullable(provisioningState), storageProfile.Value, replicationStatus.Value);
        }
    }
}
