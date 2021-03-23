// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Sequence contains an ordered list of Clips where each clip is a
    /// JobInput.  The Sequence will be treated as a single input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.JobInputSequence")]
    public partial class JobInputSequence : JobInput
    {
        /// <summary>
        /// Initializes a new instance of the JobInputSequence class.
        /// </summary>
        public JobInputSequence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobInputSequence class.
        /// </summary>
        /// <param name="inputs">JobInputs that make up the timeline.</param>
        public JobInputSequence(IList<JobInputClip> inputs = default(IList<JobInputClip>))
        {
            Inputs = inputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets jobInputs that make up the timeline.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<JobInputClip> Inputs { get; set; }

    }
}
