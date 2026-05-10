
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dir")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_log_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxLogFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_forwarded_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TrustForwardedHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LogApi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dir_size_bytes")]
        public int? DirSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTelemetry" /> class.
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="rotation"></param>
        /// <param name="maxLogFiles"></param>
        /// <param name="trustForwardedHeaders"></param>
        /// <param name="logApi"></param>
        /// <param name="dirSizeBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditTelemetry(
            string dir,
            string rotation,
            int maxLogFiles,
            bool trustForwardedHeaders,
            bool logApi,
            int? dirSizeBytes)
        {
            this.Dir = dir ?? throw new global::System.ArgumentNullException(nameof(dir));
            this.Rotation = rotation ?? throw new global::System.ArgumentNullException(nameof(rotation));
            this.MaxLogFiles = maxLogFiles;
            this.TrustForwardedHeaders = trustForwardedHeaders;
            this.LogApi = logApi;
            this.DirSizeBytes = dirSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTelemetry" /> class.
        /// </summary>
        public AuditTelemetry()
        {
        }

    }
}