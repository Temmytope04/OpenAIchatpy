// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PrivateDns
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecordSetsOperations.
    /// </summary>
    public static partial class RecordSetsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA can be
            /// updated but not created (they are created when the Private DNS zone is
            /// created). Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR',
            /// 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new record set to be created, but to prevent updating
            /// an existing record set. Other values will be ignored.
            /// </param>
            public static RecordSet CreateOrUpdate(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA can be
            /// updated but not created (they are created when the Private DNS zone is
            /// created). Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR',
            /// 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new record set to be created, but to prevent updating
            /// an existing record set. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecordSet> CreateOrUpdateAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Possible values include: 'A',
            /// 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting concurrent changes.
            /// </param>
            public static RecordSet Update(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a record set within a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Possible values include: 'A',
            /// 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always overwrite the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// overwriting concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecordSet> UpdateAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, RecordSet parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a record set from a Private DNS zone. This operation cannot be
            /// undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA cannot
            /// be deleted (they are deleted when the Private DNS zone is deleted).
            /// Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV',
            /// 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always delete the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// deleting any concurrent changes.
            /// </param>
            public static void Delete(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, string ifMatch = default(string))
            {
                operations.DeleteAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a record set from a Private DNS zone. This operation cannot be
            /// undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Record sets of type SOA cannot
            /// be deleted (they are deleted when the Private DNS zone is deleted).
            /// Possible values include: 'A', 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV',
            /// 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the record set. Omit this value to always delete the current
            /// record set. Specify the last-seen ETag value to prevent accidentally
            /// deleting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a record set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Possible values include: 'A',
            /// 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            public static RecordSet Get(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName)
            {
                return operations.GetAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a record set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of DNS record in this record set. Possible values include: 'A',
            /// 'AAAA', 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='relativeRecordSetName'>
            /// The name of the record set, relative to the name of the zone.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecordSet> GetAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, string relativeRecordSetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, relativeRecordSetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the record sets of a specified type in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of record sets to enumerate. Possible values include: 'A', 'AAAA',
            /// 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            /// <param name='recordsetnamesuffix'>
            /// The suffix label of the record set name to be used to filter the record set
            /// enumeration. If this parameter is specified, the returned enumeration will
            /// only contain records that end with ".&lt;recordsetnamesuffix&gt;".
            /// </param>
            public static IPage<RecordSet> ListByType(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, int? top = default(int?), string recordsetnamesuffix = default(string))
            {
                return operations.ListByTypeAsync(resourceGroupName, privateZoneName, recordType, top, recordsetnamesuffix).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the record sets of a specified type in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='recordType'>
            /// The type of record sets to enumerate. Possible values include: 'A', 'AAAA',
            /// 'CNAME', 'MX', 'PTR', 'SOA', 'SRV', 'TXT'
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            /// <param name='recordsetnamesuffix'>
            /// The suffix label of the record set name to be used to filter the record set
            /// enumeration. If this parameter is specified, the returned enumeration will
            /// only contain records that end with ".&lt;recordsetnamesuffix&gt;".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecordSet>> ListByTypeAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, RecordType recordType, int? top = default(int?), string recordsetnamesuffix = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTypeWithHttpMessagesAsync(resourceGroupName, privateZoneName, recordType, top, recordsetnamesuffix, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all record sets in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            /// <param name='recordsetnamesuffix'>
            /// The suffix label of the record set name to be used to filter the record set
            /// enumeration. If this parameter is specified, the returned enumeration will
            /// only contain records that end with ".&lt;recordsetnamesuffix&gt;".
            /// </param>
            public static IPage<RecordSet> List(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, int? top = default(int?), string recordsetnamesuffix = default(string))
            {
                return operations.ListAsync(resourceGroupName, privateZoneName, top, recordsetnamesuffix).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all record sets in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            /// <param name='recordsetnamesuffix'>
            /// The suffix label of the record set name to be used to filter the record set
            /// enumeration. If this parameter is specified, the returned enumeration will
            /// only contain records that end with ".&lt;recordsetnamesuffix&gt;".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecordSet>> ListAsync(this IRecordSetsOperations operations, string resourceGroupName, string privateZoneName, int? top = default(int?), string recordsetnamesuffix = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateZoneName, top, recordsetnamesuffix, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the record sets of a specified type in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecordSet> ListByTypeNext(this IRecordSetsOperations operations, string nextPageLink)
            {
                return operations.ListByTypeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the record sets of a specified type in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecordSet>> ListByTypeNextAsync(this IRecordSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTypeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all record sets in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecordSet> ListNext(this IRecordSetsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all record sets in a Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecordSet>> ListNextAsync(this IRecordSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
