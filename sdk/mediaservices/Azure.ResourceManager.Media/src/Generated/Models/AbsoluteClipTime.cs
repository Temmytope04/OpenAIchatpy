// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Specifies the clip time as an absolute time position in the media file.  The absolute time can point to a different position depending on whether the media file starts from a timestamp of zero or not. </summary>
    public partial class AbsoluteClipTime : ClipTime
    {
        /// <summary> Initializes a new instance of <see cref="AbsoluteClipTime"/>. </summary>
        /// <param name="time"> The time position on the timeline of the input media. It is usually specified as an ISO8601 period. e.g PT30S for 30 seconds. </param>
        public AbsoluteClipTime(TimeSpan time)
        {
            Time = time;
            OdataType = "#Microsoft.Media.AbsoluteClipTime";
        }

        /// <summary> Initializes a new instance of <see cref="AbsoluteClipTime"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="time"> The time position on the timeline of the input media. It is usually specified as an ISO8601 period. e.g PT30S for 30 seconds. </param>
        internal AbsoluteClipTime(string odataType, TimeSpan time) : base(odataType)
        {
            Time = time;
            OdataType = odataType ?? "#Microsoft.Media.AbsoluteClipTime";
        }

        /// <summary> The time position on the timeline of the input media. It is usually specified as an ISO8601 period. e.g PT30S for 30 seconds. </summary>
        public TimeSpan Time { get; set; }
    }
}
