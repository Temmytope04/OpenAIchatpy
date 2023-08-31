// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Information about payment related to a savings plan order. </summary>
    public partial class SavingsPlanOrderPaymentDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanOrderPaymentDetail"/>. </summary>
        public SavingsPlanOrderPaymentDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanOrderPaymentDetail"/>. </summary>
        /// <param name="dueOn"> Date when the payment needs to be done. </param>
        /// <param name="payOn"> Date when the transaction is completed. Is null when it is scheduled. </param>
        /// <param name="pricingCurrencyTotal"> Amount in pricing currency. Tax not included. </param>
        /// <param name="billingCurrencyTotal"> Amount charged in Billing currency. Tax not included. Is null for future payments. </param>
        /// <param name="status"> Describes whether the payment is completed, failed, cancelled or scheduled in the future. </param>
        /// <param name="extendedStatusInfo"></param>
        /// <param name="billingAccount"> Billing account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SavingsPlanOrderPaymentDetail(DateTimeOffset? dueOn, DateTimeOffset? payOn, BillingBenefitsPrice pricingCurrencyTotal, BillingBenefitsPrice billingCurrencyTotal, BillingBenefitsPaymentStatus? status, BillingBenefitsExtendedStatusInfo extendedStatusInfo, string billingAccount, Dictionary<string, BinaryData> rawData)
        {
            DueOn = dueOn;
            PayOn = payOn;
            PricingCurrencyTotal = pricingCurrencyTotal;
            BillingCurrencyTotal = billingCurrencyTotal;
            Status = status;
            ExtendedStatusInfo = extendedStatusInfo;
            BillingAccount = billingAccount;
            _rawData = rawData;
        }

        /// <summary> Date when the payment needs to be done. </summary>
        public DateTimeOffset? DueOn { get; set; }
        /// <summary> Date when the transaction is completed. Is null when it is scheduled. </summary>
        public DateTimeOffset? PayOn { get; set; }
        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public BillingBenefitsPrice PricingCurrencyTotal { get; set; }
        /// <summary> Amount charged in Billing currency. Tax not included. Is null for future payments. </summary>
        public BillingBenefitsPrice BillingCurrencyTotal { get; set; }
        /// <summary> Describes whether the payment is completed, failed, cancelled or scheduled in the future. </summary>
        public BillingBenefitsPaymentStatus? Status { get; set; }
        /// <summary> Gets the extended status info. </summary>
        public BillingBenefitsExtendedStatusInfo ExtendedStatusInfo { get; }
        /// <summary> Billing account. </summary>
        public string BillingAccount { get; set; }
    }
}
