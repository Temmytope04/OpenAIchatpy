// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Messaging.ServiceBus.Filters
{
    /// <summary>
    /// Describes a filter expression that is evaluated against a Message.
    /// </summary>
    /// <remarks>
    /// Filter is an abstract class with the following concrete implementations:
    /// <list type="bullet">
    /// <item><b>SqlRuleFilter</b> that represents a filter using SQL syntax. </item>
    /// <item><b>CorrelationRuleFilter</b> that provides an optimization for correlation equality expressions.</item>
    /// </list>
    /// </remarks>
    /// <seealso cref="SqlRuleFilter"/>
    /// <seealso cref="TrueRuleFilter"/>
    /// <seealso cref="CorrelationRuleFilter "/>
    /// <seealso cref="FalseRuleFilter"/>
    public abstract class RuleFilter : IEquatable<RuleFilter>
    {
        internal RuleFilter()
        {
            // This is intentionally left blank. This constructor exists
            // only to prevent external assemblies inheriting from it.
        }
        /// <inheritdoc/>
        public abstract bool Equals(RuleFilter other);
    }
}
