// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsageDetailsListOperations.
    /// </summary>
    public static partial class UsageDetailsListOperationsExtensions
    {
            /// <summary>
            /// Download usage details data.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope and
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope. For subscription, billing account, department,
            /// enrollment account and management group, you can also add billing period to
            /// the scope using
            /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'. For e.g.
            /// to specify billing period at department scope use
            /// '/providers/Microsoft.Billing/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// </param>
            public static UsageDetailsDownloadResponse Download(this IUsageDetailsListOperations operations, string scope)
            {
                return operations.DownloadAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download usage details data.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope and
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope. For subscription, billing account, department,
            /// enrollment account and management group, you can also add billing period to
            /// the scope using
            /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'. For e.g.
            /// to specify billing period at department scope use
            /// '/providers/Microsoft.Billing/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UsageDetailsDownloadResponse> DownloadAsync(this IUsageDetailsListOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DownloadWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Download usage details data.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope and
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope. For subscription, billing account, department,
            /// enrollment account and management group, you can also add billing period to
            /// the scope using
            /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'. For e.g.
            /// to specify billing period at department scope use
            /// '/providers/Microsoft.Billing/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// </param>
            public static UsageDetailsDownloadResponse BeginDownload(this IUsageDetailsListOperations operations, string scope)
            {
                return operations.BeginDownloadAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download usage details data.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with usage details operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// '/providers/Microsoft.Billing/departments/{departmentId}' for Department
            /// scope,
            /// '/providers/Microsoft.Billing/enrollmentAccounts/{enrollmentAccountId}' for
            /// EnrollmentAccount scope and
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope. For subscription, billing account, department,
            /// enrollment account and management group, you can also add billing period to
            /// the scope using
            /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'. For e.g.
            /// to specify billing period at department scope use
            /// '/providers/Microsoft.Billing/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UsageDetailsDownloadResponse> BeginDownloadAsync(this IUsageDetailsListOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDownloadWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
