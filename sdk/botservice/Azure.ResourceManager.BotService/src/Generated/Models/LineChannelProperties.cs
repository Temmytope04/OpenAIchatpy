// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Line channel. </summary>
    public partial class LineChannelProperties
    {
        /// <summary> Initializes a new instance of LineChannelProperties. </summary>
        /// <param name="lineRegistrations"> The list of line channel registrations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lineRegistrations"/> is null. </exception>
        public LineChannelProperties(IEnumerable<LineRegistration> lineRegistrations)
        {
            if (lineRegistrations == null)
            {
                throw new ArgumentNullException(nameof(lineRegistrations));
            }

            LineRegistrations = lineRegistrations.ToList();
        }

        /// <summary> Initializes a new instance of LineChannelProperties. </summary>
        /// <param name="lineRegistrations"> The list of line channel registrations. </param>
        /// <param name="callbackUri"> Callback Url to enter in line registration. </param>
        /// <param name="isValidated"> Whether this channel is validated for the bot. </param>
        internal LineChannelProperties(IList<LineRegistration> lineRegistrations, Uri callbackUri, bool? isValidated)
        {
            LineRegistrations = lineRegistrations;
            CallbackUri = callbackUri;
            IsValidated = isValidated;
        }

        /// <summary> The list of line channel registrations. </summary>
        public IList<LineRegistration> LineRegistrations { get; }
        /// <summary> Callback Url to enter in line registration. </summary>
        public Uri CallbackUri { get; }
        /// <summary> Whether this channel is validated for the bot. </summary>
        public bool? IsValidated { get; }
    }
}
