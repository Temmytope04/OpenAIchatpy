namespace Azure.ResourceManager.Chaos
{
    public partial class CapabilityCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.CapabilityResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.CapabilityResource>, System.Collections.IEnumerable
    {
        protected CapabilityCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.CapabilityResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string capabilityName, Azure.ResourceManager.Chaos.CapabilityData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.CapabilityResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string capabilityName, Azure.ResourceManager.Chaos.CapabilityData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource> Get(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.CapabilityResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.CapabilityResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource>> GetAsync(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.CapabilityResource> GetIfExists(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.CapabilityResource>> GetIfExistsAsync(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.CapabilityResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.CapabilityResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.CapabilityResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.CapabilityResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CapabilityData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityData>
    {
        public CapabilityData() { }
        public string Description { get { throw null; } }
        public string ParametersSchema { get { throw null; } }
        public string Publisher { get { throw null; } }
        public string TargetType { get { throw null; } }
        public string Urn { get { throw null; } }
        Azure.ResourceManager.Chaos.CapabilityData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.CapabilityData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CapabilityResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CapabilityResource() { }
        public virtual Azure.ResourceManager.Chaos.CapabilityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, string capabilityName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.CapabilityResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Chaos.CapabilityData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.CapabilityResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Chaos.CapabilityData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CapabilityTypeCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.CapabilityTypeResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.CapabilityTypeResource>, System.Collections.IEnumerable
    {
        protected CapabilityTypeCollection() { }
        public virtual Azure.Response<bool> Exists(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource> Get(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.CapabilityTypeResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.CapabilityTypeResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource>> GetAsync(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.CapabilityTypeResource> GetIfExists(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.CapabilityTypeResource>> GetIfExistsAsync(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.CapabilityTypeResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.CapabilityTypeResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.CapabilityTypeResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.CapabilityTypeResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CapabilityTypeData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityTypeData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityTypeData>
    {
        public CapabilityTypeData() { }
        public System.Collections.Generic.IList<string> AzureRbacActions { get { throw null; } }
        public System.Collections.Generic.IList<string> AzureRbacDataActions { get { throw null; } }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Kind { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string ParametersSchema { get { throw null; } }
        public string Publisher { get { throw null; } }
        public string RuntimeKind { get { throw null; } }
        public string TargetType { get { throw null; } }
        public string Urn { get { throw null; } }
        Azure.ResourceManager.Chaos.CapabilityTypeData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityTypeData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.CapabilityTypeData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.CapabilityTypeData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityTypeData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityTypeData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.CapabilityTypeData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CapabilityTypeResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CapabilityTypeResource() { }
        public virtual Azure.ResourceManager.Chaos.CapabilityTypeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName, string capabilityTypeName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ChaosExtensions
    {
        public static Azure.ResourceManager.Chaos.CapabilityResource GetCapabilityResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Chaos.CapabilityTypeResource GetCapabilityTypeResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource> GetExperiment(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource>> GetExperimentAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource GetExperimentExecutionDetailResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentResource GetExperimentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentCollection GetExperiments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Chaos.ExperimentResource> GetExperiments(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Chaos.ExperimentResource> GetExperimentsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentStatusResource GetExperimentStatusResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Chaos.TargetResource> GetTarget(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetResource>> GetTargetAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetResource GetTargetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetCollection GetTargets(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource> GetTargetType(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationName, string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource>> GetTargetTypeAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationName, string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetTypeResource GetTargetTypeResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetTypeCollection GetTargetTypes(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationName) { throw null; }
    }
    public partial class ExperimentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentResource>, System.Collections.IEnumerable
    {
        protected ExperimentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.ExperimentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string experimentName, Azure.ResourceManager.Chaos.ExperimentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.ExperimentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string experimentName, Azure.ResourceManager.Chaos.ExperimentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource> Get(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.ExperimentResource> GetAll(bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.ExperimentResource> GetAllAsync(bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource>> GetAsync(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentResource> GetIfExists(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentResource>> GetIfExistsAsync(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.ExperimentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.ExperimentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ExperimentData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentData>
    {
        public ExperimentData(Azure.Core.AzureLocation location, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Step> steps, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Selector> selectors) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.Selector> Selectors { get { throw null; } }
        public bool? StartOnCreation { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.Step> Steps { get { throw null; } }
        Azure.ResourceManager.Chaos.ExperimentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.ExperimentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentExecutionDetailCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>, System.Collections.IEnumerable
    {
        protected ExperimentExecutionDetailCollection() { }
        public virtual Azure.Response<bool> Exists(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> Get(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>> GetAsync(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> GetIfExists(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>> GetIfExistsAsync(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ExperimentExecutionDetailData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>
    {
        internal ExperimentExecutionDetailData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string ExperimentId { get { throw null; } }
        public string FailureReason { get { throw null; } }
        public System.DateTimeOffset? LastActionOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Chaos.Models.StepStatus> RunInformationSteps { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? StopOn { get { throw null; } }
        Azure.ResourceManager.Chaos.ExperimentExecutionDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.ExperimentExecutionDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentExecutionDetailData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentExecutionDetailResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ExperimentExecutionDetailResource() { }
        public virtual Azure.ResourceManager.Chaos.ExperimentExecutionDetailData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string experimentName, string executionDetailsId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ExperimentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ExperimentResource() { }
        public virtual Azure.ResourceManager.Chaos.ExperimentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult> Cancel(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>> CancelAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string experimentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource> GetExperimentExecutionDetail(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource>> GetExperimentExecutionDetailAsync(string executionDetailsId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentExecutionDetailCollection GetExperimentExecutionDetails() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource> GetExperimentStatus(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource>> GetExperimentStatusAsync(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentStatusCollection GetExperimentStatuses() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult> Start(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>> StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource> Update(Azure.ResourceManager.Chaos.Models.ExperimentPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource>> UpdateAsync(Azure.ResourceManager.Chaos.Models.ExperimentPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ExperimentStatusCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentStatusResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentStatusResource>, System.Collections.IEnumerable
    {
        protected ExperimentStatusCollection() { }
        public virtual Azure.Response<bool> Exists(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource> Get(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.ExperimentStatusResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.ExperimentStatusResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource>> GetAsync(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentStatusResource> GetIfExists(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.ExperimentStatusResource>> GetIfExistsAsync(string statusId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.ExperimentStatusResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.ExperimentStatusResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.ExperimentStatusResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.ExperimentStatusResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ExperimentStatusData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentStatusData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentStatusData>
    {
        internal ExperimentStatusData() { }
        public System.DateTimeOffset? CreatedDateUtc { get { throw null; } }
        public System.DateTimeOffset? EndDateUtc { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Chaos.ExperimentStatusData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentStatusData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.ExperimentStatusData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.ExperimentStatusData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentStatusData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentStatusData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.ExperimentStatusData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentStatusResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ExperimentStatusResource() { }
        public virtual Azure.ResourceManager.Chaos.ExperimentStatusData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string experimentName, string statusId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentStatusResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TargetCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.TargetResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.TargetResource>, System.Collections.IEnumerable
    {
        protected TargetCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.TargetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string targetName, Azure.ResourceManager.Chaos.TargetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.TargetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string targetName, Azure.ResourceManager.Chaos.TargetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetResource> Get(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.TargetResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.TargetResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetResource>> GetAsync(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.TargetResource> GetIfExists(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.TargetResource>> GetIfExistsAsync(string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.TargetResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.TargetResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.TargetResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.TargetResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TargetData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetData>
    {
        public TargetData(System.Collections.Generic.IDictionary<string, System.BinaryData> properties) { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Properties { get { throw null; } }
        Azure.ResourceManager.Chaos.TargetData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.TargetData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TargetResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TargetResource() { }
        public virtual Azure.ResourceManager.Chaos.TargetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.CapabilityCollection GetCapabilities() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource> GetCapability(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityResource>> GetCapabilityAsync(string capabilityName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.TargetResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Chaos.TargetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Chaos.TargetResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Chaos.TargetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TargetTypeCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.TargetTypeResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.TargetTypeResource>, System.Collections.IEnumerable
    {
        protected TargetTypeCollection() { }
        public virtual Azure.Response<bool> Exists(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource> Get(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.TargetTypeResource> GetAll(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.TargetTypeResource> GetAllAsync(string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource>> GetAsync(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Chaos.TargetTypeResource> GetIfExists(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Chaos.TargetTypeResource>> GetIfExistsAsync(string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Chaos.TargetTypeResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Chaos.TargetTypeResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Chaos.TargetTypeResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.TargetTypeResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TargetTypeData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetTypeData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetTypeData>
    {
        public TargetTypeData() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string PropertiesSchema { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ResourceTypes { get { throw null; } }
        Azure.ResourceManager.Chaos.TargetTypeData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetTypeData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.TargetTypeData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.TargetTypeData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetTypeData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetTypeData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.TargetTypeData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TargetTypeResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TargetTypeResource() { }
        public virtual Azure.ResourceManager.Chaos.TargetTypeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource> GetCapabilityType(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.CapabilityTypeResource>> GetCapabilityTypeAsync(string capabilityTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.CapabilityTypeCollection GetCapabilityTypes() { throw null; }
    }
}
namespace Azure.ResourceManager.Chaos.Mocking
{
    public partial class MockableChaosArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableChaosArmClient() { }
        public virtual Azure.ResourceManager.Chaos.CapabilityResource GetCapabilityResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.CapabilityTypeResource GetCapabilityTypeResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentExecutionDetailResource GetExperimentExecutionDetailResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentResource GetExperimentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentStatusResource GetExperimentStatusResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.TargetResource GetTargetResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Chaos.TargetTypeResource GetTargetTypeResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableChaosResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableChaosResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource> GetExperiment(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.ExperimentResource>> GetExperimentAsync(string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.ExperimentCollection GetExperiments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetResource> GetTarget(string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetResource>> GetTargetAsync(string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.TargetCollection GetTargets(string parentProviderNamespace, string parentResourceType, string parentResourceName) { throw null; }
    }
    public partial class MockableChaosSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableChaosSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Chaos.ExperimentResource> GetExperiments(bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Chaos.ExperimentResource> GetExperimentsAsync(bool? running = default(bool?), string continuationToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource> GetTargetType(string locationName, string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Chaos.TargetTypeResource>> GetTargetTypeAsync(string locationName, string targetTypeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Chaos.TargetTypeCollection GetTargetTypes(string locationName) { throw null; }
    }
}
namespace Azure.ResourceManager.Chaos.Models
{
    public abstract partial class Action : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Action>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Action>
    {
        protected Action(string name) { }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.Action System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Action>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Action>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.Action System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Action>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Action>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Action>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ActionStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ActionStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ActionStatus>
    {
        internal ActionStatus() { }
        public string ActionId { get { throw null; } }
        public string ActionName { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties> Targets { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ActionStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ActionStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ActionStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ActionStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ActionStatus>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ActionStatus>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ActionStatus>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmChaosModelFactory
    {
        public static Azure.ResourceManager.Chaos.Models.ActionStatus ActionStatus(string actionName = null, string actionId = null, string status = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties> targets = null) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.BranchStatus BranchStatus(string branchName = null, string branchId = null, string status = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.ActionStatus> actions = null) { throw null; }
        public static Azure.ResourceManager.Chaos.CapabilityData CapabilityData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string publisher = null, string targetType = null, string description = null, string parametersSchema = null, string urn = null) { throw null; }
        public static Azure.ResourceManager.Chaos.CapabilityTypeData CapabilityTypeData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), string publisher = null, string targetType = null, string displayName = null, string description = null, string parametersSchema = null, string urn = null, string kind = null, System.Collections.Generic.IEnumerable<string> azureRbacActions = null, System.Collections.Generic.IEnumerable<string> azureRbacDataActions = null, string runtimeKind = null) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult ExperimentCancelOperationResult(string name = null, string statusUri = null) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentData ExperimentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Step> steps = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Selector> selectors = null, bool? startOnCreation = default(bool?)) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError ExperimentExecutionActionTargetDetailsError(string code = null, string message = null) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties ExperimentExecutionActionTargetDetailsProperties(string status = null, string target = null, System.DateTimeOffset? targetFailedOn = default(System.DateTimeOffset?), System.DateTimeOffset? targetCompletedOn = default(System.DateTimeOffset?), Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError error = null) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentExecutionDetailData ExperimentExecutionDetailData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string experimentId = null, string status = null, string failureReason = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastActionOn = default(System.DateTimeOffset?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? stopOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.StepStatus> runInformationSteps = null) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult ExperimentStartOperationResult(string name = null, string statusUri = null) { throw null; }
        public static Azure.ResourceManager.Chaos.ExperimentStatusData ExperimentStatusData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string status = null, System.DateTimeOffset? createdDateUtc = default(System.DateTimeOffset?), System.DateTimeOffset? endDateUtc = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.StepStatus StepStatus(string stepName = null, string stepId = null, string status = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.BranchStatus> branches = null) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetData TargetData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), System.Collections.Generic.IDictionary<string, System.BinaryData> properties = null) { throw null; }
        public static Azure.ResourceManager.Chaos.TargetTypeData TargetTypeData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), string displayName = null, string description = null, string propertiesSchema = null, System.Collections.Generic.IEnumerable<string> resourceTypes = null) { throw null; }
    }
    public partial class Branch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Branch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Branch>
    {
        public Branch(string name, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Action> actions) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.Action> Actions { get { throw null; } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.Branch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Branch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Branch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.Branch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Branch>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Branch>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Branch>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BranchStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.BranchStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.BranchStatus>
    {
        internal BranchStatus() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Chaos.Models.ActionStatus> Actions { get { throw null; } }
        public string BranchId { get { throw null; } }
        public string BranchName { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.BranchStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.BranchStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.BranchStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.BranchStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.BranchStatus>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.BranchStatus>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.BranchStatus>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContinuousAction : Azure.ResourceManager.Chaos.Models.Action, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>
    {
        public ContinuousAction(string name, System.TimeSpan duration, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.KeyValuePair> parameters, string selectorId) : base (default(string)) { }
        public System.TimeSpan Duration { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.KeyValuePair> Parameters { get { throw null; } }
        public string SelectorId { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.ContinuousAction System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ContinuousAction System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ContinuousAction>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DelayAction : Azure.ResourceManager.Chaos.Models.Action, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DelayAction>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DelayAction>
    {
        public DelayAction(string name, System.TimeSpan duration) : base (default(string)) { }
        public System.TimeSpan Duration { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.DelayAction System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DelayAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DelayAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.DelayAction System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DelayAction>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DelayAction>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DelayAction>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DiscreteAction : Azure.ResourceManager.Chaos.Models.Action, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>
    {
        public DiscreteAction(string name, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.KeyValuePair> parameters, string selectorId) : base (default(string)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.KeyValuePair> Parameters { get { throw null; } }
        public string SelectorId { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.DiscreteAction System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.DiscreteAction System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.DiscreteAction>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentCancelOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>
    {
        internal ExperimentCancelOperationResult() { }
        public string Name { get { throw null; } }
        public string StatusUri { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentCancelOperationResult>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentExecutionActionTargetDetailsError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>
    {
        internal ExperimentExecutionActionTargetDetailsError() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentExecutionActionTargetDetailsProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>
    {
        internal ExperimentExecutionActionTargetDetailsProperties() { }
        public Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsError Error { get { throw null; } }
        public string Status { get { throw null; } }
        public string Target { get { throw null; } }
        public System.DateTimeOffset? TargetCompletedOn { get { throw null; } }
        public System.DateTimeOffset? TargetFailedOn { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentExecutionActionTargetDetailsProperties>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>
    {
        public ExperimentPatch() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.ExperimentPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ExperimentPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentPatch>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExperimentStartOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>
    {
        internal ExperimentStartOperationResult() { }
        public string Name { get { throw null; } }
        public string StatusUri { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ExperimentStartOperationResult>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class Filter : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Filter>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Filter>
    {
        protected Filter() { }
        Azure.ResourceManager.Chaos.Models.Filter System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Filter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Filter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.Filter System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Filter>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Filter>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Filter>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyValuePair : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>
    {
        public KeyValuePair(string key, string value) { }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.KeyValuePair System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.KeyValuePair System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.KeyValuePair>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ListSelector : Azure.ResourceManager.Chaos.Models.Selector, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ListSelector>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ListSelector>
    {
        public ListSelector(string id, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.TargetReference> targets) : base (default(string)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.TargetReference> Targets { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.ListSelector System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ListSelector>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.ListSelector>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.ListSelector System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ListSelector>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ListSelector>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.ListSelector>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QuerySelector : Azure.ResourceManager.Chaos.Models.Selector, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.QuerySelector>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.QuerySelector>
    {
        public QuerySelector(string id, string queryString, System.Collections.Generic.IEnumerable<string> subscriptionIds) : base (default(string)) { }
        public string QueryString { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> SubscriptionIds { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.QuerySelector System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.QuerySelector>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.QuerySelector>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.QuerySelector System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.QuerySelector>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.QuerySelector>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.QuerySelector>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Selector : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Selector>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Selector>
    {
        public Selector(string id) { }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        public Azure.ResourceManager.Chaos.Models.Filter Filter { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.Selector System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Selector>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Selector>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.Selector System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Selector>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Selector>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Selector>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SimpleFilter : Azure.ResourceManager.Chaos.Models.Filter, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>
    {
        public SimpleFilter() { }
        public System.Collections.Generic.IList<string> ParametersZones { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.SimpleFilter System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.SimpleFilter System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.SimpleFilter>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Step : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Step>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Step>
    {
        public Step(string name, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Chaos.Models.Branch> branches) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Chaos.Models.Branch> Branches { get { throw null; } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.Step System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Step>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.Step>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.Step System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Step>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Step>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.Step>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StepStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.StepStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.StepStatus>
    {
        internal StepStatus() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Chaos.Models.BranchStatus> Branches { get { throw null; } }
        public string Status { get { throw null; } }
        public string StepId { get { throw null; } }
        public string StepName { get { throw null; } }
        Azure.ResourceManager.Chaos.Models.StepStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.StepStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.StepStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.StepStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.StepStatus>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.StepStatus>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.StepStatus>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TargetReference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.TargetReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.TargetReference>
    {
        public TargetReference(Azure.ResourceManager.Chaos.Models.TargetReferenceType referenceType, string id) { }
        public string Id { get { throw null; } set { } }
        public Azure.ResourceManager.Chaos.Models.TargetReferenceType ReferenceType { get { throw null; } set { } }
        Azure.ResourceManager.Chaos.Models.TargetReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.TargetReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Chaos.Models.TargetReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Chaos.Models.TargetReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.TargetReference>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.TargetReference>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Chaos.Models.TargetReference>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TargetReferenceType : System.IEquatable<Azure.ResourceManager.Chaos.Models.TargetReferenceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TargetReferenceType(string value) { throw null; }
        public static Azure.ResourceManager.Chaos.Models.TargetReferenceType ChaosTarget { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Chaos.Models.TargetReferenceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Chaos.Models.TargetReferenceType left, Azure.ResourceManager.Chaos.Models.TargetReferenceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Chaos.Models.TargetReferenceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Chaos.Models.TargetReferenceType left, Azure.ResourceManager.Chaos.Models.TargetReferenceType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
