// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupProtectionIntentResource"/> and their operations.
    /// Each <see cref="BackupProtectionIntentResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="BackupProtectionIntentCollection"/> instance call the GetBackupProtectionIntents method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class BackupProtectionIntentCollection : ArmCollection
    {
        private readonly ClientDiagnostics _backupProtectionIntentProtectionIntentClientDiagnostics;
        private readonly ProtectionIntentRestOperations _backupProtectionIntentProtectionIntentRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionIntentCollection"/> class for mocking. </summary>
        protected BackupProtectionIntentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupProtectionIntentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupProtectionIntentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupProtectionIntentProtectionIntentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupProtectionIntentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupProtectionIntentResource.ResourceType, out string backupProtectionIntentProtectionIntentApiVersion);
            _backupProtectionIntentProtectionIntentRestClient = new ProtectionIntentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupProtectionIntentProtectionIntentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Intent for Enabling backup of an item. This is a synchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backup item. </param>
        /// <param name="intentObjectName"> Intent object name. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="intentObjectName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BackupProtectionIntentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, string fabricName, string intentObjectName, BackupProtectionIntentData data, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupProtectionIntentProtectionIntentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionIntentResource>(Response.FromValue(new BackupProtectionIntentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Intent for Enabling backup of an item. This is a synchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backup item. </param>
        /// <param name="intentObjectName"> Intent object name. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="intentObjectName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BackupProtectionIntentResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, string fabricName, string intentObjectName, BackupProtectionIntentData data, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupProtectionIntentProtectionIntentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, data, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation<BackupProtectionIntentResource>(Response.FromValue(new BackupProtectionIntentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the details of the protection intent up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<Response<BackupProtectionIntentResource>> GetAsync(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupProtectionIntentProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the details of the protection intent up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual Response<BackupProtectionIntentResource> Get(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.Get");
            scope.Start();
            try
            {
                var response = _backupProtectionIntentProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupProtectionIntentProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupProtectionIntentProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupProtectionIntentResource>> GetIfExistsAsync(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupProtectionIntentProtectionIntentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionIntentResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/Subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/backupProtectionIntent/{intentObjectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProtectionIntent_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupProtectionIntentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        public virtual NullableResponse<BackupProtectionIntentResource> GetIfExists(string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var scope = _backupProtectionIntentProtectionIntentClientDiagnostics.CreateScope("BackupProtectionIntentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupProtectionIntentProtectionIntentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, fabricName, intentObjectName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupProtectionIntentResource>(response.GetRawResponse());
                return Response.FromValue(new BackupProtectionIntentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
