// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The comparison expression to be used in the budgets. </summary>
    public partial class BudgetComparisonExpression
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BudgetComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="values"/> is null. </exception>
        public BudgetComparisonExpression(string name, BudgetOperatorType @operator, IEnumerable<string> values)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BudgetComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BudgetComparisonExpression(string name, BudgetOperatorType @operator, IList<string> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Operator = @operator;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BudgetComparisonExpression"/> for deserialization. </summary>
        internal BudgetComparisonExpression()
        {
        }

        /// <summary> The name of the column to use in comparison. </summary>
        public string Name { get; set; }
        /// <summary> The operator to use for comparison. </summary>
        public BudgetOperatorType Operator { get; set; }
        /// <summary> Array of values to use for comparison. </summary>
        public IList<string> Values { get; }
    }
}
