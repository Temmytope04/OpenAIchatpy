// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class ExportPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RuleIndex))
            {
                writer.WritePropertyName("ruleIndex");
                writer.WriteNumberValue(RuleIndex.Value);
            }
            if (Optional.IsDefined(UnixReadOnly))
            {
                writer.WritePropertyName("unixReadOnly");
                writer.WriteBooleanValue(UnixReadOnly.Value);
            }
            if (Optional.IsDefined(UnixReadWrite))
            {
                writer.WritePropertyName("unixReadWrite");
                writer.WriteBooleanValue(UnixReadWrite.Value);
            }
            if (Optional.IsDefined(Kerberos5ReadOnly))
            {
                writer.WritePropertyName("kerberos5ReadOnly");
                writer.WriteBooleanValue(Kerberos5ReadOnly.Value);
            }
            if (Optional.IsDefined(Kerberos5ReadWrite))
            {
                writer.WritePropertyName("kerberos5ReadWrite");
                writer.WriteBooleanValue(Kerberos5ReadWrite.Value);
            }
            if (Optional.IsDefined(Kerberos5IReadOnly))
            {
                writer.WritePropertyName("kerberos5iReadOnly");
                writer.WriteBooleanValue(Kerberos5IReadOnly.Value);
            }
            if (Optional.IsDefined(Kerberos5IReadWrite))
            {
                writer.WritePropertyName("kerberos5iReadWrite");
                writer.WriteBooleanValue(Kerberos5IReadWrite.Value);
            }
            if (Optional.IsDefined(Kerberos5PReadOnly))
            {
                writer.WritePropertyName("kerberos5pReadOnly");
                writer.WriteBooleanValue(Kerberos5PReadOnly.Value);
            }
            if (Optional.IsDefined(Kerberos5PReadWrite))
            {
                writer.WritePropertyName("kerberos5pReadWrite");
                writer.WriteBooleanValue(Kerberos5PReadWrite.Value);
            }
            if (Optional.IsDefined(Cifs))
            {
                writer.WritePropertyName("cifs");
                writer.WriteBooleanValue(Cifs.Value);
            }
            if (Optional.IsDefined(Nfsv3))
            {
                writer.WritePropertyName("nfsv3");
                writer.WriteBooleanValue(Nfsv3.Value);
            }
            if (Optional.IsDefined(Nfsv41))
            {
                writer.WritePropertyName("nfsv41");
                writer.WriteBooleanValue(Nfsv41.Value);
            }
            if (Optional.IsDefined(AllowedClients))
            {
                writer.WritePropertyName("allowedClients");
                writer.WriteStringValue(AllowedClients);
            }
            if (Optional.IsDefined(HasRootAccess))
            {
                writer.WritePropertyName("hasRootAccess");
                writer.WriteBooleanValue(HasRootAccess.Value);
            }
            if (Optional.IsDefined(ChownMode))
            {
                writer.WritePropertyName("chownMode");
                writer.WriteStringValue(ChownMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExportPolicyRule DeserializeExportPolicyRule(JsonElement element)
        {
            Optional<int> ruleIndex = default;
            Optional<bool> unixReadOnly = default;
            Optional<bool> unixReadWrite = default;
            Optional<bool> kerberos5ReadOnly = default;
            Optional<bool> kerberos5ReadWrite = default;
            Optional<bool> kerberos5iReadOnly = default;
            Optional<bool> kerberos5iReadWrite = default;
            Optional<bool> kerberos5pReadOnly = default;
            Optional<bool> kerberos5pReadWrite = default;
            Optional<bool> cifs = default;
            Optional<bool> nfsv3 = default;
            Optional<bool> nfsv41 = default;
            Optional<string> allowedClients = default;
            Optional<bool> hasRootAccess = default;
            Optional<ChownMode> chownMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ruleIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unixReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unixReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unixReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unixReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5ReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5ReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5iReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5iReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5pReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5pReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cifs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cifs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv3"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsv3 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv41"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsv41 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedClients"))
                {
                    allowedClients = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasRootAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasRootAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("chownMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    chownMode = new ChownMode(property.Value.GetString());
                    continue;
                }
            }
            return new ExportPolicyRule(Optional.ToNullable(ruleIndex), Optional.ToNullable(unixReadOnly), Optional.ToNullable(unixReadWrite), Optional.ToNullable(kerberos5ReadOnly), Optional.ToNullable(kerberos5ReadWrite), Optional.ToNullable(kerberos5iReadOnly), Optional.ToNullable(kerberos5iReadWrite), Optional.ToNullable(kerberos5pReadOnly), Optional.ToNullable(kerberos5pReadWrite), Optional.ToNullable(cifs), Optional.ToNullable(nfsv3), Optional.ToNullable(nfsv41), allowedClients.Value, Optional.ToNullable(hasRootAccess), Optional.ToNullable(chownMode));
        }
    }
}
