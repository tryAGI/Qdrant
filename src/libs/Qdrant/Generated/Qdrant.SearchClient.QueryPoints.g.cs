
#nullable enable

namespace Qdrant
{
    public partial class SearchClient
    {


        private static readonly global::Qdrant.EndPointSecurityRequirement s_QueryPointsSecurityRequirement0 =
            new global::Qdrant.EndPointSecurityRequirement
            {
                Authorizations = new global::Qdrant.EndPointAuthorizationRequirement[]
                {                    new global::Qdrant.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyApiKey",
                        Location = "Header",
                        Name = "api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Qdrant.EndPointSecurityRequirement[] s_QueryPointsSecurityRequirements =
            new global::Qdrant.EndPointSecurityRequirement[]
            {                s_QueryPointsSecurityRequirement0,
            };
        partial void PrepareQueryPointsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionName,
            ref global::Qdrant.ReadConsistency? consistency,
            ref int? timeout,
            global::Qdrant.QueryRequest request);
        partial void PrepareQueryPointsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionName,
            global::Qdrant.ReadConsistency? consistency,
            int? timeout,
            global::Qdrant.QueryRequest request);
        partial void ProcessQueryPointsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryPointsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query points<br/>
        /// Universally query points. This endpoint covers all capabilities of search, recommend, discover, filters. But also enables hybrid and multi-stage queries.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.QueryPointsResponse> QueryPointsAsync(
            string collectionName,

            global::Qdrant.QueryRequest request,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryPointsArguments(
                httpClient: HttpClient,
                collectionName: ref collectionName,
                consistency: ref consistency,
                timeout: ref timeout,
                request: request);


            var __authorizations = global::Qdrant.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_QueryPointsSecurityRequirements,
                operationName: "QueryPointsAsync");

            using var __timeoutCancellationTokenSource = global::Qdrant.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Qdrant.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Qdrant.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Qdrant.PathBuilder(
                                path: $"/collections/{collectionName}/points/query",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("consistency", consistency?.ToString())
                                .AddOptionalParameter("timeout", timeout?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Qdrant.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Qdrant.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareQueryPointsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    collectionName: collectionName!,
                    consistency: consistency,
                    timeout: timeout,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Qdrant.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryPoints",
                                methodName: "QueryPointsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Qdrant.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryPoints",
                                methodName: "QueryPointsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Qdrant.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Qdrant.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Qdrant.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryPoints",
                                methodName: "QueryPointsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Qdrant.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessQueryPointsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Qdrant.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryPoints",
                                methodName: "QueryPointsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Qdrant.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QueryPoints",
                                methodName: "QueryPointsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/query\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // error
                            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
                            {
                                string? __content_4XX = null;
                                global::System.Exception? __exception_4XX = null;
                                global::Qdrant.ErrorResponse? __value_4XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_4XX = global::Qdrant.ErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::Qdrant.ErrorResponse.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessQueryPointsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Qdrant.QueryPointsResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Qdrant.QueryPointsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Query points<br/>
        /// Universally query points. This endpoint covers all capabilities of search, recommend, discover, filters. But also enables hybrid and multi-stage queries.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="prefetch">
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="query">
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </param>
        /// <param name="params">
        /// Search params for when there is no prefetch
        /// </param>
        /// <param name="scoreThreshold">
        /// Return points with scores better than this threshold.
        /// </param>
        /// <param name="limit">
        /// Max number of points to return. Default is 10.
        /// </param>
        /// <param name="offset">
        /// Offset of the result. Skip this many points. Default is 0
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </param>
        /// <param name="withPayload">
        /// Options for specifying which payload to include or not. Default is false.
        /// </param>
        /// <param name="lookupFrom">
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.QueryPointsResponse> QueryPointsAsync(
            string collectionName,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::Qdrant.ShardKeySelector? shardKey = default,
            global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>? prefetch = default,
            global::Qdrant.QueryInterface? query = default,
            string? @using = default,
            global::Qdrant.Filter? filter = default,
            global::Qdrant.SearchParams? @params = default,
            float? scoreThreshold = default,
            int? limit = default,
            int? offset = default,
            global::Qdrant.WithVector? withVector = default,
            global::Qdrant.WithPayloadInterface? withPayload = default,
            global::Qdrant.LookupLocation? lookupFrom = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Qdrant.QueryRequest
            {
                ShardKey = shardKey,
                Prefetch = prefetch,
                Query = query,
                Using = @using,
                Filter = filter,
                Params = @params,
                ScoreThreshold = scoreThreshold,
                Limit = limit,
                Offset = offset,
                WithVector = withVector,
                WithPayload = withPayload,
                LookupFrom = lookupFrom,
            };

            return await QueryPointsAsync(
                collectionName: collectionName,
                consistency: consistency,
                timeout: timeout,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}