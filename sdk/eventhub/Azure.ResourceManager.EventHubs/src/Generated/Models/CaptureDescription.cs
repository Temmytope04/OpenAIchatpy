// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure capture description for eventhub. </summary>
    public partial class CaptureDescription
    {
        /// <summary> Initializes a new instance of CaptureDescription. </summary>
        public CaptureDescription()
        {
        }

        /// <summary> Initializes a new instance of CaptureDescription. </summary>
        /// <param name="enabled"> A value that indicates whether capture description is enabled. </param>
        /// <param name="encoding"> Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version. </param>
        /// <param name="intervalInSeconds"> The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds. </param>
        /// <param name="sizeLimitInBytes"> The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes. </param>
        /// <param name="destination"> Properties of Destination where capture will be stored. (Storage Account, Blob Names). </param>
        /// <param name="skipEmptyArchives"> A value that indicates whether to Skip Empty Archives. </param>
        internal CaptureDescription(bool? enabled, EncodingCaptureDescription? encoding, int? intervalInSeconds, int? sizeLimitInBytes, EventHubDestination destination, bool? skipEmptyArchives)
        {
            Enabled = enabled;
            Encoding = encoding;
            IntervalInSeconds = intervalInSeconds;
            SizeLimitInBytes = sizeLimitInBytes;
            Destination = destination;
            SkipEmptyArchives = skipEmptyArchives;
        }

        /// <summary> A value that indicates whether capture description is enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version. </summary>
        public EncodingCaptureDescription? Encoding { get; set; }
        /// <summary> The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds. </summary>
        public int? IntervalInSeconds { get; set; }
        /// <summary> The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes. </summary>
        public int? SizeLimitInBytes { get; set; }
        /// <summary> Properties of Destination where capture will be stored. (Storage Account, Blob Names). </summary>
        public EventHubDestination Destination { get; set; }
        /// <summary> A value that indicates whether to Skip Empty Archives. </summary>
        public bool? SkipEmptyArchives { get; set; }
    }
}
