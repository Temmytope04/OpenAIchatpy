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

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A Class representing a ScheduledAction along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ScheduledActionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetScheduledActionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetScheduledAction method.
    /// </summary>
    public partial class ScheduledActionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScheduledActionResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string name)
        {
            var resourceId = $"{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scheduledActionClientDiagnostics;
        private readonly ScheduledActionsRestOperations _scheduledActionRestClient;
        private readonly ScheduledActionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CostManagement/scheduledActions";

        /// <summary> Initializes a new instance of the <see cref="ScheduledActionResource"/> class for mocking. </summary>
        protected ScheduledActionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledActionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScheduledActionResource(ArmClient client, ScheduledActionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledActionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScheduledActionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scheduledActionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scheduledActionApiVersion);
            _scheduledActionRestClient = new ScheduledActionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scheduledActionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScheduledActionData Data
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
        /// Get the shared scheduled action from the given scope by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScheduledActionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Get");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.GetByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the shared scheduled action from the given scope by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScheduledActionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Get");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.GetByScope(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledActionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_DeleteByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Delete");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.DeleteByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation(response);
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
        /// Delete a scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_DeleteByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Delete");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.DeleteByScope(Id.Parent, Id.Name, cancellationToken);
                var operation = new CostManagementArmOperation(response);
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
        /// Create or update a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScheduledActionResource>> UpdateAsync(WaitUntil waitUntil, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Update");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.CreateOrUpdateByScopeAsync(Id.Parent, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<ScheduledActionResource>(Response.FromValue(new ScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Scheduled action to be created or updated. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity. Optional when updating an entity and can be specified to achieve optimistic concurrency. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScheduledActionResource> Update(WaitUntil waitUntil, ScheduledActionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.Update");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.CreateOrUpdateByScope(Id.Parent, Id.Name, data, ifMatch, cancellationToken);
                var operation = new CostManagementArmOperation<ScheduledActionResource>(Response.FromValue(new ScheduledActionResource(Client, response), response.GetRawResponse()));
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
        /// Runs a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_RunByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RunByScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.RunByScope");
            scope.Start();
            try
            {
                var response = await _scheduledActionRestClient.RunByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Runs a shared scheduled action within the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/scheduledActions/{name}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledActions_RunByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RunByScope(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledActionClientDiagnostics.CreateScope("ScheduledActionResource.RunByScope");
            scope.Start();
            try
            {
                var response = _scheduledActionRestClient.RunByScope(Id.Parent, Id.Name, cancellationToken);
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
