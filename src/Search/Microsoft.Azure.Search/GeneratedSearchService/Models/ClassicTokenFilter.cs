// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Removes "'s" from the end of words, and removes dots from acronyms.
    /// This token filter is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/ClassicFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.ClassicTokenFilter")]
    public partial class ClassicTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the ClassicTokenFilter class.
        /// </summary>
        public ClassicTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the ClassicTokenFilter class.
        /// </summary>
        public ClassicTokenFilter(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
