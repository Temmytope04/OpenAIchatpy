// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The ContactAsset. </summary>
    public partial class ContactAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of <see cref="ContactAsset"/>. </summary>
        internal ContactAsset()
        {
            Names = new ChangeTrackingList<ObservedString>();
            Organizations = new ChangeTrackingList<ObservedString>();
            Sources = new ChangeTrackingList<SourceDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="ContactAsset"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="email"></param>
        /// <param name="names"></param>
        /// <param name="organizations"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        internal ContactAsset(IDictionary<string, BinaryData> serializedAdditionalRawData, string email, IReadOnlyList<ObservedString> names, IReadOnlyList<ObservedString> organizations, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count) : base(serializedAdditionalRawData)
        {
            Email = email;
            Names = names;
            Organizations = organizations;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
        }

        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Gets the names. </summary>
        public IReadOnlyList<ObservedString> Names { get; }
        /// <summary> Gets the organizations. </summary>
        public IReadOnlyList<ObservedString> Organizations { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
    }
}
