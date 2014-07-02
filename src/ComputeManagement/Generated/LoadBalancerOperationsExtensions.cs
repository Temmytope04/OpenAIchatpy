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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL, and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class LoadBalancerOperationsExtensions
    {
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginCreating(this ILoadBalancerOperations operations, string serviceName, string deploymentName, LoadBalancerCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).BeginCreatingAsync(serviceName, deploymentName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginCreatingAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, LoadBalancerCreateParameters parameters)
        {
            return operations.BeginCreatingAsync(serviceName, deploymentName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the load balancer.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginDeleting(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).BeginDeletingAsync(serviceName, deploymentName, loadBalancerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the load balancer.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginDeletingAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName)
        {
            return operations.BeginDeletingAsync(serviceName, deploymentName, loadBalancerName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse BeginUpdating(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).BeginUpdatingAsync(serviceName, deploymentName, loadBalancerName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> BeginUpdatingAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters)
        {
            return operations.BeginUpdatingAsync(serviceName, deploymentName, loadBalancerName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse Create(this ILoadBalancerOperations operations, string serviceName, string deploymentName, LoadBalancerCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).CreateAsync(serviceName, deploymentName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Add an internal load balancer to a an existing deployment. When
        /// used by an input endpoint, the internal load balancer will provide
        /// an additional private VIP that can be used for load balancing to
        /// the roles in this deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> CreateAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, LoadBalancerCreateParameters parameters)
        {
            return operations.CreateAsync(serviceName, deploymentName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the load balancer.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).DeleteAsync(serviceName, deploymentName, loadBalancerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete an internal load balancer from the deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the load balancer.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName)
        {
            return operations.DeleteAsync(serviceName, deploymentName, loadBalancerName, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse Update(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILoadBalancerOperations)s).UpdateAsync(serviceName, deploymentName, loadBalancerName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates an internal load balancer associated with an existing
        /// deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ILoadBalancerOperations.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the service.
        /// </param>
        /// <param name='deploymentName'>
        /// Required. The name of the deployment.
        /// </param>
        /// <param name='loadBalancerName'>
        /// Required. The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Load Balancer operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> UpdateAsync(this ILoadBalancerOperations operations, string serviceName, string deploymentName, string loadBalancerName, LoadBalancerUpdateParameters parameters)
        {
            return operations.UpdateAsync(serviceName, deploymentName, loadBalancerName, parameters, CancellationToken.None);
        }
    }
}
