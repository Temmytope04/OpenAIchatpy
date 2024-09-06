// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the align mode between Virtual Machine Scale Set compute and storage Fault Domain count. </summary>
    public readonly partial struct ZonalPlatformFaultDomainAlignMode : IEquatable<ZonalPlatformFaultDomainAlignMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ZonalPlatformFaultDomainAlignMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ZonalPlatformFaultDomainAlignMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlignedValue = "Aligned";
        private const string UnalignedValue = "Unaligned";

        /// <summary> Aligned. </summary>
        public static ZonalPlatformFaultDomainAlignMode Aligned { get; } = new ZonalPlatformFaultDomainAlignMode(AlignedValue);
        /// <summary> Unaligned. </summary>
        public static ZonalPlatformFaultDomainAlignMode Unaligned { get; } = new ZonalPlatformFaultDomainAlignMode(UnalignedValue);
        /// <summary> Determines if two <see cref="ZonalPlatformFaultDomainAlignMode"/> values are the same. </summary>
        public static bool operator ==(ZonalPlatformFaultDomainAlignMode left, ZonalPlatformFaultDomainAlignMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ZonalPlatformFaultDomainAlignMode"/> values are not the same. </summary>
        public static bool operator !=(ZonalPlatformFaultDomainAlignMode left, ZonalPlatformFaultDomainAlignMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ZonalPlatformFaultDomainAlignMode"/>. </summary>
        public static implicit operator ZonalPlatformFaultDomainAlignMode(string value) => new ZonalPlatformFaultDomainAlignMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ZonalPlatformFaultDomainAlignMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ZonalPlatformFaultDomainAlignMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
