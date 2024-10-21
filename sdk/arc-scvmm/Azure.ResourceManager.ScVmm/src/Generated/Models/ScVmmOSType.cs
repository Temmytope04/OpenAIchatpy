// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> Defines the different types of VM guest operating systems. </summary>
    public readonly partial struct ScVmmOSType : IEquatable<ScVmmOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScVmmOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScVmmOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string OtherValue = "Other";

        /// <summary> Windows. </summary>
        public static ScVmmOSType Windows { get; } = new ScVmmOSType(WindowsValue);
        /// <summary> Linux. </summary>
        public static ScVmmOSType Linux { get; } = new ScVmmOSType(LinuxValue);
        /// <summary> Other. </summary>
        public static ScVmmOSType Other { get; } = new ScVmmOSType(OtherValue);
        /// <summary> Determines if two <see cref="ScVmmOSType"/> values are the same. </summary>
        public static bool operator ==(ScVmmOSType left, ScVmmOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScVmmOSType"/> values are not the same. </summary>
        public static bool operator !=(ScVmmOSType left, ScVmmOSType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScVmmOSType"/>. </summary>
        public static implicit operator ScVmmOSType(string value) => new ScVmmOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScVmmOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScVmmOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
