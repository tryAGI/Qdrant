
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Load RAM-friendly components as their on-disk variants where possible:<br/>
    /// * Quantization is loaded as if `always_ram = false`. * Payload field indexes are loaded as if `on_disk = true`. * Payload storage is loaded as the mmap variant (lazy populate).
    /// </summary>
    public enum LowMemoryModeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        NoResident,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LowMemoryModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LowMemoryModeVariant2 value)
        {
            return value switch
            {
                LowMemoryModeVariant2.NoResident => "no_resident",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LowMemoryModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "no_resident" => LowMemoryModeVariant2.NoResident,
                _ => null,
            };
        }
    }
}