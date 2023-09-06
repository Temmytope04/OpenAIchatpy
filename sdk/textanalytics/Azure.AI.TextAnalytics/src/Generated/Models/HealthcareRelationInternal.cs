// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Every relation is an entity graph of a certain relationType, where all entities are connected and have specific roles within the relation context. </summary>
    internal partial class HealthcareRelationInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareRelationInternal"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entities"/> is null. </exception>
        public HealthcareRelationInternal(HealthcareEntityRelationType relationType, IEnumerable<HealthcareRelationEntity> entities)
        {
            Argument.AssertNotNull(entities, nameof(entities));

            RelationType = relationType;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelationInternal"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted relation. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareRelationInternal(HealthcareEntityRelationType relationType, double? confidenceScore, IList<HealthcareRelationEntity> entities, Dictionary<string, BinaryData> rawData)
        {
            RelationType = relationType;
            ConfidenceScore = confidenceScore;
            Entities = entities;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelationInternal"/> for deserialization. </summary>
        internal HealthcareRelationInternal()
        {
        }

        /// <summary> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </summary>
        public HealthcareEntityRelationType RelationType { get; set; }
        /// <summary> Confidence score between 0 and 1 of the extracted relation. </summary>
        public double? ConfidenceScore { get; set; }
        /// <summary> The entities in the relation. </summary>
        public IList<HealthcareRelationEntity> Entities { get; }
    }
}
