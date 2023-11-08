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

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesMarketplaceRegistrationProperties : IUtf8JsonSerializable, IJsonModel<ManagedServicesMarketplaceRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesMarketplaceRegistrationProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ManagedServicesMarketplaceRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("managedByTenantId"u8);
            writer.WriteStringValue(ManagedByTenantId);
            writer.WritePropertyName("authorizations"u8);
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(EligibleAuthorizations))
            {
                writer.WritePropertyName("eligibleAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in EligibleAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OfferDisplayName))
            {
                writer.WritePropertyName("offerDisplayName"u8);
                writer.WriteStringValue(OfferDisplayName);
            }
            if (Optional.IsDefined(PublisherDisplayName))
            {
                writer.WritePropertyName("publisherDisplayName"u8);
                writer.WriteStringValue(PublisherDisplayName);
            }
            if (Optional.IsDefined(PlanDisplayName))
            {
                writer.WritePropertyName("planDisplayName"u8);
                writer.WriteStringValue(PlanDisplayName);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ManagedServicesMarketplaceRegistrationProperties IJsonModel<ManagedServicesMarketplaceRegistrationProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesMarketplaceRegistrationProperties(document.RootElement, options);
        }

        internal static ManagedServicesMarketplaceRegistrationProperties DeserializeManagedServicesMarketplaceRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid managedByTenantId = default;
            IReadOnlyList<ManagedServicesAuthorization> authorizations = default;
            Optional<IReadOnlyList<ManagedServicesEligibleAuthorization>> eligibleAuthorizations = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherDisplayName = default;
            Optional<string> planDisplayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedByTenantId"u8))
                {
                    managedByTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    List<ManagedServicesAuthorization> array = new List<ManagedServicesAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesAuthorization.DeserializeManagedServicesAuthorization(item));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("eligibleAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesEligibleAuthorization> array = new List<ManagedServicesEligibleAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesEligibleAuthorization.DeserializeManagedServicesEligibleAuthorization(item));
                    }
                    eligibleAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("offerDisplayName"u8))
                {
                    offerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherDisplayName"u8))
                {
                    publisherDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedServicesMarketplaceRegistrationProperties(managedByTenantId, authorizations, Optional.ToList(eligibleAuthorizations), offerDisplayName.Value, publisherDisplayName.Value, planDisplayName.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ManagedServicesMarketplaceRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedServicesMarketplaceRegistrationProperties IModel<ManagedServicesMarketplaceRegistrationProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedServicesMarketplaceRegistrationProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ManagedServicesMarketplaceRegistrationProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
