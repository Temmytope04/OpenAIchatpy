// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The HealthcareAssertion. </summary>
    public partial class HealthcareEntityAssertion
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityAssertion"/>. </summary>
        /// <param name="conditionality"> Describes any conditionality on the entity. </param>
        /// <param name="certainty"> Describes the entities certainty and polarity. </param>
        /// <param name="association"> Describes if the entity is the subject of the text or if it describes someone else. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareEntityAssertion(EntityConditionality? conditionality, EntityCertainty? certainty, EntityAssociation? association, Dictionary<string, BinaryData> rawData)
        {
            Conditionality = conditionality;
            Certainty = certainty;
            Association = association;
            _rawData = rawData;
        }
    }
}
