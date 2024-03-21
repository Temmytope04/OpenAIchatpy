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
using Azure.ResourceManager.IotFirmwareDefense.Models;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing a collection of <see cref="FirmwareAnalysisSummaryResource"/> and their operations.
    /// Each <see cref="FirmwareAnalysisSummaryResource"/> in the collection will belong to the same instance of <see cref="IotFirmwareResource"/>.
    /// To get a <see cref="FirmwareAnalysisSummaryCollection"/> instance call the GetFirmwareAnalysisSummaries method from an instance of <see cref="IotFirmwareResource"/>.
    /// </summary>
    public partial class FirmwareAnalysisSummaryCollection : ArmCollection, IEnumerable<FirmwareAnalysisSummaryResource>, IAsyncEnumerable<FirmwareAnalysisSummaryResource>
    {
        private readonly ClientDiagnostics _firmwareAnalysisSummarySummariesClientDiagnostics;
        private readonly SummariesRestOperations _firmwareAnalysisSummarySummariesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirmwareAnalysisSummaryCollection"/> class for mocking. </summary>
        protected FirmwareAnalysisSummaryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FirmwareAnalysisSummaryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FirmwareAnalysisSummaryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _firmwareAnalysisSummarySummariesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotFirmwareDefense", FirmwareAnalysisSummaryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FirmwareAnalysisSummaryResource.ResourceType, out string firmwareAnalysisSummarySummariesApiVersion);
            _firmwareAnalysisSummarySummariesRestClient = new SummariesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, firmwareAnalysisSummarySummariesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotFirmwareResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotFirmwareResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an analysis result summary of a firmware by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirmwareAnalysisSummaryResource>> GetAsync(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = await _firmwareAnalysisSummarySummariesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareAnalysisSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an analysis result summary of a firmware by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirmwareAnalysisSummaryResource> Get(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = _firmwareAnalysisSummarySummariesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareAnalysisSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists analysis result summary names of a firmware. To fetch the full summary data, get that summary by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_ListByFirmware</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirmwareAnalysisSummaryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirmwareAnalysisSummaryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareAnalysisSummarySummariesRestClient.CreateListByFirmwareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareAnalysisSummarySummariesRestClient.CreateListByFirmwareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FirmwareAnalysisSummaryResource(Client, FirmwareAnalysisSummaryData.DeserializeFirmwareAnalysisSummaryData(e)), _firmwareAnalysisSummarySummariesClientDiagnostics, Pipeline, "FirmwareAnalysisSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists analysis result summary names of a firmware. To fetch the full summary data, get that summary by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_ListByFirmware</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirmwareAnalysisSummaryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirmwareAnalysisSummaryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareAnalysisSummarySummariesRestClient.CreateListByFirmwareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareAnalysisSummarySummariesRestClient.CreateListByFirmwareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FirmwareAnalysisSummaryResource(Client, FirmwareAnalysisSummaryData.DeserializeFirmwareAnalysisSummaryData(e)), _firmwareAnalysisSummarySummariesClientDiagnostics, Pipeline, "FirmwareAnalysisSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _firmwareAnalysisSummarySummariesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = _firmwareAnalysisSummarySummariesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<FirmwareAnalysisSummaryResource>> GetIfExistsAsync(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _firmwareAnalysisSummarySummariesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FirmwareAnalysisSummaryResource>(response.GetRawResponse());
                return Response.FromValue(new FirmwareAnalysisSummaryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}/summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FirmwareAnalysisSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The Firmware analysis summary name describing the type of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<FirmwareAnalysisSummaryResource> GetIfExists(FirmwareAnalysisSummaryName summaryName, CancellationToken cancellationToken = default)
        {
            using var scope = _firmwareAnalysisSummarySummariesClientDiagnostics.CreateScope("FirmwareAnalysisSummaryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _firmwareAnalysisSummarySummariesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, summaryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FirmwareAnalysisSummaryResource>(response.GetRawResponse());
                return Response.FromValue(new FirmwareAnalysisSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FirmwareAnalysisSummaryResource> IEnumerable<FirmwareAnalysisSummaryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirmwareAnalysisSummaryResource> IAsyncEnumerable<FirmwareAnalysisSummaryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
