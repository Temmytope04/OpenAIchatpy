// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Network related properties of a server. </summary>
    public partial class HighAvailability
    {
        /// <summary> Initializes a new instance of HighAvailability. </summary>
        public HighAvailability()
        {
        }

        /// <summary> Initializes a new instance of HighAvailability. </summary>
        /// <param name="mode"> High availability mode for a server. </param>
        /// <param name="state"> The state of server high availability. </param>
        /// <param name="standbyAvailabilityZone"> Availability zone of the standby server. </param>
        internal HighAvailability(HighAvailabilityMode? mode, HighAvailabilityState? state, string standbyAvailabilityZone)
        {
            Mode = mode;
            State = state;
            StandbyAvailabilityZone = standbyAvailabilityZone;
        }

        /// <summary> High availability mode for a server. </summary>
        public HighAvailabilityMode? Mode { get; set; }
        /// <summary> The state of server high availability. </summary>
        public HighAvailabilityState? State { get; }
        /// <summary> Availability zone of the standby server. </summary>
        public string StandbyAvailabilityZone { get; set; }
    }
}
