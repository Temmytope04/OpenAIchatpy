// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Sample utterance. </summary>
    public partial class SampleUtterance
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SampleUtterance"/>. </summary>
        public SampleUtterance()
        {
            Links = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SampleUtterance"/>. </summary>
        /// <param name="text"> Text attribute of sample utterance. </param>
        /// <param name="links"> Links attribute of sample utterance. </param>
        /// <param name="qid"> Question id of sample utterance (for stackoverflow questions titles). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SampleUtterance(string text, IList<string> links, string qid, Dictionary<string, BinaryData> rawData)
        {
            Text = text;
            Links = links;
            Qid = qid;
            _rawData = rawData;
        }

        /// <summary> Text attribute of sample utterance. </summary>
        public string Text { get; set; }
        /// <summary> Links attribute of sample utterance. </summary>
        public IList<string> Links { get; }
        /// <summary> Question id of sample utterance (for stackoverflow questions titles). </summary>
        public string Qid { get; set; }
    }
}
