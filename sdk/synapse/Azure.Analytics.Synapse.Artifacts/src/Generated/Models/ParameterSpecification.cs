// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Definition of a single parameter for an entity. </summary>
    public partial class ParameterSpecification
    {
        /// <summary> Initializes a new instance of <see cref="ParameterSpecification"/>. </summary>
        /// <param name="type"> Parameter type. </param>
        public ParameterSpecification(ParameterType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="ParameterSpecification"/>. </summary>
        /// <param name="type"> Parameter type. </param>
        /// <param name="defaultValue"> Default value of parameter. </param>
        internal ParameterSpecification(ParameterType type, object defaultValue)
        {
            Type = type;
            DefaultValue = defaultValue;
        }

        /// <summary> Parameter type. </summary>
        public ParameterType Type { get; set; }
        /// <summary> Default value of parameter. </summary>
        public object DefaultValue { get; set; }
    }
}
