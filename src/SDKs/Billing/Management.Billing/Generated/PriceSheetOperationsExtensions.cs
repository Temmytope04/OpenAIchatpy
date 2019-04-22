// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PriceSheetOperations.
    /// </summary>
    public static partial class PriceSheetOperationsExtensions
    {
            /// <summary>
            /// Download price sheet for an invoice.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// Azure Billing Account ID.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            public static DownloadUrl Download(this IPriceSheetOperations operations, string billingAccountName, string invoiceName)
            {
                return operations.DownloadAsync(billingAccountName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download price sheet for an invoice.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// Azure Billing Account ID.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DownloadUrl> DownloadAsync(this IPriceSheetOperations operations, string billingAccountName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DownloadWithHttpMessagesAsync(billingAccountName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Download price sheet for an invoice.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// Azure Billing Account ID.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            public static DownloadUrl BeginDownload(this IPriceSheetOperations operations, string billingAccountName, string invoiceName)
            {
                return operations.BeginDownloadAsync(billingAccountName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Download price sheet for an invoice.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// Azure Billing Account ID.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DownloadUrl> BeginDownloadAsync(this IPriceSheetOperations operations, string billingAccountName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDownloadWithHttpMessagesAsync(billingAccountName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
