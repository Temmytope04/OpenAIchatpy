// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments. </summary>
    public readonly partial struct SynapseDatabasePrincipalAssignmentType : IEquatable<SynapseDatabasePrincipalAssignmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseDatabasePrincipalAssignmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseDatabasePrincipalAssignmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftSynapseWorkspacesKustoPoolsDatabasesPrincipalAssignmentsValue = "Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments";

        /// <summary> Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments. </summary>
        public static SynapseDatabasePrincipalAssignmentType MicrosoftSynapseWorkspacesKustoPoolsDatabasesPrincipalAssignments { get; } = new SynapseDatabasePrincipalAssignmentType(MicrosoftSynapseWorkspacesKustoPoolsDatabasesPrincipalAssignmentsValue);
        /// <summary> Determines if two <see cref="SynapseDatabasePrincipalAssignmentType"/> values are the same. </summary>
        public static bool operator ==(SynapseDatabasePrincipalAssignmentType left, SynapseDatabasePrincipalAssignmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseDatabasePrincipalAssignmentType"/> values are not the same. </summary>
        public static bool operator !=(SynapseDatabasePrincipalAssignmentType left, SynapseDatabasePrincipalAssignmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseDatabasePrincipalAssignmentType"/>. </summary>
        public static implicit operator SynapseDatabasePrincipalAssignmentType(string value) => new SynapseDatabasePrincipalAssignmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseDatabasePrincipalAssignmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseDatabasePrincipalAssignmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
