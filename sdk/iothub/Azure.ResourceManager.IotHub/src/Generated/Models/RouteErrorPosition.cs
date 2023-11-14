// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Position where the route error happened. </summary>
    public partial class RouteErrorPosition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteErrorPosition"/>. </summary>
        internal RouteErrorPosition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteErrorPosition"/>. </summary>
        /// <param name="line"> Line where the route error happened. </param>
        /// <param name="column"> Column where the route error happened. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteErrorPosition(int? line, int? column, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Line = line;
            Column = column;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Line where the route error happened. </summary>
        public int? Line { get; }
        /// <summary> Column where the route error happened. </summary>
        public int? Column { get; }
    }
}
