﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationsTests.cs" company="Microsoft">
//   
// </copyright>
// <summary>
//   Defines the OperationsTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Peering.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.Azure.Management.Peering;
    using Microsoft.Azure.Management.Peering.Models;
    using Microsoft.Azure.Management.Resources;
    using Microsoft.Azure.Management.Resources.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    using Xunit;

    using ContactInfo = Microsoft.Azure.Management.Peering.Models.ContactInfo;
    using DirectConnection = Microsoft.Azure.Management.Peering.Models.DirectConnection;
    using PeeringSku = Microsoft.Azure.Management.Peering.Models.PeeringSku;
    using SubResource = Microsoft.Azure.Management.Peering.Models.SubResource;

    public class PeeringTests
    {
        private readonly Random random = new Random();
        public PeeringManagementClient client { get; set; }
        public ResourceManagementClient resourcesClient { get; set; }

        [Fact]
        public void PeeringOperationsTest()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();
                var peeringLists = this.client.Operations.List();
                Assert.NotNull(peeringLists);
            }
        }

        [Fact]
        public void GetDirectLocations()
        {

            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();
                var result = this.client.PeeringLocations.List("Direct");
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void GetExchangeLocations()
        {

            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();
                var result = this.client.PeeringLocations.List("Exchange");
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void UpdatePeerInfoTest()
        {
            this.Init();
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                string[] phone = { "9999999" };
                string[] email = { "noc@contoso.com" };
                var contactInfo = new ContactInfo(email, phone);
                var peerInfo = new PeerAsn(peerAsnProperty: 65000, peerContactInfo: contactInfo, peerName: "Contoso");

                this.client = context.GetServiceClient<PeeringManagementClient>();
                try
                {
                    var result = this.client.PeerAsns.CreateOrUpdate(peerInfo.PeerName, peerInfo);
                    var peerAsn = this.client.PeerAsns.Get(peerInfo.PeerName);
                    Assert.NotNull(peerAsn);
                }
                catch (Exception exception)
                {
                    var peerAsn = this.client.PeerAsns.ListBySubscription();
                    Assert.NotNull(peerAsn);
                    Assert.NotNull(exception);
                }
            }
        }

        [Fact]
        public void GetPeerAsnTest()
        {
            this.Init();
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();
                var result = this.client.PeerAsns.Get("Contoso");
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void CreateDirectPeering()
        {

            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();

                //Create a Resource Group
                this.resourcesClient = context.GetServiceClient<ResourceManagementClient>();
                var rgname = TestUtilities.GenerateName("res");
                var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                    rgname,
                    new ResourceGroup
                    {
                        Location = "centralus"
                    });

                //Create Direct Peering
                var directConnection = new DirectConnection
                {
                    BandwidthInMbps = 10000,
                    PeeringDBFacilityId = 63,
                    BgpSession = new Microsoft.Azure.Management.Peering.Models.BgpSession()
                    {
                        SessionPrefixV4 = this.CreateIpv4Address(true),
                        MaxPrefixesAdvertisedV4 = 20000
                    }
                };
                var directPeeringProperties = new PeeringPropertiesDirect(new List<DirectConnection>(), false, new SubResource("65000"));
                directPeeringProperties.Connections.Add(directConnection);
                var peeringModel = new PeeringModel
                {
                    PeeringLocation = "Amsterdam",
                    Sku = new PeeringSku("Basic_Direct_Free"),
                    Direct = directPeeringProperties,
                    Location = "centralus",
                    Kind = "Direct"
                };

                var result = this.client.Peerings.CreateOrUpdate(rgname, "abc", peeringModel);
                var peering = this.client.Peerings.Get(rgname, "abc");
                Assert.NotNull(peering);
                Assert.Equal("abc", peering.Name);
            }
        }

        [Fact]
        public void CreateExchangePeering()
        {

            using (var context = MockContext.Start(this.GetType().FullName))
            {
                this.client = context.GetServiceClient<PeeringManagementClient>();

                //Create a Resource Group
                this.resourcesClient = context.GetServiceClient<ResourceManagementClient>();
                var rgname = TestUtilities.GenerateName("res");
                var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                    rgname,
                    new ResourceGroup
                    {
                        Location = "centralus"
                    });

                //Create Exchange Peering
                var exchangeConnection = new ExchangeConnection
                {
                    PeeringDBFacilityId = 26,
                    BgpSession = new Microsoft.Azure.Management.Peering.Models.BgpSession()
                    {
                        PeerSessionIPv4Address = "80.249.208.2",
                        MaxPrefixesAdvertisedV4 = 20000
                    }
                };
                var exchangePeeringProperties = new PeeringPropertiesExchange(new List<ExchangeConnection>(), new SubResource("65000"));
                exchangePeeringProperties.Connections.Add(exchangeConnection);
                var peeringModel = new PeeringModel
                {
                    PeeringLocation = "Amsterdam",
                    Sku = new PeeringSku("Basic_Exchange_Free"),
                    Location = "centralus",
                    Exchange = exchangePeeringProperties,
                    Kind = "Exchange"
                };

                var result = this.client.Peerings.CreateOrUpdate(rgname, "xyz", peeringModel);
                var peering = this.client.Peerings.Get(rgname, "xyz");
                Assert.NotNull(peering);
                Assert.Equal("xyz", peering.Name);
            }
        }

        private string CreateIpv4Address(bool useMaxSubNet = true)
        {
            return useMaxSubNet
                ? $"{this.random.Next(1, 255)}.{this.random.Next(0, 255)}.{this.random.Next(0, 255)}.0/30"
                : $"{this.random.Next(1, 255)}.{this.random.Next(0, 255)}.{this.random.Next(0, 255)}.0/31";
        }

        private void Init()
        {
            var mode = System.Environment.GetEnvironmentVariable("AZURE_TEST_MODE");
            var connectionstring = System.Environment.GetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION");
            if (mode == null)
                Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Record");
            if (connectionstring == null)
                Environment.SetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION", "SubscriptionId=4445bf11-61c4-436f-a940-60194f8aca57;ServicePrincipal=a66ad4b3-4c1b-43bf-a0bd-91c8c2c9a6d8;ServicePrincipalSecret=EO84mEYKj9hbJfn/GfkgFCsZmEjDpUqm4ys7CEQpAuY=;AADTenant=f686d426-8d16-42db-81b7-ab578e110ccd;Environment=Dogfood;HttpRecorderMode=Record;");
        }
    }
}