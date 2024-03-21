// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationRule : IUtf8JsonSerializable, IJsonModel<ApplicationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationAddresses))
            {
                writer.WritePropertyName("destinationAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TargetFqdns))
            {
                writer.WritePropertyName("targetFqdns"u8);
                writer.WriteStartArray();
                foreach (var item in TargetFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TargetUrls))
            {
                writer.WritePropertyName("targetUrls"u8);
                writer.WriteStartArray();
                foreach (var item in TargetUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FqdnTags))
            {
                writer.WritePropertyName("fqdnTags"u8);
                writer.WriteStartArray();
                foreach (var item in FqdnTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceIPGroups))
            {
                writer.WritePropertyName("sourceIpGroups"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TerminateTLS))
            {
                writer.WritePropertyName("terminateTLS"u8);
                writer.WriteBooleanValue(TerminateTLS.Value);
            }
            if (Optional.IsCollectionDefined(WebCategories))
            {
                writer.WritePropertyName("webCategories"u8);
                writer.WriteStartArray();
                foreach (var item in WebCategories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HttpHeadersToInsert))
            {
                writer.WritePropertyName("httpHeadersToInsert"u8);
                writer.WriteStartArray();
                foreach (var item in HttpHeadersToInsert)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
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

        ApplicationRule IJsonModel<ApplicationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationRule(document.RootElement, options);
        }

        internal static ApplicationRule DeserializeApplicationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> sourceAddresses = default;
            IList<string> destinationAddresses = default;
            IList<FirewallPolicyRuleApplicationProtocol> protocols = default;
            IList<string> targetFqdns = default;
            IList<string> targetUrls = default;
            IList<string> fqdnTags = default;
            IList<string> sourceIPGroups = default;
            bool? terminateTLS = default;
            IList<string> webCategories = default;
            IList<FirewallPolicyHttpHeaderToInsert> httpHeadersToInsert = default;
            string name = default;
            string description = default;
            FirewallPolicyRuleType ruleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceAddresses"u8))
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
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"u8))
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
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("protocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyRuleApplicationProtocol> array = new List<FirewallPolicyRuleApplicationProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyRuleApplicationProtocol.DeserializeFirewallPolicyRuleApplicationProtocol(item, options));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("targetFqdns"u8))
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
                    targetFqdns = array;
                    continue;
                }
                if (property.NameEquals("targetUrls"u8))
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
                    targetUrls = array;
                    continue;
                }
                if (property.NameEquals("fqdnTags"u8))
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
                    fqdnTags = array;
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"u8))
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
                    sourceIPGroups = array;
                    continue;
                }
                if (property.NameEquals("terminateTLS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminateTLS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("webCategories"u8))
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
                    webCategories = array;
                    continue;
                }
                if (property.NameEquals("httpHeadersToInsert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyHttpHeaderToInsert> array = new List<FirewallPolicyHttpHeaderToInsert>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyHttpHeaderToInsert.DeserializeFirewallPolicyHttpHeaderToInsert(item, options));
                    }
                    httpHeadersToInsert = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationRule(
                name,
                description,
                ruleType,
                serializedAdditionalRawData,
                sourceAddresses ?? new ChangeTrackingList<string>(),
                destinationAddresses ?? new ChangeTrackingList<string>(),
                protocols ?? new ChangeTrackingList<FirewallPolicyRuleApplicationProtocol>(),
                targetFqdns ?? new ChangeTrackingList<string>(),
                targetUrls ?? new ChangeTrackingList<string>(),
                fqdnTags ?? new ChangeTrackingList<string>(),
                sourceIPGroups ?? new ChangeTrackingList<string>(),
                terminateTLS,
                webCategories ?? new ChangeTrackingList<string>(),
                httpHeadersToInsert ?? new ChangeTrackingList<FirewallPolicyHttpHeaderToInsert>());
        }

        BinaryData IPersistableModel<ApplicationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationRule)} does not support '{options.Format}' format.");
            }
        }

        ApplicationRule IPersistableModel<ApplicationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
