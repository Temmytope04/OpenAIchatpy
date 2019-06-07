﻿using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Keys
{
    public partial class KeyClient
    {
        private const string ApiVersion = "7.0";
        private const string KeysPath = "/keys/";
        private const string DeletedKeysPath = "/deletedkeys/";

        private async Task<Response<TResult>> SendRequestAsync<TContent, TResult>(HttpPipelineMethod method, TContent content, Func<TResult> resultFactory, CancellationToken cancellationToken, params string[] path)
            where TContent : Model
            where TResult : Model
        {
            using (Request request = CreateRequest(method, path))
            {
                request.Content = HttpPipelineRequestContent.Create(content.Serialize());

                Response response = await SendRequestAsync(request, cancellationToken);

                return this.CreateResponse(response, resultFactory());
            }
        }

        private async Task<Response<TResult>> SendRequestAsync<TResult>(HttpPipelineMethod method, Func<TResult> resultFactory, CancellationToken cancellationToken, params string[] path)
            where TResult : Model
        {
            using (Request request = CreateRequest(method, path))
            {
                Response response = await SendRequestAsync(request, cancellationToken);

                return this.CreateResponse(response, resultFactory());
            }
        }

        private async Task<Response> SendRequestAsync(HttpPipelineMethod method, CancellationToken cancellationToken, params string[] path)
        {
            using (Request request = CreateRequest(HttpPipelineMethod.Get, path))
            {
                return await SendRequestAsync(request, cancellationToken);
            }
        }

        private async Task<Response> SendRequestAsync(Request request, CancellationToken cancellationToken)
        {
            Response response = await _pipeline.SendRequestAsync(request, cancellationToken);

            switch (response.Status)
            {
                case 200:
                case 201:
                    return response;
                default:
                    throw await response.CreateRequestFailedExceptionAsync();
            }
        }

        private Request CreateRequest(HttpPipelineMethod method, params string[] path)
        {
            // duplicating the code from the overload which takes a URI here because there is currently a bug in 
            // request.UriBuilder when you call AppendQuery before AppendPath
            Request request = _pipeline.CreateRequest();

            request.Headers.Add(HttpHeader.Common.JsonContentType);
            request.Headers.Add(HttpHeader.Names.Accept, "application/json");
            request.Method = method;
            request.UriBuilder.Uri = _vaultUri;

            foreach (var p in path)
            {
                if (!string.IsNullOrEmpty(p))
                {
                    var pp = !p.StartsWith("/") ? "/" + p : p;

                    request.UriBuilder.AppendPath(pp);
                }
            }

            request.UriBuilder.AppendQuery("api-version", ApiVersion);

            return request;
        }

        private Request CreateRequest(HttpPipelineMethod method, Uri uri)
        {
            Request request = _pipeline.CreateRequest();

            request.Headers.Add(HttpHeader.Common.JsonContentType);
            request.Headers.Add(HttpHeader.Names.Accept, "application/json");
            request.Method = method;
            request.UriBuilder.Uri = uri;

            return request;
        }

        private Uri CreateFirstPageUri(string path)
        {
            var firstPage = new HttpPipelineUriBuilder();
            firstPage.Uri = _vaultUri;
            firstPage.AppendPath(path);
            firstPage.AppendQuery("api-version", ApiVersion);

            return firstPage.Uri;
        }

        private Response<T> CreateResponse<T>(Response response, T result)
            where T : Model
        {
            result.Deserialize(response.ContentStream);

            return new Response<T>(response, result);
        }

        private async Task<PageResponse<T>> GetPageAsync<T>(Uri firstPageUri, string nextLink, Func<T> itemFactory, CancellationToken cancellationToken)
                where T : Model
        {
            // if we don't have a nextLink specified, use firstPageUri
            if (nextLink != null)
            {
                firstPageUri = new Uri(nextLink);
            }

            using (Request request = CreateRequest(HttpPipelineMethod.Get, firstPageUri))
            {
                Response response = await SendRequestAsync(request, cancellationToken);

                // read the respose
                Page<T> responseAsPage = new Page<T>(itemFactory);
                responseAsPage.Deserialize(response.ContentStream);

                // convert from the Page<T> to PageResponse<T>
                return new PageResponse<T>(responseAsPage.Items.ToArray(), response, responseAsPage.NextLink?.ToString());
            }
        }
    }
}
