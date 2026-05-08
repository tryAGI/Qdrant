
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Same as [`LowMemoryMode::NoResident`], plus mmap page population is skipped on load (for original vectors, HNSW graph and payload storage).
    /// </summary>
    public enum LowMemoryModeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        NoPopulate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LowMemoryModeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LowMemoryModeVariant3 value)
        {
            return value switch
            {
                LowMemoryModeVariant3.NoPopulate => "no_populate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LowMemoryModeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "no_populate" => LowMemoryModeVariant3.NoPopulate,
                _ => null,
            };
        }
    }
}