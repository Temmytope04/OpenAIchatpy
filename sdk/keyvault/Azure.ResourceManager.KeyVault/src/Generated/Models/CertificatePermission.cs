// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The CertificatePermission. </summary>
    public readonly partial struct CertificatePermission : IEquatable<CertificatePermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CertificatePermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificatePermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "all";
        private const string GetValue = "get";
        private const string ListValue = "list";
        private const string DeleteValue = "delete";
        private const string CreateValue = "create";
        private const string ImportValue = "import";
        private const string UpdateValue = "update";
        private const string ManagecontactsValue = "managecontacts";
        private const string GetissuersValue = "getissuers";
        private const string ListissuersValue = "listissuers";
        private const string SetissuersValue = "setissuers";
        private const string DeleteissuersValue = "deleteissuers";
        private const string ManageissuersValue = "manageissuers";
        private const string RecoverValue = "recover";
        private const string PurgeValue = "purge";
        private const string BackupValue = "backup";
        private const string RestoreValue = "restore";

        /// <summary> all. </summary>
        public static CertificatePermission All { get; } = new CertificatePermission(AllValue);
        /// <summary> get. </summary>
        public static CertificatePermission Get { get; } = new CertificatePermission(GetValue);
        /// <summary> list. </summary>
        public static CertificatePermission List { get; } = new CertificatePermission(ListValue);
        /// <summary> delete. </summary>
        public static CertificatePermission Delete { get; } = new CertificatePermission(DeleteValue);
        /// <summary> create. </summary>
        public static CertificatePermission Create { get; } = new CertificatePermission(CreateValue);
        /// <summary> import. </summary>
        public static CertificatePermission Import { get; } = new CertificatePermission(ImportValue);
        /// <summary> update. </summary>
        public static CertificatePermission Update { get; } = new CertificatePermission(UpdateValue);
        /// <summary> managecontacts. </summary>
        public static CertificatePermission Managecontacts { get; } = new CertificatePermission(ManagecontactsValue);
        /// <summary> getissuers. </summary>
        public static CertificatePermission Getissuers { get; } = new CertificatePermission(GetissuersValue);
        /// <summary> listissuers. </summary>
        public static CertificatePermission Listissuers { get; } = new CertificatePermission(ListissuersValue);
        /// <summary> setissuers. </summary>
        public static CertificatePermission Setissuers { get; } = new CertificatePermission(SetissuersValue);
        /// <summary> deleteissuers. </summary>
        public static CertificatePermission Deleteissuers { get; } = new CertificatePermission(DeleteissuersValue);
        /// <summary> manageissuers. </summary>
        public static CertificatePermission Manageissuers { get; } = new CertificatePermission(ManageissuersValue);
        /// <summary> recover. </summary>
        public static CertificatePermission Recover { get; } = new CertificatePermission(RecoverValue);
        /// <summary> purge. </summary>
        public static CertificatePermission Purge { get; } = new CertificatePermission(PurgeValue);
        /// <summary> backup. </summary>
        public static CertificatePermission Backup { get; } = new CertificatePermission(BackupValue);
        /// <summary> restore. </summary>
        public static CertificatePermission Restore { get; } = new CertificatePermission(RestoreValue);
        /// <summary> Determines if two <see cref="CertificatePermission"/> values are the same. </summary>
        public static bool operator ==(CertificatePermission left, CertificatePermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificatePermission"/> values are not the same. </summary>
        public static bool operator !=(CertificatePermission left, CertificatePermission right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CertificatePermission"/>. </summary>
        public static implicit operator CertificatePermission(string value) => new CertificatePermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificatePermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificatePermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
