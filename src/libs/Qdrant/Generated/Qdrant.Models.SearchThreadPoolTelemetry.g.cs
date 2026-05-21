
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Live snapshot of the adaptive search routing.<br/>
    /// `mode` is the runtime currently selected by [`SearchMode`]; `high_cpu_threads` and `high_io_threads` are the blocking-thread budgets of the two underlying runtimes that the adaptive handle routes between.
    /// </summary>
    public sealed partial class SearchThreadPoolTelemetry
    {
        /// <summary>
        /// Currently active mode (`high_cpu` or `high_io`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Blocking-thread count of the high-CPU runtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_cpu_threads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighCpuThreads { get; set; }

        /// <summary>
        /// Blocking-thread count of the high-IO runtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_io_threads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighIoThreads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchThreadPoolTelemetry" /> class.
        /// </summary>
        /// <param name="mode">
        /// Currently active mode (`high_cpu` or `high_io`).
        /// </param>
        /// <param name="highCpuThreads">
        /// Blocking-thread count of the high-CPU runtime.
        /// </param>
        /// <param name="highIoThreads">
        /// Blocking-thread count of the high-IO runtime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchThreadPoolTelemetry(
            string mode,
            int highCpuThreads,
            int highIoThreads)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.HighCpuThreads = highCpuThreads;
            this.HighIoThreads = highIoThreads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchThreadPoolTelemetry" /> class.
        /// </summary>
        public SearchThreadPoolTelemetry()
        {
        }

    }
}