// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The AppPlatformSkuCapabilities. </summary>
    public partial class AppPlatformSkuCapabilities
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuCapabilities"/>. </summary>
        internal AppPlatformSkuCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuCapabilities"/>. </summary>
        /// <param name="name"> Gets an invariant to describe the feature. </param>
        /// <param name="value"> Gets an invariant if the feature is measured by quantity. </param>
        internal AppPlatformSkuCapabilities(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Gets an invariant to describe the feature. </summary>
        public string Name { get; }
        /// <summary> Gets an invariant if the feature is measured by quantity. </summary>
        public string Value { get; }
    }
}
