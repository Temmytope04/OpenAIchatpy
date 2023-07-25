// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningTableJobInput. </summary>
    public partial class MachineLearningTableJobInput : MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of MachineLearningTableJobInput. </summary>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public MachineLearningTableJobInput(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            JobInputType = JobInputType.Mltable;
        }

        /// <summary> Initializes a new instance of MachineLearningTableJobInput. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="mode"> Input Asset Delivery Mode. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        internal MachineLearningTableJobInput(string description, JobInputType jobInputType, MachineLearningInputDeliveryMode? mode, Uri uri) : base(description, jobInputType)
        {
            Mode = mode;
            Uri = uri;
            JobInputType = jobInputType;
        }

        /// <summary> Input Asset Delivery Mode. </summary>
        public MachineLearningInputDeliveryMode? Mode { get; set; }
        /// <summary> [Required] Input Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
