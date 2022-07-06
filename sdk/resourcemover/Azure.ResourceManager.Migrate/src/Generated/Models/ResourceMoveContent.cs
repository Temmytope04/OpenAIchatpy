// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the request body for resource move operation. </summary>
    public partial class ResourceMoveContent
    {
        /// <summary> Initializes a new instance of ResourceMoveContent. </summary>
        /// <param name="moveResources"> Gets or sets the list of resource Id&apos;s, by default it accepts move resource id&apos;s unless the input type is switched via moveResourceInputType property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResources"/> is null. </exception>
        public ResourceMoveContent(IEnumerable<string> moveResources)
        {
            if (moveResources == null)
            {
                throw new ArgumentNullException(nameof(moveResources));
            }

            MoveResources = moveResources.ToList();
        }

        /// <summary> Gets or sets a value indicating whether the operation needs to only run pre-requisite. </summary>
        public bool? ValidateOnly { get; set; }
        /// <summary> Gets or sets the list of resource Id&apos;s, by default it accepts move resource id&apos;s unless the input type is switched via moveResourceInputType property. </summary>
        public IList<string> MoveResources { get; }
        /// <summary> Defines the move resource input type. </summary>
        public MoveResourceInputType? MoveResourceInputType { get; set; }
    }
}
