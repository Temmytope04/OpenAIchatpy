// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Secrets related to a Machine Learning compute based on AKS. </summary>
    public partial class MachineLearningAksComputeSecrets : MachineLearningComputeSecrets
    {
        /// <summary> Initializes a new instance of MachineLearningAksComputeSecrets. </summary>
        internal MachineLearningAksComputeSecrets()
        {
            ComputeType = ComputeType.Aks;
        }

        /// <summary> Initializes a new instance of MachineLearningAksComputeSecrets. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="userKubeConfig"> Content of kubeconfig file that can be used to connect to the Kubernetes cluster. </param>
        /// <param name="adminKubeConfig"> Content of kubeconfig file that can be used to connect to the Kubernetes cluster. </param>
        /// <param name="imagePullSecretName"> Image registry pull secret. </param>
        internal MachineLearningAksComputeSecrets(ComputeType computeType, string userKubeConfig, string adminKubeConfig, string imagePullSecretName) : base(computeType)
        {
            UserKubeConfig = userKubeConfig;
            AdminKubeConfig = adminKubeConfig;
            ImagePullSecretName = imagePullSecretName;
            ComputeType = computeType;
        }

        /// <summary> Content of kubeconfig file that can be used to connect to the Kubernetes cluster. </summary>
        public string UserKubeConfig { get; }
        /// <summary> Content of kubeconfig file that can be used to connect to the Kubernetes cluster. </summary>
        public string AdminKubeConfig { get; }
        /// <summary> Image registry pull secret. </summary>
        public string ImagePullSecretName { get; }
    }
}
