// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> Request to submit a detection. </summary>
    public partial class DetectionRequest
    {
        /// <summary> Initializes a new instance of DetectionRequest. </summary>
        /// <param name="source"> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, a extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. The variables used in detection should be consistent with variables in the model used for detection. </param>
        /// <param name="startTime"> A require field, start time of data be used for detection, should be date-time. </param>
        /// <param name="endTime"> A require field, end time of data be used for detection, should be date-time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public DetectionRequest(string source, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, a extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. The variables used in detection should be consistent with variables in the model used for detection. </summary>
        public string Source { get; set; }
        /// <summary> A require field, start time of data be used for detection, should be date-time. </summary>
        public DateTimeOffset StartTime { get; set; }
        /// <summary> A require field, end time of data be used for detection, should be date-time. </summary>
        public DateTimeOffset EndTime { get; set; }
    }
}
