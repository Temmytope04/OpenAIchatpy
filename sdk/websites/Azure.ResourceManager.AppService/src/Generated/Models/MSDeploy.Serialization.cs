// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class MsDeploy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("packageUri");
                writer.WriteStringValue(PackageUri);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(DbType))
            {
                writer.WritePropertyName("dbType");
                writer.WriteStringValue(DbType);
            }
            if (Optional.IsDefined(SetParametersXmlFileUri))
            {
                writer.WritePropertyName("setParametersXmlFileUri");
                writer.WriteStringValue(SetParametersXmlFileUri);
            }
            if (Optional.IsCollectionDefined(SetParameters))
            {
                writer.WritePropertyName("setParameters");
                writer.WriteStartObject();
                foreach (var item in SetParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SkipAppData))
            {
                writer.WritePropertyName("skipAppData");
                writer.WriteBooleanValue(SkipAppData.Value);
            }
            if (Optional.IsDefined(AppOffline))
            {
                writer.WritePropertyName("appOffline");
                writer.WriteBooleanValue(AppOffline.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MsDeploy DeserializeMsDeploy(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> packageUri = default;
            Optional<string> connectionString = default;
            Optional<string> dbType = default;
            Optional<string> setParametersXmlFileUri = default;
            Optional<IDictionary<string, string>> setParameters = default;
            Optional<bool> skipAppData = default;
            Optional<bool> appOffline = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageUri"))
                        {
                            packageUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionString"))
                        {
                            connectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dbType"))
                        {
                            dbType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("setParametersXmlFileUri"))
                        {
                            setParametersXmlFileUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("setParameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            setParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("skipAppData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            skipAppData = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appOffline"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            appOffline = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MsDeploy(id, name, type, kind.Value, packageUri.Value, connectionString.Value, dbType.Value, setParametersXmlFileUri.Value, Optional.ToDictionary(setParameters), Optional.ToNullable(skipAppData), Optional.ToNullable(appOffline));
        }
    }
}
