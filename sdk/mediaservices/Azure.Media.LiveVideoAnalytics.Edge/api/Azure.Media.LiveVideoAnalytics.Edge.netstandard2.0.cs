namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class ItemNonSetRequestBase : Azure.Media.LiveVideoAnalytics.Edge.Models.MethodRequest
    {
        public ItemNonSetRequestBase(string name) { }
        public string Name { get { throw null; } set { } }
    }
    public partial class MediaGraphAssetSink : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSink
    {
        public MediaGraphAssetSink(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, string assetNamePattern, string localMediaCachePath, string localMediaCacheMaximumSizeMiB) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public string AssetNamePattern { get { throw null; } set { } }
        public string LocalMediaCacheMaximumSizeMiB { get { throw null; } set { } }
        public string LocalMediaCachePath { get { throw null; } set { } }
        public string SegmentLength { get { throw null; } set { } }
    }
    public partial class MediaGraphCertificateSource
    {
        public MediaGraphCertificateSource() { }
    }
    public partial class MediaGraphCognitiveServicesVisionExtension : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphExtensionProcessorBase
    {
        public MediaGraphCognitiveServicesVisionExtension(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint endpoint, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage image) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage)) { }
    }
    public partial class MediaGraphCredentials
    {
        public MediaGraphCredentials() { }
    }
    public partial class MediaGraphEndpoint
    {
        public MediaGraphEndpoint(string url) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphCredentials Credentials { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
    }
    public partial class MediaGraphExtensionProcessorBase : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphProcessor
    {
        public MediaGraphExtensionProcessorBase(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint endpoint, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage image) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint Endpoint { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage Image { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSamplingOptions SamplingOptions { get { throw null; } set { } }
    }
    public partial class MediaGraphFileSink : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSink
    {
        public MediaGraphFileSink(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, string baseDirectoryPath, string fileNamePattern, string maximumSizeMiB) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public string BaseDirectoryPath { get { throw null; } set { } }
        public string FileNamePattern { get { throw null; } set { } }
        public string MaximumSizeMiB { get { throw null; } set { } }
    }
    public partial class MediaGraphGrpcExtension : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphExtensionProcessorBase
    {
        public MediaGraphGrpcExtension(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint endpoint, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage image, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransfer dataTransfer) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage)) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransfer DataTransfer { get { throw null; } set { } }
        public string ExtensionConfiguration { get { throw null; } set { } }
    }
    public partial class MediaGraphGrpcExtensionDataTransfer
    {
        public MediaGraphGrpcExtensionDataTransfer(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode mode) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode Mode { get { throw null; } set { } }
        public string SharedMemorySizeMiB { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaGraphGrpcExtensionDataTransferMode : System.IEquatable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaGraphGrpcExtensionDataTransferMode(string value) { throw null; }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode Embedded { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode SharedMemory { get { throw null; } }
        public bool Equals(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode right) { throw null; }
        public static implicit operator Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode (string value) { throw null; }
        public static bool operator !=(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphGrpcExtensionDataTransferMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaGraphHttpExtension : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphExtensionProcessorBase
    {
        public MediaGraphHttpExtension(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint endpoint, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage image) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint), default(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImage)) { }
    }
    public partial class MediaGraphHttpHeaderCredentials : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphCredentials
    {
        public MediaGraphHttpHeaderCredentials(string headerName, string headerValue) { }
        public string HeaderName { get { throw null; } set { } }
        public string HeaderValue { get { throw null; } set { } }
    }
    public partial class MediaGraphImage
    {
        public MediaGraphImage() { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormat Format { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScale Scale { get { throw null; } set { } }
    }
    public partial class MediaGraphImageFormat
    {
        public MediaGraphImageFormat() { }
    }
    public partial class MediaGraphImageFormatBmp : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormat
    {
        public MediaGraphImageFormatBmp() { }
    }
    public partial class MediaGraphImageFormatJpeg : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormat
    {
        public MediaGraphImageFormatJpeg() { }
        public string Quality { get { throw null; } set { } }
    }
    public partial class MediaGraphImageFormatPng : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormat
    {
        public MediaGraphImageFormatPng() { }
    }
    public partial class MediaGraphImageFormatRaw : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormat
    {
        public MediaGraphImageFormatRaw(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat pixelFormat) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat PixelFormat { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaGraphImageFormatRawPixelFormat : System.IEquatable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaGraphImageFormatRawPixelFormat(string value) { throw null; }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Abgr { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Argb { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Bgr24 { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Bgra { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgb24 { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgb555Be { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgb555Le { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgb565Be { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgb565Le { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Rgba { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat Yuv420P { get { throw null; } }
        public bool Equals(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat right) { throw null; }
        public static implicit operator Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat (string value) { throw null; }
        public static bool operator !=(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageFormatRawPixelFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaGraphImageScale
    {
        public MediaGraphImageScale(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode mode) { }
        public string Height { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode Mode { get { throw null; } set { } }
        public string Width { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaGraphImageScaleMode : System.IEquatable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaGraphImageScaleMode(string value) { throw null; }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode Pad { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode PreserveAspectRatio { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode Stretch { get { throw null; } }
        public bool Equals(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode right) { throw null; }
        public static implicit operator Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode (string value) { throw null; }
        public static bool operator !=(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphImageScaleMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaGraphInstance
    {
        public MediaGraphInstance(string name) { }
        public string Name { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstanceProperties Properties { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSystemData SystemData { get { throw null; } set { } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstance Deserialize(string json) { throw null; }
    }
    public partial class MediaGraphInstanceActivateRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphInstanceActivateRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphInstanceCollection
    {
        public MediaGraphInstanceCollection() { }
        public string ContinuationToken { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstance> Value { get { throw null; } }
    }
    public partial class MediaGraphInstanceDeActivateRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphInstanceDeActivateRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphInstanceDeleteRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphInstanceDeleteRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphInstanceGetRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphInstanceGetRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphInstanceListRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.MethodRequest
    {
        public MediaGraphInstanceListRequest() { }
    }
    public partial class MediaGraphInstanceProperties
    {
        public MediaGraphInstanceProperties() { }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphParameterDefinition> Parameters { get { throw null; } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstanceState? State { get { throw null; } set { } }
        public string TopologyName { get { throw null; } set { } }
    }
    public partial class MediaGraphInstanceSetRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.MethodRequest
    {
        public MediaGraphInstanceSetRequest(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstance instance) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphInstance Instance { get { throw null; } set { } }
        public override string GetPayloadAsJson() { throw null; }
    }
    public enum MediaGraphInstanceState
    {
        Inactive = 0,
        Activating = 1,
        Active = 2,
        Deactivating = 3,
    }
    public partial class MediaGraphIoTHubMessageSink : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSink
    {
        public MediaGraphIoTHubMessageSink(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, string hubOutputName) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public string HubOutputName { get { throw null; } set { } }
    }
    public partial class MediaGraphIoTHubMessageSource : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSource
    {
        public MediaGraphIoTHubMessageSource(string name) : base (default(string)) { }
        public string HubInputName { get { throw null; } set { } }
    }
    public partial class MediaGraphMotionDetectionProcessor : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphProcessor
    {
        public MediaGraphMotionDetectionProcessor(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public string EventAggregationWindow { get { throw null; } set { } }
        public bool? OutputMotionRegion { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity? Sensitivity { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaGraphMotionDetectionSensitivity : System.IEquatable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaGraphMotionDetectionSensitivity(string value) { throw null; }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity High { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity Low { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity Medium { get { throw null; } }
        public bool Equals(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity right) { throw null; }
        public static implicit operator Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity (string value) { throw null; }
        public static bool operator !=(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphMotionDetectionSensitivity right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaGraphNodeInput
    {
        public MediaGraphNodeInput() { }
        public string NodeName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphOutputSelector> OutputSelectors { get { throw null; } }
    }
    public partial class MediaGraphOutputSelector
    {
        public MediaGraphOutputSelector() { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphOutputSelectorOperator? Operator { get { throw null; } set { } }
        public string Property { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public enum MediaGraphOutputSelectorOperator
    {
        Is = 0,
        IsNot = 1,
    }
    public partial class MediaGraphParameterDeclaration
    {
        public MediaGraphParameterDeclaration(string name, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphParameterType type) { }
        public string Default { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphParameterType Type { get { throw null; } set { } }
    }
    public partial class MediaGraphParameterDefinition
    {
        public MediaGraphParameterDefinition(string name, string value) { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public enum MediaGraphParameterType
    {
        String = 0,
        SecretString = 1,
        Int = 2,
        Double = 3,
        Bool = 4,
    }
    public partial class MediaGraphPemCertificateList : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphCertificateSource
    {
        public MediaGraphPemCertificateList(System.Collections.Generic.IEnumerable<string> certificates) { }
        public System.Collections.Generic.IList<string> Certificates { get { throw null; } }
    }
    public partial class MediaGraphProcessor
    {
        public MediaGraphProcessor(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs) { }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> Inputs { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    public partial class MediaGraphRtspSource : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSource
    {
        public MediaGraphRtspSource(string name, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint endpoint) : base (default(string)) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint Endpoint { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport? Transport { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaGraphRtspTransport : System.IEquatable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaGraphRtspTransport(string value) { throw null; }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport Http { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport Tcp { get { throw null; } }
        public bool Equals(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport right) { throw null; }
        public static implicit operator Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport (string value) { throw null; }
        public static bool operator !=(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport left, Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphRtspTransport right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaGraphSamplingOptions
    {
        public MediaGraphSamplingOptions() { }
        public string MaximumSamplesPerSecond { get { throw null; } set { } }
        public string SkipSamplesWithoutAnnotation { get { throw null; } set { } }
    }
    public partial class MediaGraphSignalGateProcessor : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphProcessor
    {
        public MediaGraphSignalGateProcessor(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs, string activationSignalOffset, string minimumActivationTime, string maximumActivationTime) : base (default(string), default(System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput>)) { }
        public string ActivationEvaluationWindow { get { throw null; } set { } }
        public string ActivationSignalOffset { get { throw null; } set { } }
        public string MaximumActivationTime { get { throw null; } set { } }
        public string MinimumActivationTime { get { throw null; } set { } }
    }
    public partial class MediaGraphSink
    {
        public MediaGraphSink(string name, System.Collections.Generic.IEnumerable<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> inputs) { }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphNodeInput> Inputs { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    public partial class MediaGraphSource
    {
        public MediaGraphSource(string name) { }
        public string Name { get { throw null; } set { } }
    }
    public partial class MediaGraphSystemData
    {
        public MediaGraphSystemData() { }
        public System.DateTimeOffset? CreatedAt { get { throw null; } set { } }
        public System.DateTimeOffset? LastModifiedAt { get { throw null; } set { } }
    }
    public partial class MediaGraphTlsEndpoint : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint
    {
        public MediaGraphTlsEndpoint(string url) : base (default(string)) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphCertificateSource TrustedCertificates { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTlsValidationOptions ValidationOptions { get { throw null; } set { } }
    }
    public partial class MediaGraphTlsValidationOptions
    {
        public MediaGraphTlsValidationOptions() { }
        public string IgnoreHostname { get { throw null; } set { } }
        public string IgnoreSignature { get { throw null; } set { } }
    }
    public partial class MediaGraphTopology
    {
        public MediaGraphTopology(string name) { }
        public string Name { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopologyProperties Properties { get { throw null; } set { } }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSystemData SystemData { get { throw null; } set { } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopology Deserialize(string json) { throw null; }
    }
    public partial class MediaGraphTopologyCollection
    {
        public MediaGraphTopologyCollection() { }
        public string ContinuationToken { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopology> Value { get { throw null; } }
        public static Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopologyCollection Deserialize(string json) { throw null; }
        public string Serialize() { throw null; }
    }
    public partial class MediaGraphTopologyDeleteRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphTopologyDeleteRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphTopologyGetRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.ItemNonSetRequestBase
    {
        public MediaGraphTopologyGetRequest(string name) : base (default(string)) { }
    }
    public partial class MediaGraphTopologyListRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.MethodRequest
    {
        public MediaGraphTopologyListRequest() { }
    }
    public partial class MediaGraphTopologyProperties
    {
        public MediaGraphTopologyProperties() { }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphParameterDeclaration> Parameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphProcessor> Processors { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSink> Sinks { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphSource> Sources { get { throw null; } }
    }
    public partial class MediaGraphTopologySetRequest : Azure.Media.LiveVideoAnalytics.Edge.Models.MethodRequest
    {
        public MediaGraphTopologySetRequest(Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopology graph) { }
        public Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphTopology Graph { get { throw null; } set { } }
        public override string GetPayloadAsJson() { throw null; }
    }
    public partial class MediaGraphUnsecuredEndpoint : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphEndpoint
    {
        public MediaGraphUnsecuredEndpoint(string url) : base (default(string)) { }
    }
    public partial class MediaGraphUsernamePasswordCredentials : Azure.Media.LiveVideoAnalytics.Edge.Models.MediaGraphCredentials
    {
        public MediaGraphUsernamePasswordCredentials(string username) { }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public partial class MethodRequest
    {
        public MethodRequest() { }
        public string ApiVersion { get { throw null; } set { } }
        public string MethodName { get { throw null; } set { } }
        public virtual string GetPayloadAsJson() { throw null; }
    }
}
