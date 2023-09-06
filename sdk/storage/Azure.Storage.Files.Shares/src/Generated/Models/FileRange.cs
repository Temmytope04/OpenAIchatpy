// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An Azure Storage file range. </summary>
    internal partial class FileRange
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FileRange"/>. </summary>
        /// <param name="start"> Start of the range. </param>
        /// <param name="end"> End of the range. </param>
        internal FileRange(long start, long end)
        {
            Start = start;
            End = end;
        }

        /// <summary> Initializes a new instance of <see cref="FileRange"/>. </summary>
        /// <param name="start"> Start of the range. </param>
        /// <param name="end"> End of the range. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FileRange(long start, long end, Dictionary<string, BinaryData> rawData)
        {
            Start = start;
            End = end;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FileRange"/> for deserialization. </summary>
        internal FileRange()
        {
        }

        /// <summary> Start of the range. </summary>
        public long Start { get; }
        /// <summary> End of the range. </summary>
        public long End { get; }
    }
}
