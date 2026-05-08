
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public enum TurboQuantBitSize
    {
        /// <summary>
        /// 
        /// </summary>
        Bits1,
        /// <summary>
        /// 
        /// </summary>
        Bits15,
        /// <summary>
        /// 
        /// </summary>
        Bits2,
        /// <summary>
        /// 
        /// </summary>
        Bits4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurboQuantBitSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurboQuantBitSize value)
        {
            return value switch
            {
                TurboQuantBitSize.Bits1 => "bits1",
                TurboQuantBitSize.Bits15 => "bits1_5",
                TurboQuantBitSize.Bits2 => "bits2",
                TurboQuantBitSize.Bits4 => "bits4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurboQuantBitSize? ToEnum(string value)
        {
            return value switch
            {
                "bits1" => TurboQuantBitSize.Bits1,
                "bits1_5" => TurboQuantBitSize.Bits15,
                "bits2" => TurboQuantBitSize.Bits2,
                "bits4" => TurboQuantBitSize.Bits4,
                _ => null,
            };
        }
    }
}