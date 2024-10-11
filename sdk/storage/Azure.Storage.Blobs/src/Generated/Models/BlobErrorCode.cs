// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Error codes returned by the service. </summary>
    public readonly partial struct BlobErrorCode : IEquatable<BlobErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountAlreadyExistsValue = "AccountAlreadyExists";
        private const string AccountBeingCreatedValue = "AccountBeingCreated";
        private const string AccountIsDisabledValue = "AccountIsDisabled";
        private const string AuthenticationFailedValue = "AuthenticationFailed";
        private const string AuthorizationFailureValue = "AuthorizationFailure";
        private const string ConditionHeadersNotSupportedValue = "ConditionHeadersNotSupported";
        private const string ConditionNotMetValue = "ConditionNotMet";
        private const string EmptyMetadataKeyValue = "EmptyMetadataKey";
        private const string InsufficientAccountPermissionsValue = "InsufficientAccountPermissions";
        private const string InternalErrorValue = "InternalError";
        private const string InvalidAuthenticationInfoValue = "InvalidAuthenticationInfo";
        private const string InvalidHeaderValueValue = "InvalidHeaderValue";
        private const string InvalidHttpVerbValue = "InvalidHttpVerb";
        private const string InvalidInputValue = "InvalidInput";
        private const string InvalidMd5Value = "InvalidMd5";
        private const string InvalidMetadataValue = "InvalidMetadata";
        private const string InvalidQueryParameterValueValue = "InvalidQueryParameterValue";
        private const string InvalidRangeValue = "InvalidRange";
        private const string InvalidResourceNameValue = "InvalidResourceName";
        private const string InvalidUriValue = "InvalidUri";
        private const string InvalidXmlDocumentValue = "InvalidXmlDocument";
        private const string InvalidXmlNodeValueValue = "InvalidXmlNodeValue";
        private const string Md5MismatchValue = "Md5Mismatch";
        private const string MetadataTooLargeValue = "MetadataTooLarge";
        private const string MissingContentLengthHeaderValue = "MissingContentLengthHeader";
        private const string MissingRequiredQueryParameterValue = "MissingRequiredQueryParameter";
        private const string MissingRequiredHeaderValue = "MissingRequiredHeader";
        private const string MissingRequiredXmlNodeValue = "MissingRequiredXmlNode";
        private const string MultipleConditionHeadersNotSupportedValue = "MultipleConditionHeadersNotSupported";
        private const string OperationTimedOutValue = "OperationTimedOut";
        private const string OutOfRangeInputValue = "OutOfRangeInput";
        private const string OutOfRangeQueryParameterValueValue = "OutOfRangeQueryParameterValue";
        private const string RequestBodyTooLargeValue = "RequestBodyTooLarge";
        private const string ResourceTypeMismatchValue = "ResourceTypeMismatch";
        private const string RequestUrlFailedToParseValue = "RequestUrlFailedToParse";
        private const string ResourceAlreadyExistsValue = "ResourceAlreadyExists";
        private const string ResourceNotFoundValue = "ResourceNotFound";
        private const string ServerBusyValue = "ServerBusy";
        private const string UnsupportedHeaderValue = "UnsupportedHeader";
        private const string UnsupportedXmlNodeValue = "UnsupportedXmlNode";
        private const string UnsupportedQueryParameterValue = "UnsupportedQueryParameter";
        private const string UnsupportedHttpVerbValue = "UnsupportedHttpVerb";
        private const string AppendPositionConditionNotMetValue = "AppendPositionConditionNotMet";
        private const string BlobAlreadyExistsValue = "BlobAlreadyExists";
        private const string BlobImmutableDueToPolicyValue = "BlobImmutableDueToPolicy";
        private const string BlobNotFoundValue = "BlobNotFound";
        private const string BlobOverwrittenValue = "BlobOverwritten";
        private const string BlobTierInadequateForContentLengthValue = "BlobTierInadequateForContentLength";
        private const string BlobUsesCustomerSpecifiedEncryptionValue = "BlobUsesCustomerSpecifiedEncryption";
        private const string BlockCountExceedsLimitValue = "BlockCountExceedsLimit";
        private const string BlockListTooLongValue = "BlockListTooLong";
        private const string CannotChangeToLowerTierValue = "CannotChangeToLowerTier";
        private const string CannotVerifyCopySourceValue = "CannotVerifyCopySource";
        private const string ContainerAlreadyExistsValue = "ContainerAlreadyExists";
        private const string ContainerBeingDeletedValue = "ContainerBeingDeleted";
        private const string ContainerDisabledValue = "ContainerDisabled";
        private const string ContainerNotFoundValue = "ContainerNotFound";
        private const string ContentLengthLargerThanTierLimitValue = "ContentLengthLargerThanTierLimit";
        private const string CopyAcrossAccountsNotSupportedValue = "CopyAcrossAccountsNotSupported";
        private const string CopyIdMismatchValue = "CopyIdMismatch";
        private const string FeatureVersionMismatchValue = "FeatureVersionMismatch";
        private const string IncrementalCopyBlobMismatchValue = "IncrementalCopyBlobMismatch";
        private const string IncrementalCopyOfEarlierVersionSnapshotNotAllowedValue = "IncrementalCopyOfEarlierVersionSnapshotNotAllowed";
        private const string IncrementalCopySourceMustBeSnapshotValue = "IncrementalCopySourceMustBeSnapshot";
        private const string InfiniteLeaseDurationRequiredValue = "InfiniteLeaseDurationRequired";
        private const string InvalidBlobOrBlockValue = "InvalidBlobOrBlock";
        private const string InvalidBlobTierValue = "InvalidBlobTier";
        private const string InvalidBlobTypeValue = "InvalidBlobType";
        private const string InvalidBlockIdValue = "InvalidBlockId";
        private const string InvalidBlockListValue = "InvalidBlockList";
        private const string InvalidOperationValue = "InvalidOperation";
        private const string InvalidPageRangeValue = "InvalidPageRange";
        private const string InvalidSourceBlobTypeValue = "InvalidSourceBlobType";
        private const string InvalidSourceBlobUrlValue = "InvalidSourceBlobUrl";
        private const string InvalidVersionForPageBlobOperationValue = "InvalidVersionForPageBlobOperation";
        private const string LeaseAlreadyPresentValue = "LeaseAlreadyPresent";
        private const string LeaseAlreadyBrokenValue = "LeaseAlreadyBroken";
        private const string LeaseIdMismatchWithBlobOperationValue = "LeaseIdMismatchWithBlobOperation";
        private const string LeaseIdMismatchWithContainerOperationValue = "LeaseIdMismatchWithContainerOperation";
        private const string LeaseIdMismatchWithLeaseOperationValue = "LeaseIdMismatchWithLeaseOperation";
        private const string LeaseIdMissingValue = "LeaseIdMissing";
        private const string LeaseIsBreakingAndCannotBeAcquiredValue = "LeaseIsBreakingAndCannotBeAcquired";
        private const string LeaseIsBreakingAndCannotBeChangedValue = "LeaseIsBreakingAndCannotBeChanged";
        private const string LeaseIsBrokenAndCannotBeRenewedValue = "LeaseIsBrokenAndCannotBeRenewed";
        private const string LeaseLostValue = "LeaseLost";
        private const string LeaseNotPresentWithBlobOperationValue = "LeaseNotPresentWithBlobOperation";
        private const string LeaseNotPresentWithContainerOperationValue = "LeaseNotPresentWithContainerOperation";
        private const string LeaseNotPresentWithLeaseOperationValue = "LeaseNotPresentWithLeaseOperation";
        private const string MaxBlobSizeConditionNotMetValue = "MaxBlobSizeConditionNotMet";
        private const string NoAuthenticationInformationValue = "NoAuthenticationInformation";
        private const string NoPendingCopyOperationValue = "NoPendingCopyOperation";
        private const string OperationNotAllowedOnIncrementalCopyBlobValue = "OperationNotAllowedOnIncrementalCopyBlob";
        private const string PendingCopyOperationValue = "PendingCopyOperation";
        private const string PreviousSnapshotCannotBeNewerValue = "PreviousSnapshotCannotBeNewer";
        private const string PreviousSnapshotNotFoundValue = "PreviousSnapshotNotFound";
        private const string PreviousSnapshotOperationNotSupportedValue = "PreviousSnapshotOperationNotSupported";
        private const string SequenceNumberConditionNotMetValue = "SequenceNumberConditionNotMet";
        private const string SequenceNumberIncrementTooLargeValue = "SequenceNumberIncrementTooLarge";
        private const string SnapshotCountExceededValue = "SnapshotCountExceeded";
        private const string SnapshotOperationRateExceededValue = "SnapshotOperationRateExceeded";
        private const string SnapshotsPresentValue = "SnapshotsPresent";
        private const string SourceConditionNotMetValue = "SourceConditionNotMet";
        private const string SystemInUseValue = "SystemInUse";
        private const string TargetConditionNotMetValue = "TargetConditionNotMet";
        private const string UnauthorizedBlobOverwriteValue = "UnauthorizedBlobOverwrite";
        private const string BlobBeingRehydratedValue = "BlobBeingRehydrated";
        private const string BlobArchivedValue = "BlobArchived";
        private const string BlobNotArchivedValue = "BlobNotArchived";
        private const string AuthorizationSourceIPMismatchValue = "AuthorizationSourceIPMismatch";
        private const string AuthorizationProtocolMismatchValue = "AuthorizationProtocolMismatch";
        private const string AuthorizationPermissionMismatchValue = "AuthorizationPermissionMismatch";
        private const string AuthorizationServiceMismatchValue = "AuthorizationServiceMismatch";
        private const string AuthorizationResourceTypeMismatchValue = "AuthorizationResourceTypeMismatch";
        private const string BlobAccessTierNotSupportedForAccountTypeValue = "BlobAccessTierNotSupportedForAccountType";

        /// <summary> AccountAlreadyExists. </summary>
        public static BlobErrorCode AccountAlreadyExists { get; } = new BlobErrorCode(AccountAlreadyExistsValue);
        /// <summary> AccountBeingCreated. </summary>
        public static BlobErrorCode AccountBeingCreated { get; } = new BlobErrorCode(AccountBeingCreatedValue);
        /// <summary> AccountIsDisabled. </summary>
        public static BlobErrorCode AccountIsDisabled { get; } = new BlobErrorCode(AccountIsDisabledValue);
        /// <summary> AuthenticationFailed. </summary>
        public static BlobErrorCode AuthenticationFailed { get; } = new BlobErrorCode(AuthenticationFailedValue);
        /// <summary> AuthorizationFailure. </summary>
        public static BlobErrorCode AuthorizationFailure { get; } = new BlobErrorCode(AuthorizationFailureValue);
        /// <summary> ConditionHeadersNotSupported. </summary>
        public static BlobErrorCode ConditionHeadersNotSupported { get; } = new BlobErrorCode(ConditionHeadersNotSupportedValue);
        /// <summary> ConditionNotMet. </summary>
        public static BlobErrorCode ConditionNotMet { get; } = new BlobErrorCode(ConditionNotMetValue);
        /// <summary> EmptyMetadataKey. </summary>
        public static BlobErrorCode EmptyMetadataKey { get; } = new BlobErrorCode(EmptyMetadataKeyValue);
        /// <summary> InsufficientAccountPermissions. </summary>
        public static BlobErrorCode InsufficientAccountPermissions { get; } = new BlobErrorCode(InsufficientAccountPermissionsValue);
        /// <summary> InternalError. </summary>
        public static BlobErrorCode InternalError { get; } = new BlobErrorCode(InternalErrorValue);
        /// <summary> InvalidAuthenticationInfo. </summary>
        public static BlobErrorCode InvalidAuthenticationInfo { get; } = new BlobErrorCode(InvalidAuthenticationInfoValue);
        /// <summary> InvalidHeaderValue. </summary>
        public static BlobErrorCode InvalidHeaderValue { get; } = new BlobErrorCode(InvalidHeaderValueValue);
        /// <summary> InvalidHttpVerb. </summary>
        public static BlobErrorCode InvalidHttpVerb { get; } = new BlobErrorCode(InvalidHttpVerbValue);
        /// <summary> InvalidInput. </summary>
        public static BlobErrorCode InvalidInput { get; } = new BlobErrorCode(InvalidInputValue);
        /// <summary> InvalidMd5. </summary>
        public static BlobErrorCode InvalidMd5 { get; } = new BlobErrorCode(InvalidMd5Value);
        /// <summary> InvalidMetadata. </summary>
        public static BlobErrorCode InvalidMetadata { get; } = new BlobErrorCode(InvalidMetadataValue);
        /// <summary> InvalidQueryParameterValue. </summary>
        public static BlobErrorCode InvalidQueryParameterValue { get; } = new BlobErrorCode(InvalidQueryParameterValueValue);
        /// <summary> InvalidRange. </summary>
        public static BlobErrorCode InvalidRange { get; } = new BlobErrorCode(InvalidRangeValue);
        /// <summary> InvalidResourceName. </summary>
        public static BlobErrorCode InvalidResourceName { get; } = new BlobErrorCode(InvalidResourceNameValue);
        /// <summary> InvalidUri. </summary>
        public static BlobErrorCode InvalidUri { get; } = new BlobErrorCode(InvalidUriValue);
        /// <summary> InvalidXmlDocument. </summary>
        public static BlobErrorCode InvalidXmlDocument { get; } = new BlobErrorCode(InvalidXmlDocumentValue);
        /// <summary> InvalidXmlNodeValue. </summary>
        public static BlobErrorCode InvalidXmlNodeValue { get; } = new BlobErrorCode(InvalidXmlNodeValueValue);
        /// <summary> Md5Mismatch. </summary>
        public static BlobErrorCode Md5Mismatch { get; } = new BlobErrorCode(Md5MismatchValue);
        /// <summary> MetadataTooLarge. </summary>
        public static BlobErrorCode MetadataTooLarge { get; } = new BlobErrorCode(MetadataTooLargeValue);
        /// <summary> MissingContentLengthHeader. </summary>
        public static BlobErrorCode MissingContentLengthHeader { get; } = new BlobErrorCode(MissingContentLengthHeaderValue);
        /// <summary> MissingRequiredQueryParameter. </summary>
        public static BlobErrorCode MissingRequiredQueryParameter { get; } = new BlobErrorCode(MissingRequiredQueryParameterValue);
        /// <summary> MissingRequiredHeader. </summary>
        public static BlobErrorCode MissingRequiredHeader { get; } = new BlobErrorCode(MissingRequiredHeaderValue);
        /// <summary> MissingRequiredXmlNode. </summary>
        public static BlobErrorCode MissingRequiredXmlNode { get; } = new BlobErrorCode(MissingRequiredXmlNodeValue);
        /// <summary> MultipleConditionHeadersNotSupported. </summary>
        public static BlobErrorCode MultipleConditionHeadersNotSupported { get; } = new BlobErrorCode(MultipleConditionHeadersNotSupportedValue);
        /// <summary> OperationTimedOut. </summary>
        public static BlobErrorCode OperationTimedOut { get; } = new BlobErrorCode(OperationTimedOutValue);
        /// <summary> OutOfRangeInput. </summary>
        public static BlobErrorCode OutOfRangeInput { get; } = new BlobErrorCode(OutOfRangeInputValue);
        /// <summary> OutOfRangeQueryParameterValue. </summary>
        public static BlobErrorCode OutOfRangeQueryParameterValue { get; } = new BlobErrorCode(OutOfRangeQueryParameterValueValue);
        /// <summary> RequestBodyTooLarge. </summary>
        public static BlobErrorCode RequestBodyTooLarge { get; } = new BlobErrorCode(RequestBodyTooLargeValue);
        /// <summary> ResourceTypeMismatch. </summary>
        public static BlobErrorCode ResourceTypeMismatch { get; } = new BlobErrorCode(ResourceTypeMismatchValue);
        /// <summary> RequestUrlFailedToParse. </summary>
        public static BlobErrorCode RequestUrlFailedToParse { get; } = new BlobErrorCode(RequestUrlFailedToParseValue);
        /// <summary> ResourceAlreadyExists. </summary>
        public static BlobErrorCode ResourceAlreadyExists { get; } = new BlobErrorCode(ResourceAlreadyExistsValue);
        /// <summary> ResourceNotFound. </summary>
        public static BlobErrorCode ResourceNotFound { get; } = new BlobErrorCode(ResourceNotFoundValue);
        /// <summary> ServerBusy. </summary>
        public static BlobErrorCode ServerBusy { get; } = new BlobErrorCode(ServerBusyValue);
        /// <summary> UnsupportedHeader. </summary>
        public static BlobErrorCode UnsupportedHeader { get; } = new BlobErrorCode(UnsupportedHeaderValue);
        /// <summary> UnsupportedXmlNode. </summary>
        public static BlobErrorCode UnsupportedXmlNode { get; } = new BlobErrorCode(UnsupportedXmlNodeValue);
        /// <summary> UnsupportedQueryParameter. </summary>
        public static BlobErrorCode UnsupportedQueryParameter { get; } = new BlobErrorCode(UnsupportedQueryParameterValue);
        /// <summary> UnsupportedHttpVerb. </summary>
        public static BlobErrorCode UnsupportedHttpVerb { get; } = new BlobErrorCode(UnsupportedHttpVerbValue);
        /// <summary> AppendPositionConditionNotMet. </summary>
        public static BlobErrorCode AppendPositionConditionNotMet { get; } = new BlobErrorCode(AppendPositionConditionNotMetValue);
        /// <summary> BlobAlreadyExists. </summary>
        public static BlobErrorCode BlobAlreadyExists { get; } = new BlobErrorCode(BlobAlreadyExistsValue);
        /// <summary> BlobImmutableDueToPolicy. </summary>
        public static BlobErrorCode BlobImmutableDueToPolicy { get; } = new BlobErrorCode(BlobImmutableDueToPolicyValue);
        /// <summary> BlobNotFound. </summary>
        public static BlobErrorCode BlobNotFound { get; } = new BlobErrorCode(BlobNotFoundValue);
        /// <summary> BlobOverwritten. </summary>
        public static BlobErrorCode BlobOverwritten { get; } = new BlobErrorCode(BlobOverwrittenValue);
        /// <summary> BlobTierInadequateForContentLength. </summary>
        public static BlobErrorCode BlobTierInadequateForContentLength { get; } = new BlobErrorCode(BlobTierInadequateForContentLengthValue);
        /// <summary> BlobUsesCustomerSpecifiedEncryption. </summary>
        public static BlobErrorCode BlobUsesCustomerSpecifiedEncryption { get; } = new BlobErrorCode(BlobUsesCustomerSpecifiedEncryptionValue);
        /// <summary> BlockCountExceedsLimit. </summary>
        public static BlobErrorCode BlockCountExceedsLimit { get; } = new BlobErrorCode(BlockCountExceedsLimitValue);
        /// <summary> BlockListTooLong. </summary>
        public static BlobErrorCode BlockListTooLong { get; } = new BlobErrorCode(BlockListTooLongValue);
        /// <summary> CannotChangeToLowerTier. </summary>
        public static BlobErrorCode CannotChangeToLowerTier { get; } = new BlobErrorCode(CannotChangeToLowerTierValue);
        /// <summary> CannotVerifyCopySource. </summary>
        public static BlobErrorCode CannotVerifyCopySource { get; } = new BlobErrorCode(CannotVerifyCopySourceValue);
        /// <summary> ContainerAlreadyExists. </summary>
        public static BlobErrorCode ContainerAlreadyExists { get; } = new BlobErrorCode(ContainerAlreadyExistsValue);
        /// <summary> ContainerBeingDeleted. </summary>
        public static BlobErrorCode ContainerBeingDeleted { get; } = new BlobErrorCode(ContainerBeingDeletedValue);
        /// <summary> ContainerDisabled. </summary>
        public static BlobErrorCode ContainerDisabled { get; } = new BlobErrorCode(ContainerDisabledValue);
        /// <summary> ContainerNotFound. </summary>
        public static BlobErrorCode ContainerNotFound { get; } = new BlobErrorCode(ContainerNotFoundValue);
        /// <summary> ContentLengthLargerThanTierLimit. </summary>
        public static BlobErrorCode ContentLengthLargerThanTierLimit { get; } = new BlobErrorCode(ContentLengthLargerThanTierLimitValue);
        /// <summary> CopyAcrossAccountsNotSupported. </summary>
        public static BlobErrorCode CopyAcrossAccountsNotSupported { get; } = new BlobErrorCode(CopyAcrossAccountsNotSupportedValue);
        /// <summary> CopyIdMismatch. </summary>
        public static BlobErrorCode CopyIdMismatch { get; } = new BlobErrorCode(CopyIdMismatchValue);
        /// <summary> FeatureVersionMismatch. </summary>
        public static BlobErrorCode FeatureVersionMismatch { get; } = new BlobErrorCode(FeatureVersionMismatchValue);
        /// <summary> IncrementalCopyBlobMismatch. </summary>
        public static BlobErrorCode IncrementalCopyBlobMismatch { get; } = new BlobErrorCode(IncrementalCopyBlobMismatchValue);
        /// <summary> IncrementalCopyOfEarlierVersionSnapshotNotAllowed. </summary>
        public static BlobErrorCode IncrementalCopyOfEarlierVersionSnapshotNotAllowed { get; } = new BlobErrorCode(IncrementalCopyOfEarlierVersionSnapshotNotAllowedValue);
        /// <summary> IncrementalCopySourceMustBeSnapshot. </summary>
        public static BlobErrorCode IncrementalCopySourceMustBeSnapshot { get; } = new BlobErrorCode(IncrementalCopySourceMustBeSnapshotValue);
        /// <summary> InfiniteLeaseDurationRequired. </summary>
        public static BlobErrorCode InfiniteLeaseDurationRequired { get; } = new BlobErrorCode(InfiniteLeaseDurationRequiredValue);
        /// <summary> InvalidBlobOrBlock. </summary>
        public static BlobErrorCode InvalidBlobOrBlock { get; } = new BlobErrorCode(InvalidBlobOrBlockValue);
        /// <summary> InvalidBlobTier. </summary>
        public static BlobErrorCode InvalidBlobTier { get; } = new BlobErrorCode(InvalidBlobTierValue);
        /// <summary> InvalidBlobType. </summary>
        public static BlobErrorCode InvalidBlobType { get; } = new BlobErrorCode(InvalidBlobTypeValue);
        /// <summary> InvalidBlockId. </summary>
        public static BlobErrorCode InvalidBlockId { get; } = new BlobErrorCode(InvalidBlockIdValue);
        /// <summary> InvalidBlockList. </summary>
        public static BlobErrorCode InvalidBlockList { get; } = new BlobErrorCode(InvalidBlockListValue);
        /// <summary> InvalidOperation. </summary>
        public static BlobErrorCode InvalidOperation { get; } = new BlobErrorCode(InvalidOperationValue);
        /// <summary> InvalidPageRange. </summary>
        public static BlobErrorCode InvalidPageRange { get; } = new BlobErrorCode(InvalidPageRangeValue);
        /// <summary> InvalidSourceBlobType. </summary>
        public static BlobErrorCode InvalidSourceBlobType { get; } = new BlobErrorCode(InvalidSourceBlobTypeValue);
        /// <summary> InvalidSourceBlobUrl. </summary>
        public static BlobErrorCode InvalidSourceBlobUrl { get; } = new BlobErrorCode(InvalidSourceBlobUrlValue);
        /// <summary> InvalidVersionForPageBlobOperation. </summary>
        public static BlobErrorCode InvalidVersionForPageBlobOperation { get; } = new BlobErrorCode(InvalidVersionForPageBlobOperationValue);
        /// <summary> LeaseAlreadyPresent. </summary>
        public static BlobErrorCode LeaseAlreadyPresent { get; } = new BlobErrorCode(LeaseAlreadyPresentValue);
        /// <summary> LeaseAlreadyBroken. </summary>
        public static BlobErrorCode LeaseAlreadyBroken { get; } = new BlobErrorCode(LeaseAlreadyBrokenValue);
        /// <summary> LeaseIdMismatchWithBlobOperation. </summary>
        public static BlobErrorCode LeaseIdMismatchWithBlobOperation { get; } = new BlobErrorCode(LeaseIdMismatchWithBlobOperationValue);
        /// <summary> LeaseIdMismatchWithContainerOperation. </summary>
        public static BlobErrorCode LeaseIdMismatchWithContainerOperation { get; } = new BlobErrorCode(LeaseIdMismatchWithContainerOperationValue);
        /// <summary> LeaseIdMismatchWithLeaseOperation. </summary>
        public static BlobErrorCode LeaseIdMismatchWithLeaseOperation { get; } = new BlobErrorCode(LeaseIdMismatchWithLeaseOperationValue);
        /// <summary> LeaseIdMissing. </summary>
        public static BlobErrorCode LeaseIdMissing { get; } = new BlobErrorCode(LeaseIdMissingValue);
        /// <summary> LeaseIsBreakingAndCannotBeAcquired. </summary>
        public static BlobErrorCode LeaseIsBreakingAndCannotBeAcquired { get; } = new BlobErrorCode(LeaseIsBreakingAndCannotBeAcquiredValue);
        /// <summary> LeaseIsBreakingAndCannotBeChanged. </summary>
        public static BlobErrorCode LeaseIsBreakingAndCannotBeChanged { get; } = new BlobErrorCode(LeaseIsBreakingAndCannotBeChangedValue);
        /// <summary> LeaseIsBrokenAndCannotBeRenewed. </summary>
        public static BlobErrorCode LeaseIsBrokenAndCannotBeRenewed { get; } = new BlobErrorCode(LeaseIsBrokenAndCannotBeRenewedValue);
        /// <summary> LeaseLost. </summary>
        public static BlobErrorCode LeaseLost { get; } = new BlobErrorCode(LeaseLostValue);
        /// <summary> LeaseNotPresentWithBlobOperation. </summary>
        public static BlobErrorCode LeaseNotPresentWithBlobOperation { get; } = new BlobErrorCode(LeaseNotPresentWithBlobOperationValue);
        /// <summary> LeaseNotPresentWithContainerOperation. </summary>
        public static BlobErrorCode LeaseNotPresentWithContainerOperation { get; } = new BlobErrorCode(LeaseNotPresentWithContainerOperationValue);
        /// <summary> LeaseNotPresentWithLeaseOperation. </summary>
        public static BlobErrorCode LeaseNotPresentWithLeaseOperation { get; } = new BlobErrorCode(LeaseNotPresentWithLeaseOperationValue);
        /// <summary> MaxBlobSizeConditionNotMet. </summary>
        public static BlobErrorCode MaxBlobSizeConditionNotMet { get; } = new BlobErrorCode(MaxBlobSizeConditionNotMetValue);
        /// <summary> NoAuthenticationInformation. </summary>
        public static BlobErrorCode NoAuthenticationInformation { get; } = new BlobErrorCode(NoAuthenticationInformationValue);
        /// <summary> NoPendingCopyOperation. </summary>
        public static BlobErrorCode NoPendingCopyOperation { get; } = new BlobErrorCode(NoPendingCopyOperationValue);
        /// <summary> OperationNotAllowedOnIncrementalCopyBlob. </summary>
        public static BlobErrorCode OperationNotAllowedOnIncrementalCopyBlob { get; } = new BlobErrorCode(OperationNotAllowedOnIncrementalCopyBlobValue);
        /// <summary> PendingCopyOperation. </summary>
        public static BlobErrorCode PendingCopyOperation { get; } = new BlobErrorCode(PendingCopyOperationValue);
        /// <summary> PreviousSnapshotCannotBeNewer. </summary>
        public static BlobErrorCode PreviousSnapshotCannotBeNewer { get; } = new BlobErrorCode(PreviousSnapshotCannotBeNewerValue);
        /// <summary> PreviousSnapshotNotFound. </summary>
        public static BlobErrorCode PreviousSnapshotNotFound { get; } = new BlobErrorCode(PreviousSnapshotNotFoundValue);
        /// <summary> PreviousSnapshotOperationNotSupported. </summary>
        public static BlobErrorCode PreviousSnapshotOperationNotSupported { get; } = new BlobErrorCode(PreviousSnapshotOperationNotSupportedValue);
        /// <summary> SequenceNumberConditionNotMet. </summary>
        public static BlobErrorCode SequenceNumberConditionNotMet { get; } = new BlobErrorCode(SequenceNumberConditionNotMetValue);
        /// <summary> SequenceNumberIncrementTooLarge. </summary>
        public static BlobErrorCode SequenceNumberIncrementTooLarge { get; } = new BlobErrorCode(SequenceNumberIncrementTooLargeValue);
        /// <summary> SnapshotCountExceeded. </summary>
        public static BlobErrorCode SnapshotCountExceeded { get; } = new BlobErrorCode(SnapshotCountExceededValue);
        /// <summary> SnapshotOperationRateExceeded. </summary>
        public static BlobErrorCode SnapshotOperationRateExceeded { get; } = new BlobErrorCode(SnapshotOperationRateExceededValue);
        /// <summary> SnapshotsPresent. </summary>
        public static BlobErrorCode SnapshotsPresent { get; } = new BlobErrorCode(SnapshotsPresentValue);
        /// <summary> SourceConditionNotMet. </summary>
        public static BlobErrorCode SourceConditionNotMet { get; } = new BlobErrorCode(SourceConditionNotMetValue);
        /// <summary> SystemInUse. </summary>
        public static BlobErrorCode SystemInUse { get; } = new BlobErrorCode(SystemInUseValue);
        /// <summary> TargetConditionNotMet. </summary>
        public static BlobErrorCode TargetConditionNotMet { get; } = new BlobErrorCode(TargetConditionNotMetValue);
        /// <summary> UnauthorizedBlobOverwrite. </summary>
        public static BlobErrorCode UnauthorizedBlobOverwrite { get; } = new BlobErrorCode(UnauthorizedBlobOverwriteValue);
        /// <summary> BlobBeingRehydrated. </summary>
        public static BlobErrorCode BlobBeingRehydrated { get; } = new BlobErrorCode(BlobBeingRehydratedValue);
        /// <summary> BlobArchived. </summary>
        public static BlobErrorCode BlobArchived { get; } = new BlobErrorCode(BlobArchivedValue);
        /// <summary> BlobNotArchived. </summary>
        public static BlobErrorCode BlobNotArchived { get; } = new BlobErrorCode(BlobNotArchivedValue);
        /// <summary> AuthorizationSourceIPMismatch. </summary>
        public static BlobErrorCode AuthorizationSourceIPMismatch { get; } = new BlobErrorCode(AuthorizationSourceIPMismatchValue);
        /// <summary> AuthorizationProtocolMismatch. </summary>
        public static BlobErrorCode AuthorizationProtocolMismatch { get; } = new BlobErrorCode(AuthorizationProtocolMismatchValue);
        /// <summary> AuthorizationPermissionMismatch. </summary>
        public static BlobErrorCode AuthorizationPermissionMismatch { get; } = new BlobErrorCode(AuthorizationPermissionMismatchValue);
        /// <summary> AuthorizationServiceMismatch. </summary>
        public static BlobErrorCode AuthorizationServiceMismatch { get; } = new BlobErrorCode(AuthorizationServiceMismatchValue);
        /// <summary> AuthorizationResourceTypeMismatch. </summary>
        public static BlobErrorCode AuthorizationResourceTypeMismatch { get; } = new BlobErrorCode(AuthorizationResourceTypeMismatchValue);
        /// <summary> BlobAccessTierNotSupportedForAccountType. </summary>
        public static BlobErrorCode BlobAccessTierNotSupportedForAccountType { get; } = new BlobErrorCode(BlobAccessTierNotSupportedForAccountTypeValue);
        /// <summary> Determines if two <see cref="BlobErrorCode"/> values are the same. </summary>
        public static bool operator ==(BlobErrorCode left, BlobErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobErrorCode"/> values are not the same. </summary>
        public static bool operator !=(BlobErrorCode left, BlobErrorCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlobErrorCode"/>. </summary>
        public static implicit operator BlobErrorCode(string value) => new BlobErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
