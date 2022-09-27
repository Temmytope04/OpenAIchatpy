// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary>
    /// Subscription information.
    /// Serialized Name: Subscription
    /// </summary>
    public partial class Subscription
    {
        /// <summary> Initializes a new instance of Subscription. </summary>
        internal Subscription()
        {
        }

        /// <summary> Initializes a new instance of Subscription. </summary>
        /// <param name="id">
        /// The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000.
        /// Serialized Name: Subscription.id
        /// </param>
        /// <param name="subscriptionId">
        /// The subscription ID.
        /// Serialized Name: Subscription.subscriptionId
        /// </param>
        /// <param name="displayName">
        /// The subscription display name.
        /// Serialized Name: Subscription.displayName
        /// </param>
        /// <param name="state">
        /// The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted.
        /// Serialized Name: Subscription.state
        /// </param>
        internal Subscription(string id, string subscriptionId, string displayName, SubscriptionState? state)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            DisplayName = displayName;
            State = state;
        }

        /// <summary>
        /// The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000.
        /// Serialized Name: Subscription.id
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The subscription ID.
        /// Serialized Name: Subscription.subscriptionId
        /// </summary>
        public string SubscriptionId { get; }
        /// <summary>
        /// The subscription display name.
        /// Serialized Name: Subscription.displayName
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted.
        /// Serialized Name: Subscription.state
        /// </summary>
        public SubscriptionState? State { get; }
    }
}
