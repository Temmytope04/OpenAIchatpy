// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MethodRequest : IUtf8JsonSerializable, IModelJsonSerializable<MethodRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MethodRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MethodRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        internal static MethodRequest DeserializeMethodRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("methodName", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MethodRequestEmptyBodyBase": return MethodRequestEmptyBodyBase.DeserializeMethodRequestEmptyBodyBase(element);
                    case "PipelineTopologySetRequestBody": return PipelineTopologySetRequestBody.DeserializePipelineTopologySetRequestBody(element);
                    case "RemoteDeviceAdapterSetRequestBody": return RemoteDeviceAdapterSetRequestBody.DeserializeRemoteDeviceAdapterSetRequestBody(element);
                    case "livePipelineActivate": return LivePipelineActivateRequest.DeserializeLivePipelineActivateRequest(element);
                    case "livePipelineDeactivate": return LivePipelineDeactivateRequest.DeserializeLivePipelineDeactivateRequest(element);
                    case "livePipelineDelete": return LivePipelineDeleteRequest.DeserializeLivePipelineDeleteRequest(element);
                    case "livePipelineGet": return LivePipelineGetRequest.DeserializeLivePipelineGetRequest(element);
                    case "livePipelineList": return LivePipelineListRequest.DeserializeLivePipelineListRequest(element);
                    case "livePipelineSet": return LivePipelineSetRequest.DeserializeLivePipelineSetRequest(element);
                    case "onvifDeviceDiscover": return OnvifDeviceDiscoverRequest.DeserializeOnvifDeviceDiscoverRequest(element);
                    case "onvifDeviceGet": return OnvifDeviceGetRequest.DeserializeOnvifDeviceGetRequest(element);
                    case "pipelineTopologyDelete": return PipelineTopologyDeleteRequest.DeserializePipelineTopologyDeleteRequest(element);
                    case "pipelineTopologyGet": return PipelineTopologyGetRequest.DeserializePipelineTopologyGetRequest(element);
                    case "pipelineTopologyList": return PipelineTopologyListRequest.DeserializePipelineTopologyListRequest(element);
                    case "pipelineTopologySet": return PipelineTopologySetRequest.DeserializePipelineTopologySetRequest(element);
                    case "remoteDeviceAdapterDelete": return RemoteDeviceAdapterDeleteRequest.DeserializeRemoteDeviceAdapterDeleteRequest(element);
                    case "remoteDeviceAdapterGet": return RemoteDeviceAdapterGetRequest.DeserializeRemoteDeviceAdapterGetRequest(element);
                    case "remoteDeviceAdapterList": return RemoteDeviceAdapterListRequest.DeserializeRemoteDeviceAdapterListRequest(element);
                    case "remoteDeviceAdapterSet": return RemoteDeviceAdapterSetRequest.DeserializeRemoteDeviceAdapterSetRequest(element);
                    case "LivePipelineSetRequestBody": return LivePipelineSetRequestBody.DeserializeLivePipelineSetRequestBody(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string methodName = default;
            Optional<string> apiVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownMethodRequest(methodName, apiVersion.Value, rawData);
        }

        MethodRequest IModelJsonSerializable<MethodRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMethodRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MethodRequest>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MethodRequest IModelSerializable<MethodRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMethodRequest(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MethodRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MethodRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMethodRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
