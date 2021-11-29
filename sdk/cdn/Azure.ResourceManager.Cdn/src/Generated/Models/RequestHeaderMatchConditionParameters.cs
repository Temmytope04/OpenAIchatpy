// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestHeader match conditions. </summary>
    public partial class RequestHeaderMatchConditionParameters
    {
        /// <summary> Initializes a new instance of RequestHeaderMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public RequestHeaderMatchConditionParameters(RequestHeaderMatchConditionParametersOdataType odataType, RequestHeaderOperator @operator)
        {
            OdataType = odataType;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<Transform>();
        }

        /// <summary> Initializes a new instance of RequestHeaderMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="selector"> Name of Header to be matched. </param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal RequestHeaderMatchConditionParameters(RequestHeaderMatchConditionParametersOdataType odataType, string selector, RequestHeaderOperator @operator, bool? negateCondition, IList<string> matchValues, IList<Transform> transforms)
        {
            OdataType = odataType;
            Selector = selector;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public RequestHeaderMatchConditionParametersOdataType OdataType { get; set; }
        /// <summary> Name of Header to be matched. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestHeaderOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<Transform> Transforms { get; }
    }
}
