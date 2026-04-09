
#nullable enable

namespace Qdrant
{
    public partial class PointsClient
    {


        private static readonly global::Qdrant.EndPointSecurityRequirement s_UpsertPointsSecurityRequirement0 =
            new global::Qdrant.EndPointSecurityRequirement
            {
                Authorizations = new global::Qdrant.EndPointAuthorizationRequirement[]
                {                    new global::Qdrant.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Qdrant.EndPointSecurityRequirement[] s_UpsertPointsSecurityRequirements =
            new global::Qdrant.EndPointSecurityRequirement[]
            {                s_UpsertPointsSecurityRequirement0,
            };
        partial void PrepareUpsertPointsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionName,
            ref bool? wait,
            ref global::Qdrant.WriteOrdering? ordering,
            ref int? timeout,
            global::Qdrant.PointInsertOperations request);
        partial void PrepareUpsertPointsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionName,
            bool? wait,
            global::Qdrant.WriteOrdering? ordering,
            int? timeout,
            global::Qdrant.PointInsertOperations request);
        partial void ProcessUpsertPointsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpsertPointsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upsert points<br/>
        /// Perform insert + updates on points. If point with given ID already exists - it will be overwritten.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.UpsertPointsResponse> UpsertPointsAsync(
            string collectionName,

            global::Qdrant.PointInsertOperations request,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUpsertPointsArguments(
                httpClient: HttpClient,
                collectionName: ref collectionName,
                wait: ref wait,
                ordering: ref ordering,
                timeout: ref timeout,
                request: request);


            var __authorizations = global::Qdrant.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpsertPointsSecurityRequirements,
                operationName: "UpsertPointsAsync");

            var __pathBuilder = new global::Qdrant.PathBuilder(
                path: $"/collections/{collectionName}/points",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("wait", wait?.ToString().ToLowerInvariant())
                .AddOptionalParameter("ordering", ordering?.ToValueString())
                .AddOptionalParameter("timeout", timeout?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpsertPointsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpsertPointsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // error
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::Qdrant.ErrorResponse? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::Qdrant.ErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::Qdrant.ErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::Qdrant.ApiException<global::Qdrant.ErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::Qdrant.ErrorResponse? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Qdrant.ErrorResponse.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Qdrant.ErrorResponse.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Qdrant.ApiException<global::Qdrant.ErrorResponse>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpsertPointsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Qdrant.UpsertPointsResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Qdrant.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Qdrant.UpsertPointsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Qdrant.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Upsert points<br/>
        /// Perform insert + updates on points. If point with given ID already exists - it will be overwritten.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.UpsertPointsResponse> UpsertPointsAsync(
            string collectionName,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Qdrant.PointInsertOperations
            {
            };

            return await UpsertPointsAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}