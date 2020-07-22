// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AWS cloud account connector based credentials, the credentials is
    /// composed of access key id and secret key, for more details, refer to
    /// &lt;a
    /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_create.html"&gt;Creating
    /// an IAM User in Your AWS Account (write only)&lt;/a&gt;
    /// </summary>
    [Newtonsoft.Json.JsonObject("awsCreds")]
    public partial class AwsCredsAuthenticationDetailsProperties : AuthenticationDetailsProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AwsCredsAuthenticationDetailsProperties class.
        /// </summary>
        public AwsCredsAuthenticationDetailsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AwsCredsAuthenticationDetailsProperties class.
        /// </summary>
        /// <param name="awsAccessKeyId">Public key element of the AWS
        /// credential object (write only)</param>
        /// <param name="awsSecretAccessKey">Secret key element of the AWS
        /// credential object (write only)</param>
        /// <param name="authenticationProvisioningState">State of the
        /// multi-cloud connector. Possible values include: 'Valid', 'Invalid',
        /// 'Expired', 'IncorrectPolicy'</param>
        /// <param name="grantedPermissions">The permissions detected in the
        /// cloud account.</param>
        /// <param name="accountId">The ID of the cloud account</param>
        public AwsCredsAuthenticationDetailsProperties(string awsAccessKeyId, string awsSecretAccessKey, string authenticationProvisioningState = default(string), IList<string> grantedPermissions = default(IList<string>), string accountId = default(string))
            : base(authenticationProvisioningState, grantedPermissions)
        {
            AccountId = accountId;
            AwsAccessKeyId = awsAccessKeyId;
            AwsSecretAccessKey = awsSecretAccessKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the cloud account
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets or sets public key element of the AWS credential object (write
        /// only)
        /// </summary>
        [JsonProperty(PropertyName = "awsAccessKeyId")]
        public string AwsAccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets secret key element of the AWS credential object (write
        /// only)
        /// </summary>
        [JsonProperty(PropertyName = "awsSecretAccessKey")]
        public string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AwsAccessKeyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AwsAccessKeyId");
            }
            if (AwsSecretAccessKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AwsSecretAccessKey");
            }
        }
    }
}
