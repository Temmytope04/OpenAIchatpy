// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleriesOperations.
    /// </summary>
    public static partial class GalleriesOperationsExtensions
    {
            /// <summary>
            /// Create or update a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery. The allowed characters are alphabets
            /// and numbers with dots and periods allowed in the middle. The maximum length
            /// is 80 characters.
            /// </param>
            /// <param name='gallery'>
            /// Parameters supplied to the create or update Shared Image Gallery operation.
            /// </param>
            public static Gallery CreateOrUpdate(this IGalleriesOperations operations, string resourceGroupName, string galleryName, Gallery gallery)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, galleryName, gallery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery. The allowed characters are alphabets
            /// and numbers with dots and periods allowed in the middle. The maximum length
            /// is 80 characters.
            /// </param>
            /// <param name='gallery'>
            /// Parameters supplied to the create or update Shared Image Gallery operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gallery> CreateOrUpdateAsync(this IGalleriesOperations operations, string resourceGroupName, string galleryName, Gallery gallery, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, gallery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery.
            /// </param>
            public static Gallery Get(this IGalleriesOperations operations, string resourceGroupName, string galleryName)
            {
                return operations.GetAsync(resourceGroupName, galleryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gallery> GetAsync(this IGalleriesOperations operations, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, galleryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery to be deleted.
            /// </param>
            public static void Delete(this IGalleriesOperations operations, string resourceGroupName, string galleryName)
            {
                operations.DeleteAsync(resourceGroupName, galleryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleriesOperations operations, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, galleryName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List galleries under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<Gallery> ListByResourceGroup(this IGalleriesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List galleries under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Gallery>> ListByResourceGroupAsync(this IGalleriesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List galleries under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Gallery> List(this IGalleriesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List galleries under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Gallery>> ListAsync(this IGalleriesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery. The allowed characters are alphabets
            /// and numbers with dots and periods allowed in the middle. The maximum length
            /// is 80 characters.
            /// </param>
            /// <param name='gallery'>
            /// Parameters supplied to the create or update Shared Image Gallery operation.
            /// </param>
            public static Gallery BeginCreateOrUpdate(this IGalleriesOperations operations, string resourceGroupName, string galleryName, Gallery gallery)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, galleryName, gallery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery. The allowed characters are alphabets
            /// and numbers with dots and periods allowed in the middle. The maximum length
            /// is 80 characters.
            /// </param>
            /// <param name='gallery'>
            /// Parameters supplied to the create or update Shared Image Gallery operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Gallery> BeginCreateOrUpdateAsync(this IGalleriesOperations operations, string resourceGroupName, string galleryName, Gallery gallery, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, gallery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery to be deleted.
            /// </param>
            public static void BeginDelete(this IGalleriesOperations operations, string resourceGroupName, string galleryName)
            {
                operations.BeginDeleteAsync(resourceGroupName, galleryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Shared Image Gallery.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGalleriesOperations operations, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, galleryName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List galleries under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Gallery> ListByResourceGroupNext(this IGalleriesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List galleries under a resource group.
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
            public static async Task<IPage<Gallery>> ListByResourceGroupNextAsync(this IGalleriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List galleries under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Gallery> ListNext(this IGalleriesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List galleries under a subscription.
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
            public static async Task<IPage<Gallery>> ListNextAsync(this IGalleriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
