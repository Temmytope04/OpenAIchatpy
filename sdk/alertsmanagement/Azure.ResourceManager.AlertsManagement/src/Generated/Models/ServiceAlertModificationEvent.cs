// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Reason for the modification. </summary>
    public enum ServiceAlertModificationEvent
    {
        /// <summary> AlertCreated. </summary>
        AlertCreated,
        /// <summary> StateChange. </summary>
        StateChange,
        /// <summary> MonitorConditionChange. </summary>
        MonitorConditionChange,
        /// <summary> SeverityChange. </summary>
        SeverityChange,
        /// <summary> ActionRuleTriggered. </summary>
        ActionRuleTriggered,
        /// <summary> ActionRuleSuppressed. </summary>
        ActionRuleSuppressed,
        /// <summary> ActionsTriggered. </summary>
        ActionsTriggered,
        /// <summary> ActionsSuppressed. </summary>
        ActionsSuppressed,
        /// <summary> ActionsFailed. </summary>
        ActionsFailed
    }
}
