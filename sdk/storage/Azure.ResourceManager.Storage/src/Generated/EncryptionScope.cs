// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A Class representing a EncryptionScope along with the instance operations that can be performed on it. </summary>
    public class EncryptionScope : EncryptionScopeOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "EncryptionScope"/> class for mocking. </summary>
        protected EncryptionScope() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EncryptionScope"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal EncryptionScope(ResourceOperations options, EncryptionScopeData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the EncryptionScopeData. </summary>
        public virtual EncryptionScopeData Data { get; private set; }
    }
}
