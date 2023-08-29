// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> Every relation is an entity graph of a certain relationType, where all entities are connected and have specific roles within the relation context. </summary>
    internal partial class HealthcareRelation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entities"/> is null. </exception>
        internal HealthcareRelation(RelationType relationType, IEnumerable<HealthcareRelationEntity> entities)
        {
            Argument.AssertNotNull(entities, nameof(entities));

            RelationType = relationType;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareRelation(RelationType relationType, IReadOnlyList<HealthcareRelationEntity> entities, Dictionary<string, BinaryData> rawData)
        {
            RelationType = relationType;
            Entities = entities;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/> for deserialization. </summary>
        internal HealthcareRelation()
        {
        }

        /// <summary> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </summary>
        public RelationType RelationType { get; }
        /// <summary> The entities in the relation. </summary>
        public IReadOnlyList<HealthcareRelationEntity> Entities { get; }
    }
}
