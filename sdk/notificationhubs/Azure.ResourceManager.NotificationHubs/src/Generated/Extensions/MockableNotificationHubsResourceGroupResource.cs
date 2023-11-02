// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableNotificationHubsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNotificationHubsResourceGroupResource"/> class for mocking. </summary>
        protected MockableNotificationHubsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNotificationHubsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNotificationHubsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of NotificationHubNamespaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NotificationHubNamespaceResources and their operations over a NotificationHubNamespaceResource. </returns>
        public virtual NotificationHubNamespaceCollection GetNotificationHubNamespaces()
        {
            return GetCachedClient(client => new NotificationHubNamespaceCollection(client, Id));
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NotificationHubNamespaceResource>> GetNotificationHubNamespaceAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            return await GetNotificationHubNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NotificationHubNamespaceResource> GetNotificationHubNamespace(string namespaceName, CancellationToken cancellationToken = default)
        {
            return GetNotificationHubNamespaces().Get(namespaceName, cancellationToken);
        }
    }
}
