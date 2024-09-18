// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Communication;

/// <summary>
/// A class that represents a VerificationStatus record.
/// </summary>
public partial class DomainVerificationStatusRecord : ProvisioningConstruct
{
    /// <summary>
    /// Status of the verification operation.
    /// </summary>
    public BicepValue<DomainRecordVerificationStatus> Status { get => _status; }
    private readonly BicepValue<DomainRecordVerificationStatus> _status;

    /// <summary>
    /// Error code. This property will only be present if the status is
    /// UnableToVerify.
    /// </summary>
    public BicepValue<string> ErrorCode { get => _errorCode; }
    private readonly BicepValue<string> _errorCode;

    /// <summary>
    /// Creates a new DomainVerificationStatusRecord.
    /// </summary>
    public DomainVerificationStatusRecord()
    {
        _status = BicepValue<DomainRecordVerificationStatus>.DefineProperty(this, "Status", ["status"], isOutput: true);
        _errorCode = BicepValue<string>.DefineProperty(this, "ErrorCode", ["errorCode"], isOutput: true);
    }
}
