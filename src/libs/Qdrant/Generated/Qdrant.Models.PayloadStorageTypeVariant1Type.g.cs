
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public enum PayloadStorageTypeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadStorageTypeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadStorageTypeVariant1Type value)
        {
            return value switch
            {
                PayloadStorageTypeVariant1Type.Mmap => "mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadStorageTypeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "mmap" => PayloadStorageTypeVariant1Type.Mmap,
                _ => null,
            };
        }
    }
}