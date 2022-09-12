﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// The DtmfConfigurations.
    /// </summary>
    public class DtmfOptions
    {
        /// <summary> Initializes a new instance of DtmfConfigurations. </summary>
        public DtmfOptions()
        {
        }

        /// <summary> Time to wait between DTMF inputs to stop recognizing. </summary>
        public TimeSpan? InterToneTimeoutInSeconds { get; set; }
        /// <summary> Maximum number of DTMFs to be collected. </summary>
        public int? MaxTonesToCollect { get; set; }
        /// <summary> List of tones that will stop recognizing. </summary>
        public IReadOnlyList<DtmfTone> StopTones { get; set; }
    }
}
