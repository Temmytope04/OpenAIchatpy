// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.CallAutomation
{
    internal partial class CreateCallRequestInternal : IUtf8JsonSerializable, IModelJsonSerializable<CreateCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateCallRequestInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateCallRequestInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SourceCallerIdNumber))
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                if (SourceCallerIdNumber is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PhoneNumberIdentifierModel>)SourceCallerIdNumber).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SourceDisplayName))
            {
                writer.WritePropertyName("sourceDisplayName"u8);
                writer.WriteStringValue(SourceDisplayName);
            }
            if (Optional.IsDefined(SourceIdentity))
            {
                writer.WritePropertyName("sourceIdentity"u8);
                if (SourceIdentity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationUserIdentifierModel>)SourceIdentity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsDefined(MediaStreamingConfiguration))
            {
                writer.WritePropertyName("mediaStreamingConfiguration"u8);
                if (MediaStreamingConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MediaStreamingOptionsInternal>)MediaStreamingConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AzureCognitiveServicesEndpointUrl))
            {
                writer.WritePropertyName("azureCognitiveServicesEndpointUrl"u8);
                writer.WriteStringValue(AzureCognitiveServicesEndpointUrl);
            }
            if (Optional.IsDefined(CustomContext))
            {
                writer.WritePropertyName("customContext"u8);
                if (CustomContext is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CustomContextInternal>)CustomContext).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static CreateCallRequestInternal DeserializeCreateCallRequestInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CommunicationIdentifierModel> targets = default;
            Optional<PhoneNumberIdentifierModel> sourceCallerIdNumber = default;
            Optional<string> sourceDisplayName = default;
            Optional<CommunicationUserIdentifierModel> sourceIdentity = default;
            Optional<string> operationContext = default;
            string callbackUri = default;
            Optional<MediaStreamingOptionsInternal> mediaStreamingConfiguration = default;
            Optional<string> azureCognitiveServicesEndpointUrl = default;
            Optional<CustomContextInternal> customContext = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"u8))
                {
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("sourceCallerIdNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCallerIdNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDisplayName"u8))
                {
                    sourceDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIdentity = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaStreamingConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingConfiguration = MediaStreamingOptionsInternal.DeserializeMediaStreamingOptionsInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("azureCognitiveServicesEndpointUrl"u8))
                {
                    azureCognitiveServicesEndpointUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customContext = CustomContextInternal.DeserializeCustomContextInternal(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateCallRequestInternal(targets, sourceCallerIdNumber.Value, sourceDisplayName.Value, sourceIdentity.Value, operationContext.Value, callbackUri, mediaStreamingConfiguration.Value, azureCognitiveServicesEndpointUrl.Value, customContext.Value, rawData);
        }

        CreateCallRequestInternal IModelJsonSerializable<CreateCallRequestInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateCallRequestInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateCallRequestInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateCallRequestInternal IModelSerializable<CreateCallRequestInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateCallRequestInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CreateCallRequestInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CreateCallRequestInternal"/> to convert. </param>
        public static implicit operator RequestContent(CreateCallRequestInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CreateCallRequestInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CreateCallRequestInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateCallRequestInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
