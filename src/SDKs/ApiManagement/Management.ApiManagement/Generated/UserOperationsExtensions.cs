// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UserOperations.
    /// </summary>
    public static partial class UserOperationsExtensions
    {
            /// <summary>
            /// Returns calling user identity information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static CurrentUserIdentity GetIdentity(this IUserOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.GetIdentityAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns calling user identity information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CurrentUserIdentity> GetIdentityAsync(this IUserOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIdentityWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of registered users in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<UserContract> ListByService(this IUserOperations operations, string resourceGroupName, string serviceName, ODataQuery<UserContract> odataQuery = default(ODataQuery<UserContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of registered users in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<UserContract>> ListByServiceAsync(this IUserOperations operations, string resourceGroupName, string serviceName, ODataQuery<UserContract> odataQuery = default(ODataQuery<UserContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the user specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static UserGetEntityTagHeaders GetEntityTag(this IUserOperations operations, string resourceGroupName, string serviceName, string uid)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, uid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the user specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserGetEntityTagHeaders> GetEntityTagAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, uid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the user specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static UserContract Get(this IUserOperations operations, string resourceGroupName, string serviceName, string uid)
            {
                return operations.GetAsync(resourceGroupName, serviceName, uid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the user specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserContract> GetAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, uid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static UserContract CreateOrUpdate(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserCreateParameters parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, uid, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserContract> CreateOrUpdateAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserCreateParameters parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, uid, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the details of the user specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Update(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserUpdateParameters parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, uid, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the details of the user specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, uid, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes specific user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='deleteSubscriptions'>
            /// Whether to delete user's subscription or not.
            /// </param>
            /// <param name='notify'>
            /// Send an Account Closed Email notification to the User.
            /// </param>
            public static void Delete(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, string ifMatch, bool? deleteSubscriptions = default(bool?), bool? notify = default(bool?))
            {
                operations.DeleteAsync(resourceGroupName, serviceName, uid, ifMatch, deleteSubscriptions, notify).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specific user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='deleteSubscriptions'>
            /// Whether to delete user's subscription or not.
            /// </param>
            /// <param name='notify'>
            /// Send an Account Closed Email notification to the User.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, string ifMatch, bool? deleteSubscriptions = default(bool?), bool? notify = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, uid, ifMatch, deleteSubscriptions, notify, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a redirection URL containing an authentication token for signing
            /// a given user into the developer portal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static GenerateSsoUrlResult GenerateSsoUrl(this IUserOperations operations, string resourceGroupName, string serviceName, string uid)
            {
                return operations.GenerateSsoUrlAsync(resourceGroupName, serviceName, uid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a redirection URL containing an authentication token for signing
            /// a given user into the developer portal.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerateSsoUrlResult> GenerateSsoUrlAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateSsoUrlWithHttpMessagesAsync(resourceGroupName, serviceName, uid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Shared Access Authorization Token for the User.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create Authorization Token parameters.
            /// </param>
            public static UserTokenResult GetSharedAccessToken(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserTokenParameters parameters)
            {
                return operations.GetSharedAccessTokenAsync(resourceGroupName, serviceName, uid, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Shared Access Authorization Token for the User.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='uid'>
            /// User identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='parameters'>
            /// Create Authorization Token parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserTokenResult> GetSharedAccessTokenAsync(this IUserOperations operations, string resourceGroupName, string serviceName, string uid, UserTokenParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSharedAccessTokenWithHttpMessagesAsync(resourceGroupName, serviceName, uid, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of registered users in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<UserContract> ListByServiceNext(this IUserOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of registered users in the specified service instance.
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
            public static async Task<IPage<UserContract>> ListByServiceNextAsync(this IUserOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
