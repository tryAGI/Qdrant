
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionTelemetry
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
        [global::System.Text.Json.Serialization.JsonPropertyName("init_time_ms")]
        public int? InitTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Qdrant.CollectionConfigTelemetry? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? Shards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        public global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? Transfers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resharding")]
        public global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? Resharding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_clean_tasks")]
        public object? ShardCleanTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionTelemetry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="initTimeMs"></param>
        /// <param name="config"></param>
        /// <param name="shards"></param>
        /// <param name="transfers"></param>
        /// <param name="resharding"></param>
        /// <param name="shardCleanTasks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionTelemetry(
            string id,
            int? initTimeMs,
            global::Qdrant.CollectionConfigTelemetry? config,
            global::System.Collections.Generic.IList<global::Qdrant.ReplicaSetTelemetry>? shards,
            global::System.Collections.Generic.IList<global::Qdrant.ShardTransferInfo>? transfers,
            global::System.Collections.Generic.IList<global::Qdrant.ReshardingInfo>? resharding,
            object? shardCleanTasks)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InitTimeMs = initTimeMs;
            this.Config = config;
            this.Shards = shards;
            this.Transfers = transfers;
            this.Resharding = resharding;
            this.ShardCleanTasks = shardCleanTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionTelemetry" /> class.
        /// </summary>
        public CollectionTelemetry()
        {
        }
    }
}