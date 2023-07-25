// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class Test : IUtf8JsonSerializable, IJsonModelSerializable
    {
        /// <summary>
        /// </summary>
        /// <param name="test"></param>
        public static implicit operator RequestContent(Test test)
        {
            return new Utf8JsonDelayedRequestContent(test);
        }

        /// <summary>
        /// </summary>
        /// <param name="response"></param>
        public static explicit operator Test(Response response)
        {
            MutableJsonDocument jsonDocument = MutableJsonDocument.Parse(response.Content);
            return new Test(jsonDocument.RootElement);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PassFailCriteria))
            {
                writer.WritePropertyName("passFailCriteria"u8);
                writer.WriteObjectValue(PassFailCriteria);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartObject();
                foreach (var item in Secrets)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LoadTestConfiguration))
            {
                writer.WritePropertyName("loadTestConfiguration"u8);
                writer.WriteObjectValue(LoadTestConfiguration);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(KeyvaultReferenceIdentityType))
            {
                writer.WritePropertyName("keyvaultReferenceIdentityType"u8);
                writer.WriteStringValue(KeyvaultReferenceIdentityType);
            }
            if (Optional.IsDefined(KeyvaultReferenceIdentityId))
            {
                writer.WritePropertyName("keyvaultReferenceIdentityId"u8);
                writer.WriteStringValue(KeyvaultReferenceIdentityId);
            }
            writer.WriteEndObject();
        }

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            // TODO: it would be nice to standardize on the type of Format.
            if (options.Format == "P")
            {
                _element.WriteTo(writer, 'P');
                return;
            }

            ((IUtf8JsonSerializable)this).Write(writer);
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            JsonDocument doc = JsonDocument.ParseValue(ref reader);
            MutableJsonDocument mdoc = new MutableJsonDocument(doc, new JsonSerializerOptions());
            return new Test(mdoc.RootElement);
        }

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            // TODO: Use options?

            MutableJsonDocument jsonDocument = MutableJsonDocument.Parse(data);
            return new Test(jsonDocument.RootElement);
        }

        BinaryData IModelSerializable.Serialize(ModelSerializerOptions options) => ModelSerializerHelper.SerializeToBinaryData(writer => ((IJsonModelSerializable)this).Serialize(writer, options));
    }
}
