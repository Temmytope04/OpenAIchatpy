﻿using Microsoft.Azure.Management.Orbital.Models;
using Microsoft.Azure.Management.Orbital.Tests.Helpers;
using Microsoft.Azure.Management.Orbital.Tests.Tests;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace Microsoft.Azure.Management.Orbital.Tests.Tests
{
    public class AvailableGroundStationTests : TestBase
    {
        [Fact]
        public void AvailableGroundStationApiTests()
        {
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };
                var azureOrbitalClient = GetAzureOrbitalClientWithHandler(context, handler);

                List<AvailableGroundStation> listAvailableGroundStations = (List<AvailableGroundStation>)azureOrbitalClient.AvailableGroundStations.ListByCapability("EarthObservation");
                
                Assert.NotNull(listAvailableGroundStations);
                Assert.NotEmpty(listAvailableGroundStations);

                var getAvailableGroundStation = azureOrbitalClient.AvailableGroundStations.Get(listAvailableGroundStations[0].Id);

                Assert.NotNull(getAvailableGroundStation);
                Assert.NotNull(getAvailableGroundStation.Name);
                Assert.NotNull(getAvailableGroundStation.Location);
            }
        }
    }
}
