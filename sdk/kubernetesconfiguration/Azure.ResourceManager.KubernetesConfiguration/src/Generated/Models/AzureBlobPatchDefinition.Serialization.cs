// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class AzureBlobPatchDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url");
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(ContainerName))
            {
                if (ContainerName != null)
                {
                    writer.WritePropertyName("containerName");
                    writer.WriteStringValue(ContainerName);
                }
                else
                {
                    writer.WriteNull("containerName");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds");
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds");
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                if (ServicePrincipal != null)
                {
                    writer.WritePropertyName("servicePrincipal");
                    writer.WriteObjectValue(ServicePrincipal);
                }
                else
                {
                    writer.WriteNull("servicePrincipal");
                }
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey");
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken");
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                if (ManagedIdentity != null)
                {
                    writer.WritePropertyName("managedIdentity");
                    writer.WriteObjectValue(ManagedIdentity);
                }
                else
                {
                    writer.WriteNull("managedIdentity");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef");
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
            }
            writer.WriteEndObject();
        }
    }
}
