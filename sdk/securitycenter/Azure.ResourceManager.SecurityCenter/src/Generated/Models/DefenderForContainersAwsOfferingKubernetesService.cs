// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The kubernetes service connection configuration. </summary>
    internal partial class DefenderForContainersAwsOfferingKubernetesService
    {
        /// <summary> Initializes a new instance of DefenderForContainersAwsOfferingKubernetesService. </summary>
        public DefenderForContainersAwsOfferingKubernetesService()
        {
        }

        /// <summary> Initializes a new instance of DefenderForContainersAwsOfferingKubernetesService. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature used for provisioning resources. </param>
        internal DefenderForContainersAwsOfferingKubernetesService(string cloudRoleArn)
        {
            CloudRoleArn = cloudRoleArn;
        }

        /// <summary> The cloud role ARN in AWS for this feature used for provisioning resources. </summary>
        public string CloudRoleArn { get; set; }
    }
}
