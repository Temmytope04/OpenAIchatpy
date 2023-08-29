// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning. </summary>
    public partial class ImmutableStorageAccount
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImmutableStorageAccount"/>. </summary>
        public ImmutableStorageAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImmutableStorageAccount"/>. </summary>
        /// <param name="isEnabled"> A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability enabled by default. </param>
        /// <param name="immutabilityPolicy"> Specifies the default account-level immutability policy which is inherited and applied to objects that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher precedence than the container-level immutability policy, which has a higher precedence than the account-level immutability policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImmutableStorageAccount(bool? isEnabled, AccountImmutabilityPolicy immutabilityPolicy, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            ImmutabilityPolicy = immutabilityPolicy;
            _rawData = rawData;
        }

        /// <summary> A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability enabled by default. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Specifies the default account-level immutability policy which is inherited and applied to objects that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher precedence than the container-level immutability policy, which has a higher precedence than the account-level immutability policy. </summary>
        public AccountImmutabilityPolicy ImmutabilityPolicy { get; set; }
    }
}
