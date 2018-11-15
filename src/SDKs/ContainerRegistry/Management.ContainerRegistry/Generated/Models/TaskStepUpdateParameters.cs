// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base properties for updating any task step.
    /// </summary>
    public partial class TaskStepUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TaskStepUpdateParameters class.
        /// </summary>
        public TaskStepUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskStepUpdateParameters class.
        /// </summary>
        /// <param name="contextPath">The URL(absolute or relative) of the
        /// source context for the task step.</param>
        public TaskStepUpdateParameters(string contextPath = default(string))
        {
            ContextPath = contextPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL(absolute or relative) of the source context
        /// for the task step.
        /// </summary>
        [JsonProperty(PropertyName = "contextPath")]
        public string ContextPath { get; set; }

    }
}
