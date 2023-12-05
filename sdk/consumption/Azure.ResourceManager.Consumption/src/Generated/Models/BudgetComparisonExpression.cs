// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The comparison expression to be used in the budgets. </summary>
    public partial class BudgetComparisonExpression
    {
        /// <summary> Initializes a new instance of <see cref="BudgetComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="values"/> is null. </exception>
        public BudgetComparisonExpression(string name, BudgetOperatorType @operator, IEnumerable<string> values)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(values, nameof(values));

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BudgetComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        internal BudgetComparisonExpression(string name, BudgetOperatorType @operator, IList<string> values)
        {
            Name = name;
            Operator = @operator;
            Values = values;
        }

        /// <summary> The name of the column to use in comparison. </summary>
        public string Name { get; set; }
        /// <summary> The operator to use for comparison. </summary>
        public BudgetOperatorType Operator { get; set; }
        /// <summary> Array of values to use for comparison. </summary>
        public IList<string> Values { get; }
    }
}
