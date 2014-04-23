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
using Microsoft.Azure.Management.WebSites;
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// The Windows Azure Web Sites management API provides a RESTful set of
    /// web services that interact with Windows Azure Web Sites service to
    /// manage your web sites. The API has entities that capture the
    /// relationship between an end user and the Windows Azure Web Sites
    /// service.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public partial interface IWebSiteManagementClient : IDisposable
    {
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Management API. The
        /// Management APIs use JWT bearer tokens over SSL to ensure that a
        /// request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </summary>
        TokenCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the server farm in a resource group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        IServerFarmOperations ServerFarms
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the web sites in a web space.
        /// </summary>
        IWebSiteOperations WebSites
        {
            get; 
        }
        
        /// <summary>
        /// Begins deleting a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> BeginDeletingResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates or updates the resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create or Update resource group operation response.
        /// </returns>
        Task<ResourceGroupCreateOrUpdateResponse> CreateOrUpdateResourceGroupAsync(string resourceGroupName, ResourceGroupCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets all resource groups in the subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> GetResourceGroupsAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Register the resource provider with a subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> RegisterResourceProviderAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Unregister the resource provider with a subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UnregisterResourceProviderAsync(CancellationToken cancellationToken);
    }
}
