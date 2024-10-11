// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The BotChannelName. </summary>
    public readonly partial struct BotChannelName : IEquatable<BotChannelName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BotChannelName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BotChannelName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlexaChannelValue = "AlexaChannel";
        private const string FacebookChannelValue = "FacebookChannel";
        private const string EmailChannelValue = "EmailChannel";
        private const string KikChannelValue = "KikChannel";
        private const string TelegramChannelValue = "TelegramChannel";
        private const string SlackChannelValue = "SlackChannel";
        private const string MsTeamsChannelValue = "MsTeamsChannel";
        private const string SkypeChannelValue = "SkypeChannel";
        private const string WebChatChannelValue = "WebChatChannel";
        private const string DirectLineChannelValue = "DirectLineChannel";
        private const string SmsChannelValue = "SmsChannel";
        private const string LineChannelValue = "LineChannel";
        private const string DirectLineSpeechChannelValue = "DirectLineSpeechChannel";
        private const string OutlookChannelValue = "OutlookChannel";
        private const string OmnichannelValue = "Omnichannel";
        private const string TelephonyChannelValue = "TelephonyChannel";
        private const string AcsChatChannelValue = "AcsChatChannel";
        private const string SearchAssistantValue = "SearchAssistant";
        private const string M365ExtensionsValue = "M365Extensions";

        /// <summary> AlexaChannel. </summary>
        public static BotChannelName AlexaChannel { get; } = new BotChannelName(AlexaChannelValue);
        /// <summary> FacebookChannel. </summary>
        public static BotChannelName FacebookChannel { get; } = new BotChannelName(FacebookChannelValue);
        /// <summary> EmailChannel. </summary>
        public static BotChannelName EmailChannel { get; } = new BotChannelName(EmailChannelValue);
        /// <summary> KikChannel. </summary>
        public static BotChannelName KikChannel { get; } = new BotChannelName(KikChannelValue);
        /// <summary> TelegramChannel. </summary>
        public static BotChannelName TelegramChannel { get; } = new BotChannelName(TelegramChannelValue);
        /// <summary> SlackChannel. </summary>
        public static BotChannelName SlackChannel { get; } = new BotChannelName(SlackChannelValue);
        /// <summary> MsTeamsChannel. </summary>
        public static BotChannelName MsTeamsChannel { get; } = new BotChannelName(MsTeamsChannelValue);
        /// <summary> SkypeChannel. </summary>
        public static BotChannelName SkypeChannel { get; } = new BotChannelName(SkypeChannelValue);
        /// <summary> WebChatChannel. </summary>
        public static BotChannelName WebChatChannel { get; } = new BotChannelName(WebChatChannelValue);
        /// <summary> DirectLineChannel. </summary>
        public static BotChannelName DirectLineChannel { get; } = new BotChannelName(DirectLineChannelValue);
        /// <summary> SmsChannel. </summary>
        public static BotChannelName SmsChannel { get; } = new BotChannelName(SmsChannelValue);
        /// <summary> LineChannel. </summary>
        public static BotChannelName LineChannel { get; } = new BotChannelName(LineChannelValue);
        /// <summary> DirectLineSpeechChannel. </summary>
        public static BotChannelName DirectLineSpeechChannel { get; } = new BotChannelName(DirectLineSpeechChannelValue);
        /// <summary> OutlookChannel. </summary>
        public static BotChannelName OutlookChannel { get; } = new BotChannelName(OutlookChannelValue);
        /// <summary> Omnichannel. </summary>
        public static BotChannelName Omnichannel { get; } = new BotChannelName(OmnichannelValue);
        /// <summary> TelephonyChannel. </summary>
        public static BotChannelName TelephonyChannel { get; } = new BotChannelName(TelephonyChannelValue);
        /// <summary> AcsChatChannel. </summary>
        public static BotChannelName AcsChatChannel { get; } = new BotChannelName(AcsChatChannelValue);
        /// <summary> SearchAssistant. </summary>
        public static BotChannelName SearchAssistant { get; } = new BotChannelName(SearchAssistantValue);
        /// <summary> M365Extensions. </summary>
        public static BotChannelName M365Extensions { get; } = new BotChannelName(M365ExtensionsValue);
        /// <summary> Determines if two <see cref="BotChannelName"/> values are the same. </summary>
        public static bool operator ==(BotChannelName left, BotChannelName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BotChannelName"/> values are not the same. </summary>
        public static bool operator !=(BotChannelName left, BotChannelName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BotChannelName"/>. </summary>
        public static implicit operator BotChannelName(string value) => new BotChannelName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BotChannelName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BotChannelName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
