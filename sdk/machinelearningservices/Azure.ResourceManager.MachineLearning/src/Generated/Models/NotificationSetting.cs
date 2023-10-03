// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Configuration for notification. </summary>
    public partial class NotificationSetting
    {
        /// <summary> Initializes a new instance of NotificationSetting. </summary>
        public NotificationSetting()
        {
            EmailOn = new ChangeTrackingList<EmailNotificationEnableType>();
            Emails = new ChangeTrackingList<string>();
            Webhooks = new ChangeTrackingDictionary<string, MachineLearningWebhook>();
        }

        /// <summary> Initializes a new instance of NotificationSetting. </summary>
        /// <param name="emailOn"> Send email notification to user on specified notification type. </param>
        /// <param name="emails"> This is the email recipient list which has a limitation of 499 characters in total concat with comma separator. </param>
        /// <param name="webhooks">
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
        /// </param>
        internal NotificationSetting(IList<EmailNotificationEnableType> emailOn, IList<string> emails, IDictionary<string, MachineLearningWebhook> webhooks)
        {
            EmailOn = emailOn;
            Emails = emails;
            Webhooks = webhooks;
        }

        /// <summary> Send email notification to user on specified notification type. </summary>
        public IList<EmailNotificationEnableType> EmailOn { get; set; }
        /// <summary> This is the email recipient list which has a limitation of 499 characters in total concat with comma separator. </summary>
        public IList<string> Emails { get; set; }
        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
        /// </summary>
        public IDictionary<string, MachineLearningWebhook> Webhooks { get; set; }
    }
}
