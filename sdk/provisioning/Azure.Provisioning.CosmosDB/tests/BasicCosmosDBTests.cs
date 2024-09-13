// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Tests;
using NUnit.Framework;

namespace Azure.Provisioning.CosmosDB.Tests;

public class BasicCosmosDBTests(bool async)
    : ProvisioningTestBase(async /*, skipTools: true, skipLiveCalls: true /**/)
{
    [Test]
    [Description("https://github.com/Azure/azure-quickstart-templates/blob/master/quickstarts/microsoft.documentdb/cosmosdb-free/main.bicep")]
    public async Task CreateCosmosSqlDB()
    {
        await using Trycep test = CreateBicepTest();
        await test.Define(
            ctx =>
            {
                BicepParameter dbName = new(nameof(dbName), typeof(string)) { Value = "orders" };
                BicepParameter containerName = new(nameof(containerName), typeof(string)) { Value = "products" };

                CosmosDBAccount cosmos =
                    new(nameof(cosmos))
                    {
                        DatabaseAccountOfferType = CosmosDBAccountOfferType.Standard,
                        ConsistencyPolicy = new ConsistencyPolicy
                        {
                            DefaultConsistencyLevel = DefaultConsistencyLevel.Session
                        },
                        Locations =
                        {
                            new CosmosDBAccountLocation { LocationName = BicepFunction.GetResourceGroup().Location }
                        }
                    };

                CosmosDBSqlDatabase db =
                    new(nameof(db), CosmosDBAccount.ResourceVersions.V2023_11_15)
                    {
                        Parent = cosmos,
                        Name = dbName,
                        Resource = new CosmosDBSqlDatabaseResourceInfo
                        {
                            DatabaseName = dbName
                        },
                        Options = new CosmosDBCreateUpdateConfig
                        {
                            Throughput = 400
                        }
                    };

                CosmosDBSqlContainer container =
                    new(nameof(container), CosmosDBAccount.ResourceVersions.V2023_11_15)
                    {
                        Parent = db,
                        Name = containerName,
                        Resource = new CosmosDBSqlContainerResourceInfo
                        {
                            ContainerName = containerName,
                            PartitionKey = new CosmosDBContainerPartitionKey
                            {
                                Paths = { "/myPartitionKey" }
                            }
                        },
                    };

                _ = new BicepOutput("containerName", typeof(string)) { Value = container.Name };
                _ = new BicepOutput("containerId", typeof(string)) { Value = container.Id };
            })
        .Compare(
            """
            param dbName string = 'orders'

            param containerName string = 'products'

            @description('The location for the resource(s) to be deployed.')
            param location string = resourceGroup().location

            resource cosmos 'Microsoft.DocumentDB/databaseAccounts@2024-05-15-preview' = {
                name: take('cosmos-${uniqueString(resourceGroup().id)}', 44)
                location: location
                properties: {
                    locations: [
                        {
                            locationName: resourceGroup().location
                        }
                    ]
                    consistencyPolicy: {
                        defaultConsistencyLevel: 'Session'
                    }
                    databaseAccountOfferType: 'Standard'
                }
            }

            resource db 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases@2023-11-15' = {
                name: dbName
                location: location
                properties: {
                    resource: {
                        id: dbName
                    }
                    options: {
                        throughput: 400
                    }
                }
                parent: cosmos
            }

            resource container 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers@2023-11-15' = {
                name: containerName
                location: location
                properties: {
                    resource: {
                        id: containerName
                        partitionKey: {
                            paths: [
                                '/myPartitionKey'
                            ]
                        }
                    }
                }
                parent: db
            }

            output containerName string = containerName

            output containerId string = container.id
            """)
        .Lint()
        .ValidateAndDeployAsync();
    }
}
