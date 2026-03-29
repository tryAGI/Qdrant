
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Qdrant.AppBuildTelemetry? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.CollectionsTelemetry Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::Qdrant.ClusterTelemetry? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::Qdrant.RequestsTelemetry? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.MemoryTelemetry? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public global::Qdrant.HardwareTelemetry? Hardware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collections"></param>
        /// <param name="app"></param>
        /// <param name="cluster"></param>
        /// <param name="requests"></param>
        /// <param name="memory"></param>
        /// <param name="hardware"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryData(
            string id,
            global::Qdrant.CollectionsTelemetry collections,
            global::Qdrant.AppBuildTelemetry? app,
            global::Qdrant.ClusterTelemetry? cluster,
            global::Qdrant.RequestsTelemetry? requests,
            global::Qdrant.MemoryTelemetry? memory,
            global::Qdrant.HardwareTelemetry? hardware)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.App = app;
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.Cluster = cluster;
            this.Requests = requests;
            this.Memory = memory;
            this.Hardware = hardware;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryData" /> class.
        /// </summary>
        public TelemetryData()
        {
        }
    }
}