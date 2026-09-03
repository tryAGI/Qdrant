
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunningEnvironmentTelemetry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution")]
        public string? Distribution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution_version")]
        public string? DistributionVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_docker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDocker { get; set; }

        /// <summary>
        /// Container runtime Qdrant is running under (`none` if bare metal).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ContainerRuntimeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ContainerRuntime ContainerRuntime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public int? Cores { get; set; }

        /// <summary>
        /// Average number of CPU cores used by this process over roughly the last two seconds. `None` on unsupported platforms, before two samples are collected, or on transient failures reading process CPU time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_cores_used")]
        public float? CpuCoresUsed { get; set; }

        /// <summary>
        /// Effective total memory for this process in KiB (cgroup limit or host RAM).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ram_size")]
        public int? RamSize { get; set; }

        /// <summary>
        /// Size in KiB of the filesystem hosting Qdrant's /storage path (if not available, fallback to host disk size)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_size")]
        public int? DiskSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CpuFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_endian")]
        public global::Qdrant.CpuEndian? CpuEndian { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_devices")]
        public global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? GpuDevices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunningEnvironmentTelemetry" /> class.
        /// </summary>
        /// <param name="isDocker"></param>
        /// <param name="containerRuntime">
        /// Container runtime Qdrant is running under (`none` if bare metal).
        /// </param>
        /// <param name="cpuFlags"></param>
        /// <param name="distribution"></param>
        /// <param name="distributionVersion"></param>
        /// <param name="cores"></param>
        /// <param name="cpuCoresUsed">
        /// Average number of CPU cores used by this process over roughly the last two seconds. `None` on unsupported platforms, before two samples are collected, or on transient failures reading process CPU time.
        /// </param>
        /// <param name="ramSize">
        /// Effective total memory for this process in KiB (cgroup limit or host RAM).
        /// </param>
        /// <param name="diskSize">
        /// Size in KiB of the filesystem hosting Qdrant's /storage path (if not available, fallback to host disk size)
        /// </param>
        /// <param name="cpuEndian"></param>
        /// <param name="gpuDevices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunningEnvironmentTelemetry(
            bool isDocker,
            global::Qdrant.ContainerRuntime containerRuntime,
            string cpuFlags,
            string? distribution,
            string? distributionVersion,
            int? cores,
            float? cpuCoresUsed,
            int? ramSize,
            int? diskSize,
            global::Qdrant.CpuEndian? cpuEndian,
            global::System.Collections.Generic.IList<global::Qdrant.GpuDeviceTelemetry>? gpuDevices)
        {
            this.Distribution = distribution;
            this.DistributionVersion = distributionVersion;
            this.IsDocker = isDocker;
            this.ContainerRuntime = containerRuntime;
            this.Cores = cores;
            this.CpuCoresUsed = cpuCoresUsed;
            this.RamSize = ramSize;
            this.DiskSize = diskSize;
            this.CpuFlags = cpuFlags ?? throw new global::System.ArgumentNullException(nameof(cpuFlags));
            this.CpuEndian = cpuEndian;
            this.GpuDevices = gpuDevices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunningEnvironmentTelemetry" /> class.
        /// </summary>
        public RunningEnvironmentTelemetry()
        {
        }

    }
}