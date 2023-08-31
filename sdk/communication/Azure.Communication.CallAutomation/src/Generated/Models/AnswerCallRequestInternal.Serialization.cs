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
    internal partial class AnswerCallRequestInternal : IUtf8JsonSerializable, IModelJsonSerializable<AnswerCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnswerCallRequestInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnswerCallRequestInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
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
            if (Optional.IsDefined(AnsweredByIdentifier))
            {
                writer.WritePropertyName("answeredByIdentifier"u8);
                if (AnsweredByIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationUserIdentifierModel>)AnsweredByIdentifier).Serialize(writer, options);
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

        internal static AnswerCallRequestInternal DeserializeAnswerCallRequestInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string incomingCallContext = default;
            string callbackUri = default;
            Optional<string> operationContext = default;
            Optional<MediaStreamingOptionsInternal> mediaStreamingConfiguration = default;
            Optional<string> azureCognitiveServicesEndpointUrl = default;
            Optional<CommunicationUserIdentifierModel> answeredByIdentifier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
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
                if (property.NameEquals("answeredByIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answeredByIdentifier = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnswerCallRequestInternal(incomingCallContext, callbackUri, operationContext.Value, mediaStreamingConfiguration.Value, azureCognitiveServicesEndpointUrl.Value, answeredByIdentifier.Value, rawData);
        }

        AnswerCallRequestInternal IModelJsonSerializable<AnswerCallRequestInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnswerCallRequestInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnswerCallRequestInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnswerCallRequestInternal IModelSerializable<AnswerCallRequestInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnswerCallRequestInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnswerCallRequestInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnswerCallRequestInternal"/> to convert. </param>
        public static implicit operator RequestContent(AnswerCallRequestInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnswerCallRequestInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnswerCallRequestInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnswerCallRequestInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
