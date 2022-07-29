// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow status. </summary>
    public readonly partial struct LogicWorkflowStatus : IEquatable<LogicWorkflowStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicWorkflowStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string PausedValue = "Paused";
        private const string RunningValue = "Running";
        private const string WaitingValue = "Waiting";
        private const string SucceededValue = "Succeeded";
        private const string SkippedValue = "Skipped";
        private const string SuspendedValue = "Suspended";
        private const string CancelledValue = "Cancelled";
        private const string FailedValue = "Failed";
        private const string FaultedValue = "Faulted";
        private const string TimedOutValue = "TimedOut";
        private const string AbortedValue = "Aborted";
        private const string IgnoredValue = "Ignored";

        /// <summary> NotSpecified. </summary>
        public static LogicWorkflowStatus NotSpecified { get; } = new LogicWorkflowStatus(NotSpecifiedValue);
        /// <summary> Paused. </summary>
        public static LogicWorkflowStatus Paused { get; } = new LogicWorkflowStatus(PausedValue);
        /// <summary> Running. </summary>
        public static LogicWorkflowStatus Running { get; } = new LogicWorkflowStatus(RunningValue);
        /// <summary> Waiting. </summary>
        public static LogicWorkflowStatus Waiting { get; } = new LogicWorkflowStatus(WaitingValue);
        /// <summary> Succeeded. </summary>
        public static LogicWorkflowStatus Succeeded { get; } = new LogicWorkflowStatus(SucceededValue);
        /// <summary> Skipped. </summary>
        public static LogicWorkflowStatus Skipped { get; } = new LogicWorkflowStatus(SkippedValue);
        /// <summary> Suspended. </summary>
        public static LogicWorkflowStatus Suspended { get; } = new LogicWorkflowStatus(SuspendedValue);
        /// <summary> Cancelled. </summary>
        public static LogicWorkflowStatus Cancelled { get; } = new LogicWorkflowStatus(CancelledValue);
        /// <summary> Failed. </summary>
        public static LogicWorkflowStatus Failed { get; } = new LogicWorkflowStatus(FailedValue);
        /// <summary> Faulted. </summary>
        public static LogicWorkflowStatus Faulted { get; } = new LogicWorkflowStatus(FaultedValue);
        /// <summary> TimedOut. </summary>
        public static LogicWorkflowStatus TimedOut { get; } = new LogicWorkflowStatus(TimedOutValue);
        /// <summary> Aborted. </summary>
        public static LogicWorkflowStatus Aborted { get; } = new LogicWorkflowStatus(AbortedValue);
        /// <summary> Ignored. </summary>
        public static LogicWorkflowStatus Ignored { get; } = new LogicWorkflowStatus(IgnoredValue);
        /// <summary> Determines if two <see cref="LogicWorkflowStatus"/> values are the same. </summary>
        public static bool operator ==(LogicWorkflowStatus left, LogicWorkflowStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicWorkflowStatus"/> values are not the same. </summary>
        public static bool operator !=(LogicWorkflowStatus left, LogicWorkflowStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicWorkflowStatus"/>. </summary>
        public static implicit operator LogicWorkflowStatus(string value) => new LogicWorkflowStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicWorkflowStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicWorkflowStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
