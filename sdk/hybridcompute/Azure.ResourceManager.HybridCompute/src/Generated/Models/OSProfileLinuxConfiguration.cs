// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Specifies the linux configuration for update management. </summary>
    public partial class OSProfileLinuxConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OSProfileLinuxConfiguration"/>. </summary>
        public OSProfileLinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSProfileLinuxConfiguration"/>. </summary>
        /// <param name="assessmentMode"> Specifies the assessment mode. </param>
        /// <param name="patchMode"> Specifies the patch mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSProfileLinuxConfiguration(AssessmentModeType? assessmentMode, PatchModeType? patchMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssessmentMode = assessmentMode;
            PatchMode = patchMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the assessment mode. </summary>
        public AssessmentModeType? AssessmentMode { get; set; }
        /// <summary> Specifies the patch mode. </summary>
        public PatchModeType? PatchMode { get; set; }
    }
}
