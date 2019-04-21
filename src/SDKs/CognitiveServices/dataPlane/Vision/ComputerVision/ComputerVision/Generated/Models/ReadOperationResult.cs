// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OCR result of the read operation.
    /// </summary>
    public partial class ReadOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the ReadOperationResult class.
        /// </summary>
        public ReadOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReadOperationResult class.
        /// </summary>
        /// <param name="status">Status of the read operation. Possible values
        /// include: 'Not Started', 'Running', 'Failed', 'Succeeded'</param>
        /// <param name="recognitionResults">An array of text recognition
        /// result of the read operation.</param>
        public ReadOperationResult(TextOperationStatusCodes status = default(TextOperationStatusCodes), IList<TextRecognitionResult> recognitionResults = default(IList<TextRecognitionResult>))
        {
            Status = status;
            RecognitionResults = recognitionResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the read operation. Possible values include:
        /// 'Not Started', 'Running', 'Failed', 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TextOperationStatusCodes Status { get; set; }

        /// <summary>
        /// Gets or sets an array of text recognition result of the read
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "recognitionResults")]
        public IList<TextRecognitionResult> RecognitionResults { get; set; }

    }
}
