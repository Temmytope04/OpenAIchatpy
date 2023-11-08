// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The expression traces. </summary>
    internal partial class ExpressionTraces
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpressionTraces"/>. </summary>
        internal ExpressionTraces()
        {
            Inputs = new ChangeTrackingList<LogicExpressionRoot>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressionTraces"/>. </summary>
        /// <param name="inputs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressionTraces(IReadOnlyList<LogicExpressionRoot> inputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Inputs = inputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the inputs. </summary>
        public IReadOnlyList<LogicExpressionRoot> Inputs { get; }
    }
}
