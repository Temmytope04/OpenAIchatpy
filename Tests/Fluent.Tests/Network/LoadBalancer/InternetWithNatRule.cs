﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Azure.Tests.Common;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.Network.Fluent;
using Microsoft.Azure.Management.Network.Fluent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;

namespace Fluent.Tests.Network.LoadBalancerHelpers
{
    /// <summary>
    /// Internet-facing LB test with NAT rules.
    /// </summary>
    public class InternetWithNatRule : TestTemplate<ILoadBalancer, ILoadBalancers, INetworkManager>
    {
        private IPublicIPAddresses pips;
        private IComputeManager computeManager;
        private IAvailabilitySets availabilitySets;
        private INetworks networks;
        private LoadBalancerHelper loadBalancerHelper;

        public InternetWithNatRule(
                IComputeManager computeManager,
                [CallerMemberName] string methodName = "testframework_failed")
            : base(methodName)
        {
            loadBalancerHelper = new LoadBalancerHelper(TestUtilities.GenerateName(methodName));
            this.computeManager = computeManager;
        }

        public override void Print(ILoadBalancer resource)
        {
            LoadBalancerHelper.PrintLB(resource);
        }

        public override ILoadBalancer CreateResource(ILoadBalancers resources)
        {
            pips = resources.Manager.PublicIPAddresses;
            networks = resources.Manager.Networks;
            availabilitySets = computeManager.AvailabilitySets;
            var existingVMs = loadBalancerHelper.EnsureVMs(networks, computeManager, 2);
            Assert.Equal(2, existingVMs.Count());
            var existingPips = loadBalancerHelper.EnsurePIPs(pips);
            var nic1 = existingVMs.ElementAt(0).GetPrimaryNetworkInterface();
            var nic2 = existingVMs.ElementAt(1).GetPrimaryNetworkInterface();

            // Create a load balancer
            var lb = resources.Define(loadBalancerHelper.LoadBalancerName)
                        .WithRegion(loadBalancerHelper.Region)
                        .WithExistingResourceGroup(loadBalancerHelper.GroupName)

                        // Frontends
                        .DefinePublicFrontend("frontend1")
                            .WithExistingPublicIPAddress(existingPips.ElementAt(0))
                            .Attach()

                        // Load balancing rules
                        .DefineLoadBalancingRule("rule1")
                            .WithProtocol(TransportProtocol.Tcp)    // Required
                            .FromFrontend("frontend1")
                            .FromFrontendPort(81)
                            .ToBackend("backend1")
                            .ToBackendPort(82)                    // Optionals
                            .WithProbe("tcpProbe1")
                            .WithIdleTimeoutInMinutes(10)
                            .WithLoadDistribution(LoadDistribution.SourceIP)
                            .Attach()

                        // Inbound NAT rules
                        .DefineInboundNatRule("natrule1")
                            .WithProtocol(TransportProtocol.Tcp)
                            .FromFrontend("frontend1")
                            .FromFrontendPort(88)
                            .Attach()

                        // Probes
                        .DefineTcpProbe("tcpProbe1")
                            .WithPort(25)               // Required
                            .WithIntervalInSeconds(15)  // Optionals
                            .WithNumberOfProbes(5)
                            .Attach()
                        .DefineHttpProbe("httpProbe1")
                            .WithRequestPath("/")       // Required
                            .WithIntervalInSeconds(13)  // Optionals
                            .WithNumberOfProbes(4)
                            .Attach()

                        .Create();

            // Connect NICs explicitly
            nic1.Update()
                .WithExistingLoadBalancerBackend(lb, "backend1")
                .WithExistingLoadBalancerInboundNatRule(lb, "natrule1")
                .Apply();
            NetworkInterfaceHelper.PrintNic(nic1);
            Assert.True(nic1.PrimaryIPConfiguration.ListAssociatedLoadBalancerBackends().ElementAt(0)
                            .Name.Equals("backend1", StringComparison.OrdinalIgnoreCase));
            Assert.True(nic1.PrimaryIPConfiguration.ListAssociatedLoadBalancerInboundNatRules().ElementAt(0)
                            .Name.Equals("natrule1", StringComparison.OrdinalIgnoreCase));

            nic2.Update()
                .WithExistingLoadBalancerBackend(lb, "backend1")
                .Apply();
            NetworkInterfaceHelper.PrintNic(nic2);
            Assert.True(nic2.PrimaryIPConfiguration.ListAssociatedLoadBalancerBackends().ElementAt(0)
                            .Name.Equals("backend1", StringComparison.OrdinalIgnoreCase));

            // Verify frontends
            Assert.True(lb.Frontends.ContainsKey("frontend1"));
            Assert.Equal(lb.Frontends.Count, 1);

            existingPips.ElementAt(0).Refresh();
            Assert.True(existingPips.ElementAt(0).GetAssignedLoadBalancerFrontend()
                                    .Name.Equals("frontend1", StringComparison.OrdinalIgnoreCase));
            PublicIPAddressHelper.PrintPIP(existingPips.ElementAt(0).Refresh());

            // Verify backends
            Assert.True(lb.Backends.ContainsKey("backend1"));
            Assert.Equal(lb.Backends.Count, 1);

            // Verify probes
            Assert.True(lb.HttpProbes.ContainsKey("httpProbe1"));
            Assert.True(lb.TcpProbes.ContainsKey("tcpProbe1"));
            Assert.False(lb.HttpProbes.ContainsKey("default"));
            Assert.False(lb.TcpProbes.ContainsKey("default"));

            // Verify rules
            Assert.True(lb.LoadBalancingRules.ContainsKey("rule1"));
            Assert.False(lb.LoadBalancingRules.ContainsKey("default"));
            Assert.Equal(lb.LoadBalancingRules.Values.Count(), 1);
            var rule = lb.LoadBalancingRules["rule1"];
            Assert.True(rule.Backend.Name.Equals("backend1", StringComparison.OrdinalIgnoreCase));
            Assert.True(rule.Frontend.Name.Equals("frontend1", StringComparison.OrdinalIgnoreCase));
            Assert.True(rule.Probe.Name.Equals("tcpProbe1", StringComparison.OrdinalIgnoreCase));
            Assert.Equal(TransportProtocol.Tcp, rule.Protocol);

            // Verify inbound NAT rules
            Assert.True(lb.InboundNatRules.ContainsKey("natrule1"));
            Assert.Equal(lb.InboundNatRules.Count, 1);
            var inboundNatRule = lb.InboundNatRules["natrule1"];
            Assert.True(inboundNatRule.Frontend.Name.Equals("frontend1", StringComparison.OrdinalIgnoreCase));
            Assert.Equal(inboundNatRule.FrontendPort, 88);
            Assert.Equal(inboundNatRule.BackendPort, 88);

            return lb;
        }

