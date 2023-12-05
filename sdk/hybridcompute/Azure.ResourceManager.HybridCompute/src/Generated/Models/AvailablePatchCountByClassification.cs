// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Summarization of patches available for installation on the machine by classification. </summary>
    public partial class AvailablePatchCountByClassification
    {
        /// <summary> Initializes a new instance of <see cref="AvailablePatchCountByClassification"/>. </summary>
        internal AvailablePatchCountByClassification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailablePatchCountByClassification"/>. </summary>
        /// <param name="security"> Number of security patches available for installation. </param>
        /// <param name="critical"> Number of critical patches available for installation. </param>
        /// <param name="definition"> Number of definition patches available for installation. </param>
        /// <param name="updateRollup"> Number of update Rollup patches available for installation. </param>
        /// <param name="featurePack"> Number of feature pack patches available for installation. </param>
        /// <param name="servicePack"> Number of service pack patches available for installation. </param>
        /// <param name="tools"> Number of tools patches available for installation. </param>
        /// <param name="updates"> Number of updates category patches available for installation. </param>
        /// <param name="other"> Number of other patches available for installation. </param>
        internal AvailablePatchCountByClassification(int? security, int? critical, int? definition, int? updateRollup, int? featurePack, int? servicePack, int? tools, int? updates, int? other)
        {
            Security = security;
            Critical = critical;
            Definition = definition;
            UpdateRollup = updateRollup;
            FeaturePack = featurePack;
            ServicePack = servicePack;
            Tools = tools;
            Updates = updates;
            Other = other;
        }

        /// <summary> Number of security patches available for installation. </summary>
        public int? Security { get; }
        /// <summary> Number of critical patches available for installation. </summary>
        public int? Critical { get; }
        /// <summary> Number of definition patches available for installation. </summary>
        public int? Definition { get; }
        /// <summary> Number of update Rollup patches available for installation. </summary>
        public int? UpdateRollup { get; }
        /// <summary> Number of feature pack patches available for installation. </summary>
        public int? FeaturePack { get; }
        /// <summary> Number of service pack patches available for installation. </summary>
        public int? ServicePack { get; }
        /// <summary> Number of tools patches available for installation. </summary>
        public int? Tools { get; }
        /// <summary> Number of updates category patches available for installation. </summary>
        public int? Updates { get; }
        /// <summary> Number of other patches available for installation. </summary>
        public int? Other { get; }
    }
}
