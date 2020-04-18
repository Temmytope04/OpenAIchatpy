// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class SynonymMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("format");
            writer.WriteStringValue(Format);
            writer.WritePropertyName("synonyms");
            writer.WriteStringValue(Synonyms);
            if (EncryptionKey != null)
            {
                writer.WritePropertyName("encryptionKey");
                writer.WriteObjectValue(EncryptionKey);
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SynonymMap DeserializeSynonymMap(JsonElement element)
        {
            string name = default;
            string format = default;
            string synonyms = default;
            EncryptionKey encryptionKey = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synonyms"))
                {
                    synonyms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionKey = EncryptionKey.DeserializeEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SynonymMap(name, format, synonyms, encryptionKey, odataEtag);
        }
    }
}
