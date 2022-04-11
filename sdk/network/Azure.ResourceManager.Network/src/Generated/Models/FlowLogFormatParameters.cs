// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the flow log format. </summary>
    public partial class FlowLogFormatParameters
    {
        /// <summary> Initializes a new instance of FlowLogFormatParameters. </summary>
        public FlowLogFormatParameters()
        {
        }

        /// <summary> Initializes a new instance of FlowLogFormatParameters. </summary>
        /// <param name="formatType"> The file type of flow log. </param>
        /// <param name="version"> The version (revision) of the flow log. </param>
        internal FlowLogFormatParameters(FlowLogFormatType? formatType, int? version)
        {
            FormatType = formatType;
            Version = version;
        }

        /// <summary> The file type of flow log. </summary>
        public FlowLogFormatType? FormatType { get; set; }
        /// <summary> The version (revision) of the flow log. </summary>
        public int? Version { get; set; }
    }
}
