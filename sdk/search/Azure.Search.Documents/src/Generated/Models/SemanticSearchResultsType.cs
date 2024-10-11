// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Type of partial response that was returned for a semantic ranking request. </summary>
    public readonly partial struct SemanticSearchResultsType : IEquatable<SemanticSearchResultsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SemanticSearchResultsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SemanticSearchResultsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BaseResultsValue = "baseResults";
        private const string RerankedResultsValue = "rerankedResults";

        /// <summary> Results without any semantic enrichment or reranking. </summary>
        public static SemanticSearchResultsType BaseResults { get; } = new SemanticSearchResultsType(BaseResultsValue);
        /// <summary> Results have been reranked with the reranker model and will include semantic captions. They will not include any answers, answers highlights or caption highlights. </summary>
        public static SemanticSearchResultsType RerankedResults { get; } = new SemanticSearchResultsType(RerankedResultsValue);
        /// <summary> Determines if two <see cref="SemanticSearchResultsType"/> values are the same. </summary>
        public static bool operator ==(SemanticSearchResultsType left, SemanticSearchResultsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SemanticSearchResultsType"/> values are not the same. </summary>
        public static bool operator !=(SemanticSearchResultsType left, SemanticSearchResultsType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SemanticSearchResultsType"/>. </summary>
        public static implicit operator SemanticSearchResultsType(string value) => new SemanticSearchResultsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SemanticSearchResultsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SemanticSearchResultsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
