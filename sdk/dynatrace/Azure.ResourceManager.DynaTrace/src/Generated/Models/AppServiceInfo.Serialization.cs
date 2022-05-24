// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DynaTrace.Models
{
    public partial class AppServiceInfo
    {
        internal static AppServiceInfo DeserializeAppServiceInfo(JsonElement element)
        {
            Optional<string> resourceId = default;
            Optional<string> version = default;
            Optional<MonitoringType> monitoringType = default;
            Optional<AutoUpdateSetting> autoUpdateSetting = default;
            Optional<UpdateStatus> updateStatus = default;
            Optional<AvailabilityState> availabilityState = default;
            Optional<LogModule> logModule = default;
            Optional<string> hostGroup = default;
            Optional<string> hostName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitoringType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitoringType = new MonitoringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoUpdateSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoUpdateSetting = new AutoUpdateSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateStatus = new UpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availabilityState = new AvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logModule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logModule = new LogModule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroup"))
                {
                    hostGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceInfo(resourceId.Value, version.Value, Optional.ToNullable(monitoringType), Optional.ToNullable(autoUpdateSetting), Optional.ToNullable(updateStatus), Optional.ToNullable(availabilityState), Optional.ToNullable(logModule), hostGroup.Value, hostName.Value);
        }
    }
}
