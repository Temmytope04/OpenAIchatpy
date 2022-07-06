// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Helps with categorization of errors. </summary>
    public readonly partial struct JobErrorCategory : IEquatable<JobErrorCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobErrorCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobErrorCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceValue = "Service";
        private const string DownloadValue = "Download";
        private const string UploadValue = "Upload";
        private const string ConfigurationValue = "Configuration";
        private const string ContentValue = "Content";

        /// <summary> The error is service related. </summary>
        public static JobErrorCategory Service { get; } = new JobErrorCategory(ServiceValue);
        /// <summary> The error is download related. </summary>
        public static JobErrorCategory Download { get; } = new JobErrorCategory(DownloadValue);
        /// <summary> The error is upload related. </summary>
        public static JobErrorCategory Upload { get; } = new JobErrorCategory(UploadValue);
        /// <summary> The error is configuration related. </summary>
        public static JobErrorCategory Configuration { get; } = new JobErrorCategory(ConfigurationValue);
        /// <summary> The error is related to data in the input files. </summary>
        public static JobErrorCategory Content { get; } = new JobErrorCategory(ContentValue);
        /// <summary> Determines if two <see cref="JobErrorCategory"/> values are the same. </summary>
        public static bool operator ==(JobErrorCategory left, JobErrorCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobErrorCategory"/> values are not the same. </summary>
        public static bool operator !=(JobErrorCategory left, JobErrorCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobErrorCategory"/>. </summary>
        public static implicit operator JobErrorCategory(string value) => new JobErrorCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobErrorCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobErrorCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
