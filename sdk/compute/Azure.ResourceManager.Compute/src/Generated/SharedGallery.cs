// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a SharedGallery along with the instance operations that can be performed on it. </summary>
    public class SharedGallery : SharedGalleryOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "SharedGallery"/> class for mocking. </summary>
        protected SharedGallery()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGallery"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SharedGallery(OperationsBase options, SharedGalleryData resource)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SharedGalleryData. </summary>
        public virtual SharedGalleryData Data { get; private set; }
    }
}
