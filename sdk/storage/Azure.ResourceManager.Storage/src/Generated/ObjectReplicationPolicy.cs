// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A Class representing a ObjectReplicationPolicy along with the instance operations that can be performed on it. </summary>
    public class ObjectReplicationPolicy : ObjectReplicationPolicyOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ObjectReplicationPolicy"/> class for mocking. </summary>
        protected ObjectReplicationPolicy() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ObjectReplicationPolicy"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ObjectReplicationPolicy(ResourceOperations options, ObjectReplicationPolicyData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ObjectReplicationPolicyData. </summary>
        public virtual ObjectReplicationPolicyData Data { get; private set; }
    }
}
