// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PublishedArtifactsOperations.
    /// </summary>
    public static partial class PublishedArtifactsOperationsExtensions
    {
            /// <summary>
            /// Get an artifact for a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='artifactName'>
            /// name of the artifact.
            /// </param>
            public static Artifact Get(this IPublishedArtifactsOperations operations, string scope, string blueprintName, string versionId, string artifactName)
            {
                return operations.GetAsync(scope, blueprintName, versionId, artifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an artifact for a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='artifactName'>
            /// name of the artifact.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Artifact> GetAsync(this IPublishedArtifactsOperations operations, string scope, string blueprintName, string versionId, string artifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, blueprintName, versionId, artifactName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List artifacts for a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            public static IPage<Artifact> List(this IPublishedArtifactsOperations operations, string scope, string blueprintName, string versionId)
            {
                return operations.ListAsync(scope, blueprintName, versionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts for a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// name of the blueprint.
            /// </param>
            /// <param name='versionId'>
            /// version of the published blueprint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Artifact>> ListAsync(this IPublishedArtifactsOperations operations, string scope, string blueprintName, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, blueprintName, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List artifacts for a published Blueprint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Artifact> ListNext(this IPublishedArtifactsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts for a published Blueprint.
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
            public static async Task<IPage<Artifact>> ListNextAsync(this IPublishedArtifactsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
