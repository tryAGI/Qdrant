
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeoDistance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.GeoDistanceParams GeoDistance1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoDistance" /> class.
        /// </summary>
        /// <param name="geoDistance1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoDistance(
            global::Qdrant.GeoDistanceParams geoDistance1)
        {
            this.GeoDistance1 = geoDistance1 ?? throw new global::System.ArgumentNullException(nameof(geoDistance1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoDistance" /> class.
        /// </summary>
        public GeoDistance()
        {
        }
    }
}