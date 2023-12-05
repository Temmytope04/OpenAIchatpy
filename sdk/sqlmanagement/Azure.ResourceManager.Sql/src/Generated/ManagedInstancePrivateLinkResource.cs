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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedInstancePrivateLink along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedInstancePrivateLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedInstancePrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource"/> using the GetManagedInstancePrivateLink method.
    /// </summary>
    public partial class ManagedInstancePrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstancePrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="managedInstanceName"> The managedInstanceName. </param>
        /// <param name="groupName"> The groupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics;
        private readonly ManagedInstancePrivateLinkResourcesRestOperations _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient;
        private readonly ManagedInstancePrivateLinkData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/privateLinkResources";

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkResource"/> class for mocking. </summary>
        protected ManagedInstancePrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstancePrivateLinkResource(ArmClient client, ManagedInstancePrivateLinkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstancePrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedInstancePrivateLinkManagedInstancePrivateLinkResourcesApiVersion);
            _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient = new ManagedInstancePrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstancePrivateLinkManagedInstancePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstancePrivateLinkData Data
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
        /// Gets a private link resource for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstancePrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstancePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource for SQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedInstancePrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstancePrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesClientDiagnostics.CreateScope("ManagedInstancePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _managedInstancePrivateLinkManagedInstancePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstancePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
