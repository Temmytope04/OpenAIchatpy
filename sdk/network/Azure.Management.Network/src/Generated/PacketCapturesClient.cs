// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The PacketCaptures service client. </summary>
    public partial class PacketCapturesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PacketCapturesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PacketCapturesClient for mocking. </summary>
        protected PacketCapturesClient()
        {
        }
        /// <summary> Initializes a new instance of PacketCapturesClient. </summary>
        internal PacketCapturesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PacketCapturesRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PacketCaptureResult>> GetAsync(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PacketCaptureResult> Get(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PacketCaptureResult> ListAsync(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            async Task<Page<PacketCaptureResult>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PacketCaptureResult> List(string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            Page<PacketCaptureResult> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkWatcherName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PacketCapturesCreateOperation> StartCreateAsync(string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateAsync(resourceGroupName, networkWatcherName, packetCaptureName, parameters, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, networkWatcherName, packetCaptureName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesCreateOperation StartCreate(string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCapture parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Create(resourceGroupName, networkWatcherName, packetCaptureName, parameters, cancellationToken);
                return new PacketCapturesCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, networkWatcherName, packetCaptureName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PacketCapturesDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesDeleteOperation StartDelete(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken);
                return new PacketCapturesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PacketCapturesStopOperation> StartStopAsync(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartStop");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StopAsync(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesStopOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesStopOperation StartStop(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartStop");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Stop(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken);
                return new PacketCapturesStopOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="packetCaptureName"> The name given to the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<PacketCapturesGetStatusOperation> StartGetStatusAsync(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartGetStatus");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.GetStatusAsync(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesGetStatusOperation(_clientDiagnostics, _pipeline, RestClient.CreateGetStatusRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="packetCaptureName"> The name given to the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesGetStatusOperation StartGetStatus(string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var scope = _clientDiagnostics.CreateScope("PacketCapturesClient.StartGetStatus");
            scope.Start();
            try
            {
                var originalResponse = RestClient.GetStatus(resourceGroupName, networkWatcherName, packetCaptureName, cancellationToken);
                return new PacketCapturesGetStatusOperation(_clientDiagnostics, _pipeline, RestClient.CreateGetStatusRequest(resourceGroupName, networkWatcherName, packetCaptureName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
