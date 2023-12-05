// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The ID of the subscriptions that is being renamed. </summary>
    public partial class RenamedSubscriptionId
    {
        /// <summary> Initializes a new instance of <see cref="RenamedSubscriptionId"/>. </summary>
        internal RenamedSubscriptionId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RenamedSubscriptionId"/>. </summary>
        /// <param name="subscriptionId"> The ID of the subscriptions that is being renamed. </param>
        internal RenamedSubscriptionId(string subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        /// <summary> The ID of the subscriptions that is being renamed. </summary>
        public string SubscriptionId { get; }
    }
}
