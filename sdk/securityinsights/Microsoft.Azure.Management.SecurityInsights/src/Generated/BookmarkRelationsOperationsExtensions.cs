// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BookmarkRelationsOperations.
    /// </summary>
    public static partial class BookmarkRelationsOperationsExtensions
    {
            /// <summary>
            /// Gets all bookmark relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            public static IPage<BookmarkRelation> List(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, ODataQuery<BookmarkRelation> odataQuery = default(ODataQuery<BookmarkRelation>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all bookmark relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BookmarkRelation>> ListAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, ODataQuery<BookmarkRelation> odataQuery = default(ODataQuery<BookmarkRelation>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            public static BookmarkRelation GetRelation(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName)
            {
                return operations.GetRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BookmarkRelation> GetRelationAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relationInputModel'>
            /// The relation input model
            /// </param>
            public static BookmarkRelation CreateOrUpdateRelation(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName, RelationsModelInput relationInputModel)
            {
                return operations.CreateOrUpdateRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName, relationInputModel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relationInputModel'>
            /// The relation input model
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BookmarkRelation> CreateOrUpdateRelationAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName, RelationsModelInput relationInputModel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName, relationInputModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            public static void DeleteRelation(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName)
            {
                operations.DeleteRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the bookmark relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteRelationAsync(this IBookmarkRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string bookmarkId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, bookmarkId, relationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all bookmark relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BookmarkRelation> ListNext(this IBookmarkRelationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all bookmark relations.
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
            public static async Task<IPage<BookmarkRelation>> ListNextAsync(this IBookmarkRelationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
