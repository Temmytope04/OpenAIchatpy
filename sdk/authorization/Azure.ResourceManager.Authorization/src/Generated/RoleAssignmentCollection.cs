// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleAssignmentResource" /> and their operations.
    /// Each <see cref="RoleAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleAssignmentCollection" /> instance call the GetRoleAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleAssignmentCollection : ArmCollection, IEnumerable<RoleAssignmentResource>, IAsyncEnumerable<RoleAssignmentResource>
    {
        private readonly ClientDiagnostics _roleAssignmentClientDiagnostics;
        private readonly RoleAssignmentsRestOperations _roleAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentCollection"/> class for mocking. </summary>
        protected RoleAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleAssignmentResource.ResourceType, out string roleAssignmentApiVersion);
            _roleAssignmentRestClient = new RoleAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentApiVersion);
        }

        /// <summary>
        /// Create or update a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="content"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleAssignmentName, RoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.CreateAsync(Id, roleAssignmentName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleAssignmentResource>(Response.FromValue(new RoleAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="content"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RoleAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string roleAssignmentName, RoleAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Create(Id, roleAssignmentName, content, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleAssignmentResource>(Response.FromValue(new RoleAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<RoleAssignmentResource>> GetAsync(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.GetAsync(Id, roleAssignmentName, tenantId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual Response<RoleAssignmentResource> Get(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Get(Id, roleAssignmentName, tenantId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all role assignments that apply to a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="skipToken"> The skipToken to apply on the operation. Use $skipToken={skiptoken} to return paged role assignments following the skipToken passed. Only supported on provider level calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentResource> GetAllAsync(string filter = null, string tenantId = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentRestClient.CreateListForScopeRequest(Id, filter, tenantId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter, tenantId, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RoleAssignmentResource(Client, RoleAssignmentData.DeserializeRoleAssignmentData(e)), _roleAssignmentClientDiagnostics, Pipeline, "RoleAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all role assignments that apply to a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="skipToken"> The skipToken to apply on the operation. Use $skipToken={skiptoken} to return paged role assignments following the skipToken passed. Only supported on provider level calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentResource> GetAll(string filter = null, string tenantId = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleAssignmentRestClient.CreateListForScopeRequest(Id, filter, tenantId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter, tenantId, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RoleAssignmentResource(Client, RoleAssignmentData.DeserializeRoleAssignmentData(e)), _roleAssignmentClientDiagnostics, Pipeline, "RoleAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleAssignmentRestClient.GetAsync(Id, roleAssignmentName, tenantId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleAssignmentName, nameof(roleAssignmentName));

            using var scope = _roleAssignmentClientDiagnostics.CreateScope("RoleAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleAssignmentRestClient.Get(Id, roleAssignmentName, tenantId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleAssignmentResource> IEnumerable<RoleAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentResource> IAsyncEnumerable<RoleAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
