// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary>
    /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
    /// &lt;list&gt;&lt;item&gt;Multiple: multiple revisions can be active.&lt;/item&gt;&lt;item&gt;Single: Only one revision can be active at a time. Revision weights can not be used in this mode. If no value if provided, this is the default.&lt;/item&gt;&lt;/list&gt;
    /// </summary>
    public readonly partial struct ContainerAppActiveRevisionsMode : IEquatable<ContainerAppActiveRevisionsMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppActiveRevisionsMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppActiveRevisionsMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MultipleValue = "Multiple";
        private const string SingleValue = "Single";

        /// <summary> Multiple. </summary>
        public static ContainerAppActiveRevisionsMode Multiple { get; } = new ContainerAppActiveRevisionsMode(MultipleValue);
        /// <summary> Single. </summary>
        public static ContainerAppActiveRevisionsMode Single { get; } = new ContainerAppActiveRevisionsMode(SingleValue);
        /// <summary> Determines if two <see cref="ContainerAppActiveRevisionsMode"/> values are the same. </summary>
        public static bool operator ==(ContainerAppActiveRevisionsMode left, ContainerAppActiveRevisionsMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppActiveRevisionsMode"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppActiveRevisionsMode left, ContainerAppActiveRevisionsMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerAppActiveRevisionsMode"/>. </summary>
        public static implicit operator ContainerAppActiveRevisionsMode(string value) => new ContainerAppActiveRevisionsMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppActiveRevisionsMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppActiveRevisionsMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
