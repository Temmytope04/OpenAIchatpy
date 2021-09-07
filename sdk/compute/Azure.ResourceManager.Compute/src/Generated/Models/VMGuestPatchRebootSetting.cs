// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Defines when it is acceptable to reboot a VM during a software update operation. </summary>
    public readonly partial struct VMGuestPatchRebootSetting : IEquatable<VMGuestPatchRebootSetting>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VMGuestPatchRebootSetting"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMGuestPatchRebootSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IfRequiredValue = "IfRequired";
        private const string NeverValue = "Never";
        private const string AlwaysValue = "Always";

        /// <summary> IfRequired. </summary>
        public static VMGuestPatchRebootSetting IfRequired { get; } = new VMGuestPatchRebootSetting(IfRequiredValue);
        /// <summary> Never. </summary>
        public static VMGuestPatchRebootSetting Never { get; } = new VMGuestPatchRebootSetting(NeverValue);
        /// <summary> Always. </summary>
        public static VMGuestPatchRebootSetting Always { get; } = new VMGuestPatchRebootSetting(AlwaysValue);
        /// <summary> Determines if two <see cref="VMGuestPatchRebootSetting"/> values are the same. </summary>
        public static bool operator ==(VMGuestPatchRebootSetting left, VMGuestPatchRebootSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMGuestPatchRebootSetting"/> values are not the same. </summary>
        public static bool operator !=(VMGuestPatchRebootSetting left, VMGuestPatchRebootSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VMGuestPatchRebootSetting"/>. </summary>
        public static implicit operator VMGuestPatchRebootSetting(string value) => new VMGuestPatchRebootSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMGuestPatchRebootSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMGuestPatchRebootSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
