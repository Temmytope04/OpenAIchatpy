// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Library requirements for a Big Data pool powered by Apache Spark. </summary>
    public partial class BigDataPoolLibraryRequirements
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BigDataPoolLibraryRequirements"/>. </summary>
        public BigDataPoolLibraryRequirements()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolLibraryRequirements"/>. </summary>
        /// <param name="updatedOn"> The last update time of the library requirements file. </param>
        /// <param name="content"> The library requirements. </param>
        /// <param name="filename"> The filename of the library requirements file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BigDataPoolLibraryRequirements(DateTimeOffset? updatedOn, string content, string filename, Dictionary<string, BinaryData> rawData)
        {
            UpdatedOn = updatedOn;
            Content = content;
            Filename = filename;
            _rawData = rawData;
        }

        /// <summary> The last update time of the library requirements file. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The library requirements. </summary>
        public string Content { get; set; }
        /// <summary> The filename of the library requirements file. </summary>
        public string Filename { get; set; }
    }
}
