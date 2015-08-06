// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.NotificationHubs.Models;

namespace Microsoft.Azure.Management.NotificationHubs
{
    /// <summary>
    /// The Management API includes operations for managing notification hubs.
    /// </summary>
    public partial interface INotificationHubOperations
    {
        /// <summary>
        /// Checks the availability of the given notificationHub in a
        /// namespace.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj870968.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='parameters'>
        /// The notificationHub name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of the Check NameAvailability operation.
        /// </returns>
        Task<CheckAvailabilityResponse> CheckAvailabilityAsync(string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The create NotificationHub authorization rule operation creates an
        /// authorization rule for a NotificationHub
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The namespace authorizationRuleName name.
        /// </param>
        /// <param name='parameters'>
        /// The shared access authorization rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of the CreateOrUpdate operation on the AuthorizationRules
        /// </returns>
        Task<AuthorizationRulesCreateOrUpdateResponse> CreateAuthorizationRuleAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, AuthorizationRulesCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new NotificationHub in a namespace.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj856303.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create a Namespace Resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of the CreateOrUpdate operation on the NotificationHub
        /// </returns>
        Task<NotificationHubCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a notification hub associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The delete a notificationHub authorization rule operation
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The namespace authorizationRuleName name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAuthorizationRuleAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the Get NotificationHub operation.
        /// </returns>
        Task<NotificationHubGetResponse> GetAsync(string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The get authorization rule operation gets an authorization rule for
        /// a NotificationHub by name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace to get the authorization rule for.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The entity name to get the authorization rule for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the Get Namespace operation.
        /// </returns>
        Task<AuthorizationRulesGetResponse> GetAuthorizationRuleAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the PNS Credentials associated with a notification hub .
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the Get NotificationHub operation.
        /// </returns>
        Task<NotificationHubGetResponse> GetPnsCredentialsAsync(string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the List NotificationHub operation.
        /// </returns>
        Task<NotificationHubListResponse> ListAsync(string resourceGroupName, string namespaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The get authorization rules operation gets the authorization rules
        /// for a NotificationHub.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The NotificationHub to get the authorization rule for.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the List Namespace operation.
        /// </returns>
        Task<AuthorizationRulesListResponse> ListAuthorizationRulesAsync(string resourceGroupName, string namespaceName, string notificationHubName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Primary and Secondary ConnectionStrings to the
        /// NotificationHub   (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='notificationHubName'>
        /// The notification hub name.
        /// </param>
        /// <param name='authorizationRuleName'>
        /// The connection string of the NotificationHub for the specified
        /// authorizationRule.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Namespace/NotificationHub Connection String
        /// </returns>
        Task<ResourceListKeys> ListKeysAsync(string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, CancellationToken cancellationToken);
    }
}
