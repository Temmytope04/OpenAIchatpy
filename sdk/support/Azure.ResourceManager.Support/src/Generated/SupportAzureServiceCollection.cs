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

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="SupportAzureServiceResource" /> and their operations.
    /// Each <see cref="SupportAzureServiceResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="SupportAzureServiceCollection" /> instance call the GetSupportAzureServices method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class SupportAzureServiceCollection : ArmCollection, IEnumerable<SupportAzureServiceResource>, IAsyncEnumerable<SupportAzureServiceResource>
    {
        private readonly ClientDiagnostics _supportAzureServiceServicesClientDiagnostics;
        private readonly ServicesRestOperations _supportAzureServiceServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupportAzureServiceCollection"/> class for mocking. </summary>
        protected SupportAzureServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportAzureServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupportAzureServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportAzureServiceServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportAzureServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportAzureServiceResource.ResourceType, out string supportAzureServiceServicesApiVersion);
            _supportAzureServiceServicesRestClient = new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportAzureServiceServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<SupportAzureServiceResource>> GetAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _supportAzureServiceServicesRestClient.GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportAzureServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<SupportAzureServiceResource> Get(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _supportAzureServiceServicesRestClient.Get(serviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportAzureServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the Azure services available for support ticket creation. For **Technical** issues, select the Service Id that maps to the Azure service/product as displayed in the **Services** drop-down list on the Azure portal&apos;s [New support request](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/overview) page. Always use the service and its corresponding problem classification(s) obtained programmatically for support ticket creation. This practice ensures that you always have the most recent set of service and problem classification Ids.
        /// Request Path: /providers/Microsoft.Support/services
        /// Operation Id: Services_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportAzureServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupportAzureServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SupportAzureServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportAzureServiceServicesRestClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportAzureServiceResource(Client, value)), null, response.GetRawResponse());
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
        /// Lists all the Azure services available for support ticket creation. For **Technical** issues, select the Service Id that maps to the Azure service/product as displayed in the **Services** drop-down list on the Azure portal&apos;s [New support request](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/overview) page. Always use the service and its corresponding problem classification(s) obtained programmatically for support ticket creation. This practice ensures that you always have the most recent set of service and problem classification Ids.
        /// Request Path: /providers/Microsoft.Support/services
        /// Operation Id: Services_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportAzureServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupportAzureServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SupportAzureServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportAzureServiceServicesRestClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportAzureServiceResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _supportAzureServiceServicesRestClient.GetAsync(serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Support/services/{serviceName}
        /// Operation Id: Services_Get
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _supportAzureServiceServicesRestClient.Get(serviceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupportAzureServiceResource> IEnumerable<SupportAzureServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupportAzureServiceResource> IAsyncEnumerable<SupportAzureServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
