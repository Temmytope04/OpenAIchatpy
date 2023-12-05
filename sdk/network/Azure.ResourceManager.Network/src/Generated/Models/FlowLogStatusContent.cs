// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define a resource to query flow log and traffic analytics (optional) status. </summary>
    public partial class FlowLogStatusContent
    {
        /// <summary> Initializes a new instance of <see cref="FlowLogStatusContent"/>. </summary>
        /// <param name="targetResourceId"> The target resource where getting the flow log and traffic analytics (optional) status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> is null. </exception>
        public FlowLogStatusContent(ResourceIdentifier targetResourceId)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));

            TargetResourceId = targetResourceId;
        }

        /// <summary> The target resource where getting the flow log and traffic analytics (optional) status. </summary>
        public ResourceIdentifier TargetResourceId { get; }
    }
}
