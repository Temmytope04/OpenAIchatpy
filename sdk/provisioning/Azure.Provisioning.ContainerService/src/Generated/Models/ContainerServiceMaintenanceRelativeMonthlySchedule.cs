// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// For schedules like: &apos;recur every month on the first Monday&apos; or
/// &apos;recur every 3 months on last Friday&apos;.
/// </summary>
public partial class ContainerServiceMaintenanceRelativeMonthlySchedule : ProvisionableConstruct
{
    /// <summary>
    /// Specifies the number of months between each set of occurrences.
    /// </summary>
    public BicepValue<int> IntervalMonths { get => _intervalMonths; set => _intervalMonths.Assign(value); }
    private readonly BicepValue<int> _intervalMonths;

    /// <summary>
    /// Specifies on which week of the month the dayOfWeek applies.
    /// </summary>
    public BicepValue<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex> WeekIndex { get => _weekIndex; set => _weekIndex.Assign(value); }
    private readonly BicepValue<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex> _weekIndex;

    /// <summary>
    /// Specifies on which day of the week the maintenance occurs.
    /// </summary>
    public BicepValue<ContainerServiceWeekDay> DayOfWeek { get => _dayOfWeek; set => _dayOfWeek.Assign(value); }
    private readonly BicepValue<ContainerServiceWeekDay> _dayOfWeek;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceRelativeMonthlySchedule.
    /// </summary>
    public ContainerServiceMaintenanceRelativeMonthlySchedule()
    {
        _intervalMonths = BicepValue<int>.DefineProperty(this, "IntervalMonths", ["intervalMonths"]);
        _weekIndex = BicepValue<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex>.DefineProperty(this, "WeekIndex", ["weekIndex"]);
        _dayOfWeek = BicepValue<ContainerServiceWeekDay>.DefineProperty(this, "DayOfWeek", ["dayOfWeek"]);
    }
}
