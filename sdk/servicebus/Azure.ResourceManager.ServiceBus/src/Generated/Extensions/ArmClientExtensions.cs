// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region ServiceBusNamespace
        /// <summary> Gets an object representing a ServiceBusNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNamespace" /> object. </returns>
        public static ServiceBusNamespace GetServiceBusNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ArmDisasterRecovery
        /// <summary> Gets an object representing a ArmDisasterRecovery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmDisasterRecovery" /> object. </returns>
        public static ArmDisasterRecovery GetArmDisasterRecovery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ArmDisasterRecovery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DisasterRecoveryConfigServiceBusAuthorizationRule
        /// <summary> Gets an object representing a DisasterRecoveryConfigServiceBusAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DisasterRecoveryConfigServiceBusAuthorizationRule" /> object. </returns>
        public static DisasterRecoveryConfigServiceBusAuthorizationRule GetDisasterRecoveryConfigServiceBusAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DisasterRecoveryConfigServiceBusAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MigrationConfigProperties
        /// <summary> Gets an object representing a MigrationConfigProperties along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MigrationConfigProperties" /> object. </returns>
        public static MigrationConfigProperties GetMigrationConfigProperties(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MigrationConfigProperties(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NamespaceServiceBusAuthorizationRule
        /// <summary> Gets an object representing a NamespaceServiceBusAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceServiceBusAuthorizationRule" /> object. </returns>
        public static NamespaceServiceBusAuthorizationRule GetNamespaceServiceBusAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NamespaceServiceBusAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region QueueServiceBusAuthorizationRule
        /// <summary> Gets an object representing a QueueServiceBusAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueServiceBusAuthorizationRule" /> object. </returns>
        public static QueueServiceBusAuthorizationRule GetQueueServiceBusAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new QueueServiceBusAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region TopicServiceBusAuthorizationRule
        /// <summary> Gets an object representing a TopicServiceBusAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopicServiceBusAuthorizationRule" /> object. </returns>
        public static TopicServiceBusAuthorizationRule GetTopicServiceBusAuthorizationRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new TopicServiceBusAuthorizationRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusQueue
        /// <summary> Gets an object representing a ServiceBusQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusQueue" /> object. </returns>
        public static ServiceBusQueue GetServiceBusQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusQueue(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusTopic
        /// <summary> Gets an object representing a ServiceBusTopic along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusTopic" /> object. </returns>
        public static ServiceBusTopic GetServiceBusTopic(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusTopic(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Rule
        /// <summary> Gets an object representing a Rule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Rule" /> object. </returns>
        public static Rule GetRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Rule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServiceBusSubscription
        /// <summary> Gets an object representing a ServiceBusSubscription along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusSubscription" /> object. </returns>
        public static ServiceBusSubscription GetServiceBusSubscription(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServiceBusSubscription(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
