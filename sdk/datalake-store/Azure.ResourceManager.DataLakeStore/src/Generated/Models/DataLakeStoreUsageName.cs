// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The usage names that can be used. </summary>
    public partial class DataLakeStoreUsageName
    {
        /// <summary> Initializes a new instance of DataLakeStoreUsageName. </summary>
        internal DataLakeStoreUsageName()
        {
        }

        /// <summary> Initializes a new instance of DataLakeStoreUsageName. </summary>
        /// <param name="value"> Gets a string describing the resource name. </param>
        /// <param name="localizedValue"> Gets a localized string describing the resource name. </param>
        internal DataLakeStoreUsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> Gets a string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> Gets a localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
