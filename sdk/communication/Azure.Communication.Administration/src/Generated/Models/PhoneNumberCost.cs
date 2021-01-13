// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Administration.Models
{
    /// <summary> The monthly incurred cost for a single phone number. </summary>
    public partial class PhoneNumberCost
    {
        /// <summary> Initializes a new instance of PhoneNumberCost. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="currencyCode"> The ISO 4217 currency code for the cost amount. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="currencyCode"/> is null. </exception>
        internal PhoneNumberCost(double amount, string currencyCode)
        {
            if (currencyCode == null)
            {
                throw new ArgumentNullException(nameof(currencyCode));
            }

            Amount = amount;
            CurrencyCode = currencyCode;
            BillingFrequency = "monthly";
        }

        /// <summary> Initializes a new instance of PhoneNumberCost. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="currencyCode"> The ISO 4217 currency code for the cost amount. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        internal PhoneNumberCost(double amount, string currencyCode, string billingFrequency)
        {
            Amount = amount;
            CurrencyCode = currencyCode;
            BillingFrequency = billingFrequency;
        }

        /// <summary> The cost amount. </summary>
        public double Amount { get; }
        /// <summary> The ISO 4217 currency code for the cost amount. </summary>
        public string CurrencyCode { get; }
        /// <summary> The frequency with which the cost gets billed. </summary>
        public string BillingFrequency { get; }
    }
}
