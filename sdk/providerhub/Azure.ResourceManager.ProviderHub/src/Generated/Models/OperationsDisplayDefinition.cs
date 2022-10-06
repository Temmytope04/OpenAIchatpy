// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The OperationsDisplayDefinition. </summary>
    public partial class OperationsDisplayDefinition
    {
        /// <summary> Initializes a new instance of OperationsDisplayDefinition. </summary>
        /// <param name="provider"></param>
        /// <param name="resource"></param>
        /// <param name="operation"></param>
        /// <param name="description"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="provider"/>, <paramref name="resource"/>, <paramref name="operation"/> or <paramref name="description"/> is null. </exception>
        public OperationsDisplayDefinition(string provider, string resource, string operation, string description)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Gets or sets the provider. </summary>
        public string Provider { get; set; }
        /// <summary> Gets or sets the resource. </summary>
        public string Resource { get; set; }
        /// <summary> Gets or sets the operation. </summary>
        public string Operation { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
