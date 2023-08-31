// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Recommended action for the service health event. </summary>
    public partial class ResourceHealthEventRecommendedActionsItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventRecommendedActionsItem"/>. </summary>
        internal ResourceHealthEventRecommendedActionsItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventRecommendedActionsItem"/>. </summary>
        /// <param name="groupId"> Recommended action group Id for the service health event. </param>
        /// <param name="actionText"> Recommended action text. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthEventRecommendedActionsItem(int? groupId, string actionText, Dictionary<string, BinaryData> rawData)
        {
            GroupId = groupId;
            ActionText = actionText;
            _rawData = rawData;
        }

        /// <summary> Recommended action group Id for the service health event. </summary>
        public int? GroupId { get; }
        /// <summary> Recommended action text. </summary>
        public string ActionText { get; }
    }
}
