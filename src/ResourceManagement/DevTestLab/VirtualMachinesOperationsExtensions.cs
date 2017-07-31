// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachinesOperations.
    /// </summary>
    public static partial class VirtualMachinesOperationsExtensions
    {
            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LabVirtualMachineInner>> ListAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, ODataQuery<LabVirtualMachineInner> odataQuery = default(ODataQuery<LabVirtualMachineInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($expand=artifacts,computeVm,networkInterface,applicableSchedule)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachineInner> GetAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Virtual machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// A virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachineInner> CreateOrUpdateAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachineInner labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Modify properties of virtual machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// A virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachineInner> UpdateAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachineFragmentInner labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attach a new or existing data disk to virtual machine. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='dataDiskProperties'>
            /// Request body for adding a new or existing data disk to a virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddDataDiskAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, DataDiskPropertiesInner dataDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddDataDiskWithHttpMessagesAsync(resourceGroupName, labName, name, dataDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Apply artifacts to virtual machine. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='artifacts'>
            /// The list of artifacts to apply.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApplyArtifactsAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, IList<ArtifactInstallPropertiesInner> artifacts = default(IList<ArtifactInstallPropertiesInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApplyArtifactsWithHttpMessagesAsync(resourceGroupName, labName, name, artifacts, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Take ownership of an existing virtual machine This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ClaimAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ClaimWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Detach the specified disk from the virtual machine. This operation can take
            /// a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='existingLabDiskId'>
            /// Specifies the disk resource ID to detach from virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DetachDataDiskAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, string existingLabDiskId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DetachDataDiskWithHttpMessagesAsync(resourceGroupName, labName, name, existingLabDiskId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all applicable schedules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicableScheduleInner> ListApplicableSchedulesAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListApplicableSchedulesWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Start a virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stop a virtual machine This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or replace an existing Virtual machine. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='labVirtualMachine'>
            /// A virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LabVirtualMachineInner> BeginCreateOrUpdateAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, LabVirtualMachineInner labVirtualMachine, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, name, labVirtualMachine, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Attach a new or existing data disk to virtual machine. This operation can
            /// take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='dataDiskProperties'>
            /// Request body for adding a new or existing data disk to a virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginAddDataDiskAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, DataDiskPropertiesInner dataDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginAddDataDiskWithHttpMessagesAsync(resourceGroupName, labName, name, dataDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Apply artifacts to virtual machine. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='artifacts'>
            /// The list of artifacts to apply.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginApplyArtifactsAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, IList<ArtifactInstallPropertiesInner> artifacts = default(IList<ArtifactInstallPropertiesInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginApplyArtifactsWithHttpMessagesAsync(resourceGroupName, labName, name, artifacts, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Take ownership of an existing virtual machine This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginClaimAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginClaimWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Detach the specified disk from the virtual machine. This operation can take
            /// a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='existingLabDiskId'>
            /// Specifies the disk resource ID to detach from virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDetachDataDiskAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, string existingLabDiskId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDetachDataDiskWithHttpMessagesAsync(resourceGroupName, labName, name, existingLabDiskId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Start a virtual machine. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stop a virtual machine This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List virtual machines in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LabVirtualMachineInner>> ListNextAsync(this IVirtualMachinesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
