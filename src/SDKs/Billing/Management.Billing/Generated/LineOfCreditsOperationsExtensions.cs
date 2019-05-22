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
    /// Extension methods for LineOfCreditsOperations.
    /// </summary>
    public static partial class LineOfCreditsOperationsExtensions
    {
            /// <summary>
            /// Get the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LineOfCredit Get(this ILineOfCreditsOperations operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LineOfCredit> GetAsync(this ILineOfCreditsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Increase the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the increase line of credit operation.
            /// </param>
            public static LineOfCredit Increase(this ILineOfCreditsOperations operations, IncreaseLineOfCreditRequestProperties parameters)
            {
                return operations.IncreaseAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Increase the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the increase line of credit operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LineOfCredit> IncreaseAsync(this ILineOfCreditsOperations operations, IncreaseLineOfCreditRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IncreaseWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Increase the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the increase line of credit operation.
            /// </param>
            public static LineOfCredit BeginIncrease(this ILineOfCreditsOperations operations, IncreaseLineOfCreditRequestProperties parameters)
            {
                return operations.BeginIncreaseAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Increase the current line of credit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the increase line of credit operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LineOfCredit> BeginIncreaseAsync(this ILineOfCreditsOperations operations, IncreaseLineOfCreditRequestProperties parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginIncreaseWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
