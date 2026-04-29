
#nullable enable

namespace Qdrant
{
    public partial class PointsClient
    {


        private static readonly global::Qdrant.EndPointSecurityRequirement s_DeleteVectorsSecurityRequirement0 =
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
        private static readonly global::Qdrant.EndPointSecurityRequirement[] s_DeleteVectorsSecurityRequirements =
            new global::Qdrant.EndPointSecurityRequirement[]
            {                s_DeleteVectorsSecurityRequirement0,
            };
        partial void PrepareDeleteVectorsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionName,
            ref bool? wait,
            ref global::Qdrant.WriteOrdering? ordering,
            ref int? timeout,
            global::Qdrant.DeleteVectors request);
        partial void PrepareDeleteVectorsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionName,
            bool? wait,
            global::Qdrant.WriteOrdering? ordering,
            int? timeout,
            global::Qdrant.DeleteVectors request);
        partial void ProcessDeleteVectorsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteVectorsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete vectors<br/>
        /// Delete named vectors from the given points.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.DeleteVectorsResponse> DeleteVectorsAsync(
            string collectionName,

            global::Qdrant.DeleteVectors request,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeleteVectorsArguments(
                httpClient: HttpClient,
                collectionName: ref collectionName,
                wait: ref wait,
                ordering: ref ordering,
                timeout: ref timeout,
                request: request);


            var __authorizations = global::Qdrant.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DeleteVectorsSecurityRequirements,
                operationName: "DeleteVectorsAsync");

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
                                path: $"/collections/{collectionName}/points/vectors/delete",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("wait", wait?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("ordering", ordering?.ToValueString())
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
                PrepareDeleteVectorsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    collectionName: collectionName!,
                    wait: wait,
                    ordering: ordering,
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
                                operationId: "DeleteVectors",
                                methodName: "DeleteVectorsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/vectors/delete\"",
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
                                operationId: "DeleteVectors",
                                methodName: "DeleteVectorsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/vectors/delete\"",
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
                                operationId: "DeleteVectors",
                                methodName: "DeleteVectorsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/vectors/delete\"",
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
                ProcessDeleteVectorsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Qdrant.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Qdrant.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DeleteVectors",
                                methodName: "DeleteVectorsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/vectors/delete\"",
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
                                operationId: "DeleteVectors",
                                methodName: "DeleteVectorsAsync",
                                pathTemplate: "$\"/collections/{collectionName}/points/vectors/delete\"",
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
                                ProcessDeleteVectorsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Qdrant.DeleteVectorsResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::Qdrant.DeleteVectorsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Delete vectors<br/>
        /// Delete named vectors from the given points.
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
        /// <param name="points">
        /// Deletes values from each point in this list
        /// </param>
        /// <param name="filter">
        /// Deletes values from points that satisfy this filter condition
        /// </param>
        /// <param name="vector">
        /// Vector names
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Qdrant.DeleteVectorsResponse> DeleteVectorsAsync(
            string collectionName,
            global::System.Collections.Generic.IList<string> vector,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>? points = default,
            global::Qdrant.Filter? filter = default,
            global::Qdrant.ShardKeySelector? shardKey = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Qdrant.DeleteVectors
            {
                Points = points,
                Filter = filter,
                Vector = vector,
                ShardKey = shardKey,
            };

            return await DeleteVectorsAsync(
                collectionName: collectionName,
                wait: wait,
                ordering: ordering,
                timeout: timeout,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}