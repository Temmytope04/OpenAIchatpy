// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicyAssignmentsOperations.
    /// </summary>
    public static partial class PolicyAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Deletes a policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment to delete.
            /// </param>
            public static PolicyAssignment Delete(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return operations.DeleteAsync(scope, policyAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> DeleteAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a policy assignment.
            /// </summary>
            /// <remarks>
            /// Policy assignments are inherited by child resources. For example, when you
            /// apply a policy to a resource group that policy is assigned to all resources
            /// in the group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the policy assignment.
            /// </param>
            public static PolicyAssignment Create(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters)
            {
                return operations.CreateAsync(scope, policyAssignmentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a policy assignment.
            /// </summary>
            /// <remarks>
            /// Policy assignments are inherited by child resources. For example, when you
            /// apply a policy to a resource group that policy is assigned to all resources
            /// in the group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> CreateAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, policyAssignmentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment to get.
            /// </param>
            public static PolicyAssignment Get(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return operations.GetAsync(scope, policyAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// The name of the policy assignment to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> GetAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments for the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains policy assignments.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResourceGroup(this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string))
            {
                return operations.ListForResourceGroupAsync(resourceGroupName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments for the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains policy assignments.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListForResourceGroupAsync(this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the resource. The name is case
            /// insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource with policy assignments.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static IPage<PolicyAssignment> ListForResource(this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>))
            {
                return operations.ListForResourceAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the resource. The name is case
            /// insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource with policy assignments.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<IPage<PolicyAssignment>> ListForResourceAsync(this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy assignments for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<PolicyAssignment> List(this IPolicyAssignmentsOperations operations, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>))
            {
                return operations.ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy assignments for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListAsync(this IPolicyAssignmentsOperations operations, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to delete. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            public static PolicyAssignment DeleteById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return operations.DeleteByIdAsync(policyAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to delete. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> DeleteByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// Policy assignments are inherited by child resources. For example, when you
            /// apply a policy to a resource group that policy is assigned to all resources
            /// in the group. When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to create. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for policy assignment.
            /// </param>
            public static PolicyAssignment CreateById(this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters)
            {
                return operations.CreateByIdAsync(policyAssignmentId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// Policy assignments are inherited by child resources. For example, when you
            /// apply a policy to a resource group that policy is assigned to all resources
            /// in the group. When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to create. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> CreateByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateByIdWithHttpMessagesAsync(policyAssignmentId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to get. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            public static PolicyAssignment GetById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return operations.GetByIdAsync(policyAssignmentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a policy assignment by ID.
            /// </summary>
            /// <remarks>
            /// When providing a scope for the assignment, use
            /// '/subscriptions/{subscription-id}/' for subscriptions,
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}' for
            /// resource groups, and
            /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
            /// for resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// The ID of the policy assignment to get. Use the format
            /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> GetByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments for the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResourceGroupNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments for the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListForResourceGroupNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static IPage<PolicyAssignment> ListForResourceNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments for a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<IPage<PolicyAssignment>> ListForResourceNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy assignments for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy assignments for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
