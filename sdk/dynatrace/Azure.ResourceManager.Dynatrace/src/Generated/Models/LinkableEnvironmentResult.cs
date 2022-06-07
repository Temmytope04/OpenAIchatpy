// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response for getting all the linkable environments. </summary>
    public partial class LinkableEnvironmentResult
    {
        /// <summary> Initializes a new instance of LinkableEnvironmentResult. </summary>
        internal LinkableEnvironmentResult()
        {
        }

        /// <summary> Initializes a new instance of LinkableEnvironmentResult. </summary>
        /// <param name="environmentId"> environment id for which user is an admin. </param>
        /// <param name="environmentName"> Name of the environment. </param>
        /// <param name="planData"> Billing plan information. </param>
        internal LinkableEnvironmentResult(string environmentId, string environmentName, PlanData planData)
        {
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
            PlanData = planData;
        }

        /// <summary> environment id for which user is an admin. </summary>
        public string EnvironmentId { get; }
        /// <summary> Name of the environment. </summary>
        public string EnvironmentName { get; }
        /// <summary> Billing plan information. </summary>
        public PlanData PlanData { get; }
    }
}
