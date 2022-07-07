// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The Usage Names. </summary>
    public partial class ComputeUsageName
    {
        /// <summary> Initializes a new instance of ComputeUsageName. </summary>
        internal ComputeUsageName()
        {
        }

        /// <summary> Initializes a new instance of ComputeUsageName. </summary>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        internal ComputeUsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> The name of the resource. </summary>
        public string Value { get; }
        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
    }
}
