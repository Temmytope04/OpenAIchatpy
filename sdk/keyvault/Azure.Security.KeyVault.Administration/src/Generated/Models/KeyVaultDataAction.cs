// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Supported permissions for data actions. </summary>
    public readonly partial struct KeyVaultDataAction : IEquatable<KeyVaultDataAction>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KeyVaultDataAction"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultDataAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/read/action";
        private const string WriteHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/write/action";
        private const string ReadDeletedHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/read/action";
        private const string RecoverDeletedHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/recover/action";
        private const string BackupHsmKeysValue = "Microsoft.KeyVault/managedHsm/keys/backup/action";
        private const string RestoreHsmKeysValue = "Microsoft.KeyVault/managedHsm/keys/restore/action";
        private const string DeleteRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/delete/action";
        private const string GetRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/read/action";
        private const string WriteRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/write/action";
        private const string ReadRoleDefinitionValue = "Microsoft.KeyVault/managedHsm/roleDefinitions/read/action";
        private const string WriteRoleDefinitionValue = "Microsoft.KeyVault/managedHsm/roleDefinitions/write/action";
        private const string DeleteRoleDefinitionValue = "Microsoft.KeyVault/managedHsm/roleDefinitions/delete/action";
        private const string EncryptHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/encrypt/action";
        private const string DecryptHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/decrypt/action";
        private const string WrapHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/wrap/action";
        private const string UnwrapHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/unwrap/action";
        private const string SignHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/sign/action";
        private const string VerifyHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/verify/action";
        private const string CreateHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/create";
        private const string DeleteHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/delete";
        private const string ExportHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/export/action";
        private const string ReleaseKeyValue = "Microsoft.KeyVault/managedHsm/keys/release/action";
        private const string ImportHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/import/action";
        private const string PurgeDeletedHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/delete";
        private const string DownloadHsmSecurityDomainValue = "Microsoft.KeyVault/managedHsm/securitydomain/download/action";
        private const string DownloadHsmSecurityDomainStatusValue = "Microsoft.KeyVault/managedHsm/securitydomain/download/read";
        private const string UploadHsmSecurityDomainValue = "Microsoft.KeyVault/managedHsm/securitydomain/upload/action";
        private const string ReadHsmSecurityDomainStatusValue = "Microsoft.KeyVault/managedHsm/securitydomain/upload/read";
        private const string ReadHsmSecurityDomainTransferKeyValue = "Microsoft.KeyVault/managedHsm/securitydomain/transferkey/read";
        private const string StartHsmBackupValue = "Microsoft.KeyVault/managedHsm/backup/start/action";
        private const string StartHsmRestoreValue = "Microsoft.KeyVault/managedHsm/restore/start/action";
        private const string ReadHsmBackupStatusValue = "Microsoft.KeyVault/managedHsm/backup/status/action";
        private const string ReadHsmRestoreStatusValue = "Microsoft.KeyVault/managedHsm/restore/status/action";
        private const string RandomNumbersGenerateValue = "Microsoft.KeyVault/managedHsm/rng/action";

        /// <summary> Read HSM key metadata. </summary>
        public static KeyVaultDataAction ReadHsmKey { get; } = new KeyVaultDataAction(ReadHsmKeyValue);
        /// <summary> Update an HSM key. </summary>
        public static KeyVaultDataAction WriteHsmKey { get; } = new KeyVaultDataAction(WriteHsmKeyValue);
        /// <summary> Read deleted HSM key. </summary>
        public static KeyVaultDataAction ReadDeletedHsmKey { get; } = new KeyVaultDataAction(ReadDeletedHsmKeyValue);
        /// <summary> Recover deleted HSM key. </summary>
        public static KeyVaultDataAction RecoverDeletedHsmKey { get; } = new KeyVaultDataAction(RecoverDeletedHsmKeyValue);
        /// <summary> Backup HSM keys. </summary>
        public static KeyVaultDataAction BackupHsmKeys { get; } = new KeyVaultDataAction(BackupHsmKeysValue);
        /// <summary> Restore HSM keys. </summary>
        public static KeyVaultDataAction RestoreHsmKeys { get; } = new KeyVaultDataAction(RestoreHsmKeysValue);
        /// <summary> Delete role assignment. </summary>
        public static KeyVaultDataAction DeleteRoleAssignment { get; } = new KeyVaultDataAction(DeleteRoleAssignmentValue);
        /// <summary> Get role assignment. </summary>
        public static KeyVaultDataAction GetRoleAssignment { get; } = new KeyVaultDataAction(GetRoleAssignmentValue);
        /// <summary> Create or update role assignment. </summary>
        public static KeyVaultDataAction WriteRoleAssignment { get; } = new KeyVaultDataAction(WriteRoleAssignmentValue);
        /// <summary> Get role definition. </summary>
        public static KeyVaultDataAction ReadRoleDefinition { get; } = new KeyVaultDataAction(ReadRoleDefinitionValue);
        /// <summary> Create or update role definition. </summary>
        public static KeyVaultDataAction WriteRoleDefinition { get; } = new KeyVaultDataAction(WriteRoleDefinitionValue);
        /// <summary> Delete role definition. </summary>
        public static KeyVaultDataAction DeleteRoleDefinition { get; } = new KeyVaultDataAction(DeleteRoleDefinitionValue);
        /// <summary> Encrypt using an HSM key. </summary>
        public static KeyVaultDataAction EncryptHsmKey { get; } = new KeyVaultDataAction(EncryptHsmKeyValue);
        /// <summary> Decrypt using an HSM key. </summary>
        public static KeyVaultDataAction DecryptHsmKey { get; } = new KeyVaultDataAction(DecryptHsmKeyValue);
        /// <summary> Wrap using an HSM key. </summary>
        public static KeyVaultDataAction WrapHsmKey { get; } = new KeyVaultDataAction(WrapHsmKeyValue);
        /// <summary> Unwrap using an HSM key. </summary>
        public static KeyVaultDataAction UnwrapHsmKey { get; } = new KeyVaultDataAction(UnwrapHsmKeyValue);
        /// <summary> Sign using an HSM key. </summary>
        public static KeyVaultDataAction SignHsmKey { get; } = new KeyVaultDataAction(SignHsmKeyValue);
        /// <summary> Verify using an HSM key. </summary>
        public static KeyVaultDataAction VerifyHsmKey { get; } = new KeyVaultDataAction(VerifyHsmKeyValue);
        /// <summary> Create an HSM key. </summary>
        public static KeyVaultDataAction CreateHsmKey { get; } = new KeyVaultDataAction(CreateHsmKeyValue);
        /// <summary> Delete an HSM key. </summary>
        public static KeyVaultDataAction DeleteHsmKey { get; } = new KeyVaultDataAction(DeleteHsmKeyValue);
        /// <summary> Export an HSM key. </summary>
        public static KeyVaultDataAction ExportHsmKey { get; } = new KeyVaultDataAction(ExportHsmKeyValue);
        /// <summary> Release an HSM key using Secure Key Release. </summary>
        public static KeyVaultDataAction ReleaseKey { get; } = new KeyVaultDataAction(ReleaseKeyValue);
        /// <summary> Import an HSM key. </summary>
        public static KeyVaultDataAction ImportHsmKey { get; } = new KeyVaultDataAction(ImportHsmKeyValue);
        /// <summary> Purge a deleted HSM key. </summary>
        public static KeyVaultDataAction PurgeDeletedHsmKey { get; } = new KeyVaultDataAction(PurgeDeletedHsmKeyValue);
        /// <summary> Download an HSM security domain. </summary>
        public static KeyVaultDataAction DownloadHsmSecurityDomain { get; } = new KeyVaultDataAction(DownloadHsmSecurityDomainValue);
        /// <summary> Check status of HSM security domain download. </summary>
        public static KeyVaultDataAction DownloadHsmSecurityDomainStatus { get; } = new KeyVaultDataAction(DownloadHsmSecurityDomainStatusValue);
        /// <summary> Upload an HSM security domain. </summary>
        public static KeyVaultDataAction UploadHsmSecurityDomain { get; } = new KeyVaultDataAction(UploadHsmSecurityDomainValue);
        /// <summary> Check the status of the HSM security domain exchange file. </summary>
        public static KeyVaultDataAction ReadHsmSecurityDomainStatus { get; } = new KeyVaultDataAction(ReadHsmSecurityDomainStatusValue);
        /// <summary> Download an HSM security domain transfer key. </summary>
        public static KeyVaultDataAction ReadHsmSecurityDomainTransferKey { get; } = new KeyVaultDataAction(ReadHsmSecurityDomainTransferKeyValue);
        /// <summary> Start an HSM backup. </summary>
        public static KeyVaultDataAction StartHsmBackup { get; } = new KeyVaultDataAction(StartHsmBackupValue);
        /// <summary> Start an HSM restore. </summary>
        public static KeyVaultDataAction StartHsmRestore { get; } = new KeyVaultDataAction(StartHsmRestoreValue);
        /// <summary> Read an HSM backup status. </summary>
        public static KeyVaultDataAction ReadHsmBackupStatus { get; } = new KeyVaultDataAction(ReadHsmBackupStatusValue);
        /// <summary> Read an HSM restore status. </summary>
        public static KeyVaultDataAction ReadHsmRestoreStatus { get; } = new KeyVaultDataAction(ReadHsmRestoreStatusValue);
        /// <summary> Generate random numbers. </summary>
        public static KeyVaultDataAction RandomNumbersGenerate { get; } = new KeyVaultDataAction(RandomNumbersGenerateValue);
        /// <summary> Determines if two <see cref="KeyVaultDataAction"/> values are the same. </summary>
        public static bool operator ==(KeyVaultDataAction left, KeyVaultDataAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultDataAction"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultDataAction left, KeyVaultDataAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultDataAction"/>. </summary>
        public static implicit operator KeyVaultDataAction(string value) => new KeyVaultDataAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultDataAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultDataAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
