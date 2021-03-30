// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BackupPolicies operations.
    /// </summary>
    public partial interface IBackupPolicies
    {
        /// <summary>
        /// Returns list of backup policies belonging to a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<BaseBackupPolicyResourceList>> ListWithHttpMessagesAsync(string vaultName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a backup policy belonging to a backup vault
        /// </summary>
        /// <remarks>
        /// Gets a backup policy belonging to a backup vault
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupPolicyName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<BaseBackupPolicyResource>> GetWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or Updates a backup policy belonging to a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupPolicyName'>
        /// </param>
        /// <param name='parameters'>
        /// Request body for operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<BaseBackupPolicyResource>> CreateOrUpdateWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupPolicyName, BaseBackupPolicyResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a backup policy belonging to a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupPolicyName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
