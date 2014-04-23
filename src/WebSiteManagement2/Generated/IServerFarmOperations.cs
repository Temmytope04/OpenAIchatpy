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
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// Operations for managing the server farm in a resource group.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx for
    /// more information)
    /// </summary>
    public partial interface IServerFarmOperations
    {
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT).  Warning: Creating a server farm
        /// changes your webspace’s Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Server Farm operation response.
        /// </returns>
        Task<ServerFarmCreateResponse> CreateAsync(string resourceGroupName, ServerFarmCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// The name of the server farm.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, string name, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT).  Warning: Creating a server farm
        /// changes your webspace’s Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serverFarmName'>
        /// The name of the server farm.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Server Farm operation response.
        /// </returns>
        Task<ServerFarmGetResponse> GetAsync(string resourceGroupName, string serverFarmName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT).  Warning: Creating a server farm
        /// changes your webspace’s Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Server Farm operation response.
        /// </returns>
        Task<ServerFarmListResponse> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
    }
}
