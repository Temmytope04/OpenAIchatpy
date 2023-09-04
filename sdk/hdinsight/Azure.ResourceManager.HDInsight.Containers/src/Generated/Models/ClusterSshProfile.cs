// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Ssh profile for the cluster. </summary>
    public partial class ClusterSshProfile
    {
        /// <summary> Initializes a new instance of ClusterSshProfile. </summary>
        /// <param name="count"> Number of ssh pods per cluster. </param>
        public ClusterSshProfile(int count)
        {
            Count = count;
        }

        /// <summary> Initializes a new instance of ClusterSshProfile. </summary>
        /// <param name="count"> Number of ssh pods per cluster. </param>
        /// <param name="podPrefix"> Prefix of the pod names. Pod number will be appended to the prefix. The ingress URLs for the pods will be available at &lt;clusterFqdn&gt;/&lt;sshBasePath&gt;/&lt;prefix&gt;-&lt;number&gt;. </param>
        internal ClusterSshProfile(int count, string podPrefix)
        {
            Count = count;
            PodPrefix = podPrefix;
        }

        /// <summary> Number of ssh pods per cluster. </summary>
        public int Count { get; set; }
        /// <summary> Prefix of the pod names. Pod number will be appended to the prefix. The ingress URLs for the pods will be available at &lt;clusterFqdn&gt;/&lt;sshBasePath&gt;/&lt;prefix&gt;-&lt;number&gt;. </summary>
        public string PodPrefix { get; }
    }
}
