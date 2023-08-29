// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Implements InnerHealthError class. HealthError object has a list of InnerHealthErrors as child errors. InnerHealthError is used because this will prevent an infinite loop of structures when Hydra tries to auto-generate the contract. We are exposing the related health errors as inner health errors and all API consumers can utilize this in the same fashion as Exception -&gt; InnerException. </summary>
    public partial class SiteRecoveryInnerHealthError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryInnerHealthError"/>. </summary>
        internal SiteRecoveryInnerHealthError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryInnerHealthError"/>. </summary>
        /// <param name="errorSource"> Source of error. </param>
        /// <param name="errorType"> Type of error. </param>
        /// <param name="errorLevel"> Level of error. </param>
        /// <param name="errorCategory"> Category of error. </param>
        /// <param name="errorCode"> Error code. </param>
        /// <param name="summaryMessage"> Summary message of the entity. </param>
        /// <param name="errorMessage"> Error message. </param>
        /// <param name="possibleCauses"> Possible causes of error. </param>
        /// <param name="recommendedAction"> Recommended action to resolve error. </param>
        /// <param name="createdOn"> Error creation time (UTC). </param>
        /// <param name="recoveryProviderErrorMessage"> DRA error message. </param>
        /// <param name="entityId"> ID of the entity. </param>
        /// <param name="errorId"> The health error unique id. </param>
        /// <param name="customerResolvability"> Value indicating whether the health error is customer resolvable. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryInnerHealthError(string errorSource, string errorType, string errorLevel, string errorCategory, string errorCode, string summaryMessage, string errorMessage, string possibleCauses, string recommendedAction, DateTimeOffset? createdOn, string recoveryProviderErrorMessage, string entityId, string errorId, HealthErrorCustomerResolvability? customerResolvability, Dictionary<string, BinaryData> rawData)
        {
            ErrorSource = errorSource;
            ErrorType = errorType;
            ErrorLevel = errorLevel;
            ErrorCategory = errorCategory;
            ErrorCode = errorCode;
            SummaryMessage = summaryMessage;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            CreatedOn = createdOn;
            RecoveryProviderErrorMessage = recoveryProviderErrorMessage;
            EntityId = entityId;
            ErrorId = errorId;
            CustomerResolvability = customerResolvability;
            _rawData = rawData;
        }

        /// <summary> Source of error. </summary>
        public string ErrorSource { get; }
        /// <summary> Type of error. </summary>
        public string ErrorType { get; }
        /// <summary> Level of error. </summary>
        public string ErrorLevel { get; }
        /// <summary> Category of error. </summary>
        public string ErrorCategory { get; }
        /// <summary> Error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Summary message of the entity. </summary>
        public string SummaryMessage { get; }
        /// <summary> Error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Possible causes of error. </summary>
        public string PossibleCauses { get; }
        /// <summary> Recommended action to resolve error. </summary>
        public string RecommendedAction { get; }
        /// <summary> Error creation time (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> DRA error message. </summary>
        public string RecoveryProviderErrorMessage { get; }
        /// <summary> ID of the entity. </summary>
        public string EntityId { get; }
        /// <summary> The health error unique id. </summary>
        public string ErrorId { get; }
        /// <summary> Value indicating whether the health error is customer resolvable. </summary>
        public HealthErrorCustomerResolvability? CustomerResolvability { get; }
    }
}
