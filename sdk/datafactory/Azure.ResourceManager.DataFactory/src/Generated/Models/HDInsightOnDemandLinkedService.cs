// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> HDInsight ondemand linked service. </summary>
    public partial class HDInsightOnDemandLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightOnDemandLinkedService"/>. </summary>
        /// <param name="clusterSize"> Number of worker/data nodes in the cluster. Suggestion value: 4. Type: int (or Expression with resultType int). </param>
        /// <param name="timeToLiveExpression"> The allowed idle time for the on-demand HDInsight cluster. Specifies how long the on-demand HDInsight cluster stays alive after completion of an activity run if there are no other active jobs in the cluster. The minimum value is 5 mins. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> Version of the HDInsight cluster.  Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> Azure Storage linked service to be used by the on-demand cluster for storing and processing data. </param>
        /// <param name="hostSubscriptionId"> The customer’s subscription to host the cluster. Type: string (or Expression with resultType string). </param>
        /// <param name="tenant"> The Tenant id/name to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="clusterResourceGroup"> The resource group where the cluster belongs. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterSize"/>, <paramref name="timeToLiveExpression"/>, <paramref name="version"/>, <paramref name="linkedServiceName"/>, <paramref name="hostSubscriptionId"/>, <paramref name="tenant"/> or <paramref name="clusterResourceGroup"/> is null. </exception>
        public HDInsightOnDemandLinkedService(DataFactoryElement<int> clusterSize, DataFactoryElement<string> timeToLiveExpression, DataFactoryElement<string> version, DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> hostSubscriptionId, DataFactoryElement<string> tenant, DataFactoryElement<string> clusterResourceGroup)
        {
            if (clusterSize == null)
            {
                throw new ArgumentNullException(nameof(clusterSize));
            }
            if (timeToLiveExpression == null)
            {
                throw new ArgumentNullException(nameof(timeToLiveExpression));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (hostSubscriptionId == null)
            {
                throw new ArgumentNullException(nameof(hostSubscriptionId));
            }
            if (tenant == null)
            {
                throw new ArgumentNullException(nameof(tenant));
            }
            if (clusterResourceGroup == null)
            {
                throw new ArgumentNullException(nameof(clusterResourceGroup));
            }

            ClusterSize = clusterSize;
            TimeToLiveExpression = timeToLiveExpression;
            Version = version;
            LinkedServiceName = linkedServiceName;
            HostSubscriptionId = hostSubscriptionId;
            Tenant = tenant;
            ClusterResourceGroup = clusterResourceGroup;
            AdditionalLinkedServiceNames = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            ScriptActions = new ChangeTrackingList<DataFactoryScriptAction>();
            LinkedServiceType = "HDInsightOnDemand";
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightOnDemandLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="clusterSize"> Number of worker/data nodes in the cluster. Suggestion value: 4. Type: int (or Expression with resultType int). </param>
        /// <param name="timeToLiveExpression"> The allowed idle time for the on-demand HDInsight cluster. Specifies how long the on-demand HDInsight cluster stays alive after completion of an activity run if there are no other active jobs in the cluster. The minimum value is 5 mins. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> Version of the HDInsight cluster.  Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> Azure Storage linked service to be used by the on-demand cluster for storing and processing data. </param>
        /// <param name="hostSubscriptionId"> The customer’s subscription to host the cluster. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The service principal id for the hostSubscriptionId. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key for the service principal id. </param>
        /// <param name="tenant"> The Tenant id/name to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="clusterResourceGroup"> The resource group where the cluster belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="clusterNamePrefix"> The prefix of cluster name, postfix will be distinct with timestamp. Type: string (or Expression with resultType string). </param>
        /// <param name="clusterUserName"> The username to access the cluster. Type: string (or Expression with resultType string). </param>
        /// <param name="clusterPassword"> The password to access the cluster. </param>
        /// <param name="clusterSshUserName"> The username to SSH remotely connect to cluster’s node (for Linux). Type: string (or Expression with resultType string). </param>
        /// <param name="clusterSshPassword"> The password to SSH remotely connect cluster’s node (for Linux). </param>
        /// <param name="additionalLinkedServiceNames"> Specifies additional storage accounts for the HDInsight linked service so that the Data Factory service can register them on your behalf. </param>
        /// <param name="hcatalogLinkedServiceName"> The name of Azure SQL linked service that point to the HCatalog database. The on-demand HDInsight cluster is created by using the Azure SQL database as the metastore. </param>
        /// <param name="clusterType"> The cluster type. Type: string (or Expression with resultType string). </param>
        /// <param name="sparkVersion"> The version of spark if the cluster type is 'spark'. Type: string (or Expression with resultType string). </param>
        /// <param name="coreConfiguration"> Specifies the core configuration parameters (as in core-site.xml) for the HDInsight cluster to be created. </param>
        /// <param name="hBaseConfiguration"> Specifies the HBase configuration parameters (hbase-site.xml) for the HDInsight cluster. </param>
        /// <param name="hdfsConfiguration"> Specifies the HDFS configuration parameters (hdfs-site.xml) for the HDInsight cluster. </param>
        /// <param name="hiveConfiguration"> Specifies the hive configuration parameters (hive-site.xml) for the HDInsight cluster. </param>
        /// <param name="mapReduceConfiguration"> Specifies the MapReduce configuration parameters (mapred-site.xml) for the HDInsight cluster. </param>
        /// <param name="oozieConfiguration"> Specifies the Oozie configuration parameters (oozie-site.xml) for the HDInsight cluster. </param>
        /// <param name="stormConfiguration"> Specifies the Storm configuration parameters (storm-site.xml) for the HDInsight cluster. </param>
        /// <param name="yarnConfiguration"> Specifies the Yarn configuration parameters (yarn-site.xml) for the HDInsight cluster. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="headNodeSize"> Specifies the size of the head node for the HDInsight cluster. </param>
        /// <param name="dataNodeSize"> Specifies the size of the data node for the HDInsight cluster. </param>
        /// <param name="zookeeperNodeSize"> Specifies the size of the Zoo Keeper node for the HDInsight cluster. </param>
        /// <param name="scriptActions"> Custom script actions to run on HDI ondemand cluster once it's up. Please refer to https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-customize-cluster-linux?toc=%2Fen-us%2Fazure%2Fhdinsight%2Fr-server%2FTOC.json&amp;bc=%2Fen-us%2Fazure%2Fbread%2Ftoc.json#understanding-script-actions. </param>
        /// <param name="virtualNetworkId"> The ARM resource ID for the vNet to which the cluster should be joined after creation. Type: string (or Expression with resultType string). </param>
        /// <param name="subnetName"> The ARM resource ID for the subnet in the vNet. If virtualNetworkId was specified, then this property is required. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal HDInsightOnDemandLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<int> clusterSize, DataFactoryElement<string> timeToLiveExpression, DataFactoryElement<string> version, DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> hostSubscriptionId, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> tenant, DataFactoryElement<string> clusterResourceGroup, DataFactoryElement<string> clusterNamePrefix, DataFactoryElement<string> clusterUserName, DataFactorySecretBaseDefinition clusterPassword, DataFactoryElement<string> clusterSshUserName, DataFactorySecretBaseDefinition clusterSshPassword, IList<DataFactoryLinkedServiceReference> additionalLinkedServiceNames, DataFactoryLinkedServiceReference hcatalogLinkedServiceName, DataFactoryElement<string> clusterType, DataFactoryElement<string> sparkVersion, BinaryData coreConfiguration, BinaryData hBaseConfiguration, BinaryData hdfsConfiguration, BinaryData hiveConfiguration, BinaryData mapReduceConfiguration, BinaryData oozieConfiguration, BinaryData stormConfiguration, BinaryData yarnConfiguration, string encryptedCredential, BinaryData headNodeSize, BinaryData dataNodeSize, BinaryData zookeeperNodeSize, IList<DataFactoryScriptAction> scriptActions, DataFactoryElement<string> virtualNetworkId, DataFactoryElement<string> subnetName, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ClusterSize = clusterSize;
            TimeToLiveExpression = timeToLiveExpression;
            Version = version;
            LinkedServiceName = linkedServiceName;
            HostSubscriptionId = hostSubscriptionId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            ClusterResourceGroup = clusterResourceGroup;
            ClusterNamePrefix = clusterNamePrefix;
            ClusterUserName = clusterUserName;
            ClusterPassword = clusterPassword;
            ClusterSshUserName = clusterSshUserName;
            ClusterSshPassword = clusterSshPassword;
            AdditionalLinkedServiceNames = additionalLinkedServiceNames;
            HcatalogLinkedServiceName = hcatalogLinkedServiceName;
            ClusterType = clusterType;
            SparkVersion = sparkVersion;
            CoreConfiguration = coreConfiguration;
            HBaseConfiguration = hBaseConfiguration;
            HdfsConfiguration = hdfsConfiguration;
            HiveConfiguration = hiveConfiguration;
            MapReduceConfiguration = mapReduceConfiguration;
            OozieConfiguration = oozieConfiguration;
            StormConfiguration = stormConfiguration;
            YarnConfiguration = yarnConfiguration;
            EncryptedCredential = encryptedCredential;
            HeadNodeSize = headNodeSize;
            DataNodeSize = dataNodeSize;
            ZookeeperNodeSize = zookeeperNodeSize;
            ScriptActions = scriptActions;
            VirtualNetworkId = virtualNetworkId;
            SubnetName = subnetName;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "HDInsightOnDemand";
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightOnDemandLinkedService"/> for deserialization. </summary>
        internal HDInsightOnDemandLinkedService()
        {
        }

        /// <summary> Number of worker/data nodes in the cluster. Suggestion value: 4. Type: int (or Expression with resultType int). </summary>
        public DataFactoryElement<int> ClusterSize { get; set; }
        /// <summary> The allowed idle time for the on-demand HDInsight cluster. Specifies how long the on-demand HDInsight cluster stays alive after completion of an activity run if there are no other active jobs in the cluster. The minimum value is 5 mins. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TimeToLiveExpression { get; set; }
        /// <summary> Version of the HDInsight cluster.  Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Version { get; set; }
        /// <summary> Azure Storage linked service to be used by the on-demand cluster for storing and processing data. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The customer’s subscription to host the cluster. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> HostSubscriptionId { get; set; }
        /// <summary> The service principal id for the hostSubscriptionId. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The key for the service principal id. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The Tenant id/name to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> The resource group where the cluster belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterResourceGroup { get; set; }
        /// <summary> The prefix of cluster name, postfix will be distinct with timestamp. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterNamePrefix { get; set; }
        /// <summary> The username to access the cluster. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterUserName { get; set; }
        /// <summary> The password to access the cluster. </summary>
        public DataFactorySecretBaseDefinition ClusterPassword { get; set; }
        /// <summary> The username to SSH remotely connect to cluster’s node (for Linux). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterSshUserName { get; set; }
        /// <summary> The password to SSH remotely connect cluster’s node (for Linux). </summary>
        public DataFactorySecretBaseDefinition ClusterSshPassword { get; set; }
        /// <summary> Specifies additional storage accounts for the HDInsight linked service so that the Data Factory service can register them on your behalf. </summary>
        public IList<DataFactoryLinkedServiceReference> AdditionalLinkedServiceNames { get; }
        /// <summary> The name of Azure SQL linked service that point to the HCatalog database. The on-demand HDInsight cluster is created by using the Azure SQL database as the metastore. </summary>
        public DataFactoryLinkedServiceReference HcatalogLinkedServiceName { get; set; }
        /// <summary> The cluster type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterType { get; set; }
        /// <summary> The version of spark if the cluster type is 'spark'. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SparkVersion { get; set; }
        /// <summary>
        /// Specifies the core configuration parameters (as in core-site.xml) for the HDInsight cluster to be created.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData CoreConfiguration { get; set; }
        /// <summary>
        /// Specifies the HBase configuration parameters (hbase-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData HBaseConfiguration { get; set; }
        /// <summary>
        /// Specifies the HDFS configuration parameters (hdfs-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData HdfsConfiguration { get; set; }
        /// <summary>
        /// Specifies the hive configuration parameters (hive-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData HiveConfiguration { get; set; }
        /// <summary>
        /// Specifies the MapReduce configuration parameters (mapred-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData MapReduceConfiguration { get; set; }
        /// <summary>
        /// Specifies the Oozie configuration parameters (oozie-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData OozieConfiguration { get; set; }
        /// <summary>
        /// Specifies the Storm configuration parameters (storm-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData StormConfiguration { get; set; }
        /// <summary>
        /// Specifies the Yarn configuration parameters (yarn-site.xml) for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData YarnConfiguration { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary>
        /// Specifies the size of the head node for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData HeadNodeSize { get; set; }
        /// <summary>
        /// Specifies the size of the data node for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData DataNodeSize { get; set; }
        /// <summary>
        /// Specifies the size of the Zoo Keeper node for the HDInsight cluster.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ZookeeperNodeSize { get; set; }
        /// <summary> Custom script actions to run on HDI ondemand cluster once it's up. Please refer to https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-customize-cluster-linux?toc=%2Fen-us%2Fazure%2Fhdinsight%2Fr-server%2FTOC.json&amp;bc=%2Fen-us%2Fazure%2Fbread%2Ftoc.json#understanding-script-actions. </summary>
        public IList<DataFactoryScriptAction> ScriptActions { get; }
        /// <summary> The ARM resource ID for the vNet to which the cluster should be joined after creation. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> VirtualNetworkId { get; set; }
        /// <summary> The ARM resource ID for the subnet in the vNet. If virtualNetworkId was specified, then this property is required. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SubnetName { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}
