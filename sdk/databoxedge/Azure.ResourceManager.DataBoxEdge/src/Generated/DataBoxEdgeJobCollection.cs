// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeJobResource"/> and their operations.
    /// Each <see cref="DataBoxEdgeJobResource"/> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource"/>.
    /// To get a <see cref="DataBoxEdgeJobCollection"/> instance call the GetDataBoxEdgeJobs method from an instance of <see cref="DataBoxEdgeDeviceResource"/>.
    /// </summary>
    public partial class DataBoxEdgeJobCollection : ArmCollection
    {
        private readonly ClientDiagnostics _dataBoxEdgeJobJobsClientDiagnostics;
        private readonly JobsRestOperations _dataBoxEdgeJobJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeJobCollection"/> class for mocking. </summary>
        protected DataBoxEdgeJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeJobJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeJobResource.ResourceType, out string dataBoxEdgeJobJobsApiVersion);
            _dataBoxEdgeJobJobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeJobJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of a specified job on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeJobResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a specified job on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DataBoxEdgeJobResource> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DataBoxEdgeJobResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeJobJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxEdgeJobResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/jobs/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The job name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DataBoxEdgeJobResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _dataBoxEdgeJobJobsClientDiagnostics.CreateScope("DataBoxEdgeJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeJobJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxEdgeJobResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
