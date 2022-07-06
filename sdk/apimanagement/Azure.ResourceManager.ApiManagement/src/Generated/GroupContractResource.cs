// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a GroupContract along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="GroupContractResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetGroupContractResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetGroupContract method.
    /// </summary>
    public partial class GroupContractResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GroupContractResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _groupContractGroupClientDiagnostics;
        private readonly GroupRestOperations _groupContractGroupRestClient;
        private readonly ClientDiagnostics _groupUserClientDiagnostics;
        private readonly GroupUserRestOperations _groupUserRestClient;
        private readonly GroupContractData _data;

        /// <summary> Initializes a new instance of the <see cref="GroupContractResource"/> class for mocking. </summary>
        protected GroupContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "GroupContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GroupContractResource(ArmClient client, GroupContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GroupContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GroupContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _groupContractGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string groupContractGroupApiVersion);
            _groupContractGroupRestClient = new GroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupContractGroupApiVersion);
            _groupUserClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _groupUserRestClient = new GroupUserRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/groups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GroupContractData Data
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
        /// Gets the details of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GroupContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Get");
            scope.Start();
            try
            {
                var response = await _groupContractGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GroupContractResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Get");
            scope.Start();
            try
            {
                var response = _groupContractGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific group of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Delete");
            scope.Start();
            try
            {
                var response = await _groupContractGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
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
        /// Deletes specific group of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Delete");
            scope.Start();
            try
            {
                var response = _groupContractGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
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
        /// Updates the details of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<GroupContractResource>> UpdateAsync(string ifMatch, GroupContractPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Update");
            scope.Start();
            try
            {
                var response = await _groupContractGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new GroupContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_Update
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="patch"/> is null. </exception>
        public virtual Response<GroupContractResource> Update(string ifMatch, GroupContractPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.Update");
            scope.Start();
            try
            {
                var response = _groupContractGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, cancellationToken);
                return Response.FromValue(new GroupContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of user entities associated with the group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users
        /// Operation Id: GroupUser_List
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UserContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UserContractResource> GetGroupUsersAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<UserContractResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.GetGroupUsers");
                scope.Start();
                try
                {
                    var response = await _groupUserRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new UserContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<UserContractResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.GetGroupUsers");
                scope.Start();
                try
                {
                    var response = await _groupUserRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new UserContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists a collection of user entities associated with the group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users
        /// Operation Id: GroupUser_List
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| firstName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| lastName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| email | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| registrationDate | filter | ge, le, eq, ne, gt, lt |     |&lt;/br&gt;| note | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UserContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UserContractResource> GetGroupUsers(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<UserContractResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.GetGroupUsers");
                scope.Start();
                try
                {
                    var response = _groupUserRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new UserContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<UserContractResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.GetGroupUsers");
                scope.Start();
                try
                {
                    var response = _groupUserRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new UserContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks that user entity specified by identifier is associated with the group entity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_CheckEntityExists
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<bool>> CheckEntityExistsGroupUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.CheckEntityExistsGroupUser");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.CheckEntityExistsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that user entity specified by identifier is associated with the group entity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_CheckEntityExists
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<bool> CheckEntityExistsGroupUser(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.CheckEntityExistsGroupUser");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.CheckEntityExists(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add existing user to existing group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_Create
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response<UserContractResource>> CreateGroupUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.CreateGroupUser");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new UserContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add existing user to existing group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_Create
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response<UserContractResource> CreateGroupUser(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.CreateGroupUser");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return Response.FromValue(new UserContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove existing user from existing group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_Delete
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual async Task<Response> DeleteGroupUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.DeleteGroupUser");
            scope.Start();
            try
            {
                var response = await _groupUserRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove existing user from existing group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}/users/{userId}
        /// Operation Id: GroupUser_Delete
        /// </summary>
        /// <param name="userId"> User identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public virtual Response DeleteGroupUser(string userId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userId, nameof(userId));

            using var scope = _groupUserClientDiagnostics.CreateScope("GroupContractResource.DeleteGroupUser");
            scope.Start();
            try
            {
                var response = _groupUserRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _groupContractGroupRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the group specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/groups/{groupId}
        /// Operation Id: Group_GetEntityTag
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _groupContractGroupClientDiagnostics.CreateScope("GroupContractResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _groupContractGroupRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
