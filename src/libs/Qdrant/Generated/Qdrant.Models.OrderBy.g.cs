
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderBy
    {
        /// <summary>
        /// Payload key to order by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Direction of ordering: `asc` or `desc`. Default is ascending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public global::Qdrant.Direction? Direction { get; set; }

        /// <summary>
        /// Which payload value to start scrolling from. Default is the lowest value for `asc` and the highest for `desc`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_from")]
        public global::Qdrant.StartFrom? StartFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload key to order by
        /// </param>
        /// <param name="direction">
        /// Direction of ordering: `asc` or `desc`. Default is ascending.
        /// </param>
        /// <param name="startFrom">
        /// Which payload value to start scrolling from. Default is the lowest value for `asc` and the highest for `desc`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderBy(
            string key,
            global::Qdrant.Direction? direction,
            global::Qdrant.StartFrom? startFrom)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Direction = direction;
            this.StartFrom = startFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy" /> class.
        /// </summary>
        public OrderBy()
        {
        }
    }
}