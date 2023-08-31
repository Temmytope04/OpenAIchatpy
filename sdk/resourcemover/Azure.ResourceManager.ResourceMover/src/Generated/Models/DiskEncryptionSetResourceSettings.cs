// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the disk encryption set resource settings. </summary>
    public partial class DiskEncryptionSetResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetResourceSettings"/>. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public DiskEncryptionSetResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            ResourceType = "Microsoft.Compute/diskEncryptionSets";
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskEncryptionSetResourceSettings(string resourceType, string targetResourceName, Dictionary<string, BinaryData> rawData) : base(resourceType, targetResourceName, rawData)
        {
            ResourceType = resourceType ?? "Microsoft.Compute/diskEncryptionSets";
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetResourceSettings"/> for deserialization. </summary>
        internal DiskEncryptionSetResourceSettings()
        {
        }
    }
}
