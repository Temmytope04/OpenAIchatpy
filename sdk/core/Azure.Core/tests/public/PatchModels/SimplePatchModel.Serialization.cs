﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.PatchModels
{
    public partial class SimplePatchModel : IModelJsonSerializable<SimplePatchModel>, IUtf8JsonSerializable
    {
        private static SimplePatchModel Deserialize(JsonElement element)
        {
            string name = default;
            int count = default;
            DateTimeOffset updatedOn = default;

            foreach (JsonProperty property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }

                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }

                if (property.NameEquals("updatedOn"))
                {
                    updatedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }

            return new SimplePatchModel(name, count, updatedOn);
        }

        SimplePatchModel IModelJsonSerializable<SimplePatchModel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            PatchModelHelper.ValidateFormat(this, options.Format);
            return Deserialize(ref reader, options);
        }

        private static SimplePatchModel Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            JsonElement element = JsonDocument.ParseValue(ref reader).RootElement;
            return Deserialize(element);
        }

        SimplePatchModel IModelSerializable<SimplePatchModel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            PatchModelHelper.ValidateFormat(this, options.Format);
            return Deserialize(data, options);
        }

        private static SimplePatchModel Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            JsonElement element = JsonDocument.Parse(data).RootElement;
            return Deserialize(element);
        }

        private void SerializeFull(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);

            writer.WritePropertyName("count");
            writer.WriteNumberValue(Count);

            writer.WritePropertyName("updatedOn");
            writer.WriteStringValue(UpdatedOn, "O");

            writer.WriteEndObject();
        }

        private void SerializePatch(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();

            if (Changed(NameProperty))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }

            if (Changed(CountProperty))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count);
            }

            if (Changed(UpdatedOnProperty))
            {
                writer.WritePropertyName("updatedOn");
                writer.WriteStringValue(UpdatedOn, "O");
            }

            writer.WriteEndObject();
        }

        void IModelJsonSerializable<SimplePatchModel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            PatchModelHelper.ValidateFormat(this, options.Format);

            switch (options.Format.ToString())
            {
                case "J":
                case "W":
                    SerializeFull(writer);
                    break;
                case "P":
                    SerializePatch(writer);
                    break;
                default:
                    // Exception was thrown by ValidateFormat.
                    break;
            }
        }

        BinaryData IModelSerializable<SimplePatchModel>.Serialize(ModelSerializerOptions options)
        {
            PatchModelHelper.ValidateFormat(this, options.Format);
            return ModelSerializer.SerializeCore(this, options);
        }

        public static implicit operator RequestContent(SimplePatchModel model)
            => RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);

        public static explicit operator SimplePatchModel(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));
            return Deserialize(response.Content, ModelSerializerOptions.DefaultWireOptions);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SimplePatchModel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);
    }
}
