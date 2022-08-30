// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The StringEncoded. </summary>
    public partial class StringEncoded
    {
        /// <summary> Initializes a new instance of StringEncoded. </summary>
        internal StringEncoded()
        {
        }

        /// <summary> Initializes a new instance of StringEncoded. </summary>
        /// <param name="encoded"></param>
        /// <param name="content"></param>
        internal StringEncoded(bool? encoded, string content)
        {
            Encoded = encoded;
            Content = content;
        }

        /// <summary> Gets the encoded. </summary>
        public bool? Encoded { get; }
        /// <summary> Gets the content. </summary>
        public string Content { get; }
    }
}
