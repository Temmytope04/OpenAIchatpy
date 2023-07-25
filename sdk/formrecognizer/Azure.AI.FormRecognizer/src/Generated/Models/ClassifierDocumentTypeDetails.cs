// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Training data source. </summary>
    public partial class ClassifierDocumentTypeDetails
    {
        /// <summary> Initializes a new instance of ClassifierDocumentTypeDetails. </summary>
        /// <param name="azureBlobSource"> Azure Blob Storage location containing the training data. </param>
        /// <param name="azureBlobFileListSource"> Azure Blob Storage file list specifying the training data. </param>
        internal ClassifierDocumentTypeDetails(AzureBlobContentSource azureBlobSource, AzureBlobFileListSource azureBlobFileListSource)
        {
            AzureBlobSource = azureBlobSource;
            AzureBlobFileListSource = azureBlobFileListSource;
        }
    }
}
