// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The state to update the asset to. </summary>
    public readonly partial struct AssetUpdateState : IEquatable<AssetUpdateState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetUpdateState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetUpdateState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CandidateValue = "candidate";
        private const string ConfirmedValue = "confirmed";
        private const string DismissedValue = "dismissed";
        private const string CandidateInvestigateValue = "candidateInvestigate";
        private const string AssociatedPartnerValue = "associatedPartner";
        private const string AssociatedThirdpartyValue = "associatedThirdparty";

        /// <summary> candidate. </summary>
        public static AssetUpdateState Candidate { get; } = new AssetUpdateState(CandidateValue);
        /// <summary> confirmed. </summary>
        public static AssetUpdateState Confirmed { get; } = new AssetUpdateState(ConfirmedValue);
        /// <summary> dismissed. </summary>
        public static AssetUpdateState Dismissed { get; } = new AssetUpdateState(DismissedValue);
        /// <summary> candidateInvestigate. </summary>
        public static AssetUpdateState CandidateInvestigate { get; } = new AssetUpdateState(CandidateInvestigateValue);
        /// <summary> associatedPartner. </summary>
        public static AssetUpdateState AssociatedPartner { get; } = new AssetUpdateState(AssociatedPartnerValue);
        /// <summary> associatedThirdparty. </summary>
        public static AssetUpdateState AssociatedThirdparty { get; } = new AssetUpdateState(AssociatedThirdpartyValue);
        /// <summary> Determines if two <see cref="AssetUpdateState"/> values are the same. </summary>
        public static bool operator ==(AssetUpdateState left, AssetUpdateState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetUpdateState"/> values are not the same. </summary>
        public static bool operator !=(AssetUpdateState left, AssetUpdateState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssetUpdateState"/>. </summary>
        public static implicit operator AssetUpdateState(string value) => new AssetUpdateState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetUpdateState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetUpdateState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
