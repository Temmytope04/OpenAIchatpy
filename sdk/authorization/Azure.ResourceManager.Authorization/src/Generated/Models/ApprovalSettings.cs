// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary>
    /// The approval settings.
    /// Serialized Name: ApprovalSettings
    /// </summary>
    public partial class ApprovalSettings
    {
        /// <summary> Initializes a new instance of ApprovalSettings. </summary>
        public ApprovalSettings()
        {
            ApprovalStages = new ChangeTrackingList<ApprovalStage>();
        }

        /// <summary> Initializes a new instance of ApprovalSettings. </summary>
        /// <param name="isApprovalRequired">
        /// Determines whether approval is required or not.
        /// Serialized Name: ApprovalSettings.isApprovalRequired
        /// </param>
        /// <param name="isApprovalRequiredForExtension">
        /// Determines whether approval is required for assignment extension.
        /// Serialized Name: ApprovalSettings.isApprovalRequiredForExtension
        /// </param>
        /// <param name="isRequestorJustificationRequired">
        /// Determine whether requestor justification is required.
        /// Serialized Name: ApprovalSettings.isRequestorJustificationRequired
        /// </param>
        /// <param name="approvalMode">
        /// The type of rule
        /// Serialized Name: ApprovalSettings.approvalMode
        /// </param>
        /// <param name="approvalStages">
        /// The approval stages of the request.
        /// Serialized Name: ApprovalSettings.approvalStages
        /// </param>
        internal ApprovalSettings(bool? isApprovalRequired, bool? isApprovalRequiredForExtension, bool? isRequestorJustificationRequired, ApprovalMode? approvalMode, IList<ApprovalStage> approvalStages)
        {
            IsApprovalRequired = isApprovalRequired;
            IsApprovalRequiredForExtension = isApprovalRequiredForExtension;
            IsRequestorJustificationRequired = isRequestorJustificationRequired;
            ApprovalMode = approvalMode;
            ApprovalStages = approvalStages;
        }

        /// <summary>
        /// Determines whether approval is required or not.
        /// Serialized Name: ApprovalSettings.isApprovalRequired
        /// </summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>
        /// Determines whether approval is required for assignment extension.
        /// Serialized Name: ApprovalSettings.isApprovalRequiredForExtension
        /// </summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>
        /// Determine whether requestor justification is required.
        /// Serialized Name: ApprovalSettings.isRequestorJustificationRequired
        /// </summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>
        /// The type of rule
        /// Serialized Name: ApprovalSettings.approvalMode
        /// </summary>
        public ApprovalMode? ApprovalMode { get; set; }
        /// <summary>
        /// The approval stages of the request.
        /// Serialized Name: ApprovalSettings.approvalStages
        /// </summary>
        public IList<ApprovalStage> ApprovalStages { get; }
    }
}
