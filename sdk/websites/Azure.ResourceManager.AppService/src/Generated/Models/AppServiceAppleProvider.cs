// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Apple provider. </summary>
    public partial class AppServiceAppleProvider
    {
        /// <summary> Initializes a new instance of AppServiceAppleProvider. </summary>
        public AppServiceAppleProvider()
        {
        }

        /// <summary> Initializes a new instance of AppServiceAppleProvider. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Apple registration. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        internal AppServiceAppleProvider(bool? isEnabled, AppServiceAppleRegistration registration, LoginScopes login)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the Apple registration. </summary>
        public AppServiceAppleRegistration Registration { get; set; }
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
