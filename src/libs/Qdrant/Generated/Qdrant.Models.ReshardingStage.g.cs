
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Resharding stages
    /// </summary>
    public enum ReshardingStage
    {
        /// <summary>
        ///
        /// </summary>
        MigratingPoints,
        /// <summary>
        ///
        /// </summary>
        ReadHashRingCommitted,
        /// <summary>
        ///
        /// </summary>
        WriteHashRingCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReshardingStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReshardingStage value)
        {
            return value switch
            {
                ReshardingStage.MigratingPoints => "migrating_points",
                ReshardingStage.ReadHashRingCommitted => "read_hash_ring_committed",
                ReshardingStage.WriteHashRingCommitted => "write_hash_ring_committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReshardingStage? ToEnum(string value)
        {
            return value switch
            {
                "migrating_points" => ReshardingStage.MigratingPoints,
                "read_hash_ring_committed" => ReshardingStage.ReadHashRingCommitted,
                "write_hash_ring_committed" => ReshardingStage.WriteHashRingCommitted,
                _ => null,
            };
        }
    }
}