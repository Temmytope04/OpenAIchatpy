// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Document model info. </summary>
    public partial class DocumentModelDetails
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

        /// <summary> Initializes a new instance of <see cref="DocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="createdOn"> Date and time (UTC) when the document model was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal DocumentModelDetails(string modelId, DateTimeOffset createdOn)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            CreatedOn = createdOn;
            Tags = new OptionalDictionary<string, string>();
            DocTypes = new OptionalDictionary<string, DocumentTypeDetails>();
            Warnings = new ChangeTrackingList<DocumentIntelligenceWarning>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="description"> Document model description. </param>
        /// <param name="createdOn"> Date and time (UTC) when the document model was created. </param>
        /// <param name="expiresOn"> Date and time (UTC) when the document model will expire. </param>
        /// <param name="apiVersion"> API version used to create this document model. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="buildMode"> Custom document model build mode. </param>
        /// <param name="azureBlobSource">
        /// Azure Blob Storage location containing the training data.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </param>
        /// <param name="azureBlobFileListSource">
        /// Azure Blob Storage file list specifying the training data.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </param>
        /// <param name="docTypes"> Supported document types. </param>
        /// <param name="warnings"> List of warnings encountered while building the model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentModelDetails(string modelId, string description, DateTimeOffset createdOn, DateTimeOffset? expiresOn, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentBuildMode? buildMode, AzureBlobContentSource azureBlobSource, AzureBlobFileListContentSource azureBlobFileListSource, IReadOnlyDictionary<string, DocumentTypeDetails> docTypes, IReadOnlyList<DocumentIntelligenceWarning> warnings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            Description = description;
            CreatedOn = createdOn;
            ExpiresOn = expiresOn;
            ApiVersion = apiVersion;
            Tags = tags;
            BuildMode = buildMode;
            AzureBlobSource = azureBlobSource;
            AzureBlobFileListSource = azureBlobFileListSource;
            DocTypes = docTypes;
            Warnings = warnings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelDetails"/> for deserialization. </summary>
        internal DocumentModelDetails()
        {
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; }
        /// <summary> Date and time (UTC) when the document model was created. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Date and time (UTC) when the document model will expire. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> API version used to create this document model. </summary>
        public string ApiVersion { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Custom document model build mode. </summary>
        public DocumentBuildMode? BuildMode { get; }
        /// <summary>
        /// Azure Blob Storage location containing the training data.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        public AzureBlobContentSource AzureBlobSource { get; }
        /// <summary>
        /// Azure Blob Storage file list specifying the training data.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </summary>
        public AzureBlobFileListContentSource AzureBlobFileListSource { get; }
        /// <summary> Supported document types. </summary>
        public IReadOnlyDictionary<string, DocumentTypeDetails> DocTypes { get; }
        /// <summary> List of warnings encountered while building the model. </summary>
        public IReadOnlyList<DocumentIntelligenceWarning> Warnings { get; }
    }
}
