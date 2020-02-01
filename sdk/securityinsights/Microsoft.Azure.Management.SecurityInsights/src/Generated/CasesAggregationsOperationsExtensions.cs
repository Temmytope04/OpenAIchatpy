// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CasesAggregationsOperations.
    /// </summary>
    public static partial class CasesAggregationsOperationsExtensions
    {
            /// <summary>
            /// Get aggregative result for the given resources under the defined workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='aggregationsName'>
            /// The aggregation name. Supports - Cases
            /// </param>
            public static Aggregations Get(this ICasesAggregationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string aggregationsName)
            {
                return operations.GetAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, aggregationsName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get aggregative result for the given resources under the defined workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='aggregationsName'>
            /// The aggregation name. Supports - Cases
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Aggregations> GetAsync(this ICasesAggregationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string aggregationsName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, aggregationsName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
