
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// No special handling. Every component loads as persisted.
    /// </summary>
    public enum LowMemoryModeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LowMemoryModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LowMemoryModeVariant1 value)
        {
            return value switch
            {
                LowMemoryModeVariant1.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LowMemoryModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => LowMemoryModeVariant1.Disabled,
                _ => null,
            };
        }
    }
}