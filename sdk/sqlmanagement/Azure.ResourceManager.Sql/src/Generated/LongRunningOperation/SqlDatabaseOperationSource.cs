// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class SqlDatabaseOperationSource : IOperationSource<SqlDatabaseResource>
    {
        private readonly ArmClient _client;

        internal SqlDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlDatabaseResource IOperationSource<SqlDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlDatabaseData.DeserializeSqlDatabaseData(document.RootElement);
            return new SqlDatabaseResource(_client, data);
        }

        async ValueTask<SqlDatabaseResource> IOperationSource<SqlDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlDatabaseData.DeserializeSqlDatabaseData(document.RootElement);
            return new SqlDatabaseResource(_client, data);
        }
    }
}
