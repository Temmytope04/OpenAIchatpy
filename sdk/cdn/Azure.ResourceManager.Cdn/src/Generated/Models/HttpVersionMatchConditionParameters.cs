// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for HttpVersion match conditions. </summary>
    public partial class HttpVersionMatchConditionParameters
    {
        /// <summary> Initializes a new instance of HttpVersionMatchConditionParameters. </summary>
        /// <param name="operator"> Describes operator to be matched. </param>
        public HttpVersionMatchConditionParameters(HttpVersionOperator @operator)
        {
            OdataType = "#Microsoft.Azure.Cdn.Models.DeliveryRuleHttpVersionConditionParameters";
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HttpVersionMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        internal HttpVersionMatchConditionParameters(string odataType, HttpVersionOperator @operator, bool? negateCondition, IList<string> matchValues)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public string OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public HttpVersionOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
    }
}
