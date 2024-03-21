// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A Class representing an AutomanageHciClusterConfigurationProfileAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomanageHciClusterConfigurationProfileAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetAutomanageHciClusterConfigurationProfileAssignment method.
    /// </summary>
    public partial class AutomanageHciClusterConfigurationProfileAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="configurationProfileAssignmentName"> The configurationProfileAssignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string configurationProfileAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileHCIAssignmentsRestOperations _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient;
        private readonly AutomanageConfigurationProfileAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automanage/configurationProfileAssignments";

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/> class for mocking. </summary>
        protected AutomanageHciClusterConfigurationProfileAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomanageHciClusterConfigurationProfileAssignmentResource(ArmClient client, AutomanageConfigurationProfileAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomanageHciClusterConfigurationProfileAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsApiVersion);
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient = new ConfigurationProfileHCIAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomanageConfigurationProfileAssignmentData Data
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

        /// <summary> Gets a collection of AutomanageHciClusterConfigurationProfileAssignmentReportResources in the AutomanageHciClusterConfigurationProfileAssignment. </summary>
        /// <returns> An object representing collection of AutomanageHciClusterConfigurationProfileAssignmentReportResources and their operations over a AutomanageHciClusterConfigurationProfileAssignmentReportResource. </returns>
        public virtual AutomanageHciClusterConfigurationProfileAssignmentReportCollection GetAutomanageHciClusterConfigurationProfileAssignmentReports()
        {
            return GetCachedClient(client => new AutomanageHciClusterConfigurationProfileAssignmentReportCollection(client, Id));
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCIReports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AutomanageHciClusterConfigurationProfileAssignmentReportResource>> GetAutomanageHciClusterConfigurationProfileAssignmentReportAsync(string reportName, CancellationToken cancellationToken = default)
        {
            return await GetAutomanageHciClusterConfigurationProfileAssignmentReports().GetAsync(reportName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HCIReports_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentReportResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AutomanageHciClusterConfigurationProfileAssignmentReportResource> GetAutomanageHciClusterConfigurationProfileAssignmentReport(string reportName, CancellationToken cancellationToken = default)
        {
            return GetAutomanageHciClusterConfigurationProfileAssignmentReports().Get(reportName, cancellationToken);
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomanageHciClusterConfigurationProfileAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomanageHciClusterConfigurationProfileAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation(response);
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
        /// Delete a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AutomanageArmOperation(response);
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

        /// <summary>
        /// Creates an association between a AzureStackHCI cluster and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>> UpdateAsync(WaitUntil waitUntil, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an association between a AzureStackHCI cluster and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomanageHciClusterConfigurationProfileAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource> Update(WaitUntil waitUntil, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
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
