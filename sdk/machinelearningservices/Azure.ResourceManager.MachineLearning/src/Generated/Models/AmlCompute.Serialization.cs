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
    public partial class AmlCompute : IUtf8JsonSerializable, IJsonModel<AmlCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlCompute>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AmlCompute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
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
            if (options.Format == ModelReaderWriterFormat.Json)
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
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
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
            if (options.Format == ModelReaderWriterFormat.Json)
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
            if (options.Format == ModelReaderWriterFormat.Json)
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

        AmlCompute IJsonModel<AmlCompute>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlCompute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlCompute(document.RootElement, options);
        }

        internal static AmlCompute DeserializeAmlCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AmlComputeProperties> properties = default;
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
                    properties = AmlComputeProperties.DeserializeAmlComputeProperties(property.Value);
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlCompute(computeType, computeLocation.Value, Optional.ToNullable(provisioningState), description.Value, Optional.ToNullable(createdOn), Optional.ToNullable(modifiedOn), resourceId.Value, Optional.ToList(provisioningErrors), Optional.ToNullable(isAttachedCompute), Optional.ToNullable(disableLocalAuth), serializedAdditionalRawData, properties.Value);
        }

        BinaryData IModel<AmlCompute>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlCompute)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AmlCompute IModel<AmlCompute>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlCompute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAmlCompute(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AmlCompute>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
