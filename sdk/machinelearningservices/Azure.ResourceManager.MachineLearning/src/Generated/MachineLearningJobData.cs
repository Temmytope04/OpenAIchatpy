// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningJob data model.
    /// Azure Resource Manager resource envelope.
    /// </summary>
    public partial class MachineLearningJobData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningJobData"/>. </summary>
        /// <param name="properties">
        /// [Required] Additional attributes of the entity.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningJobData(MachineLearningJobProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// [Required] Additional attributes of the entity.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </param>
        internal MachineLearningJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningJobProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// [Required] Additional attributes of the entity.
        /// Please note <see cref="MachineLearningJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoMLJob"/>, <see cref="MachineLearningCommandJob"/>, <see cref="LabelingJobProperties"/>, <see cref="MachineLearningPipelineJob"/>, <see cref="SparkJob"/> and <see cref="MachineLearningSweepJob"/>.
        /// </summary>
        public MachineLearningJobProperties Properties { get; set; }
    }
}
