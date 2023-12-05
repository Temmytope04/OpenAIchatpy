// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing the BillingSubscriptionAlias data model.
    /// A billing subscription alias.
    /// </summary>
    public partial class BillingSubscriptionAliasData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionAliasData"/>. </summary>
        public BillingSubscriptionAliasData()
        {
            BillingPolicies = new ChangeTrackingDictionary<string, string>();
            SuspensionReasons = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionAliasData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="autoRenew"> Indicates whether auto renewal is turned on or off for a subscription. </param>
        /// <param name="beneficiaryTenantId"> The provisioning tenant of the subscription. </param>
        /// <param name="billingFrequency"> The billing frequency of the subscription in the ISO8601 format. Example: P1M, P3M, P1Y. </param>
        /// <param name="billingProfileId"> The ID of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingPolicies"> Dictionary of billing policies associated with the subscription. </param>
        /// <param name="billingProfileDisplayName"> The display name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingProfileName"> The name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="consumptionCostCenter"> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement Type billing accounts. </param>
        /// <param name="customerId"> The ID of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="customerDisplayName"> The name of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="displayName"> The name of the subscription. </param>
        /// <param name="enrollmentAccountId"> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountDisplayName"> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="invoiceSectionId"> The ID of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionDisplayName"> The display name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionName"> The name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="lastMonthCharges"> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="monthToDateCharges"> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="nextBillingCycleDetails"> Next billing cycle details of the subscription. </param>
        /// <param name="offerId"> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts. </param>
        /// <param name="productCategory"> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </param>
        /// <param name="productType"> The type of the product for which the subscription is purchased. </param>
        /// <param name="productTypeId"> The ID of the product for which the subscription is purchased. </param>
        /// <param name="purchaseOn"> The purchase date of the subscription in UTC time. </param>
        /// <param name="quantity"> The number of licenses purchased for the subscription. </param>
        /// <param name="reseller"> The reseller for which the subscription is created. The field is available for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="renewalTermDetails"> The term details of the subscription at the next renewal. </param>
        /// <param name="skuDescription"> The SKU description of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="skuId"> The SKU ID of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="status"> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="subscriptionId"> The ID of the usage-based subscription. This field is only available for usage-based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="suspensionReasons"> The suspension reason for the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="termDuration"> The duration for which you can use the subscription. Example P1Y and P1M. </param>
        /// <param name="termStartOn"> The start date of the term in UTC time. </param>
        /// <param name="termEndOn"> The end date of the term in UTC time. </param>
        /// <param name="subscriptionEnrollmentAccountStatus"> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountStartOn"> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="billingSubscriptionId"> The ID of the billing subscription with the subscription alias. </param>
        internal BillingSubscriptionAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingSubscriptionAutoRenewState? autoRenew, string beneficiaryTenantId, string billingFrequency, ResourceIdentifier billingProfileId, IReadOnlyDictionary<string, string> billingPolicies, string billingProfileDisplayName, string billingProfileName, string consumptionCostCenter, string customerId, string customerDisplayName, string displayName, string enrollmentAccountId, string enrollmentAccountDisplayName, ResourceIdentifier invoiceSectionId, string invoiceSectionDisplayName, string invoiceSectionName, BillingAmount lastMonthCharges, BillingAmount monthToDateCharges, NextBillingCycleDetails nextBillingCycleDetails, string offerId, string productCategory, string productType, string productTypeId, DateTimeOffset? purchaseOn, long? quantity, CreatedSubscriptionReseller reseller, SubscriptionRenewalTermDetails renewalTermDetails, string skuDescription, string skuId, BillingSubscriptionStatus? status, string subscriptionId, IReadOnlyList<string> suspensionReasons, TimeSpan? termDuration, DateTimeOffset? termStartOn, DateTimeOffset? termEndOn, SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus, DateTimeOffset? enrollmentAccountStartOn, ResourceIdentifier billingSubscriptionId) : base(id, name, resourceType, systemData)
        {
            AutoRenew = autoRenew;
            BeneficiaryTenantId = beneficiaryTenantId;
            BillingFrequency = billingFrequency;
            BillingProfileId = billingProfileId;
            BillingPolicies = billingPolicies;
            BillingProfileDisplayName = billingProfileDisplayName;
            BillingProfileName = billingProfileName;
            ConsumptionCostCenter = consumptionCostCenter;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            DisplayName = displayName;
            EnrollmentAccountId = enrollmentAccountId;
            EnrollmentAccountDisplayName = enrollmentAccountDisplayName;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            InvoiceSectionName = invoiceSectionName;
            LastMonthCharges = lastMonthCharges;
            MonthToDateCharges = monthToDateCharges;
            NextBillingCycleDetails = nextBillingCycleDetails;
            OfferId = offerId;
            ProductCategory = productCategory;
            ProductType = productType;
            ProductTypeId = productTypeId;
            PurchaseOn = purchaseOn;
            Quantity = quantity;
            Reseller = reseller;
            RenewalTermDetails = renewalTermDetails;
            SkuDescription = skuDescription;
            SkuId = skuId;
            Status = status;
            SubscriptionId = subscriptionId;
            SuspensionReasons = suspensionReasons;
            TermDuration = termDuration;
            TermStartOn = termStartOn;
            TermEndOn = termEndOn;
            SubscriptionEnrollmentAccountStatus = subscriptionEnrollmentAccountStatus;
            EnrollmentAccountStartOn = enrollmentAccountStartOn;
            BillingSubscriptionId = billingSubscriptionId;
        }

        /// <summary> Indicates whether auto renewal is turned on or off for a subscription. </summary>
        public BillingSubscriptionAutoRenewState? AutoRenew { get; set; }
        /// <summary> The provisioning tenant of the subscription. </summary>
        public string BeneficiaryTenantId { get; set; }
        /// <summary> The billing frequency of the subscription in the ISO8601 format. Example: P1M, P3M, P1Y. </summary>
        public string BillingFrequency { get; set; }
        /// <summary> The ID of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </summary>
        public ResourceIdentifier BillingProfileId { get; set; }
        /// <summary> Dictionary of billing policies associated with the subscription. </summary>
        public IReadOnlyDictionary<string, string> BillingPolicies { get; }
        /// <summary> The display name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </summary>
        public string BillingProfileDisplayName { get; }
        /// <summary> The name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </summary>
        public string BillingProfileName { get; }
        /// <summary> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement Type billing accounts. </summary>
        public string ConsumptionCostCenter { get; set; }
        /// <summary> The ID of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </summary>
        public string CustomerId { get; set; }
        /// <summary> The name of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </summary>
        public string CustomerDisplayName { get; }
        /// <summary> The name of the subscription. </summary>
        public string DisplayName { get; set; }
        /// <summary> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </summary>
        public string EnrollmentAccountId { get; }
        /// <summary> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </summary>
        public string EnrollmentAccountDisplayName { get; }
        /// <summary> The ID of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </summary>
        public ResourceIdentifier InvoiceSectionId { get; set; }
        /// <summary> The display name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </summary>
        public string InvoiceSectionDisplayName { get; }
        /// <summary> The name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </summary>
        public string InvoiceSectionName { get; }
        /// <summary> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </summary>
        public BillingAmount LastMonthCharges { get; }
        /// <summary> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </summary>
        public BillingAmount MonthToDateCharges { get; }
        /// <summary> Next billing cycle details of the subscription. </summary>
        internal NextBillingCycleDetails NextBillingCycleDetails { get; }
        /// <summary> The billing frequency of the subscription in the next billing cycle. </summary>
        public string NextBillingCycleBillingFrequency
        {
            get => NextBillingCycleDetails?.NextBillingCycleBillingFrequency;
        }

        /// <summary> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts. </summary>
        public string OfferId { get; }
        /// <summary> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </summary>
        public string ProductCategory { get; }
        /// <summary> The type of the product for which the subscription is purchased. </summary>
        public string ProductType { get; }
        /// <summary> The ID of the product for which the subscription is purchased. </summary>
        public string ProductTypeId { get; set; }
        /// <summary> The purchase date of the subscription in UTC time. </summary>
        public DateTimeOffset? PurchaseOn { get; }
        /// <summary> The number of licenses purchased for the subscription. </summary>
        public long? Quantity { get; set; }
        /// <summary> The reseller for which the subscription is created. The field is available for Microsoft Partner Agreement billing accounts. </summary>
        public CreatedSubscriptionReseller Reseller { get; }
        /// <summary> The term details of the subscription at the next renewal. </summary>
        public SubscriptionRenewalTermDetails RenewalTermDetails { get; }
        /// <summary> The SKU description of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </summary>
        public string SkuDescription { get; }
        /// <summary> The SKU ID of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </summary>
        public string SkuId { get; set; }
        /// <summary> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        public BillingSubscriptionStatus? Status { get; }
        /// <summary> The ID of the usage-based subscription. This field is only available for usage-based subscriptions of Microsoft Customer Agreement billing accounts. </summary>
        public string SubscriptionId { get; }
        /// <summary> The suspension reason for the subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        public IReadOnlyList<string> SuspensionReasons { get; }
        /// <summary> The duration for which you can use the subscription. Example P1Y and P1M. </summary>
        public TimeSpan? TermDuration { get; set; }
        /// <summary> The start date of the term in UTC time. </summary>
        public DateTimeOffset? TermStartOn { get; }
        /// <summary> The end date of the term in UTC time. </summary>
        public DateTimeOffset? TermEndOn { get; }
        /// <summary> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement billing accounts. </summary>
        public SubscriptionEnrollmentAccountStatus? SubscriptionEnrollmentAccountStatus { get; }
        /// <summary> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement billing accounts. </summary>
        public DateTimeOffset? EnrollmentAccountStartOn { get; }
        /// <summary> The ID of the billing subscription with the subscription alias. </summary>
        public ResourceIdentifier BillingSubscriptionId { get; }
    }
}
