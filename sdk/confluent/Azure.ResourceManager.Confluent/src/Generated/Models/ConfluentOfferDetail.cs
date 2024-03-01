// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Confluent Offer detail. </summary>
    public partial class ConfluentOfferDetail
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

        /// <summary> Initializes a new instance of <see cref="ConfluentOfferDetail"/>. </summary>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="id"> Offer Id. </param>
        /// <param name="planId"> Offer Plan Id. </param>
        /// <param name="planName"> Offer Plan Name. </param>
        /// <param name="termUnit"> Offer Plan Term unit. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="id"/>, <paramref name="planId"/>, <paramref name="planName"/> or <paramref name="termUnit"/> is null. </exception>
        public ConfluentOfferDetail(string publisherId, string id, string planId, string planName, string termUnit)
        {
            if (publisherId == null)
            {
                throw new ArgumentNullException(nameof(publisherId));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (planId == null)
            {
                throw new ArgumentNullException(nameof(planId));
            }
            if (planName == null)
            {
                throw new ArgumentNullException(nameof(planName));
            }
            if (termUnit == null)
            {
                throw new ArgumentNullException(nameof(termUnit));
            }

            PublisherId = publisherId;
            Id = id;
            PlanId = planId;
            PlanName = planName;
            TermUnit = termUnit;
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentOfferDetail"/>. </summary>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="id"> Offer Id. </param>
        /// <param name="planId"> Offer Plan Id. </param>
        /// <param name="planName"> Offer Plan Name. </param>
        /// <param name="termUnit"> Offer Plan Term unit. </param>
        /// <param name="status"> SaaS Offer Status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfluentOfferDetail(string publisherId, string id, string planId, string planName, string termUnit, ConfluentSaaSOfferStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublisherId = publisherId;
            Id = id;
            PlanId = planId;
            PlanName = planName;
            TermUnit = termUnit;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentOfferDetail"/> for deserialization. </summary>
        internal ConfluentOfferDetail()
        {
        }

        /// <summary> Publisher Id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Offer Id. </summary>
        public string Id { get; set; }
        /// <summary> Offer Plan Id. </summary>
        public string PlanId { get; set; }
        /// <summary> Offer Plan Name. </summary>
        public string PlanName { get; set; }
        /// <summary> Offer Plan Term unit. </summary>
        public string TermUnit { get; set; }
        /// <summary> SaaS Offer Status. </summary>
        public ConfluentSaaSOfferStatus? Status { get; }
    }
}
