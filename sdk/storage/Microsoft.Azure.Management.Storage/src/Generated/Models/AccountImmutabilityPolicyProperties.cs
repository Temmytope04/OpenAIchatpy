// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This defines account-level immutability policy properties.
    /// </summary>
    public partial class AccountImmutabilityPolicyProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AccountImmutabilityPolicyProperties class.
        /// </summary>
        public AccountImmutabilityPolicyProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AccountImmutabilityPolicyProperties class.
        /// </summary>
        /// <param name="immutabilityPeriodSinceCreationInDays">The
        /// immutability period for the blobs in the container since the policy
        /// creation, in days.</param>
        /// <param name="state">The ImmutabilityPolicy state defines the mode
        /// of the policy. Disabled state disables the policy, Unlocked state
        /// allows increase and decrease of immutability retention time and
        /// also allows toggling allowProtectedAppendWrites property, Locked
        /// state only allows the increase of the immutability retention time.
        /// A policy can only be created in a Disabled or Unlocked state and
        /// can be toggled between the two states. Only a policy in an Unlocked
        /// state can transition to a Locked state which cannot be reverted.
        /// Possible values include: 'Unlocked', 'Locked', 'Disabled'</param>
        /// <param name="allowProtectedAppendWrites">This property can only be
        /// changed for disabled and unlocked time-based retention policies.
        /// When enabled, new blocks can be written to an append blob while
        /// maintaining immutability protection and compliance. Only new blocks
        /// can be added and any existing blocks cannot be modified or
        /// deleted.</param>
        public AccountImmutabilityPolicyProperties(int? immutabilityPeriodSinceCreationInDays = default(int?), string state = default(string), bool? allowProtectedAppendWrites = default(bool?))
        {
            ImmutabilityPeriodSinceCreationInDays = immutabilityPeriodSinceCreationInDays;
            State = state;
            AllowProtectedAppendWrites = allowProtectedAppendWrites;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the immutability period for the blobs in the container
        /// since the policy creation, in days.
        /// </summary>
        [JsonProperty(PropertyName = "immutabilityPeriodSinceCreationInDays")]
        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

        /// <summary>
        /// Gets or sets the ImmutabilityPolicy state defines the mode of the
        /// policy. Disabled state disables the policy, Unlocked state allows
        /// increase and decrease of immutability retention time and also
        /// allows toggling allowProtectedAppendWrites property, Locked state
        /// only allows the increase of the immutability retention time. A
        /// policy can only be created in a Disabled or Unlocked state and can
        /// be toggled between the two states. Only a policy in an Unlocked
        /// state can transition to a Locked state which cannot be reverted.
        /// Possible values include: 'Unlocked', 'Locked', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets this property can only be changed for disabled and
        /// unlocked time-based retention policies. When enabled, new blocks
        /// can be written to an append blob while maintaining immutability
        /// protection and compliance. Only new blocks can be added and any
        /// existing blocks cannot be modified or deleted.
        /// </summary>
        [JsonProperty(PropertyName = "allowProtectedAppendWrites")]
        public bool? AllowProtectedAppendWrites { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImmutabilityPeriodSinceCreationInDays != null)
            {
                if (ImmutabilityPeriodSinceCreationInDays > 146000)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "ImmutabilityPeriodSinceCreationInDays", 146000);
                }
                if (ImmutabilityPeriodSinceCreationInDays < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ImmutabilityPeriodSinceCreationInDays", 1);
                }
            }
        }
    }
}
