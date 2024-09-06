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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingProfileSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingProfileSubscriptionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingProfileSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="BillingProfileResource"/> using the GetBillingProfileSubscription method.
    /// </summary>
    public partial class BillingProfileSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingProfileSubscriptionResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="billingProfileName"> The billingProfileName. </param>
        /// <param name="billingSubscriptionName"> The billingSubscriptionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string billingSubscriptionName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/billingSubscriptions/{billingSubscriptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingProfileSubscriptionBillingSubscriptionsClientDiagnostics;
        private readonly BillingSubscriptionsRestOperations _billingProfileSubscriptionBillingSubscriptionsRestClient;
        private readonly BillingSubscriptionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingProfiles/billingSubscriptions";

        /// <summary> Initializes a new instance of the <see cref="BillingProfileSubscriptionResource"/> class for mocking. </summary>
        protected BillingProfileSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingProfileSubscriptionResource(ArmClient client, BillingSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingProfileSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingProfileSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingProfileSubscriptionBillingSubscriptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingProfileSubscriptionBillingSubscriptionsApiVersion);
            _billingProfileSubscriptionBillingSubscriptionsRestClient = new BillingSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingProfileSubscriptionBillingSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingSubscriptionData Data
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
        /// Gets a subscription by its billing profile and ID. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_GetByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Can be used to expand `Reseller`, `ConsumptionCostCenter`, `LastMonthCharges` and `MonthToDateCharges`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingProfileSubscriptionResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingProfileSubscriptionBillingSubscriptionsClientDiagnostics.CreateScope("BillingProfileSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _billingProfileSubscriptionBillingSubscriptionsRestClient.GetByBillingProfileAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription by its billing profile and ID. The operation is supported for billing accounts with agreement type Enterprise Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_GetByBillingProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingProfileSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Can be used to expand `Reseller`, `ConsumptionCostCenter`, `LastMonthCharges` and `MonthToDateCharges`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingProfileSubscriptionResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingProfileSubscriptionBillingSubscriptionsClientDiagnostics.CreateScope("BillingProfileSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _billingProfileSubscriptionBillingSubscriptionsRestClient.GetByBillingProfile(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingProfileSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
