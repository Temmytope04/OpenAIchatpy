// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of get all accounts Operation. </summary>
    internal partial class NewRelicAccountsListResult
    {
        /// <summary> Initializes a new instance of NewRelicAccountsListResult. </summary>
        /// <param name="value"> The AccountResource items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NewRelicAccountsListResult(IEnumerable<NewRelicAccountResourceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of NewRelicAccountsListResult. </summary>
        /// <param name="value"> The AccountResource items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal NewRelicAccountsListResult(IReadOnlyList<NewRelicAccountResourceData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The AccountResource items on this page. </summary>
        public IReadOnlyList<NewRelicAccountResourceData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
