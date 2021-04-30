// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using System.Linq;

    /// <summary>
    /// Network access control rules for the endpoints.
    /// </summary>
    public partial class DataCollectionEndpointNetworkAcls : NetworkRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpointNetworkAcls
        /// class.
        /// </summary>
        public DataCollectionEndpointNetworkAcls()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpointNetworkAcls
        /// class.
        /// </summary>
        /// <param name="publicNetworkAccess">The configuration to set whether
        /// network access from public internet to the endpoints are allowed.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        public DataCollectionEndpointNetworkAcls(string publicNetworkAccess = default(string))
            : base(publicNetworkAccess)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
