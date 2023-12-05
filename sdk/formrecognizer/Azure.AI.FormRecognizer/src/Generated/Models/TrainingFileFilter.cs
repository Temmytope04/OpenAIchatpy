// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Filter to apply to the documents in the source path for training. </summary>
    public partial class TrainingFileFilter
    {
        /// <summary> Initializes a new instance of <see cref="TrainingFileFilter"/>. </summary>
        /// <param name="prefix"> A case-sensitive prefix string to filter documents in the source path for training. For example, when using a Azure storage blob Uri, use the prefix to restrict sub folders for training. </param>
        /// <param name="includeSubfolders"> A flag to indicate if sub folders within the set of prefix folders will also need to be included when searching for content to be preprocessed. </param>
        internal TrainingFileFilter(string prefix, bool includeSubfolders)
        {
            Prefix = prefix;
            IncludeSubfolders = includeSubfolders;
        }
    }
}
