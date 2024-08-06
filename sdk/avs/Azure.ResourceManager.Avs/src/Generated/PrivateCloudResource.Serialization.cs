// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class PrivateCloudResource : IJsonModel<PrivateCloudData>
    {
        void IJsonModel<PrivateCloudData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PrivateCloudData>)Data).Write(writer, options);

        PrivateCloudData IJsonModel<PrivateCloudData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PrivateCloudData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PrivateCloudData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PrivateCloudData IPersistableModel<PrivateCloudData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PrivateCloudData>(data, options);

        string IPersistableModel<PrivateCloudData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PrivateCloudData>)Data).GetFormatFromOptions(options);
    }
}
