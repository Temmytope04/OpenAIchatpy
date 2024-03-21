// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabVmScheduleResource"/> and their operations.
    /// Each <see cref="DevTestLabVmScheduleResource"/> in the collection will belong to the same instance of <see cref="DevTestLabVmResource"/>.
    /// To get a <see cref="DevTestLabVmScheduleCollection"/> instance call the GetDevTestLabVmSchedules method from an instance of <see cref="DevTestLabVmResource"/>.
    /// </summary>
    public partial class DevTestLabVmScheduleCollection : ArmCollection, IEnumerable<DevTestLabVmScheduleResource>, IAsyncEnumerable<DevTestLabVmScheduleResource>
    {
        private readonly ClientDiagnostics _devTestLabVmScheduleVmSchedulesClientDiagnostics;
        private readonly VirtualMachineSchedulesRestOperations _devTestLabVmScheduleVmSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabVmScheduleCollection"/> class for mocking. </summary>
        protected DevTestLabVmScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabVmScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevTestLabVmScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devTestLabVmScheduleVmSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabVmScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabVmScheduleResource.ResourceType, out string devTestLabVmScheduleVmSchedulesApiVersion);
            _devTestLabVmScheduleVmSchedulesRestClient = new VirtualMachineSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabVmScheduleVmSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabVmResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabVmResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabVmScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabVmScheduleVmSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabVmScheduleResource>(Response.FromValue(new DevTestLabVmScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="data"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabVmScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabVmScheduleVmSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabVmScheduleResource>(Response.FromValue(new DevTestLabVmScheduleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabVmScheduleResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabVmScheduleVmSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabVmScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabVmScheduleResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabVmScheduleVmSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabVmScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List schedules in a given virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabVmScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabVmScheduleResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabVmScheduleVmSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabVmScheduleVmSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabVmScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabVmScheduleVmSchedulesClientDiagnostics, Pipeline, "DevTestLabVmScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in a given virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabVmScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabVmScheduleResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabVmScheduleVmSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabVmScheduleVmSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabVmScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), _devTestLabVmScheduleVmSchedulesClientDiagnostics, Pipeline, "DevTestLabVmScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabVmScheduleVmSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabVmScheduleVmSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabVmScheduleResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabVmScheduleVmSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabVmScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabVmScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevTestLabVmScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the schedule. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabVmScheduleResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabVmScheduleVmSchedulesClientDiagnostics.CreateScope("DevTestLabVmScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabVmScheduleVmSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabVmScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabVmScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabVmScheduleResource> IEnumerable<DevTestLabVmScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabVmScheduleResource> IAsyncEnumerable<DevTestLabVmScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
