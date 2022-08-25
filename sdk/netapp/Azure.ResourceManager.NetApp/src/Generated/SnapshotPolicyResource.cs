// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A Class representing a SnapshotPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SnapshotPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSnapshotPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="NetAppAccountResource" /> using the GetSnapshotPolicy method.
    /// </summary>
    public partial class SnapshotPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SnapshotPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string snapshotPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _snapshotPolicyClientDiagnostics;
        private readonly SnapshotPoliciesRestOperations _snapshotPolicyRestClient;
        private readonly SnapshotPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="SnapshotPolicyResource"/> class for mocking. </summary>
        protected SnapshotPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SnapshotPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SnapshotPolicyResource(ArmClient client, SnapshotPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SnapshotPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _snapshotPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string snapshotPolicyApiVersion);
            _snapshotPolicyRestClient = new SnapshotPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NetApp/netAppAccounts/snapshotPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SnapshotPolicyData Data
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
        /// Get a snapshot Policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SnapshotPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a snapshot Policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SnapshotPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation(_snapshotPolicyClientDiagnostics, Pipeline, _snapshotPolicyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetAppArmOperation(_snapshotPolicyClientDiagnostics, Pipeline, _snapshotPolicyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Patch a snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Snapshot policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<SnapshotPolicyResource>> UpdateAsync(WaitUntil waitUntil, SnapshotPolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<SnapshotPolicyResource>(new SnapshotPolicyOperationSource(Client), _snapshotPolicyClientDiagnostics, Pipeline, _snapshotPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patch a snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Snapshot policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<SnapshotPolicyResource> Update(WaitUntil waitUntil, SnapshotPolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new NetAppArmOperation<SnapshotPolicyResource>(new SnapshotPolicyOperationSource(Client), _snapshotPolicyClientDiagnostics, Pipeline, _snapshotPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get volumes associated with snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}/volumes
        /// Operation Id: SnapshotPolicies_ListVolumes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppVolumeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppVolumeResource> GetVolumesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetAppVolumeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.GetVolumes");
                scope.Start();
                try
                {
                    var response = await _snapshotPolicyRestClient.ListVolumesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppVolumeResource(Client, value)), null, response.GetRawResponse());
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
        /// Get volumes associated with snapshot policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}/volumes
        /// Operation Id: SnapshotPolicies_ListVolumes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppVolumeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppVolumeResource> GetVolumes(CancellationToken cancellationToken = default)
        {
            Page<NetAppVolumeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.GetVolumes");
                scope.Start();
                try
                {
                    var response = _snapshotPolicyRestClient.ListVolumes(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppVolumeResource(Client, value)), null, response.GetRawResponse());
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<SnapshotPolicyResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<SnapshotPolicyResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<SnapshotPolicyResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<SnapshotPolicyResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<SnapshotPolicyResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}
        /// Operation Id: SnapshotPolicies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<SnapshotPolicyResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SnapshotPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
