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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a DeletedSite along with the instance operations that can be performed on it. </summary>
    public partial class DeletedSite : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeletedSite"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string deletedSiteId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deletedSiteGlobalClientDiagnostics;
        private readonly GlobalRestOperations _deletedSiteGlobalRestClient;
        private readonly DeletedSiteData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedSite"/> class for mocking. </summary>
        protected DeletedSite()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedSite"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeletedSite(ArmClient client, DeletedSiteData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedSite"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedSite(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedSiteGlobalClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string deletedSiteGlobalApiVersion);
            _deletedSiteGlobalRestClient = new GlobalRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deletedSiteGlobalApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/deletedSites";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedSiteData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get deleted app for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// Operation Id: Global_GetDeletedWebApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedSite>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedSiteGlobalClientDiagnostics.CreateScope("DeletedSite.Get");
            scope.Start();
            try
            {
                var response = await _deletedSiteGlobalRestClient.GetDeletedWebAppAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get deleted app for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// Operation Id: Global_GetDeletedWebApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedSite> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedSiteGlobalClientDiagnostics.CreateScope("DeletedSite.Get");
            scope.Start();
            try
            {
                var response = _deletedSiteGlobalRestClient.GetDeletedWebApp(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all deleted apps for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}/snapshots
        /// Operation Id: Global_GetDeletedWebAppSnapshots
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Snapshot" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Snapshot> GetDeletedWebAppSnapshotsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Snapshot>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedSiteGlobalClientDiagnostics.CreateScope("DeletedSite.GetDeletedWebAppSnapshots");
                scope.Start();
                try
                {
                    var response = await _deletedSiteGlobalRestClient.GetDeletedWebAppSnapshotsAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
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
        /// Description for Get all deleted apps for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}/snapshots
        /// Operation Id: Global_GetDeletedWebAppSnapshots
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Snapshot" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Snapshot> GetDeletedWebAppSnapshots(CancellationToken cancellationToken = default)
        {
            Page<Snapshot> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedSiteGlobalClientDiagnostics.CreateScope("DeletedSite.GetDeletedWebAppSnapshots");
                scope.Start();
                try
                {
                    var response = _deletedSiteGlobalRestClient.GetDeletedWebAppSnapshots(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
