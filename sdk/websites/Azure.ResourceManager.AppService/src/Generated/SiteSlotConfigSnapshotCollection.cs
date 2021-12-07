// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteConfigAutoGenerated and their operations over its parent. </summary>
    public partial class SiteSlotConfigSnapshotCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigSnapshotCollection"/> class for mocking. </summary>
        protected SiteSlotConfigSnapshotCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotConfigSnapshotCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotConfigSnapshotCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Web/sites/slots/config";

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// OperationId: WebApps_GetConfigurationSnapshotSlot
        /// <summary> Description for Gets a snapshot of the configuration of an app at a previous point in time. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<SiteSlotConfigSnapshot> Get(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetConfigurationSnapshotSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigSnapshot(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web
        /// OperationId: WebApps_GetConfigurationSnapshotSlot
        /// <summary> Description for Gets a snapshot of the configuration of an app at a previous point in time. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigSnapshot>> GetAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetConfigurationSnapshotSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotConfigSnapshot(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<SiteSlotConfigSnapshot> GetIfExists(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetConfigurationSnapshotSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotConfigSnapshot>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotConfigSnapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigSnapshot>> GetIfExistsAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetConfigurationSnapshotSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotConfigSnapshot>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotConfigSnapshot(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(snapshotId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            if (snapshotId == null)
            {
                throw new ArgumentNullException(nameof(snapshotId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(snapshotId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotConfigSnapshot, SiteConfigAutoGeneratedData> Construct() { }
    }
}
