// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing a collection of <see cref="IotFhirDestinationResource" /> and their operations.
    /// Each <see cref="IotFhirDestinationResource" /> in the collection will belong to the same instance of <see cref="IotConnectorResource" />.
    /// To get an <see cref="IotFhirDestinationCollection" /> instance call the GetIotFhirDestinations method from an instance of <see cref="IotConnectorResource" />.
    /// </summary>
    public partial class IotFhirDestinationCollection : ArmCollection, IEnumerable<IotFhirDestinationResource>, IAsyncEnumerable<IotFhirDestinationResource>
    {
        private readonly ClientDiagnostics _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics;
        private readonly IotConnectorFhirDestinationRestOperations _iotFhirDestinationIotConnectorFhirDestinationRestClient;
        private readonly ClientDiagnostics _iotFhirDestinationFhirDestinationsClientDiagnostics;
        private readonly FhirDestinationsRestOperations _iotFhirDestinationFhirDestinationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotFhirDestinationCollection"/> class for mocking. </summary>
        protected IotFhirDestinationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotFhirDestinationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotFhirDestinationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", IotFhirDestinationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotFhirDestinationResource.ResourceType, out string iotFhirDestinationIotConnectorFhirDestinationApiVersion);
            _iotFhirDestinationIotConnectorFhirDestinationRestClient = new IotConnectorFhirDestinationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotFhirDestinationIotConnectorFhirDestinationApiVersion);
            _iotFhirDestinationFhirDestinationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", IotFhirDestinationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotFhirDestinationResource.ResourceType, out string iotFhirDestinationFhirDestinationsApiVersion);
            _iotFhirDestinationFhirDestinationsRestClient = new FhirDestinationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotFhirDestinationFhirDestinationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotConnectorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotConnectorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotFhirDestinationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fhirDestinationName, IotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<IotFhirDestinationResource>(new IotFhirDestinationOperationSource(Client), _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotFhirDestinationResource> CreateOrUpdate(WaitUntil waitUntil, string fhirDestinationName, IotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<IotFhirDestinationResource>(new IotFhirDestinationOperationSource(Client), _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _iotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        public virtual async Task<Response<IotFhirDestinationResource>> GetAsync(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        public virtual Response<IotFhirDestinationResource> Get(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.Get");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all FHIR destinations for the given IoT Connector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations
        /// Operation Id: FhirDestinations_ListByIotConnector
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotFhirDestinationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotFhirDestinationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IotFhirDestinationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _iotFhirDestinationFhirDestinationsClientDiagnostics.CreateScope("IotFhirDestinationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _iotFhirDestinationFhirDestinationsRestClient.ListByIotConnectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IotFhirDestinationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IotFhirDestinationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _iotFhirDestinationFhirDestinationsClientDiagnostics.CreateScope("IotFhirDestinationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _iotFhirDestinationFhirDestinationsRestClient.ListByIotConnectorNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IotFhirDestinationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all FHIR destinations for the given IoT Connector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations
        /// Operation Id: FhirDestinations_ListByIotConnector
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotFhirDestinationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotFhirDestinationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IotFhirDestinationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _iotFhirDestinationFhirDestinationsClientDiagnostics.CreateScope("IotFhirDestinationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _iotFhirDestinationFhirDestinationsRestClient.ListByIotConnector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IotFhirDestinationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IotFhirDestinationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _iotFhirDestinationFhirDestinationsClientDiagnostics.CreateScope("IotFhirDestinationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _iotFhirDestinationFhirDestinationsRestClient.ListByIotConnectorNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IotFhirDestinationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotFhirDestinationIotConnectorFhirDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        public virtual Response<bool> Exists(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fhirDestinationName, nameof(fhirDestinationName));

            using var scope = _iotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("IotFhirDestinationCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotFhirDestinationIotConnectorFhirDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, fhirDestinationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotFhirDestinationResource> IEnumerable<IotFhirDestinationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotFhirDestinationResource> IAsyncEnumerable<IotFhirDestinationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
