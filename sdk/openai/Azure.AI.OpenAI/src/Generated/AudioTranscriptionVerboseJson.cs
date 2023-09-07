// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Transcription response. </summary>
    internal partial class AudioTranscriptionVerboseJson : AudioTranscriptionSimpleJson
    {
        /// <summary> Initializes a new instance of AudioTranscriptionVerboseJson. </summary>
        /// <param name="text"> Transcribed text. </param>
        /// <param name="task"> Audio transcription task. </param>
        /// <param name="language"> Language detected in the source audio file. </param>
        /// <param name="duration"> Duration. </param>
        /// <param name="segments"> Segments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/>, <paramref name="language"/> or <paramref name="segments"/> is null. </exception>
        internal AudioTranscriptionVerboseJson(string text, AudioTranscriptionTask task, string language, TimeSpan duration, IEnumerable<AudioTranscriptionSegment> segments) : base(text)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(language, nameof(language));
            Argument.AssertNotNull(segments, nameof(segments));

            Task = task;
            Language = language;
            Duration = duration;
            Segments = segments.ToList();
        }

        /// <summary> Initializes a new instance of AudioTranscriptionVerboseJson. </summary>
        /// <param name="text"> Transcribed text. </param>
        /// <param name="task"> Audio transcription task. </param>
        /// <param name="language"> Language detected in the source audio file. </param>
        /// <param name="duration"> Duration. </param>
        /// <param name="segments"> Segments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal AudioTranscriptionVerboseJson(string text, AudioTranscriptionTask task, string language, TimeSpan duration, IReadOnlyList<AudioTranscriptionSegment> segments) : base(text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Task = task;
            Language = language;
            Duration = duration;
            Segments = segments;
        }

        /// <summary> Audio transcription task. </summary>
        public AudioTranscriptionTask Task { get; }
        /// <summary> Language detected in the source audio file. </summary>
        public string Language { get; }
        /// <summary> Duration. </summary>
        public TimeSpan Duration { get; }
        /// <summary> Segments. </summary>
        public IReadOnlyList<AudioTranscriptionSegment> Segments { get; }
    }
}
