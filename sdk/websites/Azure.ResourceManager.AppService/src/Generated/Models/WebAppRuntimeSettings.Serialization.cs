// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppRuntimeSettings : IUtf8JsonSerializable, IModelJsonSerializable<WebAppRuntimeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebAppRuntimeSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebAppRuntimeSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static WebAppRuntimeSettings DeserializeWebAppRuntimeSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runtimeVersion = default;
            Optional<bool> remoteDebuggingSupported = default;
            Optional<AppInsightsWebAppStackSettings> appInsightsSettings = default;
            Optional<GitHubActionWebAppStackSettings> gitHubActionSettings = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteDebuggingSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteDebuggingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appInsightsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebAppRuntimeSettings(runtimeVersion.Value, Optional.ToNullable(remoteDebuggingSupported), appInsightsSettings.Value, gitHubActionSettings.Value, Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess), rawData);
        }

        WebAppRuntimeSettings IModelJsonSerializable<WebAppRuntimeSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppRuntimeSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebAppRuntimeSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebAppRuntimeSettings IModelSerializable<WebAppRuntimeSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebAppRuntimeSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WebAppRuntimeSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WebAppRuntimeSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebAppRuntimeSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
