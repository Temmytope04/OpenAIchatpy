// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The HealthcareAssertion. </summary>
    internal partial class HealthcareAssertion
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareAssertion"/>. </summary>
        internal HealthcareAssertion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareAssertion"/>. </summary>
        /// <param name="conditionality"> Describes any conditionality on the entity. </param>
        /// <param name="certainty"> Describes the entities certainty and polarity. </param>
        /// <param name="association"> Describes if the entity is the subject of the text or if it describes someone else. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareAssertion(Conditionality? conditionality, Certainty? certainty, Association? association, Dictionary<string, BinaryData> rawData)
        {
            Conditionality = conditionality;
            Certainty = certainty;
            Association = association;
            _rawData = rawData;
        }

        /// <summary> Describes any conditionality on the entity. </summary>
        public Conditionality? Conditionality { get; }
        /// <summary> Describes the entities certainty and polarity. </summary>
        public Certainty? Certainty { get; }
        /// <summary> Describes if the entity is the subject of the text or if it describes someone else. </summary>
        public Association? Association { get; }
    }
}
