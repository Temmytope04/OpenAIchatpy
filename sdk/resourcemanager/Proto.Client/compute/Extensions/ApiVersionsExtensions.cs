using Azure.ResourceManager.Core;

namespace Proto.Compute.Extensions
{
    /// <summary>
    /// A class to add extension methods to AzureResourceManagerClientOptions.
    /// </summary>
    public static class ApiVersionsExtensions
    {
        /// <summary>
        /// Adds a method to AzureResourceManagerClientOptions which returns all the versions to all resources inside the compute resource provider.
        /// </summary>
        ///<param> The <see  cref="ApiVersions" /> instance the method will execute against. </param>
        /// <returns> Returns a response with the <see cref="ComputeRestApiVersions"/> operation for this resource. </returns>
        public static ComputeRestApiVersions GetComputeRestApiVersions(this ApiVersions apiVersionsExtensions)
        {
            return new ComputeRestApiVersions();
        }
    }
}
