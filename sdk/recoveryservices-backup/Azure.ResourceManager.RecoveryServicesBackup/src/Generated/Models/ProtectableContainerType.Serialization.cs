// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal static partial class ProtectableContainerTypeExtensions
    {
        public static string ToSerialString(this ProtectableContainerType value) => value switch
        {
            ProtectableContainerType.Unknown => "Unknown",
            ProtectableContainerType.Invalid => "Invalid",
            ProtectableContainerType.IaasVmContainer => "IaasVMContainer",
            ProtectableContainerType.IaasVmServiceContainer => "IaasVMServiceContainer",
            ProtectableContainerType.DpmContainer => "DPMContainer",
            ProtectableContainerType.AzureBackupServerContainer => "AzureBackupServerContainer",
            ProtectableContainerType.MabContainer => "MABContainer",
            ProtectableContainerType.Cluster => "Cluster",
            ProtectableContainerType.AzureSqlContainer => "AzureSqlContainer",
            ProtectableContainerType.Windows => "Windows",
            ProtectableContainerType.VCenter => "VCenter",
            ProtectableContainerType.VmAppContainer => "VMAppContainer",
            ProtectableContainerType.SqlAvailabilityGroupWorkLoadContainer => "SQLAGWorkLoadContainer",
            ProtectableContainerType.StorageContainer => "StorageContainer",
            ProtectableContainerType.GenericContainer => "GenericContainer",
            ProtectableContainerType.MicrosoftClassicComputeVirtualMachines => "Microsoft.ClassicCompute/virtualMachines",
            ProtectableContainerType.MicrosoftComputeVirtualMachines => "Microsoft.Compute/virtualMachines",
            ProtectableContainerType.AzureWorkloadContainer => "AzureWorkloadContainer",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProtectableContainerType value.")
        };

        public static ProtectableContainerType ToProtectableContainerType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unknown")) return ProtectableContainerType.Unknown;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Invalid")) return ProtectableContainerType.Invalid;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IaasVMContainer")) return ProtectableContainerType.IaasVmContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IaasVMServiceContainer")) return ProtectableContainerType.IaasVmServiceContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DPMContainer")) return ProtectableContainerType.DpmContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AzureBackupServerContainer")) return ProtectableContainerType.AzureBackupServerContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MABContainer")) return ProtectableContainerType.MabContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Cluster")) return ProtectableContainerType.Cluster;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AzureSqlContainer")) return ProtectableContainerType.AzureSqlContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Windows")) return ProtectableContainerType.Windows;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "VCenter")) return ProtectableContainerType.VCenter;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "VMAppContainer")) return ProtectableContainerType.VmAppContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SQLAGWorkLoadContainer")) return ProtectableContainerType.SqlAvailabilityGroupWorkLoadContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "StorageContainer")) return ProtectableContainerType.StorageContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "GenericContainer")) return ProtectableContainerType.GenericContainer;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Microsoft.ClassicCompute/virtualMachines")) return ProtectableContainerType.MicrosoftClassicComputeVirtualMachines;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Microsoft.Compute/virtualMachines")) return ProtectableContainerType.MicrosoftComputeVirtualMachines;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AzureWorkloadContainer")) return ProtectableContainerType.AzureWorkloadContainer;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ProtectableContainerType value.");
        }
    }
}
