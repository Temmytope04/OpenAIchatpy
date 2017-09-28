// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Staging settings.
    /// </summary>
    public partial class StagingSettings
    {
        /// <summary>
        /// Initializes a new instance of the StagingSettings class.
        /// </summary>
        public StagingSettings()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StagingSettings class.
        /// </summary>
        /// <param name="linkedServiceName">Staging linked service
        /// reference.</param>
        /// <param name="path">The path to storage for storing the interim
        /// data. Type: string (or Expression with resultType string).</param>
        /// <param name="enableCompression">Specifies whether to use
        /// compression when copying data via an interim staging. Default value
        /// is false. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public StagingSettings(LinkedServiceReference linkedServiceName, object path = default(object), object enableCompression = default(object))
        {
            LinkedServiceName = new LinkedServiceReference();
            LinkedServiceName = linkedServiceName;
            Path = path;
            EnableCompression = enableCompression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets staging linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the path to storage for storing the interim data.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public object Path { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use compression when copying data
        /// via an interim staging. Default value is false. Type: boolean (or
        /// Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "enableCompression")]
        public object EnableCompression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedServiceName");
            }
            if (LinkedServiceName != null)
            {
                LinkedServiceName.Validate();
            }
        }
    }
}
