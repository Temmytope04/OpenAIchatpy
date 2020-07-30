// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    /// <summary> A result containing a document found by a suggestion query, plus associated metadata. </summary>
    internal partial class SuggestResult : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of SuggestResult. </summary>
        /// <param name="text"> The text of the suggestion result. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal SuggestResult(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Text = text;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SuggestResult. </summary>
        /// <param name="text"> The text of the suggestion result. </param>
        /// <param name="additionalProperties"> . </param>
        internal SuggestResult(string text, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Text = text;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The text of the suggestion result. </summary>
        public string Text { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
