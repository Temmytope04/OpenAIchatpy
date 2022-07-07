// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class AzureFileShareConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accountName");
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("azureFileUrl");
            writer.WriteStringValue(AzureFileUri.AbsoluteUri);
            writer.WritePropertyName("accountKey");
            writer.WriteStringValue(AccountKey);
            writer.WritePropertyName("relativeMountPath");
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions");
                writer.WriteStringValue(MountOptions);
            }
            writer.WriteEndObject();
        }

        internal static AzureFileShareConfiguration DeserializeAzureFileShareConfiguration(JsonElement element)
        {
            string accountName = default;
            Uri azureFileUrl = default;
            string accountKey = default;
            string relativeMountPath = default;
            Optional<string> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileUrl"))
                {
                    azureFileUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFileShareConfiguration(accountName, azureFileUrl, accountKey, relativeMountPath, mountOptions.Value);
        }
    }
}
