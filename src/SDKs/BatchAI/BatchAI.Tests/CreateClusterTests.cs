﻿using System;
using System.Net;
using Xunit;
using Microsoft.Azure.Management.BatchAI;
using Microsoft.Azure.Management.BatchAI.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;


namespace BatchAI.Tests
{
    public class CreateClusterTests
    {
        /*
        1. Create cluster
        2. Verify properties after creation
        3. Delete cluster
        */
        [Fact]
        public void TestClusterCreationAndDeletion()
        {
            var handler1 = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };
            var handler2 = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            string clusterName = TestUtilities.GenerateName("testcluster");

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var client = Helpers.GetBatchAIClient(context, handler1);

                var rgClient = Helpers.GetResourceManagementClient(context, handler2);

                string rgName = Helpers.CreateResourceGroup(rgClient);

                var createParams = new ClusterCreateParameters()
                {
                    ScaleSettings = new ScaleSettings()
                    {
                        Manual = new ManualScaleSettings()
                        {
                            TargetNodeCount = 1
                        }
                    },
                    VmSize = "STANDARD_D1",
                    UserAccountSettings = new UserAccountSettings()
                    {
                        AdminUserName = Helpers.ADMIN_USER_NAME,
                        AdminUserPassword = Helpers.ADMIN_USER_PASSWORD,
                    },
                    Location = Helpers.LOCATION,
                };

                try
                {
                    Cluster cluster = client.Clusters.Create(rgName, clusterName, createParams);

                    Helpers.VerifyClusterProperties(clusterName, createParams, cluster);
                }
                finally
                {
                    client.Clusters.Delete(rgName, clusterName);
                }
            }

        }
    }
}
