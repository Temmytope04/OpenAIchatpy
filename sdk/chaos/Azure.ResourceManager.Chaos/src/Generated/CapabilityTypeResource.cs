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

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A Class representing a CapabilityType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CapabilityTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCapabilityTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="TargetTypeResource"/> using the GetCapabilityType method.
    /// </summary>
    public partial class CapabilityTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CapabilityTypeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="targetTypeName"> The targetTypeName. </param>
        /// <param name="capabilityTypeName"> The capabilityTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName, string capabilityTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _capabilityTypeClientDiagnostics;
        private readonly CapabilityTypesRestOperations _capabilityTypeRestClient;
        private readonly CapabilityTypeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Chaos/locations/targetTypes/capabilityTypes";

        /// <summary> Initializes a new instance of the <see cref="CapabilityTypeResource"/> class for mocking. </summary>
        protected CapabilityTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CapabilityTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CapabilityTypeResource(ArmClient client, CapabilityTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CapabilityTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CapabilityTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _capabilityTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string capabilityTypeApiVersion);
            _capabilityTypeRestClient = new CapabilityTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, capabilityTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CapabilityTypeData Data
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
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CapabilityTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _capabilityTypeClientDiagnostics.CreateScope("CapabilityTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _capabilityTypeRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapabilityTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CapabilityTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _capabilityTypeClientDiagnostics.CreateScope("CapabilityTypeResource.Get");
            scope.Start();
            try
            {
                var response = _capabilityTypeRestClient.Get(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapabilityTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
