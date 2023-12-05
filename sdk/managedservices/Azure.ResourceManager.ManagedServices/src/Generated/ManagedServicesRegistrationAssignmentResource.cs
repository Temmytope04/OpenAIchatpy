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

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A Class representing a ManagedServicesRegistrationAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedServicesRegistrationAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedServicesRegistrationAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetManagedServicesRegistrationAssignment method.
    /// </summary>
    public partial class ManagedServicesRegistrationAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedServicesRegistrationAssignmentResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="registrationAssignmentId"> The registrationAssignmentId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string registrationAssignmentId)
        {
            var resourceId = $"{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics;
        private readonly RegistrationAssignmentsRestOperations _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient;
        private readonly ManagedServicesRegistrationAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedServices/registrationAssignments";

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesRegistrationAssignmentResource"/> class for mocking. </summary>
        protected ManagedServicesRegistrationAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesRegistrationAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedServicesRegistrationAssignmentResource(ArmClient client, ManagedServicesRegistrationAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesRegistrationAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedServicesRegistrationAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedServicesRegistrationAssignmentRegistrationAssignmentsApiVersion);
            _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient = new RegistrationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedServicesRegistrationAssignmentRegistrationAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedServicesRegistrationAssignmentData Data
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
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedServicesRegistrationAssignmentResource>> GetAsync(bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.GetAsync(Id.Parent, Id.Name, expandRegistrationDefinition, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedServicesRegistrationAssignmentResource> Get(bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.Get(Id.Parent, Id.Name, expandRegistrationDefinition, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesRegistrationAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServicesArmOperation(_managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics, Pipeline, _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ManagedServicesArmOperation(_managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics, Pipeline, _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters required to create new registration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedServicesRegistrationAssignmentResource>> UpdateAsync(WaitUntil waitUntil, ManagedServicesRegistrationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServicesArmOperation<ManagedServicesRegistrationAssignmentResource>(new ManagedServicesRegistrationAssignmentOperationSource(Client), _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics, Pipeline, _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters required to create new registration assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedServicesRegistrationAssignmentResource> Update(WaitUntil waitUntil, ManagedServicesRegistrationAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics.CreateScope("ManagedServicesRegistrationAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new ManagedServicesArmOperation<ManagedServicesRegistrationAssignmentResource>(new ManagedServicesRegistrationAssignmentOperationSource(Client), _managedServicesRegistrationAssignmentRegistrationAssignmentsClientDiagnostics, Pipeline, _managedServicesRegistrationAssignmentRegistrationAssignmentsRestClient.CreateCreateOrUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
