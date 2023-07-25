// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Mapping Error Messages to Codes. </summary>
    public readonly partial struct PhoneNumberSearchResultError : IEquatable<PhoneNumberSearchResultError>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberSearchResultError"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhoneNumberSearchResultError(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoErrorValue = "NoError";
        private const string UnknownErrorCodeValue = "UnknownErrorCode";
        private const string OutOfStockValue = "OutOfStock";
        private const string AuthorizationDeniedValue = "AuthorizationDenied";
        private const string MissingAddressValue = "MissingAddress";
        private const string InvalidAddressValue = "InvalidAddress";
        private const string InvalidOfferModelValue = "InvalidOfferModel";
        private const string NotEnoughLicensesValue = "NotEnoughLicenses";
        private const string NoWalletValue = "NoWallet";
        private const string NotEnoughCreditValue = "NotEnoughCredit";
        private const string NumbersPartiallyAcquiredValue = "NumbersPartiallyAcquired";
        private const string AllNumbersNotAcquiredValue = "AllNumbersNotAcquired";
        private const string ReservationExpiredValue = "ReservationExpired";
        private const string PurchaseFailedValue = "PurchaseFailed";
        private const string BillingUnavailableValue = "BillingUnavailable";
        private const string ProvisioningFailedValue = "ProvisioningFailed";
        private const string UnknownSearchErrorValue = "UnknownSearchError";

        /// <summary> NoError. </summary>
        public static PhoneNumberSearchResultError NoError { get; } = new PhoneNumberSearchResultError(NoErrorValue);
        /// <summary> UnknownErrorCode. </summary>
        public static PhoneNumberSearchResultError UnknownErrorCode { get; } = new PhoneNumberSearchResultError(UnknownErrorCodeValue);
        /// <summary> OutOfStock. </summary>
        public static PhoneNumberSearchResultError OutOfStock { get; } = new PhoneNumberSearchResultError(OutOfStockValue);
        /// <summary> AuthorizationDenied. </summary>
        public static PhoneNumberSearchResultError AuthorizationDenied { get; } = new PhoneNumberSearchResultError(AuthorizationDeniedValue);
        /// <summary> MissingAddress. </summary>
        public static PhoneNumberSearchResultError MissingAddress { get; } = new PhoneNumberSearchResultError(MissingAddressValue);
        /// <summary> InvalidAddress. </summary>
        public static PhoneNumberSearchResultError InvalidAddress { get; } = new PhoneNumberSearchResultError(InvalidAddressValue);
        /// <summary> InvalidOfferModel. </summary>
        public static PhoneNumberSearchResultError InvalidOfferModel { get; } = new PhoneNumberSearchResultError(InvalidOfferModelValue);
        /// <summary> NotEnoughLicenses. </summary>
        public static PhoneNumberSearchResultError NotEnoughLicenses { get; } = new PhoneNumberSearchResultError(NotEnoughLicensesValue);
        /// <summary> NoWallet. </summary>
        public static PhoneNumberSearchResultError NoWallet { get; } = new PhoneNumberSearchResultError(NoWalletValue);
        /// <summary> NotEnoughCredit. </summary>
        public static PhoneNumberSearchResultError NotEnoughCredit { get; } = new PhoneNumberSearchResultError(NotEnoughCreditValue);
        /// <summary> NumbersPartiallyAcquired. </summary>
        public static PhoneNumberSearchResultError NumbersPartiallyAcquired { get; } = new PhoneNumberSearchResultError(NumbersPartiallyAcquiredValue);
        /// <summary> AllNumbersNotAcquired. </summary>
        public static PhoneNumberSearchResultError AllNumbersNotAcquired { get; } = new PhoneNumberSearchResultError(AllNumbersNotAcquiredValue);
        /// <summary> ReservationExpired. </summary>
        public static PhoneNumberSearchResultError ReservationExpired { get; } = new PhoneNumberSearchResultError(ReservationExpiredValue);
        /// <summary> PurchaseFailed. </summary>
        public static PhoneNumberSearchResultError PurchaseFailed { get; } = new PhoneNumberSearchResultError(PurchaseFailedValue);
        /// <summary> BillingUnavailable. </summary>
        public static PhoneNumberSearchResultError BillingUnavailable { get; } = new PhoneNumberSearchResultError(BillingUnavailableValue);
        /// <summary> ProvisioningFailed. </summary>
        public static PhoneNumberSearchResultError ProvisioningFailed { get; } = new PhoneNumberSearchResultError(ProvisioningFailedValue);
        /// <summary> UnknownSearchError. </summary>
        public static PhoneNumberSearchResultError UnknownSearchError { get; } = new PhoneNumberSearchResultError(UnknownSearchErrorValue);
        /// <summary> Determines if two <see cref="PhoneNumberSearchResultError"/> values are the same. </summary>
        public static bool operator ==(PhoneNumberSearchResultError left, PhoneNumberSearchResultError right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PhoneNumberSearchResultError"/> values are not the same. </summary>
        public static bool operator !=(PhoneNumberSearchResultError left, PhoneNumberSearchResultError right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PhoneNumberSearchResultError"/>. </summary>
        public static implicit operator PhoneNumberSearchResultError(string value) => new PhoneNumberSearchResultError(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhoneNumberSearchResultError other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PhoneNumberSearchResultError other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
