// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Trigger based on range of status codes. </summary>
    public partial class StatusCodesRangeBasedTrigger
    {
        /// <summary> Initializes a new instance of <see cref="StatusCodesRangeBasedTrigger"/>. </summary>
        public StatusCodesRangeBasedTrigger()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StatusCodesRangeBasedTrigger"/>. </summary>
        /// <param name="statusCodes"> HTTP status code. </param>
        /// <param name="path"></param>
        /// <param name="count"> Request Count. </param>
        /// <param name="timeInterval"> Time interval. </param>
        internal StatusCodesRangeBasedTrigger(string statusCodes, string path, int? count, string timeInterval)
        {
            StatusCodes = statusCodes;
            Path = path;
            Count = count;
            TimeInterval = timeInterval;
        }

        /// <summary> HTTP status code. </summary>
        public string StatusCodes { get; set; }
        /// <summary> Gets or sets the path. </summary>
        public string Path { get; set; }
        /// <summary> Request Count. </summary>
        public int? Count { get; set; }
        /// <summary> Time interval. </summary>
        public string TimeInterval { get; set; }
    }
}
