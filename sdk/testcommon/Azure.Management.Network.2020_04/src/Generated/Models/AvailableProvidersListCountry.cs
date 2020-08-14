// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Country details. </summary>
    public partial class AvailableProvidersListCountry
    {
        /// <summary> Initializes a new instance of AvailableProvidersListCountry. </summary>
        internal AvailableProvidersListCountry()
        {
            Providers = new ChangeTrackingList<string>();
            States = new ChangeTrackingList<AvailableProvidersListState>();
        }

        /// <summary> Initializes a new instance of AvailableProvidersListCountry. </summary>
        /// <param name="countryName"> The country name. </param>
        /// <param name="providers"> A list of Internet service providers. </param>
        /// <param name="states"> List of available states in the country. </param>
        internal AvailableProvidersListCountry(string countryName, IReadOnlyList<string> providers, IReadOnlyList<AvailableProvidersListState> states)
        {
            CountryName = countryName;
            Providers = providers;
            States = states;
        }

        /// <summary> The country name. </summary>
        public string CountryName { get; }
        /// <summary> A list of Internet service providers. </summary>
        public IReadOnlyList<string> Providers { get; }
        /// <summary> List of available states in the country. </summary>
        public IReadOnlyList<AvailableProvidersListState> States { get; }
    }
}
