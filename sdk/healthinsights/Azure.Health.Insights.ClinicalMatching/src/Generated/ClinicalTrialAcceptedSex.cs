// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Possible values for the Sex eligibility criterion as accepted by clinical trials, which indicates the sex of people who may participate in a clinical study. </summary>
    public readonly partial struct ClinicalTrialAcceptedSex : IEquatable<ClinicalTrialAcceptedSex>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialAcceptedSex"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClinicalTrialAcceptedSex(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "all";
        private const string FemaleValue = "female";
        private const string MaleValue = "male";

        /// <summary> all. </summary>
        public static ClinicalTrialAcceptedSex All { get; } = new ClinicalTrialAcceptedSex(AllValue);
        /// <summary> female. </summary>
        public static ClinicalTrialAcceptedSex Female { get; } = new ClinicalTrialAcceptedSex(FemaleValue);
        /// <summary> male. </summary>
        public static ClinicalTrialAcceptedSex Male { get; } = new ClinicalTrialAcceptedSex(MaleValue);
        /// <summary> Determines if two <see cref="ClinicalTrialAcceptedSex"/> values are the same. </summary>
        public static bool operator ==(ClinicalTrialAcceptedSex left, ClinicalTrialAcceptedSex right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClinicalTrialAcceptedSex"/> values are not the same. </summary>
        public static bool operator !=(ClinicalTrialAcceptedSex left, ClinicalTrialAcceptedSex right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClinicalTrialAcceptedSex"/>. </summary>
        public static implicit operator ClinicalTrialAcceptedSex(string value) => new ClinicalTrialAcceptedSex(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClinicalTrialAcceptedSex other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClinicalTrialAcceptedSex other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
