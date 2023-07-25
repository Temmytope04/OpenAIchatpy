// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> QoS policy. </summary>
    public partial class QosPolicy
    {
        /// <summary> Initializes a new instance of QosPolicy. </summary>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maximumBitRate"/> is null. </exception>
        public QosPolicy(Ambr maximumBitRate)
        {
            Argument.AssertNotNull(maximumBitRate, nameof(maximumBitRate));

            MaximumBitRate = maximumBitRate;
        }

        /// <summary> Initializes a new instance of QosPolicy. </summary>
        /// <param name="fiveQi"> QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values. </param>
        /// <param name="allocationAndRetentionPriorityLevel"> QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionCapability"> QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionVulnerability"> QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        internal QosPolicy(int? fiveQi, int? allocationAndRetentionPriorityLevel, PreemptionCapability? preemptionCapability, PreemptionVulnerability? preemptionVulnerability, Ambr maximumBitRate)
        {
            FiveQi = fiveQi;
            AllocationAndRetentionPriorityLevel = allocationAndRetentionPriorityLevel;
            PreemptionCapability = preemptionCapability;
            PreemptionVulnerability = preemptionVulnerability;
            MaximumBitRate = maximumBitRate;
        }

        /// <summary> QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values. </summary>
        public int? FiveQi { get; set; }
        /// <summary> QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public int? AllocationAndRetentionPriorityLevel { get; set; }
        /// <summary> QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public PreemptionCapability? PreemptionCapability { get; set; }
        /// <summary> QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public PreemptionVulnerability? PreemptionVulnerability { get; set; }
        /// <summary> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </summary>
        public Ambr MaximumBitRate { get; set; }
    }
}
