// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a submission mail entity. </summary>
    public partial class SecurityInsightsSubmissionMailEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSubmissionMailEntity"/>. </summary>
        public SecurityInsightsSubmissionMailEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.SubmissionMail;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSubmissionMailEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="networkMessageId"> The network message id of email to which submission belongs. </param>
        /// <param name="submissionId"> The submission id. </param>
        /// <param name="submitter"> The submitter. </param>
        /// <param name="submitOn"> The submission date. </param>
        /// <param name="messageReceivedOn"> The Time stamp when the message is received (Mail). </param>
        /// <param name="recipient"> The recipient of the mail. </param>
        /// <param name="sender"> The sender of the mail. </param>
        /// <param name="senderIP"> The sender's IP. </param>
        /// <param name="subject"> The subject of submission mail. </param>
        /// <param name="reportType"> The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsSubmissionMailEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, Guid? networkMessageId, Guid? submissionId, string submitter, DateTimeOffset? submitOn, DateTimeOffset? messageReceivedOn, string recipient, string sender, IPAddress senderIP, string subject, string reportType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, rawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageId = networkMessageId;
            SubmissionId = submissionId;
            Submitter = submitter;
            SubmitOn = submitOn;
            MessageReceivedOn = messageReceivedOn;
            Recipient = recipient;
            Sender = sender;
            SenderIP = senderIP;
            Subject = subject;
            ReportType = reportType;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The network message id of email to which submission belongs. </summary>
        public Guid? NetworkMessageId { get; }
        /// <summary> The submission id. </summary>
        public Guid? SubmissionId { get; }
        /// <summary> The submitter. </summary>
        public string Submitter { get; }
        /// <summary> The submission date. </summary>
        public DateTimeOffset? SubmitOn { get; }
        /// <summary> The Time stamp when the message is received (Mail). </summary>
        public DateTimeOffset? MessageReceivedOn { get; }
        /// <summary> The recipient of the mail. </summary>
        public string Recipient { get; }
        /// <summary> The sender of the mail. </summary>
        public string Sender { get; }
        /// <summary> The sender's IP. </summary>
        public IPAddress SenderIP { get; }
        /// <summary> The subject of submission mail. </summary>
        public string Subject { get; }
        /// <summary> The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk. </summary>
        public string ReportType { get; }
    }
}
