// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Defender.Easm
{
    public partial class HostAssetResource : IUtf8JsonWriteable, IJsonModel<HostAssetResource>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostAssetResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostAssetResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostAssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostAssetResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("asset"u8);
            writer.WriteObjectValue(Asset);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid.Value);
            }
            if (Optional.IsDefined(CreatedDate))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedDate.Value, "O");
            }
            if (Optional.IsDefined(UpdatedDate))
            {
                writer.WritePropertyName("updatedDate"u8);
                writer.WriteStringValue(UpdatedDate.Value, "O");
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(ExternalId))
            {
                writer.WritePropertyName("externalId"u8);
                writer.WriteStringValue(ExternalId);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Wildcard))
            {
                writer.WritePropertyName("wildcard"u8);
                writer.WriteBooleanValue(Wildcard.Value);
            }
            if (Optional.IsDefined(DiscoGroupName))
            {
                writer.WritePropertyName("discoGroupName"u8);
                writer.WriteStringValue(DiscoGroupName);
            }
            if (Optional.IsCollectionDefined(AuditTrail))
            {
                writer.WritePropertyName("auditTrail"u8);
                writer.WriteStartArray();
                foreach (var item in AuditTrail)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        HostAssetResource IJsonModel<HostAssetResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostAssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostAssetResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostAssetResource(document.RootElement, options);
        }

        internal static HostAssetResource DeserializeHostAssetResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HostAsset asset = default;
            string kind = default;
            string id = default;
            string name = default;
            string displayName = default;
            Guid? uuid = default;
            DateTimeOffset? createdDate = default;
            DateTimeOffset? updatedDate = default;
            AssetState? state = default;
            string externalId = default;
            IReadOnlyList<string> labels = default;
            bool? wildcard = default;
            string discoGroupName = default;
            IReadOnlyList<AuditTrailItem> auditTrail = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asset"u8))
                {
                    asset = HostAsset.DeserializeHostAsset(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AssetState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("externalId"u8))
                {
                    externalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("wildcard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("discoGroupName"u8))
                {
                    discoGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("auditTrail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuditTrailItem> array = new List<AuditTrailItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuditTrailItem.DeserializeAuditTrailItem(item, options));
                    }
                    auditTrail = array;
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostAssetResource(
                kind,
                id,
                name,
                displayName,
                uuid,
                createdDate,
                updatedDate,
                state,
                externalId,
                labels ?? new ChangeTrackingList<string>(),
                wildcard,
                discoGroupName,
                auditTrail ?? new ChangeTrackingList<AuditTrailItem>(),
                reason,
                serializedAdditionalRawData,
                asset);
        }

        BinaryData IPersistableModel<HostAssetResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostAssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostAssetResource)} does not support '{options.Format}' format.");
            }
        }

        HostAssetResource IPersistableModel<HostAssetResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostAssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostAssetResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostAssetResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostAssetResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new HostAssetResource FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHostAssetResource(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
