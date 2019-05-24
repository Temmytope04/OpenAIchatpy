// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Line of credit resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LineOfCredit : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LineOfCredit class.
        /// </summary>
        public LineOfCredit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LineOfCredit class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="creditLimit">The current credit limit.</param>
        /// <param name="reason">The reason for the line of credit status when
        /// not approved.</param>
        /// <param name="remainingBalance">Remaining balance.</param>
        /// <param name="status">The line of credit status. Possible values
        /// include: 'Approved', 'Rejected'</param>
        public LineOfCredit(string id = default(string), string name = default(string), string type = default(string), Amount creditLimit = default(Amount), string reason = default(string), Amount remainingBalance = default(Amount), string status = default(string))
            : base(id, name, type)
        {
            CreditLimit = creditLimit;
            Reason = reason;
            RemainingBalance = remainingBalance;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current credit limit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creditLimit")]
        public Amount CreditLimit { get; private set; }

        /// <summary>
        /// Gets the reason for the line of credit status when not approved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reason")]
        public string Reason { get; private set; }

        /// <summary>
        /// Gets remaining balance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remainingBalance")]
        public Amount RemainingBalance { get; private set; }

        /// <summary>
        /// Gets or sets the line of credit status. Possible values include:
        /// 'Approved', 'Rejected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

    }
}
