// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RecoveryPointDataStoreDetails
    /// </summary>
    /// <remarks>
    /// RecoveryPoint datastore details
    /// </remarks>
    public partial class RecoveryPointDataStoreDetails
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPointDataStoreDetails
        /// class.
        /// </summary>
        public RecoveryPointDataStoreDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPointDataStoreDetails
        /// class.
        /// </summary>
        /// <param name="rehydrationStatus">Possible values include:
        /// 'CREATE_IN_PROGRESS', 'COMPLETED', 'DELETE_IN_PROGRESS', 'DELETED',
        /// 'FAILED'</param>
        public RecoveryPointDataStoreDetails(System.DateTime? creationTime = default(System.DateTime?), System.DateTime? expiryTime = default(System.DateTime?), string id = default(string), string metaData = default(string), string state = default(string), string type = default(string), bool? visible = default(bool?), System.DateTime? rehydrationExpiryTime = default(System.DateTime?), string rehydrationStatus = default(string))
        {
            CreationTime = creationTime;
            ExpiryTime = expiryTime;
            Id = id;
            MetaData = metaData;
            State = state;
            Type = type;
            Visible = visible;
            RehydrationExpiryTime = rehydrationExpiryTime;
            RehydrationStatus = rehydrationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metaData")]
        public string MetaData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rehydrationExpiryTime")]
        public System.DateTime? RehydrationExpiryTime { get; private set; }

        /// <summary>
        /// Gets possible values include: 'CREATE_IN_PROGRESS', 'COMPLETED',
        /// 'DELETE_IN_PROGRESS', 'DELETED', 'FAILED'
        /// </summary>
        [JsonProperty(PropertyName = "rehydrationStatus")]
        public string RehydrationStatus { get; private set; }

    }
}
