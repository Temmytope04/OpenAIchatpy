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
    /// <summary> Represents a mail message entity. </summary>
    public partial class SecurityInsightsMailMessageEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailMessageEntity"/>. </summary>
        public SecurityInsightsMailMessageEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            FileEntityIds = new ChangeTrackingList<string>();
            Uris = new ChangeTrackingList<Uri>();
            Threats = new ChangeTrackingList<string>();
            ThreatDetectionMethods = new ChangeTrackingList<string>();
            Kind = SecurityInsightsEntityKind.MailMessage;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsMailMessageEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="fileEntityIds"> The File entity ids of this mail message's attachments. </param>
        /// <param name="recipient"> The recipient of this mail message. Note that in case of multiple recipients the mail message is forked and each copy has one recipient. </param>
        /// <param name="uris"> The Urls contained in this mail message. </param>
        /// <param name="threats"> The threats of this mail message. </param>
        /// <param name="p1Sender"> The p1 sender's email address. </param>
        /// <param name="p1SenderDisplayName"> The p1 sender's display name. </param>
        /// <param name="p1SenderDomain"> The p1 sender's domain. </param>
        /// <param name="senderIP"> The sender's IP address. </param>
        /// <param name="p2Sender"> The p2 sender's email address. </param>
        /// <param name="p2SenderDisplayName"> The p2 sender's display name. </param>
        /// <param name="p2SenderDomain"> The p2 sender's domain. </param>
        /// <param name="receiveOn"> The receive date of this message. </param>
        /// <param name="networkMessageId"> The network message id of this mail message. </param>
        /// <param name="internetMessageId"> The internet message id of this mail message. </param>
        /// <param name="subject"> The subject of this mail message. </param>
        /// <param name="language"> The language of this mail message. </param>
        /// <param name="threatDetectionMethods"> The threat detection methods. </param>
        /// <param name="bodyFingerprintBin1"> The bodyFingerprintBin1. </param>
        /// <param name="bodyFingerprintBin2"> The bodyFingerprintBin2. </param>
        /// <param name="bodyFingerprintBin3"> The bodyFingerprintBin3. </param>
        /// <param name="bodyFingerprintBin4"> The bodyFingerprintBin4. </param>
        /// <param name="bodyFingerprintBin5"> The bodyFingerprintBin5. </param>
        /// <param name="antispamDirection"> The directionality of this mail message. </param>
        /// <param name="deliveryAction"> The delivery action of this mail message like Delivered, Blocked, Replaced etc. </param>
        /// <param name="deliveryLocation"> The delivery location of this mail message like Inbox, JunkFolder etc. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsMailMessageEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, IReadOnlyList<string> fileEntityIds, string recipient, IReadOnlyList<Uri> uris, IReadOnlyList<string> threats, string p1Sender, string p1SenderDisplayName, string p1SenderDomain, IPAddress senderIP, string p2Sender, string p2SenderDisplayName, string p2SenderDomain, DateTimeOffset? receiveOn, Guid? networkMessageId, string internetMessageId, string subject, string language, IReadOnlyList<string> threatDetectionMethods, int? bodyFingerprintBin1, int? bodyFingerprintBin2, int? bodyFingerprintBin3, int? bodyFingerprintBin4, int? bodyFingerprintBin5, AntispamMailDirection? antispamDirection, SecurityInsightsMailMessageDeliveryAction? deliveryAction, SecurityInsightsMailMessageDeliveryLocation? deliveryLocation, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, rawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            FileEntityIds = fileEntityIds;
            Recipient = recipient;
            Uris = uris;
            Threats = threats;
            P1Sender = p1Sender;
            P1SenderDisplayName = p1SenderDisplayName;
            P1SenderDomain = p1SenderDomain;
            SenderIP = senderIP;
            P2Sender = p2Sender;
            P2SenderDisplayName = p2SenderDisplayName;
            P2SenderDomain = p2SenderDomain;
            ReceiveOn = receiveOn;
            NetworkMessageId = networkMessageId;
            InternetMessageId = internetMessageId;
            Subject = subject;
            Language = language;
            ThreatDetectionMethods = threatDetectionMethods;
            BodyFingerprintBin1 = bodyFingerprintBin1;
            BodyFingerprintBin2 = bodyFingerprintBin2;
            BodyFingerprintBin3 = bodyFingerprintBin3;
            BodyFingerprintBin4 = bodyFingerprintBin4;
            BodyFingerprintBin5 = bodyFingerprintBin5;
            AntispamDirection = antispamDirection;
            DeliveryAction = deliveryAction;
            DeliveryLocation = deliveryLocation;
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
        /// <summary> The File entity ids of this mail message's attachments. </summary>
        public IReadOnlyList<string> FileEntityIds { get; }
        /// <summary> The recipient of this mail message. Note that in case of multiple recipients the mail message is forked and each copy has one recipient. </summary>
        public string Recipient { get; }
        /// <summary> The Urls contained in this mail message. </summary>
        public IReadOnlyList<Uri> Uris { get; }
        /// <summary> The threats of this mail message. </summary>
        public IReadOnlyList<string> Threats { get; }
        /// <summary> The p1 sender's email address. </summary>
        public string P1Sender { get; }
        /// <summary> The p1 sender's display name. </summary>
        public string P1SenderDisplayName { get; }
        /// <summary> The p1 sender's domain. </summary>
        public string P1SenderDomain { get; }
        /// <summary> The sender's IP address. </summary>
        public IPAddress SenderIP { get; }
        /// <summary> The p2 sender's email address. </summary>
        public string P2Sender { get; }
        /// <summary> The p2 sender's display name. </summary>
        public string P2SenderDisplayName { get; }
        /// <summary> The p2 sender's domain. </summary>
        public string P2SenderDomain { get; }
        /// <summary> The receive date of this message. </summary>
        public DateTimeOffset? ReceiveOn { get; }
        /// <summary> The network message id of this mail message. </summary>
        public Guid? NetworkMessageId { get; }
        /// <summary> The internet message id of this mail message. </summary>
        public string InternetMessageId { get; }
        /// <summary> The subject of this mail message. </summary>
        public string Subject { get; }
        /// <summary> The language of this mail message. </summary>
        public string Language { get; }
        /// <summary> The threat detection methods. </summary>
        public IReadOnlyList<string> ThreatDetectionMethods { get; }
        /// <summary> The bodyFingerprintBin1. </summary>
        public int? BodyFingerprintBin1 { get; set; }
        /// <summary> The bodyFingerprintBin2. </summary>
        public int? BodyFingerprintBin2 { get; set; }
        /// <summary> The bodyFingerprintBin3. </summary>
        public int? BodyFingerprintBin3 { get; set; }
        /// <summary> The bodyFingerprintBin4. </summary>
        public int? BodyFingerprintBin4 { get; set; }
        /// <summary> The bodyFingerprintBin5. </summary>
        public int? BodyFingerprintBin5 { get; set; }
        /// <summary> The directionality of this mail message. </summary>
        public AntispamMailDirection? AntispamDirection { get; set; }
        /// <summary> The delivery action of this mail message like Delivered, Blocked, Replaced etc. </summary>
        public SecurityInsightsMailMessageDeliveryAction? DeliveryAction { get; set; }
        /// <summary> The delivery location of this mail message like Inbox, JunkFolder etc. </summary>
        public SecurityInsightsMailMessageDeliveryLocation? DeliveryLocation { get; set; }
    }
}
