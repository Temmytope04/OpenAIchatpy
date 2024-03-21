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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingAccountPaymentMethod along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingAccountPaymentMethodResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingAccountPaymentMethodResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetBillingAccountPaymentMethod method.
    /// </summary>
    public partial class BillingAccountPaymentMethodResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingAccountPaymentMethodResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="paymentMethodName"> The paymentMethodName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string paymentMethodName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingAccountPaymentMethodPaymentMethodsClientDiagnostics;
        private readonly PaymentMethodsRestOperations _billingAccountPaymentMethodPaymentMethodsRestClient;
        private readonly BillingPaymentMethodData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/paymentMethods";

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPaymentMethodResource"/> class for mocking. </summary>
        protected BillingAccountPaymentMethodResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingAccountPaymentMethodResource(ArmClient client, BillingPaymentMethodData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingAccountPaymentMethodResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingAccountPaymentMethodPaymentMethodsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingAccountPaymentMethodPaymentMethodsApiVersion);
            _billingAccountPaymentMethodPaymentMethodsRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAccountPaymentMethodPaymentMethodsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingPaymentMethodData Data
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
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingAccountPaymentMethodResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodResource.Get");
            scope.Start();
            try
            {
                var response = await _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccountAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method available for a billing account. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAccountPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingAccountPaymentMethodResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _billingAccountPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingAccountPaymentMethodResource.Get");
            scope.Start();
            try
            {
                var response = _billingAccountPaymentMethodPaymentMethodsRestClient.GetByBillingAccount(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
