// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the GitHub provider. </summary>
    public partial class AppServiceGitHubProvider
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceGitHubProvider"/>. </summary>
        public AppServiceGitHubProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceGitHubProvider"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the GitHub provider. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceGitHubProvider(bool? isEnabled, ClientRegistration registration, LoginScopes login, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
            _rawData = rawData;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the GitHub provider. </summary>
        public ClientRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        internal LoginScopes Login { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> LoginScopes
        {
            get
            {
                if (Login is null)
                    Login = new LoginScopes();
                return Login.Scopes;
            }
        }
    }
}
