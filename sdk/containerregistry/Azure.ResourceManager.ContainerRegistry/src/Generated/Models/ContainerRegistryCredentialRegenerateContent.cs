// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters used to regenerate the login credential. </summary>
    public partial class ContainerRegistryCredentialRegenerateContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialRegenerateContent"/>. </summary>
        /// <param name="name"> Specifies name of the password which should be regenerated -- password or password2. </param>
        public ContainerRegistryCredentialRegenerateContent(ContainerRegistryPasswordName name)
        {
            Name = name;
        }

        /// <summary> Specifies name of the password which should be regenerated -- password or password2. </summary>
        public ContainerRegistryPasswordName Name { get; }
    }
}
