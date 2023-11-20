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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a ComplianceResult along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ComplianceResultResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetComplianceResultResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetComplianceResult method.
    /// </summary>
    public partial class ComplianceResultResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ComplianceResultResource"/> instance. </summary>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="complianceResultName"> The complianceResultName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, string complianceResultName)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _complianceResultClientDiagnostics;
        private readonly ComplianceResultsRestOperations _complianceResultRestClient;
        private readonly ComplianceResultData _data;

        /// <summary> Initializes a new instance of the <see cref="ComplianceResultResource"/> class for mocking. </summary>
        protected ComplianceResultResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ComplianceResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ComplianceResultResource(ArmClient client, ComplianceResultData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ComplianceResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ComplianceResultResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _complianceResultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string complianceResultApiVersion);
            _complianceResultRestClient = new ComplianceResultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, complianceResultApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/complianceResults";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ComplianceResultData Data
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
        /// Security Compliance Result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComplianceResults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ComplianceResultResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultResource.Get");
            scope.Start();
            try
            {
                var response = await _complianceResultRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComplianceResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Security Compliance Result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComplianceResults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ComplianceResultResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultResource.Get");
            scope.Start();
            try
            {
                var response = _complianceResultRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComplianceResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
