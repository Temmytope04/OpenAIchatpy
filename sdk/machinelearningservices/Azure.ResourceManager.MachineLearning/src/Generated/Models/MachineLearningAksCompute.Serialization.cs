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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksCompute : IUtf8JsonSerializable, IJsonModel<MachineLearningAksCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAksCompute>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningAksCompute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningAksCompute>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningAksCompute>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
            if (Optional.IsDefined(ComputeLocation))
            {
                writer.WritePropertyName("computeLocation"u8);
                writer.WriteStringValue(ComputeLocation);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ModifiedOn))
                {
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(ModifiedOn.Value, "O");
                }
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(ProvisioningErrors))
                {
                    if (ProvisioningErrors != null)
                    {
                        writer.WritePropertyName("provisioningErrors"u8);
                        writer.WriteStartArray();
                        foreach (var item in ProvisioningErrors)
                        {
                            writer.WriteObjectValue(item);
                        }
                        writer.WriteEndArray();
                    }
                    else
                    {
                        writer.WriteNull("provisioningErrors");
                    }
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsAttachedCompute))
                {
                    writer.WritePropertyName("isAttachedCompute"u8);
                    writer.WriteBooleanValue(IsAttachedCompute.Value);
                }
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
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

        MachineLearningAksCompute IJsonModel<MachineLearningAksCompute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksCompute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAksCompute(document.RootElement, options);
        }

        internal static MachineLearningAksCompute DeserializeMachineLearningAksCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningAksComputeProperties> properties = default;
            ComputeType computeType = default;
            Optional<string> computeLocation = default;
            Optional<MachineLearningProvisioningState> provisioningState = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> modifiedOn = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<IReadOnlyList<MachineLearningError>> provisioningErrors = default;
            Optional<bool> isAttachedCompute = default;
            Optional<bool> disableLocalAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = MachineLearningAksComputeProperties.DeserializeMachineLearningAksComputeProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeLocation"u8))
                {
                    computeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningErrors = null;
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item));
                    }
                    provisioningErrors = array;
                    continue;
                }
                if (property.NameEquals("isAttachedCompute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAttachedCompute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAksCompute(computeType, computeLocation.Value, Optional.ToNullable(provisioningState), description.Value, Optional.ToNullable(createdOn), Optional.ToNullable(modifiedOn), resourceId.Value, Optional.ToList(provisioningErrors), Optional.ToNullable(isAttachedCompute), Optional.ToNullable(disableLocalAuth), serializedAdditionalRawData, properties.Value);
        }

        BinaryData IPersistableModel<MachineLearningAksCompute>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksCompute)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningAksCompute IPersistableModel<MachineLearningAksCompute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksCompute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningAksCompute(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningAksCompute>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
