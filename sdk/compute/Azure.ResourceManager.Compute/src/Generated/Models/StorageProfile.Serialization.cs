// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class StorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference");
                writer.WriteObjectValue(ImageReference);
            }
            if (Optional.IsDefined(OsDisk))
            {
                writer.WritePropertyName("osDisk");
                writer.WriteObjectValue(OsDisk);
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks");
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StorageProfile DeserializeStorageProfile(JsonElement element)
        {
            Optional<ImageReference> imageReference = default;
            Optional<OSDisk> osDisk = default;
            Optional<IList<DataDisk>> dataDisks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"))
                {
                    imageReference = ImageReference.DeserializeImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("osDisk"))
                {
                    osDisk = OSDisk.DeserializeOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"))
                {
                    List<DataDisk> array = new List<DataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataDisk.DeserializeDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
            }
            return new StorageProfile(imageReference.Value, osDisk.Value, Optional.ToList(dataDisks));
        }
    }
}
