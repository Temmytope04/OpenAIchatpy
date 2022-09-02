// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The UnknownAlertProcessingRuleAction. </summary>
    internal partial class UnknownAlertProcessingRuleAction : AlertProcessingRuleAction
    {
        /// <summary> Initializes a new instance of UnknownAlertProcessingRuleAction. </summary>
        /// <param name="actionType"> Action that should be applied. </param>
        internal UnknownAlertProcessingRuleAction(AlertProcessingRuleActionType actionType) : base(actionType)
        {
            ActionType = actionType;
        }
    }
}
