﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Testing;
using Azure.Identity.Tests.Mock;
using Moq;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    public class DefaultAzureCredentialTests : ClientTestBase
    {
        public DefaultAzureCredentialTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public void ValidateCtorNoOptions()
        {
            var cred = new DefaultAzureCredential();

            IExtendedTokenCredential[] sources = cred._sources();

            Assert.NotNull(sources);
            Assert.AreEqual(sources.Length, 4);
            Assert.IsInstanceOf(typeof(EnvironmentCredential), sources[0]);
            Assert.IsInstanceOf(typeof(ManagedIdentityCredential), sources[1]);
            Assert.IsInstanceOf(typeof(SharedTokenCacheCredential), sources[2]);
            Assert.IsNull(sources[3]);
        }

        [Test]
        public void ValidateCtorIncludedInteractiveParam([Values(true, false)]bool includeInteractive)
        {
            var cred = new DefaultAzureCredential(includeInteractive);

            IExtendedTokenCredential[] sources = cred._sources();

            Assert.NotNull(sources);
            Assert.AreEqual(sources.Length, 4);
            Assert.IsInstanceOf(typeof(EnvironmentCredential), sources[0]);
            Assert.IsInstanceOf(typeof(ManagedIdentityCredential), sources[1]);
            Assert.IsInstanceOf(typeof(SharedTokenCacheCredential), sources[2]);

            if (includeInteractive)
            {
                Assert.IsInstanceOf(typeof(InteractiveBrowserCredential), sources[3]);
            }
            else
            {
                Assert.IsNull(sources[3]);
            }
        }

        [Test]
        public void ValidateCtorOptionsPassedToCredentials()
        {
            string expClientId = Guid.NewGuid().ToString();
            string expUsername = Guid.NewGuid().ToString();
            string expTenantId = Guid.NewGuid().ToString();
            string actClientId = null;
            string actUsername = null;
            string actTenantId = null;

            var credFactory = new MockDefaultAzureCredentialFactory(CredentialPipeline.GetInstance(null));

            credFactory.OnCreateManagedIdentityCredential = (clientId, _) => actClientId = clientId;
            credFactory.OnCreateSharedTokenCacheCredential = (tenantId, username, _) => { actTenantId = tenantId; actUsername = username; };

            var options = new DefaultAzureCredentialOptions
            {
                ManagedIdentityClientId = expClientId,
                SharedTokenCacheUsername = expUsername,
                SharedTokenCacheTenantId = expTenantId
            };

            var cred = new DefaultAzureCredential(credFactory, options);

            Assert.AreEqual(expClientId, actClientId);
            Assert.AreEqual(expUsername, actUsername);
            Assert.AreEqual(expTenantId, actTenantId);
        }

        [Test]
        [NonParallelizable]
        public void ValidateEnvironmentBasedOptionsPassedToCredentials([Values]bool clientIdSpecified, [Values]bool usernameSpecified, [Values]bool tenantIdSpecified)
        {
            var expClientId = clientIdSpecified ? Guid.NewGuid().ToString() : null;
            var expUsername = usernameSpecified ? Guid.NewGuid().ToString() : null;
            var expTenantId = tenantIdSpecified ? Guid.NewGuid().ToString() : null;
            bool onCreateSharedCalled = false;
            bool onCreatedManagedCalled = false;
            bool onCreateInteractiveCalled = false;

            using (new TestEnvVar("AZURE_CLIENT_ID", expClientId))
            using (new TestEnvVar("AZURE_USERNAME", expUsername))
            using (new TestEnvVar("AZURE_TENANT_ID", expTenantId))
            {
                var credFactory = new MockDefaultAzureCredentialFactory(CredentialPipeline.GetInstance(null));

                credFactory.OnCreateManagedIdentityCredential = (clientId, _) =>
                {
                    onCreatedManagedCalled = true;
                    Assert.AreEqual(expClientId, clientId);
                };

                credFactory.OnCreateSharedTokenCacheCredential = (tenantId, username, _) =>
                {
                    onCreateSharedCalled = true;
                    Assert.AreEqual(expTenantId, tenantId);
                    Assert.AreEqual(expUsername, username);
                };

                credFactory.OnCreateInteractiveBrowserCredential = (tenantId, _) =>
                {
                    onCreateInteractiveCalled = true;
                    Assert.AreEqual(expTenantId, tenantId);
                };

                var options = new DefaultAzureCredentialOptions
                {
                    ExcludeEnvironmentCredential = true,
                    ExcludeManagedIdentityCredential = false,
                    ExcludeSharedTokenCacheCredential = false,
                    ExcludeInteractiveBrowserCredential = false
                };

                var cred = new DefaultAzureCredential(credFactory, options);

                Assert.IsTrue(onCreateSharedCalled);
                Assert.IsTrue(onCreatedManagedCalled);
                Assert.IsTrue(onCreateInteractiveCalled);
            }
        }

        [Test]
        public void ValidateCtorWithExcludeOptions([Values(true, false)]bool excludeEnvironmentCredential, [Values(true, false)]bool excludeManagedIdentityCredential, [Values(true, false)]bool excludeSharedTokenCacheCredential, [Values(true, false)]bool excludeInteractiveBrowserCredential)
        {
            var credFactory = new MockDefaultAzureCredentialFactory(CredentialPipeline.GetInstance(null));

            bool environmentCredentialIncluded = false;
            bool managedIdentityCredentialIncluded = false;
            bool sharedTokenCacheCredentialIncluded = false;
            bool interactiveBrowserCredentialIncluded = false;

            credFactory.OnCreateEnvironmentCredential = (_) => environmentCredentialIncluded = true;
            credFactory.OnCreateInteractiveBrowserCredential = (tenantId, _) => interactiveBrowserCredentialIncluded = true;
            credFactory.OnCreateManagedIdentityCredential = (clientId, _) =>
            {
                managedIdentityCredentialIncluded = true;
            };
            credFactory.OnCreateSharedTokenCacheCredential = (tenantId, username, _) =>
            {
                sharedTokenCacheCredentialIncluded = true;
            };

            var options = new DefaultAzureCredentialOptions
            {
                ExcludeEnvironmentCredential = excludeEnvironmentCredential,
                ExcludeManagedIdentityCredential = excludeManagedIdentityCredential,
                ExcludeSharedTokenCacheCredential = excludeSharedTokenCacheCredential,
                ExcludeInteractiveBrowserCredential = excludeInteractiveBrowserCredential
            };

            if (excludeEnvironmentCredential && excludeManagedIdentityCredential && excludeSharedTokenCacheCredential && excludeInteractiveBrowserCredential)
            {
                Assert.Throws<ArgumentException>(() => new DefaultAzureCredential(options));
            }
            else
            {
                var cred = new DefaultAzureCredential(credFactory, options);

                Assert.AreEqual(!excludeEnvironmentCredential, environmentCredentialIncluded);
                Assert.AreEqual(!excludeManagedIdentityCredential, managedIdentityCredentialIncluded);
                Assert.AreEqual(!excludeSharedTokenCacheCredential, sharedTokenCacheCredentialIncluded);
                Assert.AreEqual(!excludeInteractiveBrowserCredential, interactiveBrowserCredentialIncluded);
            }
        }

        [Test]
        public void ValidateAllUnavailable([Values(true, false)]bool excludeEnvironmentCredential, [Values(true, false)]bool excludeManagedIdentityCredential, [Values(true, false)]bool excludeSharedTokenCacheCredential, [Values(true, false)]bool excludeInteractiveBrowserCredential)
        {
            if (excludeEnvironmentCredential && excludeManagedIdentityCredential && excludeSharedTokenCacheCredential && excludeInteractiveBrowserCredential)
            {
                Assert.Pass();
            }

            var credFactory = new MockDefaultAzureCredentialFactory(CredentialPipeline.GetInstance(null));

            credFactory.OnCreateEnvironmentCredential = (c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) => { return new ExtendedAccessToken(new CredentialUnavailableException("EnvironmentCredential Unavailable")); };
            };
            credFactory.OnCreateInteractiveBrowserCredential = (_, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) => { return new ExtendedAccessToken(new CredentialUnavailableException("InteractiveBrowserCredential Unavailable")); };
            };
            credFactory.OnCreateManagedIdentityCredential = (clientId, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) => { return new ExtendedAccessToken(new CredentialUnavailableException("ManagedIdentityCredential Unavailable")); };
            };
            credFactory.OnCreateSharedTokenCacheCredential = (tenantId, username, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) => { return new ExtendedAccessToken(new CredentialUnavailableException("SharedTokenCacheCredential Unavailable")); };
            };

            var options = new DefaultAzureCredentialOptions
            {
                ExcludeEnvironmentCredential = excludeEnvironmentCredential,
                ExcludeManagedIdentityCredential = excludeManagedIdentityCredential,
                ExcludeSharedTokenCacheCredential = excludeSharedTokenCacheCredential,
                ExcludeInteractiveBrowserCredential = excludeInteractiveBrowserCredential
            };

            var cred = new DefaultAzureCredential(credFactory, options);

            var ex = Assert.ThrowsAsync<CredentialUnavailableException>(async () => await cred.GetTokenAsync(new TokenRequestContext(MockScopes.Default)));

            if (!excludeEnvironmentCredential)
            {
                Assert.True(ex.Message.Contains("EnvironmentCredential Unavailable"));
            }
            if (!excludeManagedIdentityCredential)
            {
                Assert.True(ex.Message.Contains("ManagedIdentityCredential Unavailable"));
            }
            if (!excludeSharedTokenCacheCredential)
            {
                Assert.True(ex.Message.Contains("SharedTokenCacheCredential Unavailable"));
            }
            if (!excludeInteractiveBrowserCredential)
            {
                Assert.True(ex.Message.Contains("InteractiveBrowserCredential Unavailable"));
            }
        }

        [Test]
        public void ValidateUnhandledException([Values(0, 1, 2, 3)]int exPossition)
        {
            var credFactory = new MockDefaultAzureCredentialFactory(CredentialPipeline.GetInstance(null));

            credFactory.OnCreateEnvironmentCredential = (c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) =>
                {
                    if (exPossition > 0)
                    {
                        return new ExtendedAccessToken(new CredentialUnavailableException("EnvironmentCredential Unavailable"));
                    }
                    else
                    {
                        return new ExtendedAccessToken(new MockClientException("EnvironmentCredential unhandled exception"));
                    }
                };
            };
            credFactory.OnCreateManagedIdentityCredential = (clientId, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) =>
                {
                    if (exPossition > 1)
                    {
                        return new ExtendedAccessToken(new CredentialUnavailableException("ManagedIdentityCredential Unavailable"));
                    }
                    else
                    {
                        return new ExtendedAccessToken(new MockClientException("ManagedIdentityCredential unhandled exception"));
                    }
                };
            };
            credFactory.OnCreateSharedTokenCacheCredential = (tenantId, username, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) =>
                {
                    if (exPossition > 2)
                    {
                        return new ExtendedAccessToken(new CredentialUnavailableException("SharedTokenCacheCredential Unavailable"));
                    }
                    else
                    {
                        return new ExtendedAccessToken(new MockClientException("SharedTokenCacheCredential unhandled exception"));
                    }
                };
            };
            credFactory.OnCreateInteractiveBrowserCredential = (_, c) =>
            {
                ((MockExtendedTokenCredential)c).TokenFactory = (context, cancel) =>
                {
                    return new ExtendedAccessToken(new MockClientException("InteractiveBrowserCredential unhandled exception"));
                };
            };

            var options = new DefaultAzureCredentialOptions
            {
                ExcludeEnvironmentCredential = false,
                ExcludeManagedIdentityCredential = false,
                ExcludeSharedTokenCacheCredential = false,
                ExcludeInteractiveBrowserCredential = false
            };

            var cred = new DefaultAzureCredential(credFactory, options);

            var ex = Assert.ThrowsAsync<AuthenticationFailedException>(async () => await cred.GetTokenAsync(new TokenRequestContext(MockScopes.Default)));

            switch (exPossition)
            {
                case 0:
                    Assert.AreEqual(ex.InnerException.Message, "EnvironmentCredential unhandled exception");
                    break;
                case 1:
                    Assert.AreEqual(ex.InnerException.Message, "ManagedIdentityCredential unhandled exception");
                    break;
                case 2:
                    Assert.AreEqual(ex.InnerException.Message, "SharedTokenCacheCredential unhandled exception");
                    break;
                case 3:
                    Assert.AreEqual(ex.InnerException.Message, "InteractiveBrowserCredential unhandled exception");
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }

        //[Test]
        //public void ValidateEnvironmentCredentialUnhandledException()
        //{
        //    using (new TestEnvVar("AZURE_CLIENT_ID", Guid.NewGuid().ToString()))
        //    using (new TestEnvVar("AZURE_CLIENT_SECRET", Guid.NewGuid().ToString()))
        //    using (new TestEnvVar("AZURE_TENANT_ID", "a7fc734e-9961-43ce-b4de-21b8b38403ba"))
        //    {
        //        var defaultCred = new DefaultAzureCredential();

        //        var ex = Assert.ThrowsAsync<AuthenticationFailedException>(async () => await defaultCred.GetTokenAsync(new TokenRequestContext(MockScopes.Default)));

        //        Assert.True(ex.Message.Contains("EnvironmentCredential"));
        //    }

        //    //var exMessage = "Call to AadIdentityClient failed with a mock exception.";

        //    //var aadClient = new MockAadIdentityClient(() => throw new Exception(exMessage));

        //    //var pipeline = CredentialPipeline.GetInstance(null);

        //    //var clientSecretCred = new ClientSecretCredential(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), pipeline, aadClient);

        //    //var environmentCred = new EnvironmentCredential(pipeline, clientSecretCred);

        //    //var credFactory = new PartialMockDefaultAzureCredentialFactory(pipeline: pipeline, environmentCredential: environmentCred);

        //}

        internal class PartialMockDefaultAzureCredentialFactory : DefaultAzureCredentialFactory
        {
            private EnvironmentCredential _environmentCredential;
            private ManagedIdentityCredential _managedIdentityCredential;

            public PartialMockDefaultAzureCredentialFactory(CredentialPipeline pipeline=null, EnvironmentCredential environmentCredential = null, ManagedIdentityCredential managedIdentityCredential = null) : base(pipeline ?? CredentialPipeline.GetInstance(null))
            {
                _environmentCredential = environmentCredential;
                _managedIdentityCredential = managedIdentityCredential;
            }

            public override IExtendedTokenCredential CreateEnvironmentCredential()
            {
                return _environmentCredential ?? base.CreateEnvironmentCredential();
            }

            public override IExtendedTokenCredential CreateManagedIdentityCredential(string clientId)
            {
                return _managedIdentityCredential ?? base.CreateManagedIdentityCredential(clientId);
            }
        }
    }
}
