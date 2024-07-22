// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a StaticSiteDatabaseConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StaticSiteDatabaseConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStaticSiteDatabaseConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteResource"/> using the GetStaticSiteDatabaseConnection method.
    /// </summary>
    public partial class StaticSiteDatabaseConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteDatabaseConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="databaseConnectionName"> The databaseConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string databaseConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteDatabaseConnectionStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteDatabaseConnectionStaticSitesRestClient;
        private readonly StaticSiteDatabaseConnectionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/databaseConnections";

        /// <summary> Initializes a new instance of the <see cref="StaticSiteDatabaseConnectionResource"/> class for mocking. </summary>
        protected StaticSiteDatabaseConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteDatabaseConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteDatabaseConnectionResource(ArmClient client, StaticSiteDatabaseConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteDatabaseConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteDatabaseConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteDatabaseConnectionStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteDatabaseConnectionStaticSitesApiVersion);
            _staticSiteDatabaseConnectionStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteDatabaseConnectionStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteDatabaseConnectionData Data
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
        /// Returns overview of a database connection for a static site by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteDatabaseConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteDatabaseConnectionStaticSitesRestClient.GetDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns overview of a database connection for a static site by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteDatabaseConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteDatabaseConnectionStaticSitesRestClient.GetDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a database connection for a static site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteDatabaseConnectionStaticSitesRestClient.DeleteDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _staticSiteDatabaseConnectionStaticSitesRestClient.CreateDeleteDatabaseConnectionRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a database connection for a static site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_DeleteDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteDatabaseConnectionStaticSitesRestClient.DeleteDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _staticSiteDatabaseConnectionStaticSitesRestClient.CreateDeleteDatabaseConnectionRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a database connection for a static site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_UpdateDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> A JSON representation of the database connection request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<StaticSiteDatabaseConnectionResource>> UpdateAsync(StaticSiteDatabaseConnectionPatchContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _staticSiteDatabaseConnectionStaticSitesRestClient.UpdateDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a database connection for a static site
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_UpdateDatabaseConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> A JSON representation of the database connection request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<StaticSiteDatabaseConnectionResource> Update(StaticSiteDatabaseConnectionPatchContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _staticSiteDatabaseConnectionStaticSitesRestClient.UpdateDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns details of a database connection for a static site by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}/show</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetDatabaseConnectionWithDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StaticSiteDatabaseConnectionResource>> GetDatabaseConnectionWithDetailsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.GetDatabaseConnectionWithDetails");
            scope.Start();
            try
            {
                var response = await _staticSiteDatabaseConnectionStaticSitesRestClient.GetDatabaseConnectionWithDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns details of a database connection for a static site by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/databaseConnections/{databaseConnectionName}/show</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetDatabaseConnectionWithDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StaticSiteDatabaseConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteDatabaseConnectionResource> GetDatabaseConnectionWithDetails(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteDatabaseConnectionResource.GetDatabaseConnectionWithDetails");
            scope.Start();
            try
            {
                var response = _staticSiteDatabaseConnectionStaticSitesRestClient.GetDatabaseConnectionWithDetails(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new StaticSiteDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
