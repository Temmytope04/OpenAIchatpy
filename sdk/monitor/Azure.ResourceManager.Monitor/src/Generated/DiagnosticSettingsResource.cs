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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a DiagnosticSettings along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DiagnosticSettingsResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDiagnosticSettingsResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetDiagnosticSettings method.
    /// </summary>
    public partial class DiagnosticSettingsResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiagnosticSettingsResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string name)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _diagnosticSettingsDiagnosticSettingsClientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingsDiagnosticSettingsRestClient;
        private readonly DiagnosticSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsResource"/> class for mocking. </summary>
        protected DiagnosticSettingsResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DiagnosticSettingsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiagnosticSettingsResource(ArmClient client, DiagnosticSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiagnosticSettingsResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingsDiagnosticSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string diagnosticSettingsDiagnosticSettingsApiVersion);
            _diagnosticSettingsDiagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diagnosticSettingsDiagnosticSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/diagnosticSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticSettingsData Data
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
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticSettingsResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsResource.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticSettingsResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsResource.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes existing diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsResource.Delete");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(response);
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
        /// Deletes existing diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsResource.Delete");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(response);
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
