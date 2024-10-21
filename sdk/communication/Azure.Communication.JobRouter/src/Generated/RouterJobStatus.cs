// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes the various status of a job. </summary>
    public readonly partial struct RouterJobStatus : IEquatable<RouterJobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouterJobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouterJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingClassificationValue = "pendingClassification";
        private const string QueuedValue = "queued";
        private const string AssignedValue = "assigned";
        private const string CompletedValue = "completed";
        private const string ClosedValue = "closed";
        private const string CancelledValue = "cancelled";
        private const string ClassificationFailedValue = "classificationFailed";
        private const string CreatedValue = "created";
        private const string PendingScheduleValue = "pendingSchedule";
        private const string ScheduledValue = "scheduled";
        private const string ScheduleFailedValue = "scheduleFailed";
        private const string WaitingForActivationValue = "waitingForActivation";

        /// <summary> Job is waiting to be classified. </summary>
        public static RouterJobStatus PendingClassification { get; } = new RouterJobStatus(PendingClassificationValue);
        /// <summary> Job has been queued. </summary>
        public static RouterJobStatus Queued { get; } = new RouterJobStatus(QueuedValue);
        /// <summary> Job has been assigned to a worker. </summary>
        public static RouterJobStatus Assigned { get; } = new RouterJobStatus(AssignedValue);
        /// <summary> Job has been completed by a worker. </summary>
        public static RouterJobStatus Completed { get; } = new RouterJobStatus(CompletedValue);
        /// <summary> Job has been closed by a worker. </summary>
        public static RouterJobStatus Closed { get; } = new RouterJobStatus(ClosedValue);
        /// <summary> Job has been cancelled. </summary>
        public static RouterJobStatus Cancelled { get; } = new RouterJobStatus(CancelledValue);
        /// <summary> Classification process failed for the job. </summary>
        public static RouterJobStatus ClassificationFailed { get; } = new RouterJobStatus(ClassificationFailedValue);
        /// <summary> Job has been created. </summary>
        public static RouterJobStatus Created { get; } = new RouterJobStatus(CreatedValue);
        /// <summary> Job has been created but not been scheduled yet. </summary>
        public static RouterJobStatus PendingSchedule { get; } = new RouterJobStatus(PendingScheduleValue);
        /// <summary> Job has been scheduled successfully. </summary>
        public static RouterJobStatus Scheduled { get; } = new RouterJobStatus(ScheduledValue);
        /// <summary> Job scheduling failed. </summary>
        public static RouterJobStatus ScheduleFailed { get; } = new RouterJobStatus(ScheduleFailedValue);
        /// <summary> Job is in a suspended state and waiting for an update. </summary>
        public static RouterJobStatus WaitingForActivation { get; } = new RouterJobStatus(WaitingForActivationValue);
        /// <summary> Determines if two <see cref="RouterJobStatus"/> values are the same. </summary>
        public static bool operator ==(RouterJobStatus left, RouterJobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouterJobStatus"/> values are not the same. </summary>
        public static bool operator !=(RouterJobStatus left, RouterJobStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RouterJobStatus"/>. </summary>
        public static implicit operator RouterJobStatus(string value) => new RouterJobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouterJobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouterJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
