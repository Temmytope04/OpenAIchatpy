// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Dictionary Example. </summary>
    public partial class DictionaryExample
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of DictionaryExample. </summary>
        /// <param name="sourcePrefix">
        /// The string to concatenate before the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </param>
        /// <param name="sourceTerm">
        /// A string equal to the actual term looked up. The string is added with sourcePrefix
        /// and sourceSuffix to form the complete example. Its value is separated so it can be
        /// marked in a user interface, e.g., by bolding it.
        /// </param>
        /// <param name="sourceSuffix">
        /// The string to concatenate after the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </param>
        /// <param name="targetPrefix"> A string similar to sourcePrefix but for the target. </param>
        /// <param name="targetTerm"> A string similar to sourceTerm but for the target. </param>
        /// <param name="targetSuffix"> A string similar to sourceSuffix but for the target. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourcePrefix"/>, <paramref name="sourceTerm"/>, <paramref name="sourceSuffix"/>, <paramref name="targetPrefix"/>, <paramref name="targetTerm"/> or <paramref name="targetSuffix"/> is null. </exception>
        internal DictionaryExample(string sourcePrefix, string sourceTerm, string sourceSuffix, string targetPrefix, string targetTerm, string targetSuffix)
        {
            Argument.AssertNotNull(sourcePrefix, nameof(sourcePrefix));
            Argument.AssertNotNull(sourceTerm, nameof(sourceTerm));
            Argument.AssertNotNull(sourceSuffix, nameof(sourceSuffix));
            Argument.AssertNotNull(targetPrefix, nameof(targetPrefix));
            Argument.AssertNotNull(targetTerm, nameof(targetTerm));
            Argument.AssertNotNull(targetSuffix, nameof(targetSuffix));

            SourcePrefix = sourcePrefix;
            SourceTerm = sourceTerm;
            SourceSuffix = sourceSuffix;
            TargetPrefix = targetPrefix;
            TargetTerm = targetTerm;
            TargetSuffix = targetSuffix;
        }

        /// <summary> Initializes a new instance of DictionaryExample. </summary>
        /// <param name="sourcePrefix">
        /// The string to concatenate before the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </param>
        /// <param name="sourceTerm">
        /// A string equal to the actual term looked up. The string is added with sourcePrefix
        /// and sourceSuffix to form the complete example. Its value is separated so it can be
        /// marked in a user interface, e.g., by bolding it.
        /// </param>
        /// <param name="sourceSuffix">
        /// The string to concatenate after the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </param>
        /// <param name="targetPrefix"> A string similar to sourcePrefix but for the target. </param>
        /// <param name="targetTerm"> A string similar to sourceTerm but for the target. </param>
        /// <param name="targetSuffix"> A string similar to sourceSuffix but for the target. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DictionaryExample(string sourcePrefix, string sourceTerm, string sourceSuffix, string targetPrefix, string targetTerm, string targetSuffix, Dictionary<string, BinaryData> rawData)
        {
            SourcePrefix = sourcePrefix;
            SourceTerm = sourceTerm;
            SourceSuffix = sourceSuffix;
            TargetPrefix = targetPrefix;
            TargetTerm = targetTerm;
            TargetSuffix = targetSuffix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DictionaryExample"/> for deserialization. </summary>
        internal DictionaryExample()
        {
        }

        /// <summary>
        /// The string to concatenate before the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </summary>
        public string SourcePrefix { get; }
        /// <summary>
        /// A string equal to the actual term looked up. The string is added with sourcePrefix
        /// and sourceSuffix to form the complete example. Its value is separated so it can be
        /// marked in a user interface, e.g., by bolding it.
        /// </summary>
        public string SourceTerm { get; }
        /// <summary>
        /// The string to concatenate after the value of sourceTerm to form a complete example.
        /// Do not add a space character, since it is already there when it should be.
        /// This value may be an empty string.
        /// </summary>
        public string SourceSuffix { get; }
        /// <summary> A string similar to sourcePrefix but for the target. </summary>
        public string TargetPrefix { get; }
        /// <summary> A string similar to sourceTerm but for the target. </summary>
        public string TargetTerm { get; }
        /// <summary> A string similar to sourceSuffix but for the target. </summary>
        public string TargetSuffix { get; }
    }
}
