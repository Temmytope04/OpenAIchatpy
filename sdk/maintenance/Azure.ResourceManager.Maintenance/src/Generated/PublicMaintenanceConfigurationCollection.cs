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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance
{
    /// <summary>
    /// A class representing a collection of <see cref="PublicMaintenanceConfigurationResource" /> and their operations.
    /// Each <see cref="PublicMaintenanceConfigurationResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="PublicMaintenanceConfigurationCollection" /> instance call the GetPublicMaintenanceConfigurations method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class PublicMaintenanceConfigurationCollection : ArmCollection, IEnumerable<PublicMaintenanceConfigurationResource>, IAsyncEnumerable<PublicMaintenanceConfigurationResource>
    {
        private readonly ClientDiagnostics _publicMaintenanceConfigurationClientDiagnostics;
        private readonly PublicMaintenanceConfigurationsRestOperations _publicMaintenanceConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublicMaintenanceConfigurationCollection"/> class for mocking. </summary>
        protected PublicMaintenanceConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublicMaintenanceConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublicMaintenanceConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publicMaintenanceConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maintenance", PublicMaintenanceConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublicMaintenanceConfigurationResource.ResourceType, out string publicMaintenanceConfigurationApiVersion);
            _publicMaintenanceConfigurationRestClient = new PublicMaintenanceConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publicMaintenanceConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Public Maintenance Configuration record
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}
        /// Operation Id: PublicMaintenanceConfigurations_Get
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<PublicMaintenanceConfigurationResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _publicMaintenanceConfigurationRestClient.GetAsync(Id.SubscriptionId, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicMaintenanceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Public Maintenance Configuration record
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}
        /// Operation Id: PublicMaintenanceConfigurations_Get
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<PublicMaintenanceConfigurationResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _publicMaintenanceConfigurationRestClient.Get(Id.SubscriptionId, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicMaintenanceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Public Maintenance Configuration records
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations
        /// Operation Id: PublicMaintenanceConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicMaintenanceConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublicMaintenanceConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PublicMaintenanceConfigurationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _publicMaintenanceConfigurationRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicMaintenanceConfigurationResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get Public Maintenance Configuration records
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations
        /// Operation Id: PublicMaintenanceConfigurations_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicMaintenanceConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublicMaintenanceConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PublicMaintenanceConfigurationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _publicMaintenanceConfigurationRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicMaintenanceConfigurationResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}
        /// Operation Id: PublicMaintenanceConfigurations_Get
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publicMaintenanceConfigurationRestClient.GetAsync(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/{resourceName}
        /// Operation Id: PublicMaintenanceConfigurations_Get
        /// </summary>
        /// <param name="resourceName"> Maintenance Configuration Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _publicMaintenanceConfigurationClientDiagnostics.CreateScope("PublicMaintenanceConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _publicMaintenanceConfigurationRestClient.Get(Id.SubscriptionId, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublicMaintenanceConfigurationResource> IEnumerable<PublicMaintenanceConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublicMaintenanceConfigurationResource> IAsyncEnumerable<PublicMaintenanceConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
