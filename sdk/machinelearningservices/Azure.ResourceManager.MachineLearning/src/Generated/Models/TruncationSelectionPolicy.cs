// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Defines an early termination policy that cancels a given percentage of runs at each evaluation interval. </summary>
    public partial class TruncationSelectionPolicy : MachineLearningEarlyTerminationPolicy
    {
        /// <summary> Initializes a new instance of <see cref="TruncationSelectionPolicy"/>. </summary>
        public TruncationSelectionPolicy()
        {
            PolicyType = EarlyTerminationPolicyType.TruncationSelection;
        }

        /// <summary> Initializes a new instance of <see cref="TruncationSelectionPolicy"/>. </summary>
        /// <param name="delayEvaluation"> Number of intervals by which to delay the first evaluation. </param>
        /// <param name="evaluationInterval"> Interval (number of runs) between policy evaluations. </param>
        /// <param name="policyType"> [Required] Name of policy configuration. </param>
        /// <param name="truncationPercentage"> The percentage of runs to cancel at each evaluation interval. </param>
        internal TruncationSelectionPolicy(int? delayEvaluation, int? evaluationInterval, EarlyTerminationPolicyType policyType, int? truncationPercentage) : base(delayEvaluation, evaluationInterval, policyType)
        {
            TruncationPercentage = truncationPercentage;
            PolicyType = policyType;
        }

        /// <summary> The percentage of runs to cancel at each evaluation interval. </summary>
        public int? TruncationPercentage { get; set; }
    }
}
