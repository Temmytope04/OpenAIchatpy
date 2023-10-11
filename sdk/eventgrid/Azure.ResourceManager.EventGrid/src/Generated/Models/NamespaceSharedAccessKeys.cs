// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Shared access keys of the Namespace. </summary>
    public partial class NamespaceSharedAccessKeys
    {
        /// <summary> Initializes a new instance of NamespaceSharedAccessKeys. </summary>
        internal NamespaceSharedAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of NamespaceSharedAccessKeys. </summary>
        /// <param name="key1"> Shared access key1 for the namespace. </param>
        /// <param name="key2"> Shared access key2 for the namespace. </param>
        internal NamespaceSharedAccessKeys(string key1, string key2)
        {
            Key1 = key1;
            Key2 = key2;
        }

        /// <summary> Shared access key1 for the namespace. </summary>
        public string Key1 { get; }
        /// <summary> Shared access key2 for the namespace. </summary>
        public string Key2 { get; }
    }
}
