// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for QueryString match conditions. </summary>
    public partial class QueryStringMatchConditionParameters
    {
        /// <summary> Initializes a new instance of QueryStringMatchConditionParameters. </summary>
        /// <param name="typeName"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public QueryStringMatchConditionParameters(QueryStringMatchConditionParametersTypeName typeName, QueryStringOperator @operator)
        {
            TypeName = typeName;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<TransformCategory>();
        }

        /// <summary> Initializes a new instance of QueryStringMatchConditionParameters. </summary>
        /// <param name="typeName"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal QueryStringMatchConditionParameters(QueryStringMatchConditionParametersTypeName typeName, QueryStringOperator @operator, bool? negateCondition, IList<string> matchValues, IList<TransformCategory> transforms)
        {
            TypeName = typeName;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the type name. </summary>
        public QueryStringMatchConditionParametersTypeName TypeName { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public QueryStringOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<TransformCategory> Transforms { get; }
    }
}
