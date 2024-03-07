// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Classifier document type info. </summary>
    public partial class ClassifierDocumentTypeDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClassifierDocumentTypeDetails"/>. </summary>
        public ClassifierDocumentTypeDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClassifierDocumentTypeDetails"/>. </summary>
        /// <param name="sourceKind"> Type of training data source. </param>
        /// <param name="azureBlobSource">
        /// Azure Blob Storage location containing the training data for a classifier
        /// document type.  Either azureBlobSource or azureBlobFileListSource must be
        /// specified.
        /// </param>
        /// <param name="azureBlobFileListSource">
        /// Azure Blob Storage file list specifying the training data for a classifier
        /// document type.  Either azureBlobSource or azureBlobFileListSource must be
        /// specified.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClassifierDocumentTypeDetails(ContentSourceKind? sourceKind, AzureBlobContentSource azureBlobSource, AzureBlobFileListContentSource azureBlobFileListSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceKind = sourceKind;
            AzureBlobSource = azureBlobSource;
            AzureBlobFileListSource = azureBlobFileListSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of training data source. </summary>
        public ContentSourceKind? SourceKind { get; set; }
        /// <summary>
        /// Azure Blob Storage location containing the training data for a classifier
        /// document type.  Either azureBlobSource or azureBlobFileListSource must be
        /// specified.
        /// </summary>
        public AzureBlobContentSource AzureBlobSource { get; set; }
        /// <summary>
        /// Azure Blob Storage file list specifying the training data for a classifier
        /// document type.  Either azureBlobSource or azureBlobFileListSource must be
        /// specified.
        /// </summary>
        public AzureBlobFileListContentSource AzureBlobFileListSource { get; set; }
    }
}
