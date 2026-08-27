
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetQuotasResponse
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Qdrant.Usage? Usage { get; set; }

        /// <summary>
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </summary>
        /// <example>0.002F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public float? Time { get; set; }

        /// <summary>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Quota configuration in effect, and how close each peer is to it.<br/>
        /// The configuration is cluster-wide; the utilization is not. `usage` is the node that served the request, and `peers` is what every peer that answered reports about itself — memory and disk are node-local, so one peer being under its limit says nothing about the others.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Qdrant.QuotaStatus? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetQuotasResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="time">
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </param>
        /// <param name="status">
        /// Example: ok
        /// </param>
        /// <param name="result">
        /// Quota configuration in effect, and how close each peer is to it.<br/>
        /// The configuration is cluster-wide; the utilization is not. `usage` is the node that served the request, and `peers` is what every peer that answered reports about itself — memory and disk are node-local, so one peer being under its limit says nothing about the others.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetQuotasResponse(
            global::Qdrant.Usage? usage,
            float? time,
            string? status,
            global::Qdrant.QuotaStatus? result)
        {
            this.Usage = usage;
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetQuotasResponse" /> class.
        /// </summary>
        public GetQuotasResponse()
        {
        }

    }
}