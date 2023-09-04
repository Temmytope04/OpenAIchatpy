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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeDeviceResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeDeviceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DataBoxEdgeDeviceCollection" /> instance call the GetDataBoxEdgeDevices method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DataBoxEdgeDeviceCollection : ArmCollection, IEnumerable<DataBoxEdgeDeviceResource>, IAsyncEnumerable<DataBoxEdgeDeviceResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeDeviceDevicesClientDiagnostics;
        private readonly DevicesRestOperations _dataBoxEdgeDeviceDevicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeDeviceCollection"/> class for mocking. </summary>
        protected DataBoxEdgeDeviceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeDeviceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeDeviceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeDeviceDevicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeDeviceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeDeviceResource.ResourceType, out string dataBoxEdgeDeviceDevicesApiVersion);
            _dataBoxEdgeDeviceDevicesRestClient = new DevicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeDeviceDevicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Data Box Edge/Data Box Gateway resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="data"> The resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeDeviceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deviceName, DataBoxEdgeDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeDeviceDevicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, deviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeDeviceResource>(Response.FromValue(new DataBoxEdgeDeviceResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Data Box Edge/Data Box Gateway resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="data"> The resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeDeviceResource> CreateOrUpdate(WaitUntil waitUntil, string deviceName, DataBoxEdgeDeviceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeDeviceDevicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, deviceName, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeDeviceResource>(Response.FromValue(new DataBoxEdgeDeviceResource(Client, response), response.GetRawResponse()));
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
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeDeviceResource>> GetAsync(string deviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeDeviceDevicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, deviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        public virtual Response<DataBoxEdgeDeviceResource> Get(string deviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeDeviceDevicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, deviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeDeviceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeDeviceResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeDeviceDevicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeDeviceDevicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeDeviceResource(Client, DataBoxEdgeDeviceData.DeserializeDataBoxEdgeDeviceData(e)), _dataBoxEdgeDeviceDevicesClientDiagnostics, Pipeline, "DataBoxEdgeDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeDeviceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeDeviceResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeDeviceDevicesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeDeviceDevicesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeDeviceResource(Client, DataBoxEdgeDeviceData.DeserializeDataBoxEdgeDeviceData(e)), _dataBoxEdgeDeviceDevicesClientDiagnostics, Pipeline, "DataBoxEdgeDeviceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeDeviceDevicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, deviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deviceName"> The device name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string deviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deviceName, nameof(deviceName));

            using var scope = _dataBoxEdgeDeviceDevicesClientDiagnostics.CreateScope("DataBoxEdgeDeviceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeDeviceDevicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, deviceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeDeviceResource> IEnumerable<DataBoxEdgeDeviceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeDeviceResource> IAsyncEnumerable<DataBoxEdgeDeviceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
