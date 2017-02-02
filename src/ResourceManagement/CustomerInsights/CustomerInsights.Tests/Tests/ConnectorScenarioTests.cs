﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace CustomerInsights.Tests.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading;

    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    using Xunit;

    public class ConnectorScenarioTests
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        static ConnectorScenarioTests()
        {
            HubName = AppSettings.HubName;
            ResourceGroupName = AppSettings.ResourceGroupName;
        }

        /// <summary>
        ///     Hub Name
        /// </summary>
        private static readonly string HubName;

        /// <summary>
        ///     Reosurce Group Name
        /// </summary>
        private static readonly string ResourceGroupName;

        [Fact]
        public void CrdConnectorFullCycle()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var aciClient = context.GetServiceClient<CustomerInsightsManagementClient>();

                var connectorName = TestUtilities.GenerateName("testConnector");
                var connectorResourceFormat = new ConnectorResourceFormat
                                                  {
                                                      DisplayName = connectorName,
                                                      Description = "Test connector",
                                                      ConnectorType = ConnectorTypes.AzureBlob,
                                                      ConnectorProperties =
                                                          new Dictionary<string, object>
                                                              {
                                                                      {
                                                                          "connectionKeyVaultUrl",
                                                                          $"vault=off;DefaultEndpointsProtocol=https;AccountName=XXX;AccountKey=XXX"
                                                                      }
                                                              }
                                                  };

                var createdConnector = aciClient.Connectors.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    connectorName,
                    connectorResourceFormat);

                Assert.Equal(connectorName, createdConnector.ConnectorName);
                Assert.Equal(createdConnector.Name, HubName + "/" + connectorName, StringComparer.OrdinalIgnoreCase);
                Assert.Equal(
                    createdConnector.Type,
                    "Microsoft.CustomerInsights/hubs/connectors",
                    StringComparer.OrdinalIgnoreCase);

                var getConnector = aciClient.Connectors.Get(ResourceGroupName, HubName, connectorName);

                Assert.Equal(connectorName, getConnector.ConnectorName);
                Assert.Equal(getConnector.Name, HubName + "/" + connectorName, StringComparer.OrdinalIgnoreCase);
                Assert.Equal(
                    getConnector.Type,
                    "Microsoft.CustomerInsights/hubs/connectors",
                    StringComparer.OrdinalIgnoreCase);

                var deleteConnectorResponse =
                    aciClient.Connectors.DeleteWithHttpMessagesAsync(ResourceGroupName, HubName, connectorName).Result;

                Assert.Equal(HttpStatusCode.OK, deleteConnectorResponse.Response.StatusCode);
            }
        }

        [Fact]
        public void ListConnectorsInHub()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var aciClient = context.GetServiceClient<CustomerInsightsManagementClient>();

                var connectorName1 = "testConnector1";
                var connectorResourceFormat1 = new ConnectorResourceFormat
                                                   {
                                                       DisplayName = connectorName1,
                                                       Description = "Test connector 1",
                                                       ConnectorType = ConnectorTypes.AzureBlob,
                                                       ConnectorProperties =
                                                           new Dictionary<string, object>
                                                               {
                                                                       {
                                                                           "connectionKeyVaultUrl",
                                                                           $"vault=off;DefaultEndpointsProtocol=https;AccountName=XXX;AccountKey=XXX"
                                                                       }
                                                               }
                                                   };

                var connectorName2 = "testConnector2";
                var connectorResourceFormat2 = new ConnectorResourceFormat
                                                   {
                                                       DisplayName = connectorName2,
                                                       Description = "Test connector 2",
                                                       ConnectorType = ConnectorTypes.AzureBlob,
                                                       ConnectorProperties =
                                                           new Dictionary<string, object>
                                                               {
                                                                       {
                                                                           "connectionKeyVaultUrl",
                                                                           $"vault=off;DefaultEndpointsProtocol=https;AccountName=XXX;AccountKey=XXX"
                                                                       }
                                                               }
                                                   };

                aciClient.Connectors.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    connectorName1,
                    connectorResourceFormat1);
                aciClient.Connectors.CreateOrUpdate(
                    ResourceGroupName,
                    HubName,
                    connectorName2,
                    connectorResourceFormat2);

                var result = aciClient.Connectors.ListByHub(ResourceGroupName, HubName);
                Assert.True(result.ToList().Count >= 2);
                Assert.True(
                    result.ToList().Any(connectorReturned => connectorName1 == connectorReturned.ConnectorName)
                    && result.ToList().Any(connectorReturned => connectorName2 == connectorReturned.ConnectorName));
            }
        }
    }
}