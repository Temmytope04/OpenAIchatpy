// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application logs to Azure table storage configuration.
    /// </summary>
    public partial class AzureTableStorageApplicationLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureTableStorageApplicationLogsConfig class.
        /// </summary>
        public AzureTableStorageApplicationLogsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureTableStorageApplicationLogsConfig class.
        /// </summary>
        /// <param name="sasUrl">SAS URL to an Azure table with
        /// add/query/delete permissions.</param>
        /// <param name="level">Log level. Possible values include: 'Off',
        /// 'Verbose', 'Information', 'Warning', 'Error'</param>
        public AzureTableStorageApplicationLogsConfig(string sasUrl, LogLevel? level = default(LogLevel?))
        {
            Level = level;
            SasUrl = sasUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets log level. Possible values include: 'Off', 'Verbose',
        /// 'Information', 'Warning', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LogLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets SAS URL to an Azure table with add/query/delete
        /// permissions.
        /// </summary>
        [JsonProperty(PropertyName = "sasUrl")]
        public string SasUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SasUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SasUrl");
            }
        }
    }
}
