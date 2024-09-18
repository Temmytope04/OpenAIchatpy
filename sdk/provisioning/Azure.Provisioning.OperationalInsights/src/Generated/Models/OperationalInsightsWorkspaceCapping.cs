// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The daily volume cap for ingestion.
/// </summary>
public partial class OperationalInsightsWorkspaceCapping : ProvisioningConstruct
{
    /// <summary>
    /// The workspace daily quota for ingestion.
    /// </summary>
    public BicepValue<double> DailyQuotaInGB { get => _dailyQuotaInGB; set => _dailyQuotaInGB.Assign(value); }
    private readonly BicepValue<double> _dailyQuotaInGB;

    /// <summary>
    /// The time when the quota will be rest.
    /// </summary>
    public BicepValue<string> QuotaNextResetTime { get => _quotaNextResetTime; }
    private readonly BicepValue<string> _quotaNextResetTime;

    /// <summary>
    /// The status of data ingestion for this workspace.
    /// </summary>
    public BicepValue<OperationalInsightsDataIngestionStatus> DataIngestionStatus { get => _dataIngestionStatus; }
    private readonly BicepValue<OperationalInsightsDataIngestionStatus> _dataIngestionStatus;

    /// <summary>
    /// Creates a new OperationalInsightsWorkspaceCapping.
    /// </summary>
    public OperationalInsightsWorkspaceCapping()
    {
        _dailyQuotaInGB = BicepValue<double>.DefineProperty(this, "DailyQuotaInGB", ["dailyQuotaGb"]);
        _quotaNextResetTime = BicepValue<string>.DefineProperty(this, "QuotaNextResetTime", ["quotaNextResetTime"], isOutput: true);
        _dataIngestionStatus = BicepValue<OperationalInsightsDataIngestionStatus>.DefineProperty(this, "DataIngestionStatus", ["dataIngestionStatus"], isOutput: true);
    }
}
