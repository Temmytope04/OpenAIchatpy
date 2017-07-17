// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Properties used to create a user used to execute tasks on an Azure
    /// Batch node.
    /// </summary>
    public partial class UserAccount
    {
        /// <summary>
        /// Initializes a new instance of the UserAccount class.
        /// </summary>
        public UserAccount() { }

        /// <summary>
        /// Initializes a new instance of the UserAccount class.
        /// </summary>
        /// <param name="name">The name of the user account.</param>
        /// <param name="password">The password for the user account.</param>
        /// <param name="elevationLevel">The elevation level of the user
        /// account.</param>
        /// <param name="linuxUserConfiguration">The Linux-specific user
        /// configuration for the user account.</param>
        public UserAccount(string name, string password, ElevationLevel? elevationLevel = default(ElevationLevel?), LinuxUserConfiguration linuxUserConfiguration = default(LinuxUserConfiguration))
        {
            this.Name = name;
            this.Password = password;
            this.ElevationLevel = elevationLevel;
            this.LinuxUserConfiguration = linuxUserConfiguration;
        }

        /// <summary>
        /// Gets or sets the name of the user account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the password for the user account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the elevation level of the user account.
        /// </summary>
        /// <remarks>
        /// nonAdmin - The auto user is a standard user without elevated
        /// access. admin - The auto user is a user with elevated access and
        /// operates with full Administrator permissions. The default value is
        /// nonAdmin. Possible values include: 'nonAdmin', 'admin'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "elevationLevel")]
        public ElevationLevel? ElevationLevel { get; set; }

        /// <summary>
        /// Gets or sets the Linux-specific user configuration for the user
        /// account.
        /// </summary>
        /// <remarks>
        /// This property is ignored if specified on a Windows pool. If not
        /// specified, the user is created with the default options.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linuxUserConfiguration")]
        public LinuxUserConfiguration LinuxUserConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.Password == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
