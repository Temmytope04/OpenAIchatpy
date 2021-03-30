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
    /// BackupInstances operations.
    /// </summary>
    public partial interface IBackupInstances
    {
        /// <summary>
        /// Gets a backup instances belonging to a backup vault
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
        Task<HttpOperationResponse<BackupInstanceResourceList>> ListWithHttpMessagesAsync(string vaultName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a backup instance with name in a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationResponse<BackupInstanceResource>> GetWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a backup instance in a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationResponse<BackupInstanceResource>> CreateOrUpdateWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, BackupInstanceResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a backup instance in a backup vault
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationHeaderResponse<BackupInstancesDeleteHeaders>> DeleteWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Trigger adhoc backup
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationResponse<OperationJobExtendedInfo,BackupInstancesAdhocBackupHeaders>> AdhocBackupWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, TriggerBackupRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validate whether adhoc backup will be successful or not
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
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
        Task<HttpOperationResponse<OperationJobExtendedInfo,BackupInstancesValidateForBackupHeaders>> ValidateForBackupWithHttpMessagesAsync(string vaultName, string resourceGroupName, ValidateForBackupRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// rehydrate recovery point for restore for a BackupInstance
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='parameters'>
        /// Request body for operation
        /// </param>
        /// <param name='backupInstanceName'>
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
        Task<HttpOperationHeaderResponse<BackupInstancesTriggerRehydrateHeaders>> TriggerRehydrateWithHttpMessagesAsync(string resourceGroupName, string vaultName, AzureBackupRehydrationRequest parameters, string backupInstanceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Triggers restore for a BackupInstance
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationResponse<OperationJobExtendedInfo,BackupInstancesTriggerRestoreHeaders>> TriggerRestoreWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, AzureBackupRestoreRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates if Restore can be triggered for a DataSource
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the backup vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the backup vault is present.
        /// </param>
        /// <param name='backupInstanceName'>
        /// The name of the backup instance
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
        Task<HttpOperationResponse<OperationJobExtendedInfo,BackupInstancesValidateRestoreHeaders>> ValidateRestoreWithHttpMessagesAsync(string vaultName, string resourceGroupName, string backupInstanceName, ValidateRestoreRequestObject parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
