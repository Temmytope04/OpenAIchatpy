﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Containers.ContainerRegistry.Specialized;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Containers.ContainerRegistry.Tests
{
    [NonParallelizable]
    public class ContainerRegistryBlobClientLiveTests : ContainerRegistryRecordedTestBase
    {
        public ContainerRegistryBlobClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        /// <summary>
        /// Create an OciManifest type that matches the contents of the manifest.json test data file.
        /// </summary>
        /// <returns></returns>
        private static OciManifest CreateManifest()
        {
            OciManifest manifest = new OciManifest()
            {
                SchemaVersion = 2,
                Config = new OciBlobDescriptor()
                {
                    MediaType = "application/vnd.acme.rocket.config",
                    Digest = "sha256:d25b42d3dbad5361ed2d909624d899e7254a822c9a632b582ebd3a44f9b0dbc8",
                    Size = 171
                }
            };
            manifest.Layers.Add(new OciBlobDescriptor()
            {
                MediaType = "application/vnd.oci.image.layer.v1.tar",
                Digest = "sha256:654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed",
                Size = 28,
                Annotations = new OciAnnotations()
                {
                    Name = "artifact.txt"
                }
            });

            return manifest;
        }

        [RecordedTest]
        public async Task CanUploadOciManifest()
        {
            // Arrange
            var client = CreateBlobClient("oci-artifact");

            await UploadManifestPrerequisites(client);

            // Act
            var manifest = CreateManifest();
            var uploadResult = await client.UploadManifestAsync(manifest);
            string digest = uploadResult.Value.Digest;

            // Assert
            DownloadManifestOptions downloadOptions = new DownloadManifestOptions(null, digest);
            using var downloadResultValue = (await client.DownloadManifestAsync(downloadOptions)).Value;
            Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
            Assert.AreEqual(digest, downloadResultValue.Digest);
            ValidateManifest(downloadResultValue.Manifest);

            // Clean up
            await client.DeleteManifestAsync(digest);
        }

        [RecordedTest]
        public async Task CanUploadOciManifestStream()
        {
            // Arrange
            var client = CreateBlobClient("oci-artifact");

            await UploadManifestPrerequisites(client);

            // Act
            string payload = "" +
                "{" +
                    "\"schemaVersion\":2," +
                    "\"config\":" +
                    "{" +
                        "\"mediaType\":\"application/vnd.acme.rocket.config\"," +
                        "\"size\":171," +
                        "\"digest\":\"sha256:d25b42d3dbad5361ed2d909624d899e7254a822c9a632b582ebd3a44f9b0dbc8\"" +
                    "}," +
                    "\"layers\":" +
                    "[" +
                        "{" +
                            "\"mediaType\":\"application/vnd.oci.image.layer.v1.tar\"," +
                            "\"size\":28," +
                            "\"digest\":\"sha256:654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed\"" +
                        "}" +
                    "]" +
                "}";

            using Stream manifest = new MemoryStream(Encoding.ASCII.GetBytes(payload));

            var uploadResult = await client.UploadManifestAsync(manifest);
            string digest = uploadResult.Value.Digest;

            // Assert
            DownloadManifestOptions downloadOptions = new DownloadManifestOptions(null, digest);
            using var downloadResultValue = (await client.DownloadManifestAsync(downloadOptions)).Value;
            Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
            Assert.AreEqual(digest, downloadResultValue.Digest);
            ValidateManifest(downloadResultValue.Manifest);

            // Clean up
            await client.DeleteManifestAsync(digest);
        }

        [RecordedTest]
        public async Task CanUploadOciManifestWithTag()
        {
            // Arrange
            string repository = "oci-artifact";
            var client = CreateBlobClient(repository);
            var metadataClient = CreateClient();
            string tag = "v1";

            await UploadManifestPrerequisites(client);

            // Act
            var manifest = CreateManifest();
            var uploadResult = await client.UploadManifestAsync(manifest, new UploadManifestOptions(tag));
            var digest = uploadResult.Value.Digest;

            // Assert
            DownloadManifestOptions downloadOptions = new DownloadManifestOptions(null, digest);
            using var downloadResultValue = (await client.DownloadManifestAsync(downloadOptions)).Value;
            Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
            Assert.AreEqual(digest, downloadResultValue.Digest);
            ValidateManifest(downloadResultValue.Manifest);

            var artifact = metadataClient.GetArtifact(repository, digest);
            var tags = artifact.GetTagPropertiesCollectionAsync();
            var count = await tags.CountAsync();
            Assert.AreEqual(1, count);
            var firstTag = await tags.FirstAsync();
            Assert.AreEqual(tag, firstTag.Name);

            // Clean up
            await client.DeleteManifestAsync(digest);
        }

        [RecordedTest]
        public async Task CanUploadOciManifestStreamWithTag()
        {
            // Arrange
            string repository = "oci-artifact";
            var client = CreateBlobClient(repository);
            var metadataClient = CreateClient();
            string tag = "v1";

            await UploadManifestPrerequisites(client);

            // Act
            string payload = "" +
                "{" +
                    "\"schemaVersion\":2," +
                    "\"config\":" +
                    "{" +
                        "\"mediaType\":\"application/vnd.acme.rocket.config\"," +
                        "\"size\":171," +
                        "\"digest\":\"sha256:d25b42d3dbad5361ed2d909624d899e7254a822c9a632b582ebd3a44f9b0dbc8\"" +
                    "}," +
                    "\"layers\":" +
                    "[" +
                        "{" +
                            "\"mediaType\":\"application/vnd.oci.image.layer.v1.tar\"," +
                            "\"size\":28," +
                            "\"digest\":\"sha256:654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed\"" +
                        "}" +
                    "]" +
                "}";

            using Stream manifest = new MemoryStream(Encoding.ASCII.GetBytes(payload));
            var uploadResult = await client.UploadManifestAsync(manifest, new UploadManifestOptions(tag));
            var digest = uploadResult.Value.Digest;

            // Assert
            DownloadManifestOptions downloadOptions = new DownloadManifestOptions(null, digest);
            using var downloadResultValue = (await client.DownloadManifestAsync(downloadOptions)).Value;
            Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
            Assert.AreEqual(digest, downloadResultValue.Digest);
            ValidateManifest(downloadResultValue.Manifest);

            var artifact = metadataClient.GetArtifact(repository, digest);
            var tags = artifact.GetTagPropertiesCollectionAsync();
            var count = await tags.CountAsync();
            Assert.AreEqual(1, count);
            var firstTag = await tags.FirstAsync();
            Assert.AreEqual(tag, firstTag.Name);

            downloadOptions = new DownloadManifestOptions(tag, null);
            using var downloadResultValue2 = (await client.DownloadManifestAsync(downloadOptions)).Value;
            Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
            Assert.AreEqual(digest, downloadResultValue.Digest);
            ValidateManifest(downloadResultValue.Manifest);

            // Clean up
            await client.DeleteManifestAsync(digest);
        }

        private async Task UploadManifestPrerequisites(ContainerRegistryBlobClient client)
        {
            var layer = "654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed";
            var config = "config.json";
            var basePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "oci-artifact");

            // Upload config
            using (var fs = File.OpenRead(Path.Combine(basePath, config)))
            {
                var uploadResult = await client.UploadBlobAsync(fs);
            }

            // Upload layer
            using (var fs = File.OpenRead(Path.Combine(basePath, layer)))
            {
                var uploadResult = await client.UploadBlobAsync(fs);
            }
        }

        private static void ValidateManifest(OciManifest manifest)
        {
            // These are from the values in the Data\oci-artifact\manifest.json file.
            Assert.IsNotNull(manifest);

            Assert.IsNotNull(manifest.Config);
            Assert.AreEqual("application/vnd.acme.rocket.config", manifest.Config.MediaType);
            Assert.AreEqual("sha256:d25b42d3dbad5361ed2d909624d899e7254a822c9a632b582ebd3a44f9b0dbc8", manifest.Config.Digest);
            Assert.AreEqual(171, manifest.Config.Size);

            Assert.IsNotNull(manifest.Layers);
            Assert.AreEqual(1, manifest.Layers.Count);
            Assert.AreEqual("application/vnd.oci.image.layer.v1.tar", manifest.Layers[0].MediaType);
            Assert.AreEqual("sha256:654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed", manifest.Layers[0].Digest);
            Assert.AreEqual(28, manifest.Layers[0].Size);
        }

        [RecordedTest]
        public async Task CanUploadBlob()
        {
            // Arrange
            var client = CreateBlobClient("oci-artifact");
            var blob = "654b93f61054e4ce90ed203bb8d556a6200d5f906cf3eca0620738d6dc18cbed";
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "oci-artifact", blob);

            string digest = default;
            long streamLength;
            // Act
            using (var fs = File.OpenRead(path))
            {
                streamLength = fs.Length;
                var uploadResult = await client.UploadBlobAsync(fs);
                digest = uploadResult.Value.Digest;
            }

            // Assert
            var downloadResult = await client.DownloadBlobAsync(digest);
            Assert.AreEqual(digest, downloadResult.Value.Digest);
            Assert.AreEqual(streamLength, downloadResult.Value.Content.Length);

            //// Clean up
            await client.DeleteBlobAsync(digest);
            downloadResult.Value.Dispose();
        }

        //[RecordedTest]
        //public async Task CanPushArtifact()
        //{
        //    // Arrange
        //    var client = CreateBlobClient("oci-artifact");

        //    await UploadManifestPrerequisites(client);

        //    // Act
        //    var manifest = CreateManifest();
        //    var uploadResult = await client.UploadManifestAsync(manifest);
        //    string digest = uploadResult.Value.Digest;

        //    // Assert
        //    DownloadManifestOptions downloadOptions = new DownloadManifestOptions(null, digest);
        //    using var downloadResultValue = (await client.DownloadManifestAsync(downloadOptions)).Value;
        //    Assert.AreEqual(0, downloadResultValue.ManifestStream.Position);
        //    Assert.AreEqual(digest, downloadResultValue.Digest);
        //    ValidateManifest(downloadResultValue.Manifest);

        //    // Clean up
        //    await client.DeleteManifestAsync(digest);
        //}

        //[RecordedTest]
        //public async Task CanPullArtifact()
        //{
        //    // Arrange
        //    var client = CreateBlobClient("oci-artifact");

        //    //// Arrange
        //    //var repository = "library/hello-world";

        //    //// This digest is pulling invalid blobs right now
        //    ////var digest = "sha256:90e120baffe5afa60dd5a24abcd051db49bd6aee391174da5e825ee6ee5a12a0";
        //    //var digest = "sha256:1b26826f602946860c279fce658f31050cff2c596583af237d971f4629b57792";
        //    //var client = CreateClient();
        //    //var artifact = client.GetArtifact(repository, digest);
        //    string path = @"C:\temp\acr\test-pull";

        //    // Act

        //    // Get Manifest

        //    // TODO: do we need digest in this method if artifact was instantiated with it?
        //    // TODO: How should we handle/communicate the difference in semantics between download
        //    // with digest and download with tag?
        //    var manifestResult = await client.DownloadManifestAsync(digest);

        //    // Write manifest to file
        //    Directory.CreateDirectory(path);
        //    string manifestFile = Path.Combine(path, "manifest.json");
        //    using (FileStream fs = File.Create(manifestFile))
        //    {
        //        Stream stream = manifestResult.Value.Content;
        //        await stream.CopyToAsync(fs).ConfigureAwait(false);
        //    }

        //    // Write Config and Layers
        //    foreach (var artifactFile in manifestResult.Value.ArtifactFiles)
        //    {
        //        string fileName = Path.Combine(path, artifactFile.FileName ?? TrimSha(artifactFile.Digest));

        //        using (FileStream fs = File.Create(fileName))
        //        {
        //            var layerResult = await downloadClient.DownloadBlobAsync(artifactFile.Digest);
        //            Stream stream = layerResult.Value.Content;
        //            await stream.CopyToAsync(fs).ConfigureAwait(false);
        //        }
        //    }
        //}

        private static string TrimSha(string digest)
        {
            int index = digest.IndexOf(':');
            if (index > -1)
            {
                return digest.Substring(index + 1);
            }

            return digest;
        }
    }
}
