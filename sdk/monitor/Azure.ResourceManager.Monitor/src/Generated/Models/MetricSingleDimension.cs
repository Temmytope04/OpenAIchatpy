// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The metric dimension name and value. </summary>
    internal partial class MetricSingleDimension
    {
        /// <summary> Initializes a new instance of MetricSingleDimension. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="value"> Value of the dimension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        internal MetricSingleDimension(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Value = value;
        }

        /// <summary> Name of the dimension. </summary>
        public string Name { get; }
        /// <summary> Value of the dimension. </summary>
        public string Value { get; }
    }
}
