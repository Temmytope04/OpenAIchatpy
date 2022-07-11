// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The result of the test input or output request. </summary>
    public partial class TestDatasourceResult : StreamAnalyticsError
    {
        /// <summary> Initializes a new instance of TestDatasourceResult. </summary>
        internal TestDatasourceResult()
        {
        }

        /// <summary> Initializes a new instance of TestDatasourceResult. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="details"> Error details. </param>
        /// <param name="status"> The status of the sample output request. </param>
        internal TestDatasourceResult(string code, string message, string target, IReadOnlyList<StreamAnalyticsErrorDetails> details, TestDatasourceResultStatus? status) : base(code, message, target, details)
        {
            Status = status;
        }

        /// <summary> The status of the sample output request. </summary>
        public TestDatasourceResultStatus? Status { get; }
    }
}
