// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a country. </summary>
    public partial class PhoneNumberCountry
    {
        /// <summary> Initializes a new instance of PhoneNumberCountry. </summary>
        /// <param name="localizedName"> Represents the name of the country. </param>
        /// <param name="countryCode"> Represents the abbreviated name of the country. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localizedName"/> or <paramref name="countryCode"/> is null. </exception>
        internal PhoneNumberCountry(string localizedName, string countryCode)
        {
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }

            LocalizedName = localizedName;
            CountryCode = countryCode;
        }

        /// <summary> Represents the name of the country. </summary>
        public string LocalizedName { get; }
        /// <summary> Represents the abbreviated name of the country. </summary>
        public string CountryCode { get; }
    }
}
