// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Type of the Trigger. </summary>
    public readonly partial struct CosmosDBSqlTriggerType : IEquatable<CosmosDBSqlTriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBSqlTriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreValue = "Pre";
        private const string PostValue = "Post";

        /// <summary> Pre. </summary>
        public static CosmosDBSqlTriggerType Pre { get; } = new CosmosDBSqlTriggerType(PreValue);
        /// <summary> Post. </summary>
        public static CosmosDBSqlTriggerType Post { get; } = new CosmosDBSqlTriggerType(PostValue);
        /// <summary> Determines if two <see cref="CosmosDBSqlTriggerType"/> values are the same. </summary>
        public static bool operator ==(CosmosDBSqlTriggerType left, CosmosDBSqlTriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBSqlTriggerType"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBSqlTriggerType left, CosmosDBSqlTriggerType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CosmosDBSqlTriggerType"/>. </summary>
        public static implicit operator CosmosDBSqlTriggerType(string value) => new CosmosDBSqlTriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBSqlTriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBSqlTriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
