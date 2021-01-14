// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Allowed Data actions. </summary>
    public readonly partial struct DataActions : IEquatable<DataActions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataActions"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataActions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/read/action";
        private const string WriteHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/write/action";
        private const string ReadDeletedHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/read/action";
        private const string RecoverDeletedHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/recover/action";
        private const string BackupHsmKeysValue = "Microsoft.KeyVault/managedHsm/keys/backup/action";
        private const string RestoreHsmKeyValue = "Microsoft.KeyVault/managedHsm/keys/restore/action";
        private const string DeleteRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/delete/action";
        private const string GetRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/read/action";
        private const string WriteRoleAssignmentValue = "Microsoft.KeyVault/managedHsm/roleAssignments/write/action";
        private const string ReadRoleDefinitionValue = "Microsoft.KeyVault/managedHsm/roleDefinitions/read/action";
        private const string KeyEncryptValue = "Microsoft.KeyVault/managedHsm/keys/encrypt/action";
        private const string KeyDecryptValue = "Microsoft.KeyVault/managedHsm/keys/decrypt/action";
        private const string KeyWrapValue = "Microsoft.KeyVault/managedHsm/keys/wrap/action";
        private const string KeyUnwrapValue = "Microsoft.KeyVault/managedHsm/keys/unwrap/action";
        private const string KeySignValue = "Microsoft.KeyVault/managedHsm/keys/sign/action";
        private const string KeyVerifyValue = "Microsoft.KeyVault/managedHsm/keys/verify/action";
        private const string KeyCreateValue = "Microsoft.KeyVault/managedHsm/keys/create";
        private const string KeyDeleteValue = "Microsoft.KeyVault/managedHsm/keys/delete";
        private const string KeyExportValue = "Microsoft.KeyVault/managedHsm/keys/export/action";
        private const string KeyImportValue = "Microsoft.KeyVault/managedHsm/keys/import/action";
        private const string KeyPurgeDeletedValue = "Microsoft.KeyVault/managedHsm/keys/deletedKeys/delete";
        private const string DownloadHsmSecurityDomainValue = "Microsoft.KeyVault/managedHsm/securitydomain/download/action";
        private const string UploadHsmSecurityDomainValue = "Microsoft.KeyVault/managedHsm/securitydomain/upload/action";
        private const string ReadHsmSecurityDomainStatusValue = "Microsoft.KeyVault/managedHsm/securitydomain/upload/read";
        private const string ReadHsmSecurityDomainTransferKeyValue = "Microsoft.KeyVault/managedHsm/securitydomain/transferkey/read";
        private const string StartHsmBackupValue = "Microsoft.KeyVault/managedHsm/backup/start/action";
        private const string StartHsmRestoreValue = "Microsoft.KeyVault/managedHsm/restore/start/action";
        private const string ReadHsmBackupStatusValue = "Microsoft.KeyVault/managedHsm/backup/status/action";
        private const string ReadHsmRestoreStatusValue = "Microsoft.KeyVault/managedHsm/restore/status/action";

        /// <summary> Read HSM key metadata. </summary>
        public static DataActions ReadHsmKey { get; } = new DataActions(ReadHsmKeyValue);
        /// <summary> Update an HSM key. </summary>
        public static DataActions WriteHsmKey { get; } = new DataActions(WriteHsmKeyValue);
        /// <summary> Read deleted HSM key. </summary>
        public static DataActions ReadDeletedHsmKey { get; } = new DataActions(ReadDeletedHsmKeyValue);
        /// <summary> Recover deleted HSM key. </summary>
        public static DataActions RecoverDeletedHsmKey { get; } = new DataActions(RecoverDeletedHsmKeyValue);
        /// <summary> Backup HSM keys. </summary>
        public static DataActions BackupHsmKeys { get; } = new DataActions(BackupHsmKeysValue);
        /// <summary> Restore HSM keys. </summary>
        public static DataActions RestoreHsmKey { get; } = new DataActions(RestoreHsmKeyValue);
        /// <summary> Delete role assignment. </summary>
        public static DataActions DeleteRoleAssignment { get; } = new DataActions(DeleteRoleAssignmentValue);
        /// <summary> Get role assignment. </summary>
        public static DataActions GetRoleAssignment { get; } = new DataActions(GetRoleAssignmentValue);
        /// <summary> Create or update role assignment. </summary>
        public static DataActions WriteRoleAssignment { get; } = new DataActions(WriteRoleAssignmentValue);
        /// <summary> Get role definition. </summary>
        public static DataActions ReadRoleDefinition { get; } = new DataActions(ReadRoleDefinitionValue);
        /// <summary> Encrypt using an HSM key. </summary>
        public static DataActions KeyEncrypt { get; } = new DataActions(KeyEncryptValue);
        /// <summary> Decrypt using an HSM key. </summary>
        public static DataActions KeyDecrypt { get; } = new DataActions(KeyDecryptValue);
        /// <summary> Wrap using an HSM key. </summary>
        public static DataActions KeyWrap { get; } = new DataActions(KeyWrapValue);
        /// <summary> Unwrap using an HSM key. </summary>
        public static DataActions KeyUnwrap { get; } = new DataActions(KeyUnwrapValue);
        /// <summary> Sign using an HSM key. </summary>
        public static DataActions KeySign { get; } = new DataActions(KeySignValue);
        /// <summary> Verify using an HSM key. </summary>
        public static DataActions KeyVerify { get; } = new DataActions(KeyVerifyValue);
        /// <summary> Create an HSM key. </summary>
        public static DataActions KeyCreate { get; } = new DataActions(KeyCreateValue);
        /// <summary> Delete an HSM key. </summary>
        public static DataActions KeyDelete { get; } = new DataActions(KeyDeleteValue);
        /// <summary> Export an HSM key. </summary>
        public static DataActions KeyExport { get; } = new DataActions(KeyExportValue);
        /// <summary> Import an HSM key. </summary>
        public static DataActions KeyImport { get; } = new DataActions(KeyImportValue);
        /// <summary> Purge a deleted HSM key. </summary>
        public static DataActions KeyPurgeDeleted { get; } = new DataActions(KeyPurgeDeletedValue);
        /// <summary> Download an HSM security domain. </summary>
        public static DataActions DownloadHsmSecurityDomain { get; } = new DataActions(DownloadHsmSecurityDomainValue);
        /// <summary> Upload an HSM security domain. </summary>
        public static DataActions UploadHsmSecurityDomain { get; } = new DataActions(UploadHsmSecurityDomainValue);
        /// <summary> Check the status of the HSM security domain exchange file. </summary>
        public static DataActions ReadHsmSecurityDomainStatus { get; } = new DataActions(ReadHsmSecurityDomainStatusValue);
        /// <summary> Download an HSM security domain transfer key. </summary>
        public static DataActions ReadHsmSecurityDomainTransferKey { get; } = new DataActions(ReadHsmSecurityDomainTransferKeyValue);
        /// <summary> Start an HSM backup. </summary>
        public static DataActions StartHsmBackup { get; } = new DataActions(StartHsmBackupValue);
        /// <summary> Start an HSM restore. </summary>
        public static DataActions StartHsmRestore { get; } = new DataActions(StartHsmRestoreValue);
        /// <summary> Read an HSM backup status. </summary>
        public static DataActions ReadHsmBackupStatus { get; } = new DataActions(ReadHsmBackupStatusValue);
        /// <summary> Read an HSM restore status. </summary>
        public static DataActions ReadHsmRestoreStatus { get; } = new DataActions(ReadHsmRestoreStatusValue);
        /// <summary> Determines if two <see cref="DataActions"/> values are the same. </summary>
        public static bool operator ==(DataActions left, DataActions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataActions"/> values are not the same. </summary>
        public static bool operator !=(DataActions left, DataActions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataActions"/>. </summary>
        public static implicit operator DataActions(string value) => new DataActions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataActions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataActions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
