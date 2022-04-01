// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a ServiceBusSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServiceBusSubscriptionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServiceBusSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusTopicResource" /> using the GetServiceBusSubscription method.
    /// </summary>
    public partial class ServiceBusSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusSubscriptionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusSubscriptionSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _serviceBusSubscriptionSubscriptionsRestClient;
        private readonly ServiceBusSubscriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusSubscriptionResource"/> class for mocking. </summary>
        protected ServiceBusSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusSubscriptionResource(ArmClient client, ServiceBusSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusSubscriptionSubscriptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusSubscriptionSubscriptionsApiVersion);
            _serviceBusSubscriptionSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusSubscriptionSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/topics/subscriptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusSubscriptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ServiceBusRuleResources in the ServiceBusSubscription. </summary>
        /// <returns> An object representing collection of ServiceBusRuleResources and their operations over a ServiceBusRuleResource. </returns>
        public virtual ServiceBusRuleCollection GetServiceBusRules()
        {
            return GetCachedClient(Client => new ServiceBusRuleCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the description for the specified rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}
        /// Operation Id: Rules_Get
        /// </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusRuleResource>> GetServiceBusRuleAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            return await GetServiceBusRules().GetAsync(ruleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the description for the specified rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}/rules/{ruleName}
        /// Operation Id: Rules_Get
        /// </summary>
        /// <param name="ruleName"> The rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<ServiceBusRuleResource> GetServiceBusRule(string ruleName, CancellationToken cancellationToken = default)
        {
            return GetServiceBusRules().Get(ruleName, cancellationToken);
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _serviceBusSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceBusSubscriptionSubscriptionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a subscription from the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusSubscriptionSubscriptionsClientDiagnostics.CreateScope("ServiceBusSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceBusSubscriptionSubscriptionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
