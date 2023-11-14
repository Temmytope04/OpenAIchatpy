// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class DeletedStorageAccountItem : IUtf8JsonSerializable, IJsonModel<DeletedStorageAccountItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeletedStorageAccountItem>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DeletedStorageAccountItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DeletedStorageAccountItem>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DeletedStorageAccountItem>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryId))
            {
                writer.WritePropertyName("recoveryId"u8);
                writer.WriteStringValue(RecoveryId);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ScheduledPurgeDate))
                {
                    writer.WritePropertyName("scheduledPurgeDate"u8);
                    writer.WriteNumberValue(ScheduledPurgeDate.Value, "U");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DeletedDate))
                {
                    writer.WritePropertyName("deletedDate"u8);
                    writer.WriteNumberValue(DeletedDate.Value, "U");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceId))
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Attributes))
                {
                    writer.WritePropertyName("attributes"u8);
                    writer.WriteObjectValue(Attributes);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DeletedStorageAccountItem IJsonModel<DeletedStorageAccountItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeletedStorageAccountItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedStorageAccountItem(document.RootElement, options);
        }

        internal static DeletedStorageAccountItem DeserializeDeletedStorageAccountItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryId = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<DateTimeOffset> deletedDate = default;
            Optional<string> id = default;
            Optional<string> resourceId = default;
            Optional<StorageAccountAttributes> attributes = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryId"u8))
                {
                    recoveryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("deletedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = StorageAccountAttributes.DeserializeStorageAccountAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeletedStorageAccountItem(id.Value, resourceId.Value, attributes.Value, Optional.ToDictionary(tags), serializedAdditionalRawData, recoveryId.Value, Optional.ToNullable(scheduledPurgeDate), Optional.ToNullable(deletedDate));
        }

        BinaryData IPersistableModel<DeletedStorageAccountItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeletedStorageAccountItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DeletedStorageAccountItem IPersistableModel<DeletedStorageAccountItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeletedStorageAccountItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDeletedStorageAccountItem(document.RootElement, options);
        }

        string IPersistableModel<DeletedStorageAccountItem>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
