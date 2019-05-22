// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used when calling trigger change detection action on
    /// cloud endpoint.
    /// </summary>
    public partial class TriggerChangeDetectionParameters
    {
        /// <summary>
        /// Initializes a new instance of the TriggerChangeDetectionParameters
        /// class.
        /// </summary>
        public TriggerChangeDetectionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggerChangeDetectionParameters
        /// class.
        /// </summary>
        /// <param name="directoryPath">Relative path to a directory Azure File
        /// share for which change detection is to be performed.</param>
        /// <param name="changeDetectionMode">Change Detection Mode. Applies to
        /// a directory specified in directoryPath parameter. Possible values
        /// include: 'Default', 'Recursive'</param>
        /// <param name="paths">Array of relative paths on the Azure File share
        /// to be included in the change detection. Can be files and
        /// directories.</param>
        public TriggerChangeDetectionParameters(string directoryPath = default(string), string changeDetectionMode = default(string), IList<string> paths = default(IList<string>))
        {
            DirectoryPath = directoryPath;
            ChangeDetectionMode = changeDetectionMode;
            Paths = paths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets relative path to a directory Azure File share for
        /// which change detection is to be performed.
        /// </summary>
        [JsonProperty(PropertyName = "directoryPath")]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Gets or sets change Detection Mode. Applies to a directory
        /// specified in directoryPath parameter. Possible values include:
        /// 'Default', 'Recursive'
        /// </summary>
        [JsonProperty(PropertyName = "changeDetectionMode")]
        public string ChangeDetectionMode { get; set; }

        /// <summary>
        /// Gets array of relative paths on the Azure File share to be included
        /// in the change detection. Can be files and directories.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<string> Paths { get; private set; }

    }
}
