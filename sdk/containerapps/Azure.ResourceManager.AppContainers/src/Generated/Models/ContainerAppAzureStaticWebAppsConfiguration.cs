// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Azure Static Web Apps provider. </summary>
    public partial class ContainerAppAzureStaticWebAppsConfiguration
    {
        /// <summary> Initializes a new instance of ContainerAppAzureStaticWebAppsConfiguration. </summary>
        public ContainerAppAzureStaticWebAppsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppAzureStaticWebAppsConfiguration. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Azure Static Web Apps registration. </param>
        internal ContainerAppAzureStaticWebAppsConfiguration(bool? isEnabled, AzureStaticWebAppsRegistration registration)
        {
            IsEnabled = isEnabled;
            Registration = registration;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the Azure Static Web Apps registration. </summary>
        internal AzureStaticWebAppsRegistration Registration { get; set; }
        /// <summary> The Client ID of the app used for login. </summary>
        public string RegistrationClientId
        {
            get => Registration is null ? default : Registration.ClientId;
            set
            {
                if (Registration is null)
                    Registration = new AzureStaticWebAppsRegistration();
                Registration.ClientId = value;
            }
        }
    }
}
