// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement mdn settings.
    /// </summary>
    public partial class AS2MdnSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        public AS2MdnSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2MdnSettings class.
        /// </summary>
        /// <param name="needMDN">The value indicating whether to send or
        /// request a MDN.</param>
        /// <param name="signMDN">The value indicating whether the MDN needs to
        /// be signed or not.</param>
        /// <param name="sendMDNAsynchronously">The value indicating whether to
        /// send the asynchronous MDN.</param>
        /// <param name="signOutboundMDNIfOptional">The value indicating
        /// whether to sign the outbound MDN if optional.</param>
        /// <param name="sendInboundMDNToMessageBox">The value indicating
        /// whether to send inbound MDN to message box.</param>
        /// <param name="micHashingAlgorithm">The signing or hashing algorithm.
        /// Possible values include: 'NotSpecified', 'None', 'MD5', 'SHA1',
        /// 'SHA2256', 'SHA2384', 'SHA2512'</param>
        /// <param name="receiptDeliveryUrl">The receipt delivery URL.</param>
        /// <param name="dispositionNotificationTo">The disposition
        /// notification to header value.</param>
        /// <param name="mdnText">The MDN text.</param>
        public AS2MdnSettings(bool needMDN, bool signMDN, bool sendMDNAsynchronously, bool signOutboundMDNIfOptional, bool sendInboundMDNToMessageBox, string micHashingAlgorithm, string receiptDeliveryUrl = default(string), string dispositionNotificationTo = default(string), string mdnText = default(string))
        {
            NeedMDN = needMDN;
            SignMDN = signMDN;
            SendMDNAsynchronously = sendMDNAsynchronously;
            ReceiptDeliveryUrl = receiptDeliveryUrl;
            DispositionNotificationTo = dispositionNotificationTo;
            SignOutboundMDNIfOptional = signOutboundMDNIfOptional;
            MdnText = mdnText;
            SendInboundMDNToMessageBox = sendInboundMDNToMessageBox;
            MicHashingAlgorithm = micHashingAlgorithm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to send or request a MDN.
        /// </summary>
        [JsonProperty(PropertyName = "needMDN")]
        public bool NeedMDN { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the MDN needs to be
        /// signed or not.
        /// </summary>
        [JsonProperty(PropertyName = "signMDN")]
        public bool SignMDN { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send the asynchronous
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "sendMDNAsynchronously")]
        public bool SendMDNAsynchronously { get; set; }

        /// <summary>
        /// Gets or sets the receipt delivery URL.
        /// </summary>
        [JsonProperty(PropertyName = "receiptDeliveryUrl")]
        public string ReceiptDeliveryUrl { get; set; }

        /// <summary>
        /// Gets or sets the disposition notification to header value.
        /// </summary>
        [JsonProperty(PropertyName = "dispositionNotificationTo")]
        public string DispositionNotificationTo { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to sign the outbound MDN
        /// if optional.
        /// </summary>
        [JsonProperty(PropertyName = "signOutboundMDNIfOptional")]
        public bool SignOutboundMDNIfOptional { get; set; }

        /// <summary>
        /// Gets or sets the MDN text.
        /// </summary>
        [JsonProperty(PropertyName = "mdnText")]
        public string MdnText { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to send inbound MDN to
        /// message box.
        /// </summary>
        [JsonProperty(PropertyName = "sendInboundMDNToMessageBox")]
        public bool SendInboundMDNToMessageBox { get; set; }

        /// <summary>
        /// Gets or sets the signing or hashing algorithm. Possible values
        /// include: 'NotSpecified', 'None', 'MD5', 'SHA1', 'SHA2256',
        /// 'SHA2384', 'SHA2512'
        /// </summary>
        [JsonProperty(PropertyName = "micHashingAlgorithm")]
        public string MicHashingAlgorithm { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MicHashingAlgorithm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MicHashingAlgorithm");
            }
        }
    }
}
