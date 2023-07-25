// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationWebhook data model.
    /// Definition of the webhook type.
    /// </summary>
    public partial class AutomationWebhookData : ResourceData
    {
        /// <summary> Initializes a new instance of AutomationWebhookData. </summary>
        public AutomationWebhookData()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AutomationWebhookData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Gets or sets the value of the enabled flag of the webhook. </param>
        /// <param name="uri"> Gets or sets the webhook uri. </param>
        /// <param name="expireOn"> Gets or sets the expiry time. </param>
        /// <param name="lastInvokedOn"> Gets or sets the last invoked time. </param>
        /// <param name="parameters"> Gets or sets the parameters of the job that is created when the webhook calls the runbook it is associated with. </param>
        /// <param name="runbook"> Gets or sets the runbook the webhook is associated with. </param>
        /// <param name="runOn"> Gets or sets the name of the hybrid worker group the webhook job will run on. </param>
        /// <param name="createdOn"> Gets or sets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="lastModifiedBy"> Details of the user who last modified the Webhook. </param>
        /// <param name="description"> Gets or sets the description. </param>
        internal AutomationWebhookData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled, Uri uri, DateTimeOffset? expireOn, DateTimeOffset? lastInvokedOn, IDictionary<string, string> parameters, RunbookAssociationProperty runbook, string runOn, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string lastModifiedBy, string description) : base(id, name, resourceType, systemData)
        {
            IsEnabled = isEnabled;
            Uri = uri;
            ExpireOn = expireOn;
            LastInvokedOn = lastInvokedOn;
            Parameters = parameters;
            Runbook = runbook;
            RunOn = runOn;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            LastModifiedBy = lastModifiedBy;
            Description = description;
        }

        /// <summary> Gets or sets the value of the enabled flag of the webhook. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets or sets the webhook uri. </summary>
        public Uri Uri { get; set; }
        /// <summary> Gets or sets the expiry time. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Gets or sets the last invoked time. </summary>
        public DateTimeOffset? LastInvokedOn { get; set; }
        /// <summary> Gets or sets the parameters of the job that is created when the webhook calls the runbook it is associated with. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the runbook the webhook is associated with. </summary>
        internal RunbookAssociationProperty Runbook { get; set; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook is null ? default : Runbook.Name;
            set
            {
                if (Runbook is null)
                    Runbook = new RunbookAssociationProperty();
                Runbook.Name = value;
            }
        }

        /// <summary> Gets or sets the name of the hybrid worker group the webhook job will run on. </summary>
        public string RunOn { get; set; }
        /// <summary> Gets or sets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> Details of the user who last modified the Webhook. </summary>
        public string LastModifiedBy { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
