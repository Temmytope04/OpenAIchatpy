// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A database restore point.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RestorePoint : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RestorePoint class.
        /// </summary>
        public RestorePoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorePoint class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="restorePointType">The restore point type of the
        /// database restore point. Possible values include: 'DISCRETE',
        /// 'CONTINUOUS'</param>
        /// <param name="restorePointCreationDate">Restore point creation time
        /// (ISO8601 format). Populated when restorePointType = CONTINUOUS.
        /// Null otherwise.</param>
        /// <param name="earliestRestoreDate">Earliest restore time (ISO8601
        /// format). Populated when restorePointType = DISCRETE. Null
        /// otherwise.</param>
        public RestorePoint(string id = default(string), string name = default(string), string type = default(string), RestorePointType? restorePointType = default(RestorePointType?), System.DateTime? restorePointCreationDate = default(System.DateTime?), System.DateTime? earliestRestoreDate = default(System.DateTime?))
            : base(id, name, type)
        {
            RestorePointType = restorePointType;
            RestorePointCreationDate = restorePointCreationDate;
            EarliestRestoreDate = earliestRestoreDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the restore point type of the database restore point. Possible
        /// values include: 'DISCRETE', 'CONTINUOUS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointType")]
        public RestorePointType? RestorePointType { get; private set; }

        /// <summary>
        /// Gets restore point creation time (ISO8601 format). Populated when
        /// restorePointType = CONTINUOUS. Null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointCreationDate")]
        public System.DateTime? RestorePointCreationDate { get; private set; }

        /// <summary>
        /// Gets earliest restore time (ISO8601 format). Populated when
        /// restorePointType = DISCRETE. Null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

    }
}
