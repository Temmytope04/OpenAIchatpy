// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the MoveResource states. </summary>
    public readonly partial struct MoveState : IEquatable<MoveState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoveState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoveState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssignmentPendingValue = "AssignmentPending";
        private const string PreparePendingValue = "PreparePending";
        private const string PrepareInProgressValue = "PrepareInProgress";
        private const string PrepareFailedValue = "PrepareFailed";
        private const string MovePendingValue = "MovePending";
        private const string MoveInProgressValue = "MoveInProgress";
        private const string MoveFailedValue = "MoveFailed";
        private const string DiscardInProgressValue = "DiscardInProgress";
        private const string DiscardFailedValue = "DiscardFailed";
        private const string CommitPendingValue = "CommitPending";
        private const string CommitInProgressValue = "CommitInProgress";
        private const string CommitFailedValue = "CommitFailed";
        private const string CommittedValue = "Committed";
        private const string DeleteSourcePendingValue = "DeleteSourcePending";
        private const string ResourceMoveCompletedValue = "ResourceMoveCompleted";

        /// <summary> AssignmentPending. </summary>
        public static MoveState AssignmentPending { get; } = new MoveState(AssignmentPendingValue);
        /// <summary> PreparePending. </summary>
        public static MoveState PreparePending { get; } = new MoveState(PreparePendingValue);
        /// <summary> PrepareInProgress. </summary>
        public static MoveState PrepareInProgress { get; } = new MoveState(PrepareInProgressValue);
        /// <summary> PrepareFailed. </summary>
        public static MoveState PrepareFailed { get; } = new MoveState(PrepareFailedValue);
        /// <summary> MovePending. </summary>
        public static MoveState MovePending { get; } = new MoveState(MovePendingValue);
        /// <summary> MoveInProgress. </summary>
        public static MoveState MoveInProgress { get; } = new MoveState(MoveInProgressValue);
        /// <summary> MoveFailed. </summary>
        public static MoveState MoveFailed { get; } = new MoveState(MoveFailedValue);
        /// <summary> DiscardInProgress. </summary>
        public static MoveState DiscardInProgress { get; } = new MoveState(DiscardInProgressValue);
        /// <summary> DiscardFailed. </summary>
        public static MoveState DiscardFailed { get; } = new MoveState(DiscardFailedValue);
        /// <summary> CommitPending. </summary>
        public static MoveState CommitPending { get; } = new MoveState(CommitPendingValue);
        /// <summary> CommitInProgress. </summary>
        public static MoveState CommitInProgress { get; } = new MoveState(CommitInProgressValue);
        /// <summary> CommitFailed. </summary>
        public static MoveState CommitFailed { get; } = new MoveState(CommitFailedValue);
        /// <summary> Committed. </summary>
        public static MoveState Committed { get; } = new MoveState(CommittedValue);
        /// <summary> DeleteSourcePending. </summary>
        public static MoveState DeleteSourcePending { get; } = new MoveState(DeleteSourcePendingValue);
        /// <summary> ResourceMoveCompleted. </summary>
        public static MoveState ResourceMoveCompleted { get; } = new MoveState(ResourceMoveCompletedValue);
        /// <summary> Determines if two <see cref="MoveState"/> values are the same. </summary>
        public static bool operator ==(MoveState left, MoveState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoveState"/> values are not the same. </summary>
        public static bool operator !=(MoveState left, MoveState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MoveState"/>. </summary>
        public static implicit operator MoveState(string value) => new MoveState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoveState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoveState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
