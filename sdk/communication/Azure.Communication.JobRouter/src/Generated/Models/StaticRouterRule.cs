// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> A rule providing static rules that always return the same result, regardless of input. </summary>
    public partial class StaticRouterRule : RouterRule
    {
        /// <summary> Initializes a new instance of StaticRouterRule. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of Rule. </param>
        /// <param name="value"> The static value this rule always returns. </param>
        internal StaticRouterRule(string kind, object value) : base(kind)
        {
            _value = value;
            Kind = kind ?? "static-rule";
        }
    }
}
