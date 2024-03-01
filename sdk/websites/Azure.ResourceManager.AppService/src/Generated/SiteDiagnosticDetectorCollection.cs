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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteDiagnosticDetectorResource"/> and their operations.
    /// Each <see cref="SiteDiagnosticDetectorResource"/> in the collection will belong to the same instance of <see cref="SiteDiagnosticResource"/>.
    /// To get a <see cref="SiteDiagnosticDetectorCollection"/> instance call the GetSiteDiagnosticDetectors method from an instance of <see cref="SiteDiagnosticResource"/>.
    /// </summary>
    public partial class SiteDiagnosticDetectorCollection : ArmCollection, IEnumerable<SiteDiagnosticDetectorResource>, IAsyncEnumerable<SiteDiagnosticDetectorResource>
    {
        private readonly ClientDiagnostics _siteDiagnosticDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticDetectorCollection"/> class for mocking. </summary>
        protected SiteDiagnosticDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDiagnosticDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDiagnosticDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDiagnosticDetectorResource.ResourceType, out string siteDiagnosticDetectorDiagnosticsApiVersion);
            _siteDiagnosticDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDiagnosticDetectorDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteDiagnosticResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteDiagnosticResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<SiteDiagnosticDetectorResource>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteDiagnosticDetectorResource> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detectors
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDetectors</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnosticDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnosticDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteDiagnosticDetectorResource(Client, DetectorDefinitionResourceData.DeserializeDetectorDefinitionResourceData(e)), _siteDiagnosticDetectorDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Detectors
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteDetectors</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnosticDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnosticDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticDetectorDiagnosticsRestClient.CreateListSiteDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteDiagnosticDetectorResource(Client, DetectorDefinitionResourceData.DeserializeDetectorDefinitionResourceData(e)), _siteDiagnosticDetectorDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteDiagnosticDetectorResource>> GetIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteDiagnosticDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDiagnosticDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual NullableResponse<SiteDiagnosticDetectorResource> GetIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var scope = _siteDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDetectorDiagnosticsRestClient.GetSiteDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteDiagnosticDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDiagnosticDetectorResource> IEnumerable<SiteDiagnosticDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnosticDetectorResource> IAsyncEnumerable<SiteDiagnosticDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
