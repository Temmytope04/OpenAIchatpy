// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The ReservationPurchaseContent. </summary>
    public partial class ReservationPurchaseContent
    {
        /// <summary> Initializes a new instance of ReservationPurchaseContent. </summary>
        public ReservationPurchaseContent()
        {
            AppliedScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ReservationPurchaseContent. </summary>
        /// <param name="sku"></param>
        /// <param name="location"> The Azure Region where the reserved resource lives. </param>
        /// <param name="reservedResourceType"> The type of the resource that is being reserved. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing Reservation. </param>
        /// <param name="term"> Represent the term of Reservation. </param>
        /// <param name="billingPlan"> Represent the billing plans. </param>
        /// <param name="quantity"> Quantity of the SKUs that are part of the Reservation. </param>
        /// <param name="displayName"> Friendly name of the Reservation. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="appliedScopes"> List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. </param>
        /// <param name="isRenewEnabled"> Setting this to true will automatically purchase a new reservation on the expiration date time. </param>
        /// <param name="reservedResourceProperties"> Properties specific to each reserved resource type. Not required if not applicable. </param>
        internal ReservationPurchaseContent(ReservationsSkuName sku, AzureLocation? location, ReservedResourceType? reservedResourceType, ResourceIdentifier billingScopeId, ReservationTerm? term, ReservationBillingPlan? billingPlan, int? quantity, string displayName, AppliedScopeType? appliedScopeType, IList<string> appliedScopes, bool? isRenewEnabled, PurchaseRequestPropertiesReservedResourceProperties reservedResourceProperties)
        {
            Sku = sku;
            Location = location;
            ReservedResourceType = reservedResourceType;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            Quantity = quantity;
            DisplayName = displayName;
            AppliedScopeType = appliedScopeType;
            AppliedScopes = appliedScopes;
            IsRenewEnabled = isRenewEnabled;
            ReservedResourceProperties = reservedResourceProperties;
        }

        /// <summary> Gets or sets the sku. </summary>
        internal ReservationsSkuName Sku { get; set; }
        /// <summary> Gets or sets the sku name. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new ReservationsSkuName();
                Sku.Name = value;
            }
        }

        /// <summary> The Azure Region where the reserved resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The type of the resource that is being reserved. </summary>
        public ReservedResourceType? ReservedResourceType { get; set; }
        /// <summary> Subscription that will be charged for purchasing Reservation. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Represent the term of Reservation. </summary>
        public ReservationTerm? Term { get; set; }
        /// <summary> Represent the billing plans. </summary>
        public ReservationBillingPlan? BillingPlan { get; set; }
        /// <summary> Quantity of the SKUs that are part of the Reservation. </summary>
        public int? Quantity { get; set; }
        /// <summary> Friendly name of the Reservation. </summary>
        public string DisplayName { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> List of the subscriptions that the benefit will be applied. Do not specify if AppliedScopeType is Shared. </summary>
        public IList<string> AppliedScopes { get; set; }
        /// <summary> Setting this to true will automatically purchase a new reservation on the expiration date time. </summary>
        public bool? IsRenewEnabled { get; set; }
        /// <summary> Properties specific to each reserved resource type. Not required if not applicable. </summary>
        internal PurchaseRequestPropertiesReservedResourceProperties ReservedResourceProperties { get; set; }
        /// <summary> Turning this on will apply the reservation discount to other VMs in the same VM size group. Only specify for VirtualMachines reserved resource type. </summary>
        public InstanceFlexibility? ReservedResourceInstanceFlexibility
        {
            get => ReservedResourceProperties is null ? default : ReservedResourceProperties.InstanceFlexibility;
            set
            {
                if (ReservedResourceProperties is null)
                    ReservedResourceProperties = new PurchaseRequestPropertiesReservedResourceProperties();
                ReservedResourceProperties.InstanceFlexibility = value;
            }
        }
    }
}
