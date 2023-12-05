// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance Sku Properties. </summary>
    public partial class BreakOutCategoryPolicies
    {
        /// <summary> Initializes a new instance of <see cref="BreakOutCategoryPolicies"/>. </summary>
        public BreakOutCategoryPolicies()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BreakOutCategoryPolicies"/>. </summary>
        /// <param name="allow"> Flag to control breakout of o365 allow category. </param>
        /// <param name="optimize"> Flag to control breakout of o365 optimize category. </param>
        /// <param name="default"> Flag to control breakout of o365 default category. </param>
        internal BreakOutCategoryPolicies(bool? allow, bool? optimize, bool? @default)
        {
            Allow = allow;
            Optimize = optimize;
            Default = @default;
        }

        /// <summary> Flag to control breakout of o365 allow category. </summary>
        public bool? Allow { get; set; }
        /// <summary> Flag to control breakout of o365 optimize category. </summary>
        public bool? Optimize { get; set; }
        /// <summary> Flag to control breakout of o365 default category. </summary>
        public bool? Default { get; set; }
    }
}
