// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Trigger referenced dependency.
    /// Please note <see cref="TriggerDependencyReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="TumblingWindowTriggerDependencyReference"/>.
    /// </summary>
    public partial class TriggerDependencyReference : DependencyReference
    {
        /// <summary> Initializes a new instance of <see cref="TriggerDependencyReference"/>. </summary>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceTrigger"/> is null. </exception>
        public TriggerDependencyReference(TriggerReference referenceTrigger)
        {
            Argument.AssertNotNull(referenceTrigger, nameof(referenceTrigger));

            ReferenceTrigger = referenceTrigger;
            Type = "TriggerDependencyReference";
        }

        /// <summary> Initializes a new instance of <see cref="TriggerDependencyReference"/>. </summary>
        /// <param name="type"> The type of dependency reference. </param>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerDependencyReference(string type, TriggerReference referenceTrigger, Dictionary<string, BinaryData> rawData) : base(type, rawData)
        {
            ReferenceTrigger = referenceTrigger;
            Type = type ?? "TriggerDependencyReference";
        }

        /// <summary> Initializes a new instance of <see cref="TriggerDependencyReference"/> for deserialization. </summary>
        internal TriggerDependencyReference()
        {
        }

        /// <summary> Referenced trigger. </summary>
        public TriggerReference ReferenceTrigger { get; set; }
    }
}
