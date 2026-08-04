
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Custom shard key to reshard, must already exist. If not specified, shards without a shard key are resharded.
    /// </summary>
    public sealed partial class StartReshardingShardKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}