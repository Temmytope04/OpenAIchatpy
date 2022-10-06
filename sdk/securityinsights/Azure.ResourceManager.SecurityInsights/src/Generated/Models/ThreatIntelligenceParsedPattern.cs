// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes parsed pattern entity. </summary>
    public partial class ThreatIntelligenceParsedPattern
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceParsedPattern. </summary>
        public ThreatIntelligenceParsedPattern()
        {
            PatternTypeValues = new ChangeTrackingList<ThreatIntelligenceParsedPatternTypeValue>();
        }

        /// <summary> Initializes a new instance of ThreatIntelligenceParsedPattern. </summary>
        /// <param name="patternTypeKey"> Pattern type key. </param>
        /// <param name="patternTypeValues"> Pattern type keys. </param>
        internal ThreatIntelligenceParsedPattern(string patternTypeKey, IList<ThreatIntelligenceParsedPatternTypeValue> patternTypeValues)
        {
            PatternTypeKey = patternTypeKey;
            PatternTypeValues = patternTypeValues;
        }

        /// <summary> Pattern type key. </summary>
        public string PatternTypeKey { get; set; }
        /// <summary> Pattern type keys. </summary>
        public IList<ThreatIntelligenceParsedPatternTypeValue> PatternTypeValues { get; }
    }
}
