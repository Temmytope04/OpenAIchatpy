// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A billing profile resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingProfile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        public BillingProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="displayName">The billing profile name.</param>
        /// <param name="poNumber">Purchase order number.</param>
        /// <param name="billingAddress">Billing address.</param>
        /// <param name="billingContact">Billing contact.</param>
        /// <param name="emailInvoice">Email invoice.</param>
        /// <param name="invoiceDay">Invoice day.</param>
        /// <param name="currency">Currency on the billing profile.</param>
        public BillingProfile(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string poNumber = default(string), Address billingAddress = default(Address), string billingContact = default(string), bool? emailInvoice = default(bool?), int? invoiceDay = default(int?), string currency = default(string))
            : base(id, name, type, tags)
        {
            DisplayName = displayName;
            PoNumber = poNumber;
            BillingAddress = billingAddress;
            BillingContact = billingContact;
            EmailInvoice = emailInvoice;
            InvoiceDay = invoiceDay;
            Currency = currency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the billing profile name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets purchase order number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.poNumber")]
        public string PoNumber { get; set; }

        /// <summary>
        /// Gets or sets billing address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets billing contact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingContact")]
        public string BillingContact { get; private set; }

        /// <summary>
        /// Gets email invoice.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailInvoice")]
        public bool? EmailInvoice { get; private set; }

        /// <summary>
        /// Gets invoice day.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceDay")]
        public int? InvoiceDay { get; private set; }

        /// <summary>
        /// Gets currency on the billing profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

    }
}