        public override ILoadBalancer UpdateResource(ILoadBalancer resource)
        {
            var nics = new List<INetworkInterface>();
            foreach (string nicId in resource.Backends["backend1"].BackendNicIPConfigurationNames.Keys)
            {
                nics.Add(networks.Manager.NetworkInterfaces.GetById(nicId));
            }
            INetworkInterface nic1 = nics[0];
            INetworkInterface nic2 = nics[1];

            // Remove the NIC associations
            nic1.Update()
                .WithoutLoadBalancerBackends()
                .WithoutLoadBalancerInboundNatRules()
                .Apply();
            Assert.Equal(nic1.PrimaryIPConfiguration.ListAssociatedLoadBalancerBackends().Count, 0);

            nic2.Update()
                    .WithoutLoadBalancerBackends()
                    .WithoutLoadBalancerInboundNatRules()
                    .Apply();
            Assert.Equal(nic2.PrimaryIPConfiguration.ListAssociatedLoadBalancerBackends().Count, 0);

            // Update the load balancer
            var existingPips = loadBalancerHelper.EnsurePIPs(pips);
            resource = resource.Update()
                        .UpdatePublicFrontend("frontend1")
                            .WithExistingPublicIPAddress(existingPips.ElementAt(1))
                            .Parent()
                        .WithoutFrontend("default")
                        .WithoutBackend("default")
                        .WithoutLoadBalancingRule("rule1")
                        .WithoutInboundNatRule("natrule1")
                        .WithTag("tag1", "value1")
                        .WithTag("tag2", "value2")
                  .Apply();
            Assert.True(resource.Tags.ContainsKey("tag1"));
            Assert.Equal(0, resource.InboundNatRules.Count);

            // Verify frontends
            var frontend = resource.Frontends["frontend1"];
            Assert.True(frontend.IsPublic);
            var publicFrontend = (ILoadBalancerPublicFrontend)frontend;
            Assert.True(existingPips.ElementAt(1).Id.Equals(publicFrontend.PublicIPAddressId, StringComparison.OrdinalIgnoreCase));

            return resource;
        }
    }
}
