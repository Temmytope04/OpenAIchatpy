// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Aggregate state of Arc Extensions across the nodes in this HCI cluster. </summary>
    public readonly partial struct ArcExtensionAggregateState : IEquatable<ArcExtensionAggregateState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArcExtensionAggregateState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArcExtensionAggregateState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ErrorValue = "Error";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string ConnectedValue = "Connected";
        private const string DisconnectedValue = "Disconnected";
        private const string DeletedValue = "Deleted";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string PartiallySucceededValue = "PartiallySucceeded";
        private const string PartiallyConnectedValue = "PartiallyConnected";
        private const string InProgressValue = "InProgress";

        /// <summary> NotSpecified. </summary>
        public static ArcExtensionAggregateState NotSpecified { get; } = new ArcExtensionAggregateState(NotSpecifiedValue);
        /// <summary> Error. </summary>
        public static ArcExtensionAggregateState Error { get; } = new ArcExtensionAggregateState(ErrorValue);
        /// <summary> Succeeded. </summary>
        public static ArcExtensionAggregateState Succeeded { get; } = new ArcExtensionAggregateState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static ArcExtensionAggregateState Canceled { get; } = new ArcExtensionAggregateState(CanceledValue);
        /// <summary> Failed. </summary>
        public static ArcExtensionAggregateState Failed { get; } = new ArcExtensionAggregateState(FailedValue);
        /// <summary> Connected. </summary>
        public static ArcExtensionAggregateState Connected { get; } = new ArcExtensionAggregateState(ConnectedValue);
        /// <summary> Disconnected. </summary>
        public static ArcExtensionAggregateState Disconnected { get; } = new ArcExtensionAggregateState(DisconnectedValue);
        /// <summary> Deleted. </summary>
        public static ArcExtensionAggregateState Deleted { get; } = new ArcExtensionAggregateState(DeletedValue);
        /// <summary> Creating. </summary>
        public static ArcExtensionAggregateState Creating { get; } = new ArcExtensionAggregateState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ArcExtensionAggregateState Updating { get; } = new ArcExtensionAggregateState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ArcExtensionAggregateState Deleting { get; } = new ArcExtensionAggregateState(DeletingValue);
        /// <summary> Moving. </summary>
        public static ArcExtensionAggregateState Moving { get; } = new ArcExtensionAggregateState(MovingValue);
        /// <summary> PartiallySucceeded. </summary>
        public static ArcExtensionAggregateState PartiallySucceeded { get; } = new ArcExtensionAggregateState(PartiallySucceededValue);
        /// <summary> PartiallyConnected. </summary>
        public static ArcExtensionAggregateState PartiallyConnected { get; } = new ArcExtensionAggregateState(PartiallyConnectedValue);
        /// <summary> InProgress. </summary>
        public static ArcExtensionAggregateState InProgress { get; } = new ArcExtensionAggregateState(InProgressValue);
        /// <summary> Determines if two <see cref="ArcExtensionAggregateState"/> values are the same. </summary>
        public static bool operator ==(ArcExtensionAggregateState left, ArcExtensionAggregateState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArcExtensionAggregateState"/> values are not the same. </summary>
        public static bool operator !=(ArcExtensionAggregateState left, ArcExtensionAggregateState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArcExtensionAggregateState"/>. </summary>
        public static implicit operator ArcExtensionAggregateState(string value) => new ArcExtensionAggregateState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArcExtensionAggregateState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArcExtensionAggregateState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
