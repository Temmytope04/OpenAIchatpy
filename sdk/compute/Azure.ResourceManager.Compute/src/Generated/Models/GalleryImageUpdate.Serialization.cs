// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Eula != null)
            {
                writer.WritePropertyName("eula");
                writer.WriteStringValue(Eula);
            }
            if (PrivacyStatementUri != null)
            {
                writer.WritePropertyName("privacyStatementUri");
                writer.WriteStringValue(PrivacyStatementUri);
            }
            if (ReleaseNoteUri != null)
            {
                writer.WritePropertyName("releaseNoteUri");
                writer.WriteStringValue(ReleaseNoteUri);
            }
            if (OsType != null)
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToSerialString());
            }
            if (OsState != null)
            {
                writer.WritePropertyName("osState");
                writer.WriteStringValue(OsState.Value.ToSerialString());
            }
            if (HyperVGeneration != null)
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (EndOfLifeDate != null)
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (Identifier != null)
            {
                writer.WritePropertyName("identifier");
                writer.WriteObjectValue(Identifier);
            }
            if (Recommended != null)
            {
                writer.WritePropertyName("recommended");
                writer.WriteObjectValue(Recommended);
            }
            if (Disallowed != null)
            {
                writer.WritePropertyName("disallowed");
                writer.WriteObjectValue(Disallowed);
            }
            if (PurchasePlan != null)
            {
                writer.WritePropertyName("purchasePlan");
                writer.WriteObjectValue(PurchasePlan);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
