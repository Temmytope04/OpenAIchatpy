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
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A Class representing a SnapshotResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SnapshotResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSnapshotResource method.
    /// Otherwise you can get one from its parent resource <see cref="ReportResource"/> using the GetSnapshotResource method.
    /// </summary>
    public partial class SnapshotResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SnapshotResource"/> instance. </summary>
        /// <param name="reportName"> The reportName. </param>
        /// <param name="snapshotName"> The snapshotName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string reportName, string snapshotName)
        {
            var resourceId = $"/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _snapshotResourceSnapshotClientDiagnostics;
        private readonly SnapshotRestOperations _snapshotResourceSnapshotRestClient;
        private readonly SnapshotResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppComplianceAutomation/reports/snapshots";

        /// <summary> Initializes a new instance of the <see cref="SnapshotResource"/> class for mocking. </summary>
        protected SnapshotResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SnapshotResource(ArmClient client, SnapshotResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SnapshotResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _snapshotResourceSnapshotClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string snapshotResourceSnapshotApiVersion);
            _snapshotResourceSnapshotRestClient = new SnapshotRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotResourceSnapshotApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SnapshotResourceData Data
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

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SnapshotResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResource.Get");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SnapshotResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResource.Get");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Download compliance needs from snapshot, like: Compliance Report, Resource List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Download</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DownloadResponse>> DownloadAsync(WaitUntil waitUntil, SnapshotDownloadContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResource.Download");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotRestClient.DownloadAsync(Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<DownloadResponse>(new DownloadResponseOperationSource(), _snapshotResourceSnapshotClientDiagnostics, Pipeline, _snapshotResourceSnapshotRestClient.CreateDownloadRequest(Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Download compliance needs from snapshot, like: Compliance Report, Resource List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Download</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DownloadResponse> Download(WaitUntil waitUntil, SnapshotDownloadContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _snapshotResourceSnapshotClientDiagnostics.CreateScope("SnapshotResource.Download");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotRestClient.Download(Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<DownloadResponse>(new DownloadResponseOperationSource(), _snapshotResourceSnapshotClientDiagnostics, Pipeline, _snapshotResourceSnapshotRestClient.CreateDownloadRequest(Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
