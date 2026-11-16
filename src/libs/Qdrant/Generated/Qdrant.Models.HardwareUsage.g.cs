
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Usage of the hardware resources, spent to process the request
    /// </summary>
    public sealed partial class HardwareUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public long? Cpu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_io_read")]
        public long? PayloadIoRead { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_io_write")]
        public long? PayloadIoWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_index_io_read")]
        public long? PayloadIndexIoRead { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_index_io_write")]
        public long? PayloadIndexIoWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_io_read")]
        public long? VectorIoRead { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_io_write")]
        public long? VectorIoWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_io_cached_read")]
        public long? RemoteIoCachedRead { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_io_non_cached_read")]
        public long? RemoteIoNonCachedRead { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_bytes")]
        public long? UpdatedBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_indexed_bytes")]
        public long? UpdatedIndexedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareUsage" /> class.
        /// </summary>
        /// <param name="cpu"></param>
        /// <param name="payloadIoRead"></param>
        /// <param name="payloadIoWrite"></param>
        /// <param name="payloadIndexIoRead"></param>
        /// <param name="payloadIndexIoWrite"></param>
        /// <param name="vectorIoRead"></param>
        /// <param name="vectorIoWrite"></param>
        /// <param name="remoteIoCachedRead"></param>
        /// <param name="remoteIoNonCachedRead"></param>
        /// <param name="updatedBytes"></param>
        /// <param name="updatedIndexedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareUsage(
            long? cpu,
            long? payloadIoRead,
            long? payloadIoWrite,
            long? payloadIndexIoRead,
            long? payloadIndexIoWrite,
            long? vectorIoRead,
            long? vectorIoWrite,
            long? remoteIoCachedRead,
            long? remoteIoNonCachedRead,
            long? updatedBytes,
            long? updatedIndexedBytes)
        {
            this.Cpu = cpu;
            this.PayloadIoRead = payloadIoRead;
            this.PayloadIoWrite = payloadIoWrite;
            this.PayloadIndexIoRead = payloadIndexIoRead;
            this.PayloadIndexIoWrite = payloadIndexIoWrite;
            this.VectorIoRead = vectorIoRead;
            this.VectorIoWrite = vectorIoWrite;
            this.RemoteIoCachedRead = remoteIoCachedRead;
            this.RemoteIoNonCachedRead = remoteIoNonCachedRead;
            this.UpdatedBytes = updatedBytes;
            this.UpdatedIndexedBytes = updatedIndexedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareUsage" /> class.
        /// </summary>
        public HardwareUsage()
        {
        }

    }
}