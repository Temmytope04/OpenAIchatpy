// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SparkBatchJob
    {
        /// <summary>
        /// Initializes a new instance of the SparkBatchJob class.
        /// </summary>
        public SparkBatchJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkBatchJob class.
        /// </summary>
        /// <param name="id">The session id.</param>
        /// <param name="appId">The application id of this session.</param>
        /// <param name="appInfo">The detailed application info.</param>
        /// <param name="state">The batch state. Possible values include:
        /// 'not_started', 'starting', 'idle', 'running', 'busy',
        /// 'shutting_down', 'error', 'dead', 'killed', 'success'</param>
        /// <param name="logLines">The log lines.</param>
        public SparkBatchJob(int? id = default(int?), string appId = default(string), IDictionary<string, string> appInfo = default(IDictionary<string, string>), string state = default(string), IList<string> logLines = default(IList<string>))
        {
            Id = id;
            AppId = appId;
            AppInfo = appInfo;
            State = state;
            LogLines = logLines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the application id of this session.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the detailed application info.
        /// </summary>
        [JsonProperty(PropertyName = "appInfo")]
        public IDictionary<string, string> AppInfo { get; set; }

        /// <summary>
        /// Gets or sets the batch state. Possible values include:
        /// 'not_started', 'starting', 'idle', 'running', 'busy',
        /// 'shutting_down', 'error', 'dead', 'killed', 'success'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the log lines.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public IList<string> LogLines { get; set; }

    }
}
