// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class VirtualApplicationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath");
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(MsixPackageFamilyName))
            {
                if (MsixPackageFamilyName != null)
                {
                    writer.WritePropertyName("msixPackageFamilyName");
                    writer.WriteStringValue(MsixPackageFamilyName);
                }
                else
                {
                    writer.WriteNull("msixPackageFamilyName");
                }
            }
            if (Optional.IsDefined(MsixPackageApplicationId))
            {
                if (MsixPackageApplicationId != null)
                {
                    writer.WritePropertyName("msixPackageApplicationId");
                    writer.WriteStringValue(MsixPackageApplicationId);
                }
                else
                {
                    writer.WriteNull("msixPackageApplicationId");
                }
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType");
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            writer.WritePropertyName("commandLineSetting");
            writer.WriteStringValue(CommandLineSetting.ToString());
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments");
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(ShowInPortal))
            {
                writer.WritePropertyName("showInPortal");
                writer.WriteBooleanValue(ShowInPortal.Value);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath");
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex");
                writer.WriteNumberValue(IconIndex.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualApplicationData DeserializeVirtualApplicationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> objectId = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            Optional<string> filePath = default;
            Optional<string> msixPackageFamilyName = default;
            Optional<string> msixPackageApplicationId = default;
            Optional<RemoteApplicationType> applicationType = default;
            CommandLineSetting commandLineSetting = default;
            Optional<string> commandLineArguments = default;
            Optional<bool> showInPortal = default;
            Optional<string> iconPath = default;
            Optional<int> iconIndex = default;
            Optional<string> iconHash = default;
            Optional<byte[]> iconContent = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("objectId"))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filePath"))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("msixPackageFamilyName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                msixPackageFamilyName = null;
                                continue;
                            }
                            msixPackageFamilyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("msixPackageApplicationId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                msixPackageApplicationId = null;
                                continue;
                            }
                            msixPackageApplicationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            applicationType = new RemoteApplicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("commandLineSetting"))
                        {
                            commandLineSetting = new CommandLineSetting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("commandLineArguments"))
                        {
                            commandLineArguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("showInPortal"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            showInPortal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconPath"))
                        {
                            iconPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconIndex"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            iconIndex = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("iconHash"))
                        {
                            iconHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconContent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            iconContent = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualApplicationData(id, name, type, systemData, objectId.Value, description.Value, friendlyName.Value, filePath.Value, msixPackageFamilyName.Value, msixPackageApplicationId.Value, Optional.ToNullable(applicationType), commandLineSetting, commandLineArguments.Value, Optional.ToNullable(showInPortal), iconPath.Value, Optional.ToNullable(iconIndex), iconHash.Value, iconContent.Value);
        }
    }
}
