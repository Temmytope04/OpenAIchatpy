// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// User crendentials used for publishing activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UserInner : Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        public UserInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        /// <param name="userName">Username</param>
        /// <param name="publishingUserName">Username used for
        /// publishing.</param>
        /// <param name="publishingPassword">Password used for
        /// publishing.</param>
        /// <param name="publishingPasswordHash">Password hash used for
        /// publishing.</param>
        /// <param name="publishingPasswordHashSalt">Password hash salt used
        /// for publishing.</param>
        public UserInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string userName = default(string), string publishingUserName = default(string), string publishingPassword = default(string), string publishingPasswordHash = default(string), string publishingPasswordHashSalt = default(string))
            : base(location, id, name, type, tags)
        {
            UserName = userName;
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets username used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUserName")]
        public string PublishingUserName { get; set; }

        /// <summary>
        /// Gets or sets password used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// Gets or sets password hash used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }

        /// <summary>
        /// Gets or sets password hash salt used for publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }

    }
}
